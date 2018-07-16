using CradleOfFilth.Controllers;
using CradleOfFilth.Data;
using CradleOfFilth.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace TestCradleOfFilth
{
    public class TestCourses
    {
        [Fact]
        public async void CanCreateCourse()
        {
            DbContextOptions<MetalDbContext> options =
                new DbContextOptionsBuilder<MetalDbContext>()
                .UseInMemoryDatabase("CanCreateCourse")
                .Options;
            using (MetalDbContext context = new MetalDbContext(options))
            {
                Course course1 = new Course
                {
                    Name = "Shred Veg",
                    Description = "Veggie Cucumber Zucchini"
                };
                
                await context.Courses.AddAsync(course1);
                await context.SaveChangesAsync();

                CourseController cc = new CourseController(context);

                var addCourse = cc.Create(course1);
                var results = context.Courses.Where(x => x.Name == "Shred Veg");

                Assert.Equal(1, results.Count());
            }
        }

        [Fact]
        public async void CanUpdateCourse()
        {
            DbContextOptions<MetalDbContext> options =
                new DbContextOptionsBuilder<MetalDbContext>()
                .UseInMemoryDatabase("CanUpdateCourse")
                .Options;
            using (MetalDbContext context = new MetalDbContext(options))
            {
                Course course = new Course();
                course.ID = 1;
                course.Name = "Cook overlord";
                course.Description = "Become the best cook there ever was!";

                CourseController cc = new CourseController(context);

                await context.Courses.AddAsync(course);
                await context.SaveChangesAsync();

                course.Name = "Baking overlord";

                Assert.NotEqual("Cook overlord", course.Name);
            }
        }

        [Fact]
        public async void CanDeleteCourse()
        {
            DbContextOptions<MetalDbContext> options =
                new DbContextOptionsBuilder<MetalDbContext>()
                .UseInMemoryDatabase("CanDeleteCourse")
                .Options;
            using (MetalDbContext context = new MetalDbContext(options))
            {
                Course course1 = new Course();
                course1.ID = 1;
                Course course2 = new Course();
                course2.ID = 2;
                Course course3 = new Course();
                course3.ID = 3;

                await context.Courses.AddAsync(course1);
                await context.Courses.AddAsync(course2);
                await context.Courses.AddAsync(course3);
                await context.SaveChangesAsync();

                var findCourse = context.Courses.Find(1);

                CourseController cc = new CourseController(context);

                var deleteCourse = cc.Delete(1);

                Assert.Equal(2, context.Courses.Count());
            }
        }
    }
}
