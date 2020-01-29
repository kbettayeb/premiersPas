using MediaChill.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaChill.Controllers
{

    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
           
            return View();
       
        }

        [HttpPost]
        public ActionResult Index(Film film, HttpPostedFileBase file1, HttpPostedFileBase file2)
        {
            if (file1 != null && file2 != null && ModelState.IsValid)
            { 
                try
                {
                    Model1 moedel = new Model1();
                    string path1 = Path.Combine(Server.MapPath("/Photos/"),
                    Path.GetFileName(file1.FileName));
                    file1.SaveAs(path1);
                    film.Image ="/Images/" + file1.FileName;
                    string path2 = Path.Combine(Server.MapPath("/Videos/"),
                    Path.GetFileName(file2.FileName));
                    file2.SaveAs(path2);
                    film.Video = "/Videos/" +file2.FileName;
                    moedel.Films.Add(film);
                    moedel.SaveChanges();
                    
                    ViewBag.Message = "File uploaded successfully";

                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Error" + ex.Message.ToString();
                    
                }
            
                
            }
            return View();
    
        }

       

         

       


   
    }
}
