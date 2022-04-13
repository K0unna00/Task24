using System;
using System.Collections.Generic;
using System.Text;

namespace Task24
{
    internal class MeetingSchedule
    {
        public List<Meeting> meetings = new List<Meeting>();
        public void SetMeeting(string fullName, DateTime from, DateTime to)
        {
            Meeting meeting = new Meeting();
            int count = 0;
            foreach (var item in meetings)
            {
                if (item.FromDate > from || item.ToDate < to) count++;
            }
            if(count == meetings.Count)
            {
                meeting.ToDate = to;
                meeting.Name = fullName;
                meeting.FromDate = from;
                meetings.Add(meeting);
            }
        }
        public int FindMeetingCount(DateTime dT)
        {   
            int count = 0;
            foreach (var item in meetings)
            {
                if (item.FromDate > dT) count++;
            }
            return count;
        }
        public bool IsExistsMeetingByName(string name)
        {
            foreach (var item in meetings)
            {
                if(item.Name == name) return true;
            }
            return false;
        }
        public List<Meeting> GetExistsMeetins(string name)
        {
            List<Meeting> newMeetins = new List<Meeting>();
            foreach (var item in meetings)
            {
                if (item.Name.Contains(name)) newMeetins.Add(item);
            }
            return newMeetins;
        }
    }
}
