﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Campus.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class isikuniEntities1 : DbContext
    {
        public isikuniEntities1()
            : base("name=isikuniEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Curricula> Curricula { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<emails> emails { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Instructor> Instructor { get; set; }
        public virtual DbSet<prevDegrees> prevDegrees { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<sectionn> sectionn { get; set; }
        public virtual DbSet<student> student { get; set; }
        public virtual DbSet<TimeSlot> TimeSlot { get; set; }
        public virtual DbSet<Attends> Attends { get; set; }
        public virtual DbSet<curriculaCourses> curriculaCourses { get; set; }
        public virtual DbSet<enrolled> enrolled { get; set; }
        public virtual DbSet<GradsInProjects> GradsInProjects { get; set; }
        public virtual DbSet<gradstudent> gradstudent { get; set; }
        public virtual DbSet<InstrInProjects> InstrInProjects { get; set; }
    }
}