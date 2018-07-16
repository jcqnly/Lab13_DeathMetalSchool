using CradleOfFilth.Models;
using System;
using Xunit;

namespace TestCradleOfFilth
{
    public class TestModels
    {
        [Fact]
        public void CourseNameGetterTest()
        {
            Course course = new Course();
            course.Name = "Cheez Wiz";

            Assert.Equal("Cheez Wiz", course.Name);
        }
    }
}