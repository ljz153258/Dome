using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class Announcer
    {
        [Key]
        public int? ID { get; set; }

        [StringLength(50)] //varchar 必须指定长度, 否则默认长度为max
        [Required] //不允许为空
        public string Name { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserPwd{ get; set; }
        [StringLength(200)]
        public string NickName { get; set; }
        public int? Sex { get; set; }
        public int? Age { get; set; }
        [StringLength(18)]
        public string CDCard { get; set; }
        [StringLength(11)]
        public string Phone { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [StringLength(20)]
        public string QQ { get; set; }
        [StringLength(50)]
        public string WetChat{ get; set; }
        [StringLength(200)]
        public string Other { get; set; }
        [StringLength(200)]
        public string BankName { get; set; }
        [StringLength(50)]
        public string BanCard { get; set; }
        public string Vitae{ get; set; }
        public string Remake { get; set; }
        public int? State { get; set; }
    }
}
