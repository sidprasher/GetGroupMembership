using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices.AccountManagement;
using System.Security.Principal;
using System.DirectoryServices;

namespace GetGroupMembership.UserGroup
{
    public class UserGroupMembership
    {
        public string Domain { get; private set; }
        public string UserName { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="grpName"></param>
        public UserGroupMembership(string domain, string userName)
        {
            this.Domain = domain;
            this.UserName = userName;
        }

        /// <summary>
        /// List immediate groups for a user.
        /// Does not search for sub-groups
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserMembershipModel> GetImmediateGroups()
        {
            UserPrincipal user = UserPrincipal.FindByIdentity(
                                    new PrincipalContext(
                                        ContextType.Domain, Domain),
                                        IdentityType.SamAccountName, UserName);

            var n = GetUserNameOfFSP("CN=TA0532,OU=Technical Accounts,OU=User and Role Management,OU=Production,DC=launcher,DC=prd");
            List<UserMembershipModel> result = new List<UserMembershipModel>();
            foreach (var g in user.GetGroups())
            {
                result.Add(new UserMembershipModel(g.SamAccountName));
            }
            foreach (var g in user.GetGroups(new PrincipalContext(ContextType.Domain,"launcher")))
            {
                result.Add(new UserMembershipModel(g.SamAccountName));
            }


            return result;
        }

        public bool IsValidUser
        {
            get
            {

                UserPrincipal user = UserPrincipal.FindByIdentity(
                                    new PrincipalContext(
                                        ContextType.Domain, Domain),
                                        IdentityType.SamAccountName, UserName);

                return (user != null);
            }
        }

        private string GetUserNameOfFSP(string ForeignSecurityPrincipal)
        {
            //Returns with syntax of "DOMAIN\logonname"
            try
            {
                DirectoryEntry user = new DirectoryEntry("LDAP://" + ForeignSecurityPrincipal);
                SecurityIdentifier sid = new SecurityIdentifier((byte[])user.InvokeGet("objectSid"), 0);
                NTAccount account = (NTAccount)sid.Translate(typeof(NTAccount));
                return account.ToString();
            }
            catch (DirectoryServicesCOMException e) { Console.Write(e.Message); return "Error"; }
        }
    }
}
