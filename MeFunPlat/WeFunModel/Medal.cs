using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class Medal
    {
        [Key]
        public int? ID { get; set; }
        //[StringLength(32)] //varchar 必须指定长度, 否则默认长度为max
        [Required] //不允许为空
        [StringLength(50)]
        public string MedalName { get; set; }
        public int? MedalLevel { get; set; }
        [StringLength(200)]
        public string Remake { get; set; }
        public int? State { get; set; }
    }
}
