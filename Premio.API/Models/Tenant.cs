namespace Premio.Models;
public class Tenant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Unit { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    // Foreign key to Premise
    public string PremiseId { get; set; }
    
    // Navigation property for the Premise where the tenant resides
    public Premise Premise { get; set; }

    // Foreign key to User (Tenant can be assigned to a user)
    public string UserId { get; set; }
    
    // Navigation property for the User assigned to the tenant
    public User User { get; set; }
}
