using System;
using Premio.Interfaces;
using Premio.Models;

namespace Premio.Services;

public class PremiseService : IPremiseService
{
    public Task<bool> CreatePremiseAsync(string premiseName)
    {
        throw new NotImplementedException();
    }
    
    public Task<bool> DeletePremiseAsync(string premiseId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Premise>> GetAllPremiseAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Premise> GetPremiseByIdAsync(string premiseId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdatePremiseAsync(string premiseId, string newPremiseName)
    {
        throw new NotImplementedException();
    }
}
