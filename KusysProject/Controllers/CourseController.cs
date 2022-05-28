using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using KUSYS_Demo.Models;
using KUSYS_Demo.Entities.Concrete;
using KUSYS_Demo.Business.Interfaces;

namespace KUSYS_Demo.Controllers
{
    public class CourseController : Controller
    {
        #region CTOR - DEPENDENCY INJECTION

        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CourseController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }
        #endregion

        public IActionResult Index()
        {
            return View(_mapper.Map<List<CourseModel>>(_courseService.GetAll()));
        }

        public IActionResult Create()
        {
            return View(new CourseModel());
        }

        [HttpPost]
        public IActionResult Create(CourseModel model)
        {
            if (ModelState.IsValid)
            {
                _courseService.Add(new Course
                {
                    CourseName = model.CourseName,
                     CourseId = model.CourseId
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            return View(_mapper.Map<CourseModel>(_courseService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(CourseModel model)
        {
            if (ModelState.IsValid)
            {
                _courseService.Update(new Course
                {
                    Id = model.Id,
                    CourseName = model.CourseName,
                    CourseId = model.CourseId
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
