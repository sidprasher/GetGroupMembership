using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetGroupMembership
{
    public class GroupMembershipModel : IComparable<GroupMembershipModel>
    {
        public string DisplayName { get; set; }
        public string DomainName { get; set; }
        public bool? NEP { get; set; }

        public DateTime? LastLogon { get; private set; }

        public bool? Enabled { get; set; }



        //public List<string> PermittedWorkStations { get; set; }

        public string SamAccountName { get; set; }

        public GroupMembershipModel(string displayName, bool? passwordNeverExpires, DateTime? lastLogon,
                                    bool? enabled, /*List<string> permittedWorkStations,*/ string samAccountName, string domainName)
        {
            this.DisplayName = displayName;
            this.NEP = passwordNeverExpires;
            this.LastLogon = lastLogon;
            this.Enabled = enabled;
            //this.PermittedWorkStations = permittedWorkStations;
            this.SamAccountName = samAccountName;
            this.DomainName = domainName;

        }

        public int CompareTo(GroupMembershipModel other)
        {
            if (other == null)
                return 1;
            return this.DisplayName.CompareTo(other.DisplayName);
        }
    }
}
