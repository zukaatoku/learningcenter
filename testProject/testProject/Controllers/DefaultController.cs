﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testProject.Misc;

namespace testProject.Controllers {
    public class DefaultController : Controller {
        //
        // GET: /Default/

        [HttpGet]
        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string login, string password) {
            if (login == "admin" && password == "admin") {
                //todo: redirect to feed controller DONE
                //todo: set user information somewhere
                if (Globals.CurrentMode != Mode.ADMINISTRATOR) {
                    return RedirectPermanent("/home/mylearning");
                }
                else {
                    return RedirectPermanent("/administration/index");
                }
                //return null;
            }
            else {
                ViewBag.ErrorMessage = "Пользователя с такими данными не существует!";
                return View();
            }
        }

    }
}