﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalBudget.Api.Models
{
    [Table("BudgetExpense")]
    public class BudgetExpense
    {
        [Key] public int Id { get; set; }
        public int BudgetId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public bool? IsDeleted { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? TenantId { get; set; }
    }
}
