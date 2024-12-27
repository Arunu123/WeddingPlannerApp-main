using BudgetService0025.Models;
using BudgetService0025.Services.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetService0025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController0025 : ControllerBase
    {
        private readonly IBudgetService0025 _budgetService;

        public BudgetController0025(IBudgetService0025 budgetService)
        {
            _budgetService = budgetService;
        }

        [HttpPost("CreateBudget")]
        public IActionResult CreateBudget([FromBody] Budget0025 budget)
        {
            var result = _budgetService.CreateBudget(budget);
            return CreatedAtAction(nameof(GetBudget), new { id = result.Id }, result);
        }

        [HttpGet("{id}")]
        public IActionResult GetBudget(string id)
        {
            var result = _budgetService.GetBudget(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBudget(string id, [FromBody] Budget0025 updatedBudget)
        {
            var result = _budgetService.UpdateBudget(id, updatedBudget);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBudget(string id)
        {
            var result = _budgetService.DeleteBudget(id);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpGet("{id}/Categories")]
        public IActionResult GetBudgetCategories(string id)
        {
            var result = _budgetService.GetBudgetCategories(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost("{categoryId}/AddExpense")]
        public IActionResult AddExpense(string categoryId, [FromBody] Expense0025 expense)
        {
            var result = _budgetService.AddExpense(categoryId, expense);
            if (result == null) return NotFound();
            return Ok(result);
        }
    }
}
