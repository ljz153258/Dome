using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class RolePopedom
    {
        [Key]
        public int? RPID { get; set; }
        //[StringLength(32)] //varchar 必须指定长度, 否则默认长度为max
        [Required] //不允许为空

        public int? RoleID { get; set; }
        public int? PopID { get; set; }
        public int? PopType { get; set; }
    }
}
