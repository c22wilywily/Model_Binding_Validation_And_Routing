using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model_Binding_Validation_And_Routing.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Model_Binding_Validation_And_Routing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Register()
        {
            return View();
        }

        //Routing của Register là https://localhost:44322/Home/Register
        [HttpPost]
        public IActionResult Register(Student student)
        {
            //user nhập vào đúng với tất cả các kiểu dữ liệu và điều kiện
            if (ModelState.IsValid)
            {
                //thêm vào danh sách có sẵn
                Repository.SetStudent(student);
                //Truyền data student vào trang Thanks
                return View("Thanks", student);
            }
            //user nhập vào không đúng với tất cả các kiểu dữ liệu và điều kiện
            else
            {
                //trả về View
                return View();
            }
        }
        //Routing của Register là https://localhost:44322/Home/ListStudent
        public IActionResult ListStudent()
        {
            //list danh sách Student
            return View(Repository.GetStudent());
        }
    }
}
