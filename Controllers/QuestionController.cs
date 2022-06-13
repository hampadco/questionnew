using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class QuestionController : Controller
{

    private readonly Context db;

    public QuestionController(Context _db)
    {
       db = _db;

    }

    public IActionResult index()
    {
       
        //check tempdata for error message
        if (TempData["Error"] != null)
        {
            ViewBag.Error = TempData["Error"];
            TempData["Error"] = null;

        }
       
        return View();
    }
    
    //add category
    public IActionResult addCategory(Tbl_Category category)
    {
        //if caategory name repited then show error
        if (db.Tbl_Categories.Any(x => x.Name == category.Name))
        {
            //tempdata show error
           
           TempData["error"] = "Category Name Already Exist";
           return RedirectToAction("index");
            
        }
        else
        {
            db.Tbl_Categories.Add(category);
            db.SaveChanges();
            //add final id into tbl_category
            var lastId = db.Tbl_Categories.OrderByDescending(x => x.Id).FirstOrDefault();
            //add lastid into session
            HttpContext.Session.SetInt32("lastId", lastId.Id);
            //add name lastid into session
            HttpContext.Session.SetString("LastName", lastId.Name);

                return RedirectToAction("DesignQuestion");
        }
        
        
    }
   
   public IActionResult DesignQuestion(int id)
   {
        //view bag show seesion lastname
        ViewBag.LastName = HttpContext.Session.GetString("LastName");
        ViewBag.listquestion= db.tbl_Questions.Where(x => x.Id_Category == id).ToList();

        //viwbag tblchoices by id category
        ViewBag.listchoices = db.Tbl_Choices.Where(x => x.CategoryId == id).ToList();
       return View();
   }
   
    //add question
    [HttpPost]
    public IActionResult addtext(Tbl_Question q)
    {
        //find count of question in category and add question number
        int count;
         var subid=HttpContext.Session.GetInt32("subId") ;
          if (subid != null && subid.ToString() != ""  && subid.ToString() != "0")
          {
            var s=db.Tbl_Choices.Where(x => x.Id == subid).Select(x=>x.NumberQuestion).FirstOrDefault();
             count=db.tbl_Questions.Where(x => x.Id == s).Select(x=>x.Question_Number).FirstOrDefault();
            q.ParentId =int.Parse(subid.ToString()) ;

          }else
          {
                     count = db.tbl_Questions.Where(x => x.Id_Category == HttpContext.Session.GetInt32("lastId") && x.ParentId==0).Count()+1;
                     q.ParentId = 0;

          }
          
        //add tbl_question
        q.Question_Number = count;
        q.Id_Category =int.Parse(HttpContext.Session.GetInt32("lastId").ToString()) ;
        q.Status = true;
        q.Access = "public";
        db.tbl_Questions.Add(q);
        db.SaveChanges();
        //find last id of question
        var lastId = db.tbl_Questions.OrderByDescending(x => x.Id).FirstOrDefault();

        //add tbl_choice
        if (subid != null && subid.ToString() != ""  && subid.ToString() != "0")
          {
            //update subquestionid
            var subquestion=db.Tbl_Choices.Where(x => x.Id == subid).FirstOrDefault();
            subquestion.SubquestionId = lastId.Id;
            db.SaveChanges();
            HttpContext.Session.Remove("subId");

          }

      
        return RedirectToAction("DesignQuestion",new {id=HttpContext.Session.GetInt32("lastId")});
    }
    

//add tbl_choice
    public IActionResult addChoice(Tbl_Question q,string listitem)    
    {

        if (listitem != null)
        {
            //split listitem
            int count;
            var list = listitem.Split(',');
          //find count of question in category and add question number
           var subid=HttpContext.Session.GetInt32("subId") ;
          if (subid != null && subid.ToString() != ""  && subid.ToString() != "0")
          {
            var s=db.Tbl_Choices.Where(x => x.Id == subid).Select(x=>x.NumberQuestion).FirstOrDefault();
             count=db.tbl_Questions.Where(x => x.Id == s).Select(x=>x.Question_Number).FirstOrDefault();
            q.ParentId =int.Parse(subid.ToString()) ;

          }else
          {
                     count = db.tbl_Questions.Where(x => x.Id_Category == HttpContext.Session.GetInt32("lastId") && x.ParentId==0).Count()+1;
                     q.ParentId = 0;

          }
        
        //add tbl_question
        q.Question_Number = count;
        q.Id_Category =int.Parse(HttpContext.Session.GetInt32("lastId").ToString()) ;
        q.Status = true;
        q.Access = "public";
        db.tbl_Questions.Add(q);
        db.SaveChanges();
        //find last id of question
        var lastId = db.tbl_Questions.OrderByDescending(x => x.Id).FirstOrDefault();
        //add tbl_choice
        if (subid != null && subid.ToString() != ""  && subid.ToString() != "0")
          {
            //update subquestionid
            var subquestion=db.Tbl_Choices.Where(x => x.Id == subid).FirstOrDefault();
            subquestion.SubquestionId = lastId.Id;
            db.SaveChanges();
            HttpContext.Session.Remove("subId");

          }
        //add tbl_choice
        foreach (var item in list)
        {
            if (item !="")
            {
                Tbl_Choice choice = new Tbl_Choice();
                choice.NumberQuestion = lastId.Id;
                choice.ItemName = item;
                choice.SubquestionId = 0;
                choice.CategoryId = int.Parse(HttpContext.Session.GetInt32("lastId").ToString());
                db.Tbl_Choices.Add(choice);
                db.SaveChanges();
            }
            
        }
        }
        return RedirectToAction("DesignQuestion",new {id=HttpContext.Session.GetInt32("lastId")});
    }

    //add checkbox
     public IActionResult addcheckbox(Tbl_Question q,string listitemcheckbox)    
    {

        if (listitemcheckbox != null)
        {
            int count;
            //split listitem
            var list = listitemcheckbox.Split(',');
          //find count of question in category and add question number
          var subid=HttpContext.Session.GetInt32("subId") ;
          if (subid != null && subid.ToString() != ""  && subid.ToString() != "0")
          {
            var s=db.Tbl_Choices.Where(x => x.Id == subid).Select(x=>x.NumberQuestion).FirstOrDefault();
             count=db.tbl_Questions.Where(x => x.Id == s).Select(x=>x.Question_Number).FirstOrDefault();
            q.ParentId =int.Parse(subid.ToString()) ;

          }else
          {
                     count = db.tbl_Questions.Where(x => x.Id_Category == HttpContext.Session.GetInt32("lastId") && x.ParentId==0).Count()+1;
                     q.ParentId = 0;

          }
        //add tbl_question
        q.Question_Number = count;
        q.Id_Category =int.Parse(HttpContext.Session.GetInt32("lastId").ToString()) ;
        q.Status = true;
        q.Access = "public";
        db.tbl_Questions.Add(q);
        db.SaveChanges();
        //find last id of question
        var lastId = db.tbl_Questions.OrderByDescending(x => x.Id).FirstOrDefault();
        //add tbl_choice
        if (subid != null && subid.ToString() != ""  && subid.ToString() != "0")
          {
            //update subquestionid
            var subquestion=db.Tbl_Choices.Where(x => x.Id == subid).FirstOrDefault();
            subquestion.SubquestionId = lastId.Id;
            db.SaveChanges();
            HttpContext.Session.Remove("subId");

          }
        foreach (var item in list)
        {
            if (item !="")
            {
                Tbl_Choice choice = new Tbl_Choice();
                choice.NumberQuestion = lastId.Id;
                choice.ItemName = item;
                choice.SubquestionId = 0;
                choice.CategoryId = int.Parse(HttpContext.Session.GetInt32("lastId").ToString());
                db.Tbl_Choices.Add(choice);
                db.SaveChanges();
            }
            
        }
        }
        return RedirectToAction("DesignQuestion",new {id=HttpContext.Session.GetInt32("lastId")});
    }

    //add select sub
    public void selectsub(int id)
    {
        //id save to session
        HttpContext.Session.SetInt32("subId", id);
        
        
    }
    

}