using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAPI.BASE
{
    public class DataEntity
    {
        [DisplayName("EmailId")]
        [Column("EmailId")]
        public string emailid { get; set; }


    }
}
