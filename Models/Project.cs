using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MacAppMVC.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime DateOfStart { get; set; }
        public int TeamSize { get; set; }
    }

    public class TaskManagerDBContext : DbContext
    {
        public DbSet<Project> Project { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            base.OnConfiguring(dbContextOptionsBuilder);
            dbContextOptionsBuilder.UseSqlServer("Data Source=SAGITEC-0679;Initial Catalog=MacAPP;Integrated Security=True");
        }
    }
}
