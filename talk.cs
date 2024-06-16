public class Talk
{
    public string Title { get; set; }
    public int Duration { get; set; } // Duration in minutes

    public Talk(string title, int duration)
    {
        Title = title;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"{Title} {Duration}min";
    }
}