using Premio.Enums;
namespace Premio.Models;

public class Annoucement
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public bool Published { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    // Foreign key to Premise
    public string PremiseId { get; set; }
    
    // Navigation property for Premise
    public Premise Premise { get; set; }

    // Foreign key to User (CreatedBy)
    public string UserId { get; set; }
    
    // Navigation property for the User (Creator of the announcement)
    public User CreatedBy { get; set; }
}
