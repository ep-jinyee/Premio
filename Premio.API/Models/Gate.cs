using System.Collections.Generic;
using Premio.Enums;

namespace Premio.Models
{
    public class Gate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GateType Type { get; set; }
        public string PremiseId { get; set; }
        public Premise Premise { get; set; }
        public ICollection<AccessTransaction> AccessTransactions { get; set; }
    }
}
