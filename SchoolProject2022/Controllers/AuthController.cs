﻿using Microsoft.AspNetCore.Mvc;
using SchoolProject2022.AuthHelpers;
using System.Threading.Tasks;

namespace SchoolProject2022.Controllers
{
    public class AuthController : Controller
    {
        private AuthHelper _authHelper;

        public AuthController(AuthHelper authHelper)
        {
            _authHelper = authHelper;
        }
   
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            ViewBag.LoginResult = "";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            var isSuccess = await _authHelper.SecureSignInAsync(userName, password);

            if (isSuccess == true)
            {
                return RedirectToAction("Index", "Home");

            }
            ViewBag.LoginResult = "no user found. check login details...";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            var isSuccess = _authHelper.SecureSignOutAsync();
            return RedirectToAction("Login", "Auth");
        }

        [HttpGet]
        public async Task<IActionResult> Err()
        {
            var isSuccess = _authHelper.SecureSignOutAsync();
            return RedirectToAction("Login", "Auth");
        }
    }
}
