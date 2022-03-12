using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

public interface IPerteneceService
{
    // Usado para mostrar info de ambas tablas (producto y temporada) una vez dentro de las temporadas
    public IEnumerable<PerteneceDTO> GetPerteneceDetail(int guid);

}