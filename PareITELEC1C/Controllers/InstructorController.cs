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
                InstructorFirstName = "Gabirel", DateHired = DateTime.Now,
                InstructorLastName= "Montano", InstructorRank=Rank.Instructor,
                IsTenured= true
            },

             new Instructor
            {
                InstructorFirstName = "Lourdes", DateHired = DateTime.Parse ("30/5/2023"),
                InstructorLastName = "Santos", InstructorRank=Rank.AssistantProfessor,
                IsTenured= true
            },
              new Instructor
            {
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

    }
}