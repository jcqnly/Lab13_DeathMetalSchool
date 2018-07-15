using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CradleOfFilth.Models
{
    public class Course
    {
        public int ID { get; set; }
        public CourseName CourseName { get; set; }
        public string Description { get; set; }
        public List<Student> Students { get; set; }
    }

    public enum CourseName
    {
        [Display(Name = "Public Static Void")] PublicStaticVoid = 1,
        Shredding,
        [Display(Name = "Air Guital")] AirGuitar,

    }
}
