﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_EntityFrameWork_readV2.Controllers
{
    public class HomeController : Controller
    {
        private Models.Database1Entities2 db = new Models.Database1Entities2();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            //List<Models.User> mesUsers;
            //mesUsers = Data_Services.DataServices.GetUsers();

            return View(db.User.ToList());
        }
    }
}