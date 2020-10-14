using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Models;

namespace DoctorOffice.Controllers
{
  public class PatientsController : Controller
  {
    private readonly DoctorOfficeContext _db;
    public PatientsController(DoctorOfficeContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Patient> model = _db.Patient.OrderBy(x => x.Name).ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Patient patient)
    {
      _db.Patient.Add(patient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult details(int id)
    {
      Patient model = _db.Patient.FirstOrDefault(x => x.PatientId == id);
      return View(model); 
    }
    public ActionResult AddDoctor(int id)
    {
      Patient thisPatient = _db.Patient.FirstOrDefault(s => s.PatientId == id);
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
      return View(thisPatient);
    }
    [HttpPost]
    public ActionResult AddDoctor(PatientDoctor patientDoctor)
    {
      if (patientDoctor.DoctorId != 0)
      {
        if (_db.PatientDoctors.Where(x => x.PatientId == patientDoctor.PatientId && x.DoctorId == patientDoctor.DoctorId).ToHashSet().Count == 0)
        {
          _db.PatientDoctors.Add(patientDoctor);
        }
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisPatient = _db.Patient.FirstOrDefault(x => x.PatientId == id);
      return View(thisPatient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisPatient = _db.Patient.FirstOrDefault(x => x.PatientId == id);
      _db.Patient.Remove(thisPatient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }



  }
}