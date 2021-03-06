﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class AnnouncerStudio
    {
        [Key]
        public int? ASID { get; set; }
        //[StringLength(32)] //varchar 必须指定长度, 否则默认长度为max
        [Required] //不允许为空

        public int? ID { get; set; }
        public int? RoomID{ get; set; }
        public int? State { get; set; }
    }
}
