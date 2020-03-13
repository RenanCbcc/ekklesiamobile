using Caelum.Stella.CSharp.Vault;
using System;

namespace ekklesiamobile.Models.TransactionModel
{
    public class Transaction : BaseModel
    {
        public Transaction()
        {
            this.Date = DateTime.Today;
            this.Value = 0.0;
        }

        public DateTime Date { get; set; }
        public Money Value { get; set; }
        public TransactionType Type { get; set; }
        public string Category { get; set; }

        public Object ToJson()
        {
            return new
            {
                Id,
                Date = Date.ToString("O"),
                Value = (decimal)Value,
                Type = Type.ToString(),
                Category
            };

        }

    }
}
