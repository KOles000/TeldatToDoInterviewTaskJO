using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TeldatToDoInterviewTaskJO.Models;
using TeldatToDoInterviewTaskJO.Services;

namespace TeldatToDoInterviewTaskJO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IAssigmentService _assigmentService;

        public HomeController(ILogger<HomeController> logger, IAssigmentService service)
        {
            _logger = logger;
            _assigmentService = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Assigments() 
        {
            AssigmentsViewModel viewModel = new AssigmentsViewModel()
            {
                AssigmentsToday = _assigmentService.GetAssigmentsByDate(DateTime.Today.Date),
                AssigmentsTomorrow = _assigmentService.GetAssigmentsByDate(DateTime.Today.AddDays(1)),
                chosenDate = DateTime.Today.Date
            };

            return View(viewModel);
        }

        public IActionResult AddAssigment(int id)
        {
            if(id != null)
            {
                Assigment editedAssigment = _assigmentService.GetAssigmentById(id);
                return View(editedAssigment);
            }
            return View();
        }

        public IActionResult EditAssigment(int id)
        {
            Assigment editedAssigment = _assigmentService.GetAssigmentById(id);
            return RedirectToAction("AddAssigment", editedAssigment);
        }

        public IActionResult AddAssigment_OnAdd(Assigment model)
        {
            try
            {
                _assigmentService.SaveAssigment(model);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Assigments");
        }

        public IActionResult DateChosen(AssigmentsViewModel model)
        {
            AssigmentsViewModel viewModel = new AssigmentsViewModel()
            {
                AssigmentsToday = _assigmentService.GetAssigmentsByDate(model.chosenDate.Date),
                AssigmentsTomorrow = _assigmentService.GetAssigmentsByDate(model.chosenDate.Date.AddDays(1)),
                chosenDate = model.chosenDate.Date
            };
            return View("Assigments", viewModel);
        }

        public IActionResult RemoveAssigment(int id)
        {
            _assigmentService.DeleteAssigmentById(id);
            return RedirectToAction("Assigments");
        }

    }
}
