using MeterReadingProject.Models;
using MeterReadingProject.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;

namespace MeterReadingProject.Controllers
{
    public class EmployeeController : Controller
	{

        IEmployeeRL employeeRL;
        IAddMetersRL addMetersRL;
        IMetersReadingRL metersReadingRL;
        public EmployeeController(IEmployeeRL employeeRL,IAddMetersRL addMetersRL)
        {
            this.employeeRL = employeeRL;
            this.addMetersRL = addMetersRL;
        }

        public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Registration()
		{
			return View();
		}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration([Bind] EmployeeRegistrationModel employee)
        {
            if (ModelState.IsValid)
            {
                employeeRL.Registration(employee);
                return RedirectToAction("Employee/Login");
            }
            return View(employee);
        }


        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Admin,Employee")]
        public IActionResult Login([Bind] LoginModel loginModel)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
               
                var result = employeeRL.UserLogin(loginModel);

                

                if (result != null)
                {
					HttpContext.Session.SetInt32("users_id",result.users_id);
					HttpContext.Session.SetString("Email", result.Email);
					HttpContext.Session.SetString("Password", result.Password);
					HttpContext.Session.SetInt32("BranchName", result.BranchName);
					HttpContext.Session.SetInt32("Role", result.Role);
                    HttpContext.Session.SetString("branch_name", result.branch_name);
                    HttpContext.Session.SetString("RoleName", result.RoleName);
                    //HttpContext.Session.Convert SetString("BranchName1", result.BranchName1);

                    if (result.Role.Equals(1))
                    {
                        return RedirectToAction("Admin");
                    }
                    else if (result.Role.Equals(2))
                    {
                        return RedirectToAction("users");
                    }
                    else
                    {
                        return RedirectToAction("Dashboard");
                    }
                    //message = "Username and/or password is correct.";
                    //Console.WriteLine(message);
 
                    //return RedirectToAction("Dashboard");

                }
                else
                {
                    return RedirectToAction("Login");
                }


            }
            return null;
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }


        [HttpGet]
        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Admin()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Users()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddMeters()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMeters([Bind] AddMetersModel addMeters)
        {
			if (ModelState.IsValid)
            {
                addMetersRL.AddMeters(addMeters);
               
            }
            return View(addMeters);
        }
       
		[HttpGet]
		public IActionResult ListMeters()
        {
			var meterlist = employeeRL.GetAllMeters();
			return View(meterlist);
		}


        [HttpGet]
        public IActionResult Meters()
        {
            var meterlist = employeeRL.GetAllMeters();
            ViewBag.Model = meterlist;
            //int id = ViewBag.MetersId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Meters([Bind] MetersReadingData enterMetersReading)
        {
            if (ModelState.IsValid)
            {
               var result =  employeeRL.EnterMetersReading(enterMetersReading);
                if(result!=null)
                {
                    return RedirectToAction("Meters");
                }
                else
                {
                    return RedirectToAction("login");
                }
            }
            return View(enterMetersReading);
        }

        [HttpGet]
        public IActionResult ListMeterReadings()
        {
            var BranchName1 = HttpContext.Session.GetString("branch_name"); 
            
            var meterreadinglist = employeeRL.GetAllMetersReadings(BranchName1);
            return View(meterreadinglist);
        }
        [HttpGet]
        public IActionResult ListMeterReading()
        {
            //var BranchName1 = HttpContext.Session.GetString();

            var meterreadinglist = employeeRL.GetAllMetersReading();
            return View(meterreadinglist);
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var meterlist = employeeRL.GetAllMeters();
            ViewBag.Model = meterlist;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind] MetersReadingData enterMetersReading)
        {
            if (ModelState.IsValid)
            {
                var result = employeeRL.UpdateMeterReading(enterMetersReading);
                if (result != null)
                {
                    return RedirectToAction("ListMeterReadings");
                }
                else
                {
                    return RedirectToAction("login");
                }
            }
            return View(enterMetersReading);
        }


        [HttpGet]
        public ActionResult Show(int ID)
        {
            var BranchName1 = HttpContext.Session.GetString("branch_name");

            var meterreadinglist = employeeRL.ShowReport(BranchName1, ID);
            ViewBag.Model = meterreadinglist;
            return View(meterreadinglist);
            //var BranchName1 = HttpContext.Session.GetString("branch_name");
            //var meterlist = employeeRL.ShowReport(BranchName1,ID);
            //ViewBag.Model = meterlist;
            //return View();
        }

    }
}
