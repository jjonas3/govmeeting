using System;
using System.Collections.Generic;
using System.Linq;
using GM.DatabaseAccess;
using GM.DatabaseModel;

namespace GM.DatabaseRepositories
{
    public class GovBodyRepository : IGovBodyRepository
    {
        dBOperations dBOperations;

        public GovBodyRepository(dBOperations _dBOperations)
        {
            dBOperations = _dBOperations;
        }

        public GovBody Get(long governmentBodyId)
        {
            GovBody govBody = dBOperations.GetGovernmentBody(governmentBodyId);
            return govBody;
        }
        public long GetIdOfMatching(string country, string state, string county, string municipality)
        {
            // TODO - implement - return ID of body based on country, state, county & municipality.
            return -1;
        }

        public long GetIdOfMatching(GovBody g)
        {
            // TODO - implement - return ID of body based on country, state, county & municipality.
            return -1;
        }

        public GovBody GetMatching(string country, string state, string county, string municipality)
        {
            // TODO - implement - return ID of body based on country, state, county & municipality.
            return null;
        }

        public GovBody GetMatching(GovBody g)
        {
            // TODO - implement - return ID of body based on country, state, county & municipality.
            return null;
        }

        public long Add(GovBody g)
        {
            // TODO implement
            return -1;
        }

    }
}
