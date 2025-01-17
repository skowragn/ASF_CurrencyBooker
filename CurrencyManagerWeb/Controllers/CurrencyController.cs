﻿using Microsoft.AspNetCore.Mvc;
using CurrencyManagerWeb.Models;
using System.Threading.Tasks;
using CurrencyManagerWeb.Interfaces;

namespace CurrencyManagerWeb.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ICurrencyList _currencyListService;
        private CurrencyListViewModel _currencyList = new();

        public CurrencyController(ICurrencyList currencyListService)
        {
            _currencyListService = currencyListService;
        }

        public async Task<ActionResult> Index()
        { 
            _currencyList = await _currencyListService.GetCurrenciesListViewModelInput();
            return View(_currencyList);
        }
    }
}
