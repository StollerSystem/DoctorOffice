using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Models;

namespace DoctorOffice.Controllers
{
  public class DoctorsController : Controller
  {
    private readonly DoctorOfficeContext _db;
    public DoctorsController(DoctorOfficeContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Doctor> model = _db.Doctors.OrderBy(x => x.Name).ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Doctor doctor)
    {
      _db.Doctors.Add(doctor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Doctor model = _db.Doctors.FirstOrDefault(doctor => doctor.DoctorId == id);
      return View(model);
    }
    public ActionResult AddSpecialty(int id)
    {
      Doctor thisDoctor = _db.Doctors.FirstOrDefault(s => s.DoctorId == id);
      ViewBag.SpecialtyId = new SelectList(_db.Specialties, "SpecialtyId", "SpecialtyType");
      return View(thisDoctor);
    }
    [HttpPost]
    public ActionResult AddSpecialty(SpecialtyDoctor specialtyDoctor)
    {
      if (specialtyDoctor.SpecialtyId != 0)
      {
        if (_db.SpecialtyDoctors.Where(x => x.SpecialtyId == specialtyDoctor.SpecialtyId && x.DoctorId == specialtyDoctor.DoctorId).ToHashSet().Count == 0)
        {
          _db.SpecialtyDoctors.Add(specialtyDoctor);
        }
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisDoctor = _db.Doctors.FirstOrDefault(x => x.DoctorId == id);
      return View(thisDoctor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisDoctor = _db.Doctors.FirstOrDefault(x => x.DoctorId == id);
      _db.Doctors.Remove(thisDoctor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}