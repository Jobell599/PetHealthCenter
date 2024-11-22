using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using PetHealthCenter.Domain.Entities;
using PetHealthCenter.Webb.Data;

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
        public IActionResult Create()
        {

            var client = new Client();
            return View(client);
        }
    }
}
