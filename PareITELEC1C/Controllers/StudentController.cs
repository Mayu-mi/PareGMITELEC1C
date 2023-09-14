using Microsoft.AspNetCore.Mvc;
using PareITELEC1C.Models;

namespace PareITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>()
        {
            new Student()
            {
                StudentId=1,
                StudentFirstName = "Goldie May",
                StudentLastName = "Pare",
                Course = Course.BSIT,
                DateEnrolled = DateTime.Parse("28/07/2021"),
                GPA = 1.8,
                Email = "goldiemay.pare.cics@ust.edu.ph",
            },

            new Student()
            {
                StudentId=1,
                StudentFirstName = "Jastin",
                StudentLastName = "Leano",
                Course = Course.BSCS,
                DateEnrolled = DateTime.Parse("08/05/2022"),
                GPA = 2.0,
                Email = "jastinleano63@gmail.com",
            },

            new Student()
            {
                StudentId=1,
                StudentFirstName = "Gian Lloyd",
                StudentLastName = "Laberinto",
                Course = Course.BSIS,
                DateEnrolled = DateTime.Parse("22/07/2023"),
                GPA = 2.0,
                Email = "gianlaberinto@gmail.com",
            },


        };
        public IActionResult Index()
        {
            return View(StudentList);
        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the Instructor whose id matches the given id
            Student? Student = StudentList.FirstOrDefault(st => st.StudentId == id);

            if (Student != null)//was an Instructor found?
                return View(Student);

            return NotFound();
        }
       

     }

    }


