namespace Premio.Models;
public class Tenant
{
    public int Id { get; set; }
    public required string Unit { get; set; }
    public required string Floor { get; set; }
    public required string Block { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Guid PremiseId { get; set; }
    public Premise Premise { get; set; } = null!;
    public string? UserId { get; set; }
    public User User { get; set; } = null!;
}
