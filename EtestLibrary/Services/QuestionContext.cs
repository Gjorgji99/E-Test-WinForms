using System;
using System.Collections.Generic;
using System.IO;
using EtestLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EtestLibrary.Services
{
    public class QuestionContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public string DbPath { get; private set; }
        public QuestionContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}dbEtest.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
	    {
            modelBuilder.Entity<Question>().ToTable("question");
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
         //   var path = Path.Combine(Environment.CurrentDirectory, "dbEtest.db");
         //   optionsBuilder.UseSqlite("Data Source="+path+";");
        //}
    }
}
