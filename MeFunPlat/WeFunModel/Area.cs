using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class Area
    {
        [Key]
        public int? ARID { get; set; }
        //[StringLength(32)] //varchar 必须指定长度, 否则默认长度为max
        [StringLength(50)]
        [Required] //不允许为空

        public string ARName { get; set; }
        public int? ARParent { get; set; }
        public int? ARIndex { get; set; }
        public int? ARState { get; set; }
        [StringLength(200)]
        public string ARReamle{ get; set; }
}
}
