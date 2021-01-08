using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class Studio
    {
        [Key]
        public int? RoomID { get; set; }
        //[StringLength(32)] //varchar 必须指定长度, 否则默认长度为max
        [StringLength(100)]
        [Required] //不允许为空

        public string RoomName { get; set; }
        [StringLength(200)]
        public string Remake { get; set; }
        public int? State { get; set; }
    }
}
