using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class Suggestion
    {
        [Key]
        public int? SugID { get; set; }
        //[StringLength(32)] //varchar 必须指定长度, 否则默认长度为max
        [StringLength(20)]
        [Required] //不允许为空

        public string SugUser { get; set; }
        [StringLength(500)]
        public string SugContent { get; set; }
        [StringLength(500)]
        public string SugProcess { get; set; }
        public int? SugState { get; set; }
    }
}
