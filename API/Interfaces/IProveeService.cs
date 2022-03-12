using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

public interface IProveeService
{
    // Usado para mostrar info de ambas tablas (producto y proveedor)
    public IEnumerable<ProveeDTO> GetProveeDetail(int guid);

}