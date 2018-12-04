using Examination3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Examination3.Context
{
    public class ExamContext : DbContext
    {
        public DbSet<Exam> Exams { get; set; }
    }
}