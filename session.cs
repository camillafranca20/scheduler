using System;
using System.Collections.Generic;

public class Session
{
    public List<Talk> Talks { get; private set; }
    public int TotalDuration { get; private set; }
    public TimeSpan StartTime { get; private set; }
    public TimeSpan EndTime { get; private set; }
    private TimeSpan currentTime;

    public Session(TimeSpan startTime, TimeSpan endTime)
    {
        Talks = new List<Talk>();
        StartTime = startTime;
        EndTime = endTime;
        currentTime = startTime;
    }

    public bool AddTalk(Talk talk)
    {
        if (TotalDuration + talk.Duration <= (EndTime - StartTime).TotalMinutes)
        {
            Talks.Add(talk);
            TotalDuration += talk.Duration;
            return true;
        }
        return false;
    }

    public string PrintSchedule()
    {
        var schedule = new System.Text.StringBuilder();
        currentTime = StartTime;

        foreach (var talk in Talks)
        {
            schedule.AppendLine($"{currentTime:hh\\:mm}H {talk}");
            currentTime = currentTime.Add(TimeSpan.FromMinutes(talk.Duration));
        }

        return schedule.ToString();
    }
}