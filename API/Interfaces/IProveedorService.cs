using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// Interface used for 'Proveedor' service
/// </summary>

public interface IProveedorService
{
    public IEnumerable<ProveedorDTO> GetAll();

    //public ProveedorDTO GetByID(int guid);

    //public ProveedorDTO Add(BaseProveedorDTO guid);

    //public void Delete(int guid);

    //public ProveedorDTO Modify(BaseProveedorDTO proveedor, int guid);
}