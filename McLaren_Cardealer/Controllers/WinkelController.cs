using McLaren_Cardealer.Data;
using McLaren_Cardealer.Models;
using McLaren_Cardealer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace McLaren_Cardealer.Controllers
{
    public class WinkelController : Controller
    {
        private readonly CardealerContext _context;

        public WinkelController(CardealerContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            WinkelViewModel wvm = new WinkelViewModel();
            wvm.Autos = _context.Autos.ToList();


            return View(wvm);
        }
        public IActionResult Details(int id)
        {
            Auto auto = _context.Autos.Where(d => d.AutoId == id).FirstOrDefault();
            Motor motor = _context.Motoren.Where(a => a.MotorId == id).FirstOrDefault();
            //AutoMotor autoMotor = _context.AutoMotors.Where(d => d.AutoMotorId == id).FirstOrDefault();   
            //Motor motor = _context.Motoren.Where(d => d.MotorId == autoMotor.MotorId).FirstOrDefault();



            WinkelDetailViewModel wvm = new WinkelDetailViewModel();

            wvm.Naam = auto.Naam;
            wvm.Prijs = auto.Prijs;
            wvm.Kilogram = auto.Kilogram;
            wvm.Kleur = auto.Kleur;
            wvm.Foto = auto.Foto;
            wvm.PK = motor.PK;
            wvm.Torque = motor.Torque;
            wvm.Configuratie = motor.Configuratie;
            wvm.ProductieJaar = motor.ProductieJaar;
            wvm.CodeNaam = motor.CodeNaam;


            //wvm.CodeNaam = motor.CodeNaam;
            //wvm.PK = motor.PK;
            //wvm.Torque = motor.Torque;
            //wvm.Configuratie = motor.Configuratie;
            //wvm.ProductieJaar = motor.ProductieJaar;

            //Testen van curses en donutqueen
            //wvm.AutoMotoren = _context.AutoMotors.Include(x => x.Auto).Include(y => y.Motor).Where(z => z.MotorId == id).ToList();


            //Naam = auto.Naam,
            //Prijs = auto.Prijs,
            //Kilogram = auto.Kilogram,
            //Kleur = auto.Kleur,
            //Foto = auto.Foto,

            //CodeNaam = motor.CodeNaam,
            //PK = motor.PK,
            //Torque = motor.Torque,
            //Configuratie = motor.Configuratie,
            //ProductieJaar = motor.ProductieJaar



            return View(wvm);
        }
    }
}
