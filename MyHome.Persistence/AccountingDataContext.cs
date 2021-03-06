﻿using System.Data.Entity;
using MyHome.DataClasses;
using MyHome.Persistence.Configurations;

namespace MyHome.Persistence
{
    public class AccountingDataContext : DbContext
    {
        public AccountingDataContext() : base("name=Database")
        {
        }

        public AccountingDataContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new IncomeConfiguration());
            modelBuilder.Configurations.Add(new IncomeCategoryConfiguration());
            modelBuilder.Configurations.Add(new ExpenseConfiguration());
            modelBuilder.Configurations.Add(new ExpenseCategoryConfiguration());
            modelBuilder.Configurations.Add(new PaymentMethodConfiguration());
        }

        public virtual IDbSet<Income> Incomes { get; set; }

        public virtual IDbSet<Expense> Expenses { get; set; }

        public virtual IDbSet<IncomeCategory> IncomeCategories { get; set; }

        public virtual IDbSet<ExpenseCategory> ExpenseCategories { get; set; }

        public virtual IDbSet<PaymentMethod> PaymentMethods { get; set; }
    }
}
