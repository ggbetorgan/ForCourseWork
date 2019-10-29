using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kursovaya.Controllers
{
    public class Lab2Controller:Controller
    {
        public string[] getBrandsName()
        {
            string[] BrandsName = { "Stels", "Mongoose", "DE" };
            return BrandsName;
        }
        public double[] getRateBrand()
        {
            double[] Rating = { 7.6, 9.8, 6.9 };
            return Rating;
        }
        public string Browser()
        {
            string userBrowser = HttpContext.Request.Headers["User-Agent"];
            return $"Ваш юраузер - {userBrowser}";
        }

        public string BrandsName(int numBrand)//привем одного парраметра
        {
            if (numBrand > 0)
            {
                string brand = getBrandsName()[numBrand - 1];
                return $"Бренд велосипедов: {brand}";
            }
            else
            {
                return "Введено неверное значение параметра";
            }
        }

        public string ClientReview(int brand, int mark, string comment)
        {
            return $"Вы поставили бреду {getBrandsName()[brand - 1]} оценку {mark} с комментарием: {comment}";
        }

        public string _GetListRateBrand(int[] numBrand)
        {
            string info = "";
            foreach (int i in numBrand)
            {
                if (i>0&&i<4)
                {
                    info+= $"Бренд велосипедов {getBrandsName()[i - 1]} среди покупателей имеет рейтинг {getRateBrand()[i - 1]}. ";
                }
                else
                {
                    return "бренда с таким ID нет в нашей базе";
                }
            }
            return info;
        }

        [HttpGet]
        public IActionResult CheckForms()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckForms(string Username, string Email, string Password, string RepeatPassword)
        {
            if (Password == RepeatPassword)
            {
                string RegisterFormData = $"Регистрация завершена! Имя пользователя: {Username},  E-mail: {Email}";
                return Content(RegisterFormData);
            }
            else
            {
                string RegisterFormData = $"Пароли не совпадают!";
                return Content(RegisterFormData);
            }

        }
    }
}
