using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GM.DatabaseModel;

namespace GM.DatabaseRepositories
{
    public interface IGovBodyRepository
    {
        GovBody Get(long govBodyId);
        
        long GetIdOfMatching(string country, string state, string county, string municipality);

        long GetIdOfMatching(GovBody govBody);

        GovBody GetMatching(string country, string state, string county, string municipality);

        GovBody GetMatching(GovBody govBody);
        long Add(GovBody govBody);
    }
}
