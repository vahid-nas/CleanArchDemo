using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interface
{
    public interface ICourseService
    {
        //CourseViewModel GetCourses();
        IEnumerable<CourseViewModel> GetCourses();

        void Create(CourseViewModel courseViewModel);
    }
}
