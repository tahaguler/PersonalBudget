using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalBudget.Core.Budget;
using System;
using System.Collections.Generic;
using System.Net;
using PersonalBudget.Application.Budget;

namespace PersonalBudget.Api.Controllers
{
    [ApiController]
    [Route("api/PersonalBudget")]
    public class MainController : ControllerBase
    {
        private readonly IBudgetAppService _budgetAppService;
        private readonly ILogger<MainController> _logger;

        public MainController(IBudgetAppService budgetAppService, ILogger<MainController> logger)
        {
            _budgetAppService = budgetAppService;
            _logger = logger;
        }

        // GET: api/personalbudget
        [HttpGet]
        public IEnumerable<Budget> GetAllBudgets()
        {
            return _budgetAppService.GetAllBudget();
        }

        // POST: api/personalbudget
        [HttpPost]
        public HttpStatusCode PostBudget([FromBody] BudgetDto addBudgetRequest)
        {
            try
            {
                //  Budget budget = _budgetAppService.ParseAddBudgetRequestToBudget(addBudgetRequest);

                //_budgetAppService.CreateNewBudget(budget);
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