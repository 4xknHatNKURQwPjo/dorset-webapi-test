using System.Collections.Generic;
using app.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        public static List<Students> GetStudents()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students(){Id = 1, Name = "Aurèle"});
            students.Add(new Students(){Id = 2, Name = "Segundo"});
            return students;
        }

        [HttpGet]
        public IEnumerable<Students> GetStudents_List()
        {
            return GetStudents();
        }

        [HttpGet("{id}")]
        public ActionResult<Students> GetStudentByID(int id) {
            var students = GetStudents().Find(x => x.Id == id);
            return students != null ? students : NotFound();
        }
    }

}