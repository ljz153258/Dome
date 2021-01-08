using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class SysRoles
    {
        [Key]
        public int? RoleID { get; set; }
        //[StringLength(32)] //varchar 必须指定长度, 否则默认长度为max
        [Required] //不允许为空
        [StringLength(50)]

        public string RoleName { get; set; }
        [StringLength(500)]
        public string RoleDesc { get; set; }
        public int? RoleState { get; set; }
    }
}
