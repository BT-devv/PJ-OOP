using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DangKyHocPhan.Models
{
    public class CSinhVien
    {
        private string idSv;
        private string nameSv;
        private string sex;
        private DateTime birth;
        private string address;
        private string country;

        public string IdSv { get => idSv; set => idSv = value; }
        public string NameSv { get => nameSv; set => nameSv = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Address { get => address; set => address = value; }
        public string Country { get => country; set => country = value; }
    }
}