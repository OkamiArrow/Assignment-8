﻿using Assignment8.Models;
using ChipotleCalorieCalculator.Controllers;
using ChipotleCalorieCalculator.Extensions;
using System.Web.Mvc;

namespace Assignment8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowCrossSiteJson]
        public JsonResult GetPlayerInformation(RequestModel model)
        {
            var response = new ResponseModel();
            response.PlayerNumber = model.PlayerNumber;

            if (model.PlayerNumber == 23)
            {
                response.PlayerName = "Lebron James";
            }
            else if (model.PlayerNumber == 2)
            {
                response.PlayerName = "Kyrie Irving";
            }
            else if (model.PlayerNumber == 17)
            {
                response.PlayerName = "Anderson Varejão";
            }
            else if (model.PlayerNumber == 5)
            {
                response.PlayerName = "J.R.Smith";
            }
            else if(model.PlayerNumber == 0)
            {
                response.PlayerName = "Kevin Love";
            }
            else
            {
                response.PlayerName = "Player doesn't exist";
            }

            return new JsonResult().SerializeObject(response);
        }
    }
}