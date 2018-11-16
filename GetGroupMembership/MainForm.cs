using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GetGroupMembership.UserGroup;

namespace GetGroupMembership
{
    public partial class MainForm : Form
    {
        BackgroundWorker bgWorker, bguserWorker;
        private const string SELECTTEXT = "Select Domain";
        public MainForm()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            bgWorker = new BackgroundWorker();
            bgWorker.WorkerSupportsCancellation = false;
            bgWorker.WorkerReportsProgress = true;
            bgWorker.DoWork += bgWorker_DoWork;
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
            bgWorker.ProgressChanged += bgWorker_ProgressChanged;


            bguserWorker = new BackgroundWorker();
            bguserWorker.WorkerSupportsCancellation = false;
            bguserWorker.WorkerReportsProgress = true;
            bguserWorker.DoWork += bguserWorker_DoWork;
            bguserWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bguserWorker_RunWorkerCompleted);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!CheckConfigFileIsPresent())
                {
                    MessageBox.Show("Cannot find the config file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGrpMembership.Enabled = false;
                    btnUserGroups.Enabled = false;
                    return;
                }
                List<string> domains = new List<string>();

                domains.Add(SELECTTEXT);
                domains.AddRange(ConfigurationManager.AppSettings["Domain"].Split('|').ToList());
                cbDomains.DataSource = domains;
                cbDomains.SelectedIndex = 1;

                cbUserDomains.DataSource = domains;
                cbUserDomains.SelectedIndex = 1;

                txtGroup.Text = "Q_SD_APP_SmartstreamTA";
                dgvResult.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool CheckConfigFileIsPresent()
        {
            return File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrpMembership_Click(object sender, EventArgs e)
        {
            var domain = cbDomains.SelectedItem.ToString();
            if(domain==null || string.Equals(domain, SELECTTEXT))
                domain = null;
            var grpName = txtGroup.Text.Trim();
            if (string.IsNullOrEmpty(domain) || string.IsNullOrEmpty(grpName))
            {
                MessageBox.Show("Select required fields - domain / group");
                return;
            }

            var grpMembership = new GroupMembership(domain, grpName);

            try
            {
                if (!grpMembership.IsValidGroupName)
                {
                    MessageBox.Show("Group Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                FreezeForm(true);

                bgWorker.RunWorkerAsync(grpMembership);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FreezeForm(bool p)
        {
            pbWait.Visible = pictureBox1.Visible = p;
            btnGrpMembership.Enabled = btnUserGroups.Enabled= !p;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserGroups_Click(object sender, EventArgs e)
        {
            //UserGroupMembership ug = new UserGroupMembership(domain, userName);
            lblWarning.Text = "";
            var domain = cbUserDomains.SelectedItem.ToString();

            if (string.Equals(domain, SELECTTEXT))
                domain = null;

            var userName = txtUserName.Text.Trim();
            if (string.IsNullOrEmpty(domain) || string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Select required fields - domain / user");
                return;
            }
            try
            {
                UserGroupMembership ugm = new UserGroupMembership(domain, userName);

                if (!ugm.IsValidUser)
                {
                    MessageBox.Show("User name is not valid");
                    return;
                }

                FreezeForm(true);
                bguserWorker.RunWorkerAsync(ugm);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //not implemented
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var grpMembership = e.Argument as GroupMembership;

            if (grpMembership != null)
                e.Result = grpMembership.GetGroupMembership();
            else
                e.Result = null;
        }


        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                FreezeForm(false);
                return;
            }
            var ds = e.Result as IEnumerable<GroupMembershipModel>;

            dgvResult.DataSource = ds;
            FreezeForm(false);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bguserWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var ug = e.Argument as UserGroupMembership;

            if (ug!= null)
                e.Result = ug.GetImmediateGroups();
            else
                e.Result = null;
        }


        private void bguserWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                FreezeForm(false);
                return;
            }
            var ds = e.Result as IEnumerable<UserMembershipModel>;

            dgbUserGroups.DataSource = ds;
            lblWarning.Text = "This only lists group membership in the base domain";
            FreezeForm(false);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = sender as TabControl;

            switch (s.SelectedIndex)
            {
                case 0:
                    this.AcceptButton = btnGrpMembership;
                    break;
                case 1:
                    this.AcceptButton = btnUserGroups;
                    break;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }             
    }
}
