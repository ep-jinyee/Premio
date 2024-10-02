using System;
using System.Collections.Generic;
using Premio.Enums;

namespace Premio.Models
{
    public class Premise
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public MY_STATE State { get; set; } = MY_STATE.UNDEFINED;
        public string Postcode { get; set; }
        public string BankName { get; set; }
        public string BankAccNo { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public ICollection<Facility> Facilities { get; set; }
        public ICollection<VisitorRequest> VisitorRequests { get; set; }
        public ICollection<Annoucement> Annoucements { get; set; }
        public ICollection<AccessTransaction> AccessTransactions { get; set; }
        public ICollection<Tenant> Tenants { get; set; }
        public ICollection<Gate> Gates { get; set; }
        public ICollection<Parking> Parkings { get; set; }
    }
}
