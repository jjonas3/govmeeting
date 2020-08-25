using System;
using System.Collections.Generic;
using System.Linq;
using GM.DatabaseModel;

namespace GM.DatabaseRepositories
{
    public class GovBodyRepository_Stub : IGovBodyRepository
    {
    public GovBody Get(long governmentBodyId)
    {
        GovBody location = GetTestMeeting(governmentBodyId);
        return location;
    }

    // Return ID of government body, if it exists
    //public long GetId(GovernmentBody body)
    //{
    //    GovernmentBody g = testGovBodies.Find(element =>
    //        (element.Country == body.Country) &&
    //        (element.County == body.County) &&
    //        (element.State == body.State) &&
    //        (element.Municipality == body.Municipality)
    //    );
    //    return g.Id;
    //}


    public long GetIdOfMatching(string country, string state, string county, string municipality)
    {
        GovBody govBody = new GovBody(country, state, county, municipality);
        return GetIdOfMatching(govBody);
    }

    public long GetIdOfMatching(GovBody g)
    {
        GovBody govBody = GetMatching(g);

        return (govBody == null) ? -1 : govBody.Id;
    }

    public GovBody GetMatching(string country, string state, string county, string municipality)
    {
        GovBody govBody = new GovBody(country, state, county, municipality);
        return GetMatching(govBody);
    }

    public GovBody GetMatching(GovBody g)
    {
        GovBody govBody = testGovBodies.Find(e =>
            (e.Country == g.Country) &&
            (e.County == g.County) &&
            (e.State == g.State) &&
            (e.Municipality == g.Municipality)
        );
        return govBody;
    }

    public long Add(string country, string state, string county, string municipality)
    {
        GovBody g = new GovBody(country, state, county, municipality);
        return Add(g);
    }

    public long Add(GovBody govBody )
    {      
        long id= testGovBodies.Count + 1;
        govBody.Id = id;
        testGovBodies.Add(govBody);
        return id;
    }


    private GovBody GetTestMeeting(long govBodyId)
    {
        GovBody govBody = testGovBodies.Single(m => m.Id == govBodyId);
        return govBody;
    }

    private List<GovBody> testGovBodies = new List<GovBody>
        {
            new GovBody()
            {
                Id = 1,
                Name = "Selectmen",
                Country = "USA",
                State = "ME",
                County = "LincolnCounty",
                Municipality = "BoothbayHarbor",
                Languages = new List<Language> {new Language {Id = 1, Name = "en"} }
            },
            new GovBody()
            {
                Id = 2,
                Name = "CityCouncil",
                Country = "USA",
                State = "PA",
                County = "Philadelphia",
                Municipality = "Philadelphia",
                Languages = new List<Language> {new Language {Id = 1, Name = "en"} }
            }
        };
    }
}
