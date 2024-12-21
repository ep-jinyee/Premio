using Premio.Models;

namespace Premio.Interfaces;
public interface IPremiseService
{
    Task<IEnumerable<Premise>> GetAllPremiseAsync();
    Task<Premise> GetPremiseByIdAsync(string premiseId);
    Task<bool> CreatePremiseAsync(string premiseName);
    Task<bool> UpdatePremiseAsync(string premiseId, string newPremiseName);
    Task<bool> DeletePremiseAsync(string premiseId);
}
