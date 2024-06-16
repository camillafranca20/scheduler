using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var talks = new List<Talk>
        {
            new Talk("Writing Fast Tests Against Enterprise .Net", 60),
            new Talk("Overdoing it in Python", 45),
            new Talk("Lua for the Masses", 30),
            new Talk(".Net Errors from Mismatched Nuget Versions", 45),
            new Talk("Common .Net Errors", 45),
            new Talk("Python for .Net Developers", 5),
            new Talk("Communicating Over Distance", 60),
            new Talk("Accounting-Driven Development", 45),
            new Talk("Woah", 30),
            new Talk("Sit Down and Write", 30),
            new Talk("Pair Programming vs Noise", 45),
            new Talk(".Net Magic", 60),
            new Talk(".Net Core: Why We Should Move On", 60),
            new Talk("Clojure Ate Scala (on my project)", 45),
            new Talk("Programming in the Boondocks of Seattle", 30),
            new Talk(".Net vs. Clojure for Back-End Development", 30),
            new Talk(".Net Core Legacy App Maintenance", 60),
            new Talk("A World Without HackerNews", 30),
            new Talk("User Interface CSS in .Net Apps", 30)
        };

        var scheduler = new Scheduler();
        var conference = scheduler.ScheduleConference(talks);

        Console.WriteLine(conference.PrintSchedule());
    }
}
