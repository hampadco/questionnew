using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class DoctorController : Controller
{

    private readonly Context db;

    public DoctorController(Context _db)
    {
       db = _db;

    }

    public IActionResult adddoctor()
    {

        return View();
    }

     [HttpPost]
    public IActionResult add(Tbl_Doctor dr)
    {

        db.Tbl_Doctors.Add(dr);
        db.SaveChanges();

        return RedirectToAction("adddoctor");
    }

    public IActionResult ListDoctor()
    {
        var qlist=db.Tbl_Doctors.OrderByDescending(a=>a.Id).ToList();

        return View(qlist);
    }

    public IActionResult del(int id)
    {
       var qlist=db.Tbl_Doctors.Where(a=>a.Id==id).FirstOrDefault();
        db.Tbl_Doctors.Remove(qlist);
        db.SaveChanges();

        return RedirectToAction("ListDoctor");
    }
    
     public IActionResult update(int id)
    {

        var qlist=db.Tbl_Doctors.Where(a=>a.Id==id).FirstOrDefault();

        return View(qlist);
    }

    public IActionResult up(Tbl_Doctor dr)
    {
       
       db.Tbl_Doctors.Update(dr);
        db.SaveChanges();

          return RedirectToAction("ListDoctor");
    }
    



}