﻿using System;
using System.Collections.Generic;
using System.Text;
using GM.ProcessRecording;
using GM.ProcessTranscript;
using GM.ViewModels;
using Microsoft.Extensions.Options;
using GM.Configuration;
using GM.FileDataRepositories;
using Microsoft.Extensions.Logging;
using GM.Utilities;
using GM.EditTranscript;

using GM.ApplicationCore.Entities.GovBodies;
using GM.ApplicationCore.Entities.Meetings;
using GM.ApplicationCore.Entities.Speakers;
using GM.ApplicationCore.Entities.Topics;


namespace GM.WorkflowApp
{
    /* The final meeting transctipt is ready for viewing, when either:
     *  1.  An original transcript has been processed and tagged.
     *  OR
     *  2. An original recording has been transcribed and edited.
     */

    public class WF6_View
    {
        readonly ILogger<WF6_View> logger;
        readonly AppSettings config;
        ////readonly IDBOperations dBOperations;
        readonly WorkSegments workSegments = new WorkSegments();

        public WF6_View(
            ILogger<WF6_View> _logger,
            IOptions<AppSettings> _config
            ////IDBOperations _dBOperations
           )
        {
            logger = _logger;
            config = _config.Value;
            ////dBOperations = _dBOperations;
        }

        public void Run()
        {
            // Do we need manager approval?
            bool? approved = true;
            if (!config.RequireManagerApproval) approved = null;
            List<Meeting> meetings;

            // Find all tagged transcripts or edited transcriptions

            ////meetings = dBOperations.FindMeetings(SourceType.Transcript, WorkStatus.Tagged, approved);
            meetings = new List<Meeting>();   // TODO - CA
            foreach (Meeting meeting in meetings)
            {
                ViewTaggedTranscript(meeting);
            }

            ////meetings = dBOperations.FindMeetings(SourceType.Recording, WorkStatus.Edited, approved);
            foreach (Meeting meeting in meetings)
            {
                ViewEditedTranscription(meeting);
            }
        }

        private void ViewTaggedTranscript(Meeting meeting)
        {

        }

        private void ViewEditedTranscription(Meeting meeting)
        {

        }

    }
}
