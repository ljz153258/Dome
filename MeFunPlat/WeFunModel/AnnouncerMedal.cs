using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class AnnouncerMedal
    {
        [Key]
        public int? AMID { get; set; }
        //[StringLength(32)] //varchar 必须指定长度, 否则默认长度为max
        [Required]

        public int? ID { get; set; }
        public int? MedalID { get; set; }
        public int? State { get; set; }
    }
}
