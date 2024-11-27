using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using PetHealthCenter.Domain.Entities;
using PetHealthCenter.Webb.Data;
using PetHealthCenter.Webb.Models;

namespace PetHealthCenter.Webb.Controllers
{
    public class ClientsController:Controller
    {
        private readonly PetHealthCenterDbContext _context;
        public ClientsController(PetHealthCenterDbContext context) 
        {
           this._context = context;
        }
        public IActionResult Index()
        {

            var clients = _context.Clients.ToList();
            

            return View(clients);
        }
        [HttpGet]
        public IActionResult Create()
        {

            var client = new Client();
            return View(client);
        }
        [HttpPost]
        public IActionResult Create(Client vm)
        {
            // if (ModelState.IsValid)
            // {
            //     _context.Clients.Add(vm);
            //     _context.SaveChanges();
            //     //RedirectToAction("Index");
            //     return RedirectToAction(nameof(Index));
            // }
            ////else
            ////{
            //     return View(vm);
            //// }

            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            _context.Clients.Add(vm);
            _context.SaveChanges();
            //return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var client = _context.Clients.FirstOrDefault(cl => cl.Id == id);

            if (client == null)
            {
                NotFound();
            }
            return View(client);
        }
        [HttpPost]
        public IActionResult Edit(Client vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            _context.Clients.Update(vm);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
