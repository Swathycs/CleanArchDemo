using CleanArch.Appication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Appication.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
