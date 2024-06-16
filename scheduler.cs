using System;
using System.Collections.Generic;
using System.Linq;

public class Scheduler
{
    public Conference ScheduleConference(List<Talk> talks)
    {
        talks = talks.OrderByDescending(t => t.Duration).ToList();
        var conference = new Conference();

        while (talks.Any())
        {
            var track = new Track();

            ScheduleSession(track.MorningSession, talks);
            ScheduleSession(track.AfternoonSession, talks);

            track.ScheduleNetworkingEvent();
            conference.AddTrack(track);
        }

        return conference;
    }

    private void ScheduleSession(Session session, List<Talk> talks)
    {
        foreach (var talk in talks.ToList())
        {
            if (session.AddTalk(talk))
            {
                talks.Remove(talk);
            }
        }
    }
}