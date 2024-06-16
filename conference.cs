using System.Collections.Generic;

public class Conference
{
    public List<Track> Tracks { get; private set; }

    public Conference()
    {
        Tracks = new List<Track>();
    }

    public void AddTrack(Track track)
    {
        Tracks.Add(track);
    }

    public string PrintSchedule()
    {
        var schedule = new System.Text.StringBuilder();
        int trackNumber = 1;

        foreach (var track in Tracks)
        {
            schedule.AppendLine(track.PrintSchedule(trackNumber));
            trackNumber++;
        }

        return schedule.ToString();
    }
}