namespace PersonalBudget.Api.Models.RequestModels
{
    public class AddBudgetRequest
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string CreateUser { get; set; }
        public string TenantId { get; set; }
    }
}
