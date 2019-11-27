using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CourseLibrary.API.Entities;
using CourseLibraryAPI.Models;

namespace CourseLibraryAPI.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Course, CourseDto>();
        }
    }
}
