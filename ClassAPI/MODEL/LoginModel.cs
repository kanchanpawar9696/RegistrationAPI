using ClassAPI.BASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAPI.MODEL
{
    public class LoginModel:DataEntity
    {

        [DisplayName("SrNo")]
        [Key,Column("SrNo")]
        public int srno { get; set; }

        [DisplayName("UserId")]
        [Column("UserId")]
        public string userid { get; set; }


        [DisplayName("Password")]
        [Column("Password")]
        public string password { get; set; }



        [DisplayName("CustName")]
        [Column("custname")]
        public string custname { get; set; }

        [DisplayName("Address")]
        [Column("Address")]
        public string address { get; set; }

        [DisplayName("Salary")]
        [Column("Salary")]
        public decimal salary { get; set; }

    }
 

}
