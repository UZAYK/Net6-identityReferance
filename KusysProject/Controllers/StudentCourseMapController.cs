using AutoMapper;
using KUSYSDemo.Business.Interfaces;
using KUSYSDemo.Entities.Concrete;
using KUSYSDemo.Models.StudentCourseMap;
using Microsoft.AspNetCore.Mvc;

namespace KUSYSDemo.Controllers
{
    public class StudentCourseMapController : Controller
    {
        #region CTOR - DEPENDENCY INJECTION

        private readonly IStudentCourseMapService _studentCourseMapService;
        private readonly IMapper _mapper;

        public StudentCourseMapController(IStudentCourseMapService studentCourseMapService, IMapper mapper)
        {
            _studentCourseMapService = studentCourseMapService;
            _mapper = mapper;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            // create the method of this operation
            var students = _studentCourseMapService.GetStudentAll();
            var course = _studentCourseMapService.GetCourseAll();

            return View(new StudentCourseMapListModel
            {
                CourseId = course.Select(x=>x.CourseId).ToList(),
                StudentId = course.Select(x => x.CourseId).ToList(),
            });
        }

        [HttpPost]
        public IActionResult Create(StudentCourseMapAddModel model)
        {
            if (ModelState.IsValid)
            {
                // a hasvalue method will be written here
                var item = _studentCourseMapService.Find(s => s.StudentId == model.StudentId).Select(x => x.CourseId);
                if (item.Count() == 0)
                {
                    _studentCourseMapService.Add(new StudentCourseMap
                    {
                        CourseId = model.CourseId,
                        StudentId = model.StudentId,
                    });
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }

    }
}
