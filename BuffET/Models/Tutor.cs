using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BuffET.Models
{
    public class Tutor
    {
        public enum Categories
        {
            Assembly,
            C,
            C_Plus_Plus,
            C_Sharp,
            MATLAB,
            MySQL,
            PHP,
            Python,
            R,
            Systems
        }

        public string Name { get; set; }
        public string Bio { get; set; }
        public DateTime Graduation { get; set; }
        public List<Categories> Expertise { get; set; }
        public string PicUrl { get; set; }
    }

    public class TutorDbContext : DbContext
    {
        public DbSet<Tutor> Tutors { get; set; }
    }
}