using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistrationAPI.DTO
{
    public class DTO_LoginModel
    {
        [Key]
        public int srno { get; set; }
        public string userid { get; set; }


        public string password { get; set; }

        public string custname { get; set; }

        //public string address { get; set; }


        //public float salary { get; set; }
        public string Email { get; set; }


    }
}
