using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// Interface used for 'Temporada' service
/// </summary>

public interface ITemporadaService
{
    public IEnumerable<TemporadaDTO> GetAll();

    //public TemporadaDTO GetByID(int guid);

    //public TemporadaDTO Add(BaseTemporadaDTO guid);

    //public void Delete(int guid);

    //public TemporadaDTO Modify(BaseTemporadaDTO temporada, int guid);
}