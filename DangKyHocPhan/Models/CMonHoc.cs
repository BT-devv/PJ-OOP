using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DangKyHocPhan.Models
{
    public class CMonHoc
    {
        private string idSub;
        private string nameSub;
        private int credits;

        public string IdSub { get => idSub; set => idSub = value; }
        public string NameSub { get => nameSub; set => nameSub = value; }
        public int Credits { get => credits; set => credits = value; }
    }
}