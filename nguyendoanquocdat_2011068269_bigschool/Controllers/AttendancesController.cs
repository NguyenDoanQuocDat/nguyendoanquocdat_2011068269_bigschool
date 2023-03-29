using Microsoft.AspNet.Identity;
using nguyendoanquocdat_2011068269_bigschool.DTOs;
using nguyendoanquocdat_2011068269_bigschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace nguyendoanquocdat_2011068269_bigschool.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbcontext;
        public AttendancesController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbcontext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
            {
                return BadRequest("The Attendance allready exits!!");

                var attendance = new Attendance
                {
                    CourseId = attendanceDto.CourseId,
                    AttendeeId = userId
                };
                _dbcontext.Attendances.Add(attendance);
                _dbcontext.SaveChanges();

            }
            return Ok();
        }
    }
}
