﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RitoAPI.Models;

namespace RitoAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Index()
        {
            string apiResponse;
            using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://euw1.api.riotgames.com/lol/platform/v3/champion-rotations?api_key=RGAPI-9f7f6c27-ba1a-4f98-8a4c-c5fb428fdb1e"))
                {
                    if (!response.IsSuccessStatusCode)
                        throw new Exception("Not a valid response");
                    apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            var result = JsonConvert.DeserializeObject<ChampRotationModel>(apiResponse);
            // = apiResponse;

            return View(result);
        }

        public async Task<IActionResult> ChampionList()
        {
            string apiResponse;
            using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://ddragon.leagueoflegends.com/cdn/9.22.1/data/en_US/champion.json"))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            var result = JsonConvert.DeserializeObject<ChampionList>(apiResponse);

            // = apiResponse;

            return View(result);
        }

        public async Task<IActionResult> showChampion(String id)
        {
            Champion champion;
            string apiResponse;
            using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://ddragon.leagueoflegends.com/cdn/9.22.1/data/en_US/champion.json/" + id + ""))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            var result = JsonConvert.DeserializeObject<ChampionList>(apiResponse);

            // = apiResponse;

            return View(result);
        }

    }
}
