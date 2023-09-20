using Microsoft.AspNetCore.Mvc;
using PareITELEC1C.Models;
namespace PareITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
        {
            new Instructor
            {
                InstructorId = 1,
                InstructorFirstName = "Gabirel", DateHired = DateTime.Now,
                InstructorLastName= "Montano", InstructorRank=Rank.Instructor,
                IsTenured= true
            },

             new Instructor
            {
                InstructorId = 2,
                InstructorFirstName = "Lourdes", DateHired = DateTime.Parse ("30/5/2023"),
                InstructorLastName = "Santos", InstructorRank=Rank.AssistantProfessor,
                IsTenured= true
            },
              new Instructor
            {
                InstructorId = 3,
                InstructorFirstName = "Alyssa", DateHired = DateTime.Parse ("30/7/2023"),
                InstructorLastName = "Romen", InstructorRank=Rank.Professor,
                IsTenured= true
            }
        };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the Instructor whose id matches the given id
            Instructor? Instructor = InstructorList.FirstOrDefault(st => st.InstructorId == id);

            if (Instructor != null)//was an Instructor found?
                return View(Instructor);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {

            return View();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.InstructorId == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.InstructorId == instructorChanges.InstructorId);
            if (instructor != null)
            {
                instructor.InstructorId = instructorChanges.InstructorId;
                instructor.InstructorFirstName = instructorChanges.InstructorFirstName;
                instructor.InstructorLastName = instructorChanges.InstructorLastName;
                instructor.IsTenured = instructorChanges.IsTenured;
                instructor.InstructorRank = instructorChanges.InstructorRank;
                instructor.DateHired = instructorChanges.DateHired;
            }

            return View("Index", InstructorList);
        }

    }
}



