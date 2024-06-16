using System;

public class Track
{
    public Session MorningSession { get; private set; }
    public Session AfternoonSession { get; private set; }
    public string NetworkingEventTime { get; private set; }

    public Track()
    {
        MorningSession = new Session(TimeSpan.FromHours(9), TimeSpan.FromHours(12));
        AfternoonSession = new Session(TimeSpan.FromHours(13), TimeSpan.FromHours(17));
        NetworkingEventTime = "16:00H Networking Event";
    }

    public void ScheduleNetworkingEvent()
    {
        if (AfternoonSession.TotalDuration <= 180)
        {
            NetworkingEventTime = "16:00H Networking Event";
        }
        else
        {
            NetworkingEventTime = "17:00H Networking Event";
        }
    }

    public string PrintSchedule(int trackNumber)
    {
        var schedule = new System.Text.StringBuilder();
        schedule.AppendLine($"Trilha {trackNumber}:");

        schedule.AppendLine(MorningSession.PrintSchedule());
        schedule.AppendLine("12:00H Almoço");
        schedule.AppendLine(AfternoonSession.PrintSchedule());
        schedule.AppendLine(NetworkingEventTime);

        return schedule.ToString();
    }
}