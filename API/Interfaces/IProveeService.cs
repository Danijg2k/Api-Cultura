using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

public interface IProveeService
{
    public IEnumerable<ProveeDTO> GetAll();

    public ProveeDTO GetByID(int guid);

    public ProveeDTO Add(BaseProveeDTO guid);

    public void Delete(int guid);

    public ProveeDTO Modify(BaseProveeDTO provision, int guid);
}