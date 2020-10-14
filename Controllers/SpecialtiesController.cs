using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Models;

namespace DoctorOffice.Controllers 
{
  public class SpecialtiesController : Controller
  {
    private readonly DoctorOfficeContext _db;
    public SpecialtiesController(DoctorOfficeContext db)
    {
      _db = db;
    } 

    public ActionResult Index()
    {
      List<Specialty> model = _db.Specialties.OrderBy(x => x.SpecialtyType).ToList();
      return View(model);
    }
    public ActionResult Create() 
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Specialty specialty)
    {
      _db.Specialties.Add(specialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult details(int id)
    {
        Specialty model = _db.Specialties.FirstOrDefault(x => x.SpecialtyId == id);
        return View(model);
    }
      public ActionResult Delete(int id)
    {
      var thisSpecialtie = _db.Specialties.FirstOrDefault(x => x.SpecialtyId == id);
      return View(thisSpecialtie);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(x => x.SpecialtyId == id);
      _db.Specialties.Remove(thisSpecialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}