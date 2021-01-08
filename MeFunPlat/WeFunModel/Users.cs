using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class Users
    {
        [Key]
        public int? ID { get; set; }

        [Column("UserName", TypeName = "varchar")]
        [MaxLength(50)]
        [Required] //不允许为空
        public string UserName { get; set; }

        [Column("UserPwd", TypeName = "varchar")]
        [MaxLength(50)]
        [Required] //不允许为空
        public string UserPwd { get; set; }

        [Column("NickName", TypeName = "varchar")]
        [MaxLength(50)]
        [Required] //不允许为空
        public string NickName { get; set; }

        public int? State { get; set; }
    }
}
