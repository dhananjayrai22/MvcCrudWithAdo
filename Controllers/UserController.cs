﻿using MvcCrudWithAdo.Models;
using MvcCrudWithAdo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrudWithAdo.Controllers
{
    public class UserController : Controller
    {
        UserDAL userDAL = new UserDAL();
        // GET: User
        public ActionResult List()
        {
            var data= userDAL.GetUsers();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserModel user)
        {
            if(userDAL.InsertUser(user))
            {
                TempData["InsertMsg"] = "<script>alert('User Saved Successfully..')</script>";
                return RedirectToAction("List");
            }
            else
            {
                TempData["InsertErrorMsg"] = "<script>alert('Data not saved.')</script>";
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var data = userDAL.GetUsers().Find(a => a.Id == id);
            return View(data);
        }

        public ActionResult Edit(int id)
        {
            var data = userDAL.GetUsers().Find(a => a.Id == id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(UserModel user)
        {
            if (userDAL.UpdateUser(user))
            {
                TempData["UpdateMsg"] = "<script>alert('User Updated Successfully..')</script>";
                return RedirectToAction("List");
            }
            else
            {
                TempData["UpadteErrorMsg"] = "<script>alert('Data not updated.')</script>";
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            int r = userDAL.DeleteUser(id);
            if (r > 0)
            {
                TempData["DeleteMsg"] = "<script>alert('User Deleted Successfully..')</script>";
                return RedirectToAction("List");
            }
            else
            {
                TempData["DeleteErrorMsg"] = "<script>alert('Data not deleted.')</script>";
            }
            return View();
        }
    }
}