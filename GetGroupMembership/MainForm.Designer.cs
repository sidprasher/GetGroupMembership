using System.Windows.Forms;
namespace GetGroupMembership
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDomain = new System.Windows.Forms.Label();
            this.cbDomains = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.pbWait = new System.Windows.Forms.PictureBox();
            this.btnGrpMembership = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsrDomain = new System.Windows.Forms.Label();
            this.cbUserDomains = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dgbUserGroups = new System.Windows.Forms.DataGridView();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUserGroups = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.DomainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NEP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.displayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samAccountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enabledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lastLogonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupMembershipModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userMembershipModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbUserGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupMembershipModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMembershipModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 601);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Group Membership";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblDomain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbDomains, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGroup, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtGroup, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvResult, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbWait, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGrpMembership, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 536);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDomain
            // 
            this.lblDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDomain.AutoSize = true;
            this.lblDomain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomain.Location = new System.Drawing.Point(3, 30);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(120, 23);
            this.lblDomain.TabIndex = 0;
            this.lblDomain.Text = "Select Domain";
            // 
            // cbDomains
            // 
            this.cbDomains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDomains.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDomains.FormattingEnabled = true;
            this.cbDomains.Location = new System.Drawing.Point(256, 19);
            this.cbDomains.Name = "cbDomains";
            this.cbDomains.Size = new System.Drawing.Size(247, 31);
            this.cbDomains.TabIndex = 1;
            // 
            // lblGroup
            // 
            this.lblGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(3, 83);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(109, 23);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "Group Name";
            // 
            // txtGroup
            // 
            this.txtGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroup.Location = new System.Drawing.Point(256, 73);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(247, 30);
            this.txtGroup.TabIndex = 3;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvResult.AutoGenerateColumns = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DomainName,
            this.displayNameDataGridViewTextBoxColumn,
            this.samAccountNameDataGridViewTextBoxColumn,
            this.NEP,
            this.enabledDataGridViewTextBoxColumn,
            this.lastLogonDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvResult, 4);
            this.dgvResult.DataSource = this.groupMembershipModelBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResult.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvResult.Location = new System.Drawing.Point(3, 162);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(832, 371);
            this.dgvResult.TabIndex = 5;
            // 
            // pbWait
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pbWait, 2);
            this.pbWait.Image = ((System.Drawing.Image)(resources.GetObject("pbWait.Image")));
            this.pbWait.Location = new System.Drawing.Point(509, 3);
            this.pbWait.Name = "pbWait";
            this.tableLayoutPanel1.SetRowSpan(this.pbWait, 2);
            this.pbWait.Size = new System.Drawing.Size(307, 100);
            this.pbWait.TabIndex = 6;
            this.pbWait.TabStop = false;
            this.pbWait.Visible = false;
            // 
            // btnGrpMembership
            // 
            this.btnGrpMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnGrpMembership, 2);
            this.btnGrpMembership.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrpMembership.Location = new System.Drawing.Point(3, 109);
            this.btnGrpMembership.Name = "btnGrpMembership";
            this.btnGrpMembership.Size = new System.Drawing.Size(246, 47);
            this.btnGrpMembership.TabIndex = 4;
            this.btnGrpMembership.Text = "Group Membership";
            this.btnGrpMembership.UseVisualStyleBackColor = true;
            this.btnGrpMembership.Click += new System.EventHandler(this.btnGrpMembership_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Groups";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblUsrDomain, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbUserDomains, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblUserName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtUserName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgbUserGroups, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnUserGroups, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblWarning, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(846, 545);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(307, 100);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblUsrDomain
            // 
            this.lblUsrDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsrDomain.AutoSize = true;
            this.lblUsrDomain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrDomain.Location = new System.Drawing.Point(3, 31);
            this.lblUsrDomain.Name = "lblUsrDomain";
            this.lblUsrDomain.Size = new System.Drawing.Size(120, 23);
            this.lblUsrDomain.TabIndex = 0;
            this.lblUsrDomain.Text = "Select Domain";
            // 
            // cbUserDomains
            // 
            this.cbUserDomains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbUserDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserDomains.FormattingEnabled = true;
            this.cbUserDomains.Location = new System.Drawing.Point(256, 23);
            this.cbUserDomains.Name = "cbUserDomains";
            this.cbUserDomains.Size = new System.Drawing.Size(247, 28);
            this.cbUserDomains.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(3, 85);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(206, 23);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name (SamAccount)";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(256, 79);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(247, 26);
            this.txtUserName.TabIndex = 3;
            // 
            // dgbUserGroups
            // 
            this.dgbUserGroups.AllowUserToAddRows = false;
            this.dgbUserGroups.AllowUserToDeleteRows = false;
            this.dgbUserGroups.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgbUserGroups.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgbUserGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgbUserGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbUserGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgbUserGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbUserGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName});
            this.tableLayoutPanel2.SetColumnSpan(this.dgbUserGroups, 4);
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbUserGroups.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgbUserGroups.Location = new System.Drawing.Point(3, 165);
            this.dgbUserGroups.Name = "dgbUserGroups";
            this.dgbUserGroups.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbUserGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgbUserGroups.RowTemplate.Height = 24;
            this.dgbUserGroups.Size = new System.Drawing.Size(830, 377);
            this.dgbUserGroups.TabIndex = 5;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "Group Name";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // btnUserGroups
            // 
            this.btnUserGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.SetColumnSpan(this.btnUserGroups, 2);
            this.btnUserGroups.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserGroups.Location = new System.Drawing.Point(3, 111);
            this.btnUserGroups.Name = "btnUserGroups";
            this.btnUserGroups.Size = new System.Drawing.Size(249, 48);
            this.btnUserGroups.TabIndex = 4;
            this.btnUserGroups.Text = "User Groups";
            this.btnUserGroups.UseVisualStyleBackColor = true;
            this.btnUserGroups.Click += new System.EventHandler(this.btnUserGroups_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Location = new System.Drawing.Point(509, 108);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(100, 23);
            this.lblWarning.TabIndex = 8;
            // 
            // DomainName
            // 
            this.DomainName.DataPropertyName = "DomainName";
            this.DomainName.HeaderText = "Domain";
            this.DomainName.Name = "DomainName";
            this.DomainName.ReadOnly = true;
            this.DomainName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NEP
            // 
            this.NEP.DataPropertyName = "NEP";
            this.NEP.HeaderText = "NEP";
            this.NEP.Name = "NEP";
            this.NEP.ReadOnly = true;
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            this.displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.displayNameDataGridViewTextBoxColumn.HeaderText = "DisplayName";
            this.displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            this.displayNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.displayNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // samAccountNameDataGridViewTextBoxColumn
            // 
            this.samAccountNameDataGridViewTextBoxColumn.DataPropertyName = "SamAccountName";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samAccountNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.samAccountNameDataGridViewTextBoxColumn.HeaderText = "SamAccountName";
            this.samAccountNameDataGridViewTextBoxColumn.Name = "samAccountNameDataGridViewTextBoxColumn";
            this.samAccountNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.samAccountNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // enabledDataGridViewTextBoxColumn
            // 
            this.enabledDataGridViewTextBoxColumn.DataPropertyName = "Enabled";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = false;
            this.enabledDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.enabledDataGridViewTextBoxColumn.HeaderText = "Enabled";
            this.enabledDataGridViewTextBoxColumn.Name = "enabledDataGridViewTextBoxColumn";
            this.enabledDataGridViewTextBoxColumn.ReadOnly = true;
            this.enabledDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lastLogonDataGridViewTextBoxColumn
            // 
            this.lastLogonDataGridViewTextBoxColumn.DataPropertyName = "LastLogon";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLogonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.lastLogonDataGridViewTextBoxColumn.HeaderText = "LastLogon";
            this.lastLogonDataGridViewTextBoxColumn.Name = "lastLogonDataGridViewTextBoxColumn";
            this.lastLogonDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastLogonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupMembershipModelBindingSource
            // 
            this.groupMembershipModelBindingSource.DataSource = typeof(GetGroupMembership.GroupMembershipModel);
            // 
            // userMembershipModelBindingSource
            // 
            this.userMembershipModelBindingSource.DataSource = typeof(GetGroupMembership.UserMembershipModel);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnGrpMembership;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 601);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Find User and Group Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbUserGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupMembershipModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMembershipModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.ComboBox cbDomains;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnGrpMembership;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUsrDomain;
        private System.Windows.Forms.ComboBox cbUserDomains;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnUserGroups;
        private System.Windows.Forms.DataGridView dgbUserGroups;
        private System.Windows.Forms.PictureBox pbWait;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource userMembershipModelBindingSource;
        private System.Windows.Forms.BindingSource groupMembershipModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private Label lblWarning;
        private DataGridViewTextBoxColumn DomainName;
        private DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn samAccountNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn NEP;
        private DataGridViewCheckBoxColumn enabledDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastLogonDataGridViewTextBoxColumn;

    }
}

