using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
                }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();  
            return View(data);
                }
        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        //get: Actors/Details
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Notfound");
            return View(actorDetails);
        }
        public async Task<IActionResult> Edit(int Id)
        {
            var data = await _service.GetByIdAsync(Id);
            if(data == null) return View("NotFound");
             return View(data);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int Id,[Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
              if (!ModelState.IsValid)
            {
                return View(actor);
             }
            await _service.UpdateAsync(Id,actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var data = await _service.GetByIdAsync(Id);
            if (data == null) return View("NotFound");
            return View(data);

        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
