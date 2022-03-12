using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

public interface IProveeService
{
    // Usado para poder mostrar cada producto junto a su precio, ya que se encuentran en tablas diferentes (producto, provee)
    public IEnumerable<ProveeDTO> GetProveeDetail();

    // Usado para mostrar info de ambas tablas (producto y proveedor) una vez dentro de los productos
    public IEnumerable<ProveeDTO> GetProveeDetail(int guid);

}