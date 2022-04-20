using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2_03_30_2022.Models
{
    internal class MeetingSchedule
    {
        List<Meeting> _meetingList;

        public void SetMeeting(string name, DateTime from, DateTime to)
        {
            Meeting meeting = _meetingList.Find(e => e.FromDate <= from && e.ToDate <= to);
            if (meeting != null)
            {
                _meetingList.Add(meeting);
            }
            throw new NullReferenceException();
        }
        public int FindMeetingsCount(DateTime dt)
        {
            List<Meeting> meetings = _meetingList.FindAll(e => dt < e.FromDate);
            return meetings.Count;
        }
        public bool FindMeetings(Predicate<Meeting> predicate)
        {
            Meeting meeting = _meetingList.Find(predicate);
            if (meeting == null)
                return false;
            return true;
        }

        public bool ExistMeetingsByName(string name)
        {
            List<Meeting> meeting = _meetingList.FindAll(e => e.Name == name);
            if (meeting != null)
                return true;
            return false;
        }
        public bool ExistMeetings(Predicate<Meeting> predicate)
        {
            Meeting meetings = _meetingList.Find(predicate);
            if (meetings != null)
                return true;
            return false;
        }
    }
}
