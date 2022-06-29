using SQLite;
using System;

namespace BudgetApp
{
    internal class Transaction
    {
        [PrimaryKey, AutoIncrement] public int ID { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }

    }
}
