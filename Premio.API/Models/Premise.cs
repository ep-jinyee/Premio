using System;
using System.Collections.Generic;
using Premio.Enums;

namespace Premio.Models;
public class Premise
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Address1 { get; set; }
        public string? Address2 { get; set; }
        public MY_STATE State { get; set; } = MY_STATE.UNDEFINED;
        public required string Postcode { get; set; }
        public required string ContactPhone { get; set; }
        public required string ContactEmail { get; set; }
        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public ICollection<Tenant> Tenants { get; set; } = [];
        // public ICollection<Facility> Facilities { get; set; }
        // public ICollection<AccessRequest> VisitorRequests { get; set; }
        // public ICollection<Annoucement> Annoucements { get; set; }
        // public ICollection<AccessTransaction> AccessTransactions { get; set; }
        // public ICollection<Gate> Gates { get; set; }
        // public ICollection<Parking> Parkings { get; set; }
    }
