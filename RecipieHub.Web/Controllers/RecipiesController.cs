using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RecipieHub.Domain;
using RecipieHub.Domain.Interfaces;

namespace RecipieHub.Web
{
    public class RecipiesController : Controller
    {
        private IRecipieApplicationService _service;

        public RecipiesController (IRecipieApplicationService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet("api/Recipies")]
        public List<Recipie> RetrieveRecipies()
        {
            //TODO: return a view model object instead
            return _service.RecipiesRetreive();
        }
    }
}