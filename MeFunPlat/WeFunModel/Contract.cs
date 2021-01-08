using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class Contract
    {
        [Key]
        public int? ConID { get; set; }
        //[StringLength(32)] //varchar 必须指定长度, 否则默认长度为max
        [Required] //不允许为空

        public int ID { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public DateTime ConBeginDate { get; set; }
        public DateTime ConEndDate { get; set; }
        [StringLength(200)]
        public string ConRemake { get; set; }
    }
}
