using Premio.Enums;

namespace Premio.Models;

public class FacilityCategory

{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string Description { get; set; } = null!;

    // Navigation property: A FacilityCategory can have many Facilities
    public ICollection<Facility> Facilities { get; set; }
}
