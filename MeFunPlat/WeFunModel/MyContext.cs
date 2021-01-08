using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace WeFunModel
{
    public class MyContext:DbContext
    {
        public MyContext() 
            : base("EF_DB") 
        {
           
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Announcer> Announcer { set; get; }
        public DbSet<UsersRole> UsersRole { set; get; }
        public DbSet<AnnouncerMedal> AnnouncerMedal { set; get; }
        public DbSet<AnnouncerStudio> AnnouncerStudio { set; get; }
        public DbSet<BlackRoom> BlackRoom { set; get; }
        public DbSet<SysRoles> SysRoles { set; get; }
        public DbSet<Medal> Medal { set; get; }
        public DbSet<Studio> Studio { set; get; }
        public DbSet<Area> Area { set; get; }
        public DbSet<RolePopedom> RolePopedom { set; get; }
        public DbSet<Contract> Contract { set; get; }
        public DbSet<LivePeriod> LivePeriods { set; get; }
        public DbSet<Suggestion> Suggestions { set; get; }
        public DbSet<SysPopedoms> SysPopedoms { set; get; }
    }
}
