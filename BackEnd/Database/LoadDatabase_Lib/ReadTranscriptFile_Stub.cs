using System;
using System.Collections.Generic;
using System.Text;
using GM.DatabaseModel;

namespace GM.LoadDatabase
{
    class ReadTranscriptFile_Stub
    {
        public GovBody LoadHeadingInfo()
        {
            return new GovBody();
        }

        public Meeting LoadMeetingData(List<Category> categories, List<Topic> topics)
        {
            return new Meeting();
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

/*
    private addtags: Addtags = {
        data: [
            { speaker: 'Joe', said: 'Waz up', section: 'Invocation', topic: null, showSetTopic: false },
            { speaker: 'Mary', said: 'nutten', section: null, topic: null, showSetTopic: false },
            { speaker: 'Jo', said: 'haiyall', section: null, topic: null, showSetTopic: false },
            { speaker: 'Joe', said: '1111', section: 'Reports', topic: null, showSetTopic: false },
            { speaker: 'Mary', said: '1111111', section: null, topic: 'Topic1', showSetTopic: false },
            { speaker: 'Jo', said: '11111111', section: null, topic: null, showSetTopic: false },
            { speaker: 'Jose', said: '22', section: null, topic: null, showSetTopic: false },
            { speaker: 'Mary', said: '2222', section: null, topic: null, showSetTopic: false },
            { speaker: 'Jo', said: '2222222', section: null, topic: null, showSetTopic: false },
            { speaker: 'Joe', said: '33', section: 'Public Comment', topic: null, showSetTopic: false },
            { speaker: 'Mary', said: '33333', section: null, topic: 'Topic2', showSetTopic: false },
            { speaker: 'Jo', said: '33333333', section: null, topic: null, showSetTopic: false }
        ]
 */
