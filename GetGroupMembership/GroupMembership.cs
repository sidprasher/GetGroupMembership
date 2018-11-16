using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;

namespace GetGroupMembership
{
    public class GroupMembership
    {
        public string Domain { get; private set; }
        public string GroupName { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="grpName"></param>
        public GroupMembership(string domain, string grpName)
        {
            this.Domain = domain;
            this.GroupName = grpName;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsValidGroupName
        {
            get
            {
                using (var context = new PrincipalContext(ContextType.Domain, Domain))
                {
                    using (var group = GroupPrincipal.FindByIdentity(context, GroupName))
                        return (group != null);
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<GroupMembershipModel> GetGroupMembership()
        {
            List<GroupMembershipModel> groupInfo = new List<GroupMembershipModel>();

            using (var context = new PrincipalContext(ContextType.Domain, Domain))
            {
                using (var group = GroupPrincipal.FindByIdentity(context, GroupName))
                {
                    if (group == null)
                        return groupInfo;

                    var users = group.GetMembers(true);

                    for (int i = 0; i < users.Count(); ++i)
                    {
                        var u = users.ElementAt(i) as UserPrincipal;
                    }

                    foreach (var user in users)
                    {
                        UserPrincipal up = user as UserPrincipal;

                        if (up != null)
                        {
                            var d = up.DisplayName;
                            var en = up.Enabled;
                            var p = up.PasswordNeverExpires;
                            var dom = up.Context.Name;

                            var l = up.LastLogon;
                            //var pw = user.PermittedWorkstations;
                            var s = up.SamAccountName;

                            groupInfo.Add(new GroupMembershipModel(d, p, l, en, s, dom));
                        }
                        else
                        {
                            //System.DirectoryServices.AccountManagement.UnknownPrincipal ukp;
                            // there is an unknown principle
                            groupInfo.Add(new GroupMembershipModel(user.Name, null, null, null, null, null));
                        }
                    }
                    return groupInfo;
                }
            }
        }
    }
}
