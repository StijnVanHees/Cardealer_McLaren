using McLaren_Cardealer.Data;
using McLaren_Cardealer.Models;
using McLaren_Cardealer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace McLaren_Cardealer.Controllers
{
    public class AdminController : Controller
    {
        private readonly CardealerContext _context;

        public AdminController(CardealerContext context)
        {
            _context = context;
        }

        public IActionResult Autos()
        {
            AutoOverviewViewModel avm = new AutoOverviewViewModel()
            {
                Autos = _context.Autos.ToList()
            };
            return View(avm);
        }

        public  IActionResult Berichten()
        {
            BerichtListViewModel blvm = new BerichtListViewModel()
            {
                Berichten = _context.Berichten.ToList()
            };
            return View(blvm);
        }

        public IActionResult AutoDetails(int id)
        {
            Auto auto = _context.Autos.Where(d => d.AutoId == id).FirstOrDefault();
            Motor motor = _context.Motoren.Where(d => d.MotorId == id).FirstOrDefault();
            if (auto != null)
            {
                AutoDetailsViewModel adv = new AutoDetailsViewModel()
                {
                    AutoId = id,
                    Naam = auto.Naam,
                    Prijs = auto.Prijs,
                    Kilogram = auto.Kilogram,
                    Kleur = auto.Kleur,
                    CodeNaam = motor.CodeNaam,
                    PK = motor.PK,
                    Torque = motor.Torque,
                    Configuratie = motor.Configuratie,
                    ProductieJaar = motor.ProductieJaar

                };
                return View(adv);
            }
            else
            {
                AutoOverviewViewModel avm = new AutoOverviewViewModel()
                {
                    Autos = _context.Autos.ToList()
                };
                return View("Index", avm);
            }
        }


        [HttpGet]
        public IActionResult CreateAuto()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAuto(CreateAutoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(new Auto()
                {
                    Naam = viewModel.Naam,
                    Prijs = viewModel.Prijs,
                    Kilogram = viewModel.Kilogram,
                    Kleur = viewModel.Kleur,
                    Foto = viewModel.Foto
                });
                _context.Add(new Motor()
                {
                    CodeNaam = viewModel.CodeNaam,
                    ProductieJaar = viewModel.ProductieJaar,
                    PK = viewModel.PK,
                    Torque = viewModel.Torque,
                    Configuratie =viewModel.Configuratie
                });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Autos));
            }
            return View(viewModel);
        }

        public IActionResult Orders()
        {
            OrderOverviewViewModel oovm = new OrderOverviewViewModel()
            {
                facturen = _context.Facturen.ToList(),
                autos = _context.Autos.ToList()
                
            };
            return View(oovm);
        }

        [HttpGet]
        public IActionResult EditAuto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Auto auto = _context.Autos.Where(x => x.AutoId == id).FirstOrDefault();
            Motor motor = _context.Motoren.Where(y => y.MotorId == id).FirstOrDefault();

            if (auto == null || motor == null)
            {
                return NotFound();
            }

            EditAutoViewModel eavm = new EditAutoViewModel()
            {
                AutoId = auto.AutoId,
                Naam = auto.Naam,
                Prijs = auto.Prijs,
                Kilogram = auto.Kilogram,
                Kleur=auto.Kleur,
                Foto=auto.Foto,
                CodeNaam = motor.CodeNaam,
                PK = motor.PK,
                ProductieJaar = motor.ProductieJaar,
                Torque = motor.Torque,
                Configuratie = motor.Configuratie

            };
            return View(eavm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAuto(int id, EditAutoViewModel eavm)
        {
            if (id != eavm.AutoId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    Auto auto = new Auto()
                    {
                        AutoId = eavm.AutoId,
                        Naam = eavm.Naam,
                        Prijs = eavm.Prijs,
                        Kilogram = eavm.Kilogram,
                        Kleur = eavm.Kleur,
                        Foto = eavm.Foto             
                    };
                    Motor motor = new Motor()
                    {
                        CodeNaam = eavm.CodeNaam,
                        PK = eavm.PK,
                        ProductieJaar = eavm.ProductieJaar,
                        Torque = eavm.Torque,
                        Configuratie = eavm.Configuratie
                    };
                    _context.Update(auto);
                    _context.Update(motor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException e)
                {

                    if (!_context.Autos.Any(d => d.AutoId == eavm.AutoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Autos));
            }
            return View(eavm);
        }



        [HttpGet]
        public IActionResult DeleteAuto(int id)
        {
            Auto auto = _context.Autos.Where(d => d.AutoId == id).FirstOrDefault();
            Motor motor = _context.Motoren.Where(x => x.MotorId == id).FirstOrDefault();
            if (auto != null && motor != null)
            {
                DeleteAutoViewModel dvm = new DeleteAutoViewModel()
                {
                    AutoId = id,
                    Naam = auto.Naam,
                    Prijs = auto.Prijs,
                    Kilogram = auto.Kilogram,
                    Kleur = auto.Kleur,
                    CodeNaam = motor.CodeNaam,
                    PK = motor.PK,
                    Torque = motor.Torque,
                    Configuratie = motor.Configuratie,
                    ProductieJaar = motor.ProductieJaar
                };

                return View(dvm);
            }
            else
            {
                AutoOverviewViewModel avm = new AutoOverviewViewModel()
                {
                    Autos = _context.Autos.ToList()
                };
                return View("Index", avm);
            }
        }

        [HttpPost, ActionName("DeleteAuto")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAutoConfirm(int id)
        {
            Auto auto = await _context.Autos.FindAsync(id);
            Motor motor = await _context.Motoren.FindAsync(id);
            _context.Autos.Remove(auto);
            _context.Motoren.Remove(motor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Autos));
        }
    }
}
