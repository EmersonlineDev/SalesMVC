using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySalesMVC.Models.Enumerates
{
    public enum SystemUserLevel
    {
        SysAdmin,
        MasterUser,
        Manager,
        Supervisor,
        AdvancedUser,
        CommonUser,
        Visitor
    }
}
