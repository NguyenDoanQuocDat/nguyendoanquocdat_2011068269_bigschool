﻿using nguyendoanquocdat_2011068269_bigschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyendoanquocdat_2011068269_bigschool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}