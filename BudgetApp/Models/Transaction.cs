using System;

namespace BudgetApp
{
    internal class Transaction
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }

    }
}
