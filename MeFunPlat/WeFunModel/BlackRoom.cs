using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class BlackRoom
    {
        [Key]
        public int? BRID { get; set; }
        //[StringLength(32)] //varchar 必须指定长度, 否则默认长度为max
        [Required] //不允许为空

        public int? ID { get; set; }
        [StringLength(200)]
        public string Remake { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? State { get; set; }
    }
}
