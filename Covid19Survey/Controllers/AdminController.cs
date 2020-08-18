using Covid19Survey.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Survey.Controllers
{
    [Authorize]
    public class AdminController:Controller
    {

        private IResponseRepository repository;
        public AdminController(IResponseRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(repository.ResponseCollection);

        [HttpPost]
        public IActionResult Delete(String name)
        {
            UserResponse deletedItem = repository.Delete(name);
            if (deletedItem != null)
            {
                TempData["message"] = $"{deletedItem.Name} was deleted";
            }
            return RedirectToAction("Index");
        }

       
    }
}
