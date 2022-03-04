using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

public interface IOpinionService
{
    public IEnumerable<OpinionDTO> GetAll();

    public OpinionDTO GetByID(int guid);

    public OpinionDTO Add(BaseOpinionDTO guid);

    public void Delete(int guid);

    public OpinionDTO Modify(BaseOpinionDTO opinion, int guid);
}