using prjMember.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMember.AllClass
{
    public class UserData
    {
        public static CMember Member { get; set; }
        public static CBusinessMember MemberBusiness { get; set; }

        public static string linkstream = "Data Source=.;Initial Catalog=iSpan_Project;Integrated Security=True";


        //public static string linkstream = "Data Source=msit145nidin.database.windows.net;Initial Catalog=iSpan_Project;Persist Security Info=True;User ID=MSIT145nidin;Password=Nidinmsit145";
    }
}
