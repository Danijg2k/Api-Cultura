using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

public interface IPerteneceService
{
    public IEnumerable<PerteneceDTO> GetAll();

    public PerteneceDTO GetByID(int guid);

    public PerteneceDTO Add(BasePerteneceDTO guid);

    public void Delete(int guid);

    public PerteneceDTO Modify(BasePerteneceDTO pertenencia, int guid);
}