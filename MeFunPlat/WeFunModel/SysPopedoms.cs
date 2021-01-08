using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class SysPopedoms
    {
        [Key]
        public int? PopID { get; set; }
        //[StringLength(32)] //varchar 必须指定长度, 否则默认长度为max
        [StringLength(100)]
        [Required] //不允许为空

        public string PopName { get; set; }
        public int? Parent { get; set; }
        public int? PopIndex { get; set; }
        [StringLength(1000)]
        public string PopPath { get; set; }
        [StringLength(100)]
        public string PopArea { get; set; }
        [StringLength(100)]
        public string PopControll { get; set; }
        public int? PopState { get; set; }
        [StringLength(500)]
        public string PopDesc { get; set; }
    }
}
