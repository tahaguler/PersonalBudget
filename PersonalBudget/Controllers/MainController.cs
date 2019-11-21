using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalBudget.Api.Models;
using PersonalBudget.Api.Models.RequestModels;
using PersonalBudget.Api.Services;
using System;
using System.Collections.Generic;
using System.Net;

namespace PersonalBudget.Api.Controllers
{
    [ApiController]
    [Route("api/PersonalBudget")]
    public class MainController : Controller
    {
        private readonly ILogger<MainController> _logger;

        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
        }


        // GET: api/personalbudget
        [HttpGet]
        public IEnumerable<Budget> GetAllBudgets()
        {
            PersonalBudgetService personalBudgetService = new PersonalBudgetService();
            return personalBudgetService.GetAllBudget();
        }

        // POST: api/personalbudget
        [HttpPost]
        public HttpStatusCode PostBudget([FromBody] AddBudgetRequest addBudgetRequest)
        {
            try
            {
                PersonalBudgetService personalBudgetService = new PersonalBudgetService();
                Budget budget = personalBudgetService.ParseAddBudgetRequestToBudget(addBudgetRequest);
                personalBudgetService.CreateNewBudget(budget);
                return HttpStatusCode.OK;
            }
            catch (Exception exc)
            {
                return HttpStatusCode.InternalServerError;
            }
        }

        // POST: api/personalbudget
        [HttpPost("{budgetId}")]
        public HttpStatusCode PostExpenses(int budgetId, [FromBody] string description, string amount)
        {
            return HttpStatusCode.OK;
        }
    }
}
