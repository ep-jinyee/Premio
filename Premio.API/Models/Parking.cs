using Premio.Enums;

namespace Premio.Models;

public class Parking
{
    public int Id { get; set; }
    public string SpotNumber { get; set; }
    
    // Enum for vehicle type
    public VehicleType VehicleType { get; set; }
    public string Plate { get; set; }
    
    // Foreign key to User
    public string UserId { get; set; }
    
    // Navigation property for the user occupying the parking spot
    public User User { get; set; }

    // Foreign key to Premise
    public string PremiseId { get; set; }

    // Navigation property for the premise where the parking spot is located
    public Premise Premise { get; set; }

    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
}
