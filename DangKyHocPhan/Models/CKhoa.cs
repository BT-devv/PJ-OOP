using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DangKyHocPhan.Models
{
    public class CKhoa
    {
        private string idK;
        private string nameK;
        private string addressK;
        private string phone;

        public string IdK { get => idK; set => idK = value; }
        public string NameK { get => nameK; set => nameK = value; }
        public string AddressK { get => addressK; set => addressK = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}