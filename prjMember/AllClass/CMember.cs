using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMember.NewFolder1
{
    public class CMember
    {
        public int fid { get; set; }

        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Address_City { get; set; }
        public string Address_Area { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public int Point { get; set; }

        public DateTime RegisterTime { get; set; }

        public string MemberPhotoFile { get; set; }
    }
    



}
