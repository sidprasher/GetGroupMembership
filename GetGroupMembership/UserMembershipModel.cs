using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetGroupMembership
{
    public class UserMembershipModel
    {
        public String GroupName { get; private set; }

        public UserMembershipModel(string n)
        {
            this.GroupName = n;
        }
    }
}
