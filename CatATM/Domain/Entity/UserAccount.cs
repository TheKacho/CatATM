using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatATM.Domain.Entity
{
    public class UserAccount
    {
        public int Id { get; set; }
        public long AccountNumber { get; set; }
        public int AccountPin { get; set; }
        public string Name { get; set; }
        public decimal AcctBalance { get; set; }
        public int TotalLog { get; set; }
        public bool IsLocked { get; set; }
    }
}
