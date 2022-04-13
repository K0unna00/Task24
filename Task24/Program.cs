using System;

namespace Task24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting2 = new Meeting()
            {
            FromDate = DateTime.Parse("5.10.2020"),
            ToDate = DateTime.Parse("7.10.2020"),
            Name = "salam"
            }; 
            MeetingSchedule meetingSchedule = new MeetingSchedule();
            meetingSchedule.meetings.Add(meeting2);
            meetingSchedule.SetMeeting("Atakisiyev Bextiyar" , DateTime.Parse("1.14.2022") , DateTime.Parse("3.10.2022"));
            meetingSchedule.SetMeeting("salam Bextiyar" , DateTime.Parse("5.10.2022") , DateTime.Parse("7.10.2022"));
            meetingSchedule.SetMeeting("sagol hikmet" , DateTime.Parse("9.10.2022") , DateTime.Parse("11.10.2022"));
            meetingSchedule.SetMeeting("salam hikmet" , DateTime.Parse("10.10.2022") , DateTime.Parse("10.7.2022"));
            foreach (var item in meetingSchedule.meetings)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(meetingSchedule.FindMeetingCount(DateTime.Parse("1.10.2022")));
        }
    }
}
