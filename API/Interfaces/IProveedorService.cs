using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

public interface IProveedorService
{
    public IEnumerable<ProveedorDTO> GetAll();

    public ProveedorDTO GetByID(int guid);

    public ProveedorDTO Add(BaseProveedorDTO guid);

    public void Delete(int guid);

    public ProveedorDTO Modify(BaseProveedorDTO proveedor, int guid);
}