using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace QualitasDigitalSpecFlowCSharp.Extensions
{
    /// <summary>
    /// The Event Logger for the local machine
    /// </summary>
    public static class EventLogger
    {
        private static EventLog EventLog { get; set; }

        /// <summary>
        /// Gets a list of event log entries for the source specified
        /// </summary>
        /// <param name="eventType">The event log source</param>
        /// <param name="startTime">The test start time</param>
        /// <param name="endTime">The test end time</param>
        /// <returns></returns>
        public static List<EventLogEntry> GetEventLog(EventType eventType, DateTime startTime, DateTime endTime)
        {
            switch (eventType)
            {
                case EventType.Error:
                    return GetEvents(EventLogEntryType.Error, startTime, endTime);
                case EventType.Warning:
                    return GetEvents(EventLogEntryType.Warning, startTime, endTime);
                case EventType.Information:
                    return GetEvents(EventLogEntryType.Information, startTime, endTime);
                default:
                    throw new ArgumentOutOfRangeException(nameof(eventType), eventType, null);
            }
        }

        private static List<EventLogEntry> GetEvents(EventLogEntryType eventLogEntryType, DateTime startTime, DateTime endTime)
        {
            List<EventLogEntry> eventLogs = new List<EventLogEntry>();

            if (EventLog == null)
            {
                EventLog = new EventLog("Application");

                foreach (EventLogEntry eventLogEntry in EventLog.Entries)
                {
                    if (eventLogEntry.TimeGenerated >= startTime && eventLogEntry.TimeGenerated <= endTime)
                    {
                        eventLogs.Add(eventLogEntry);
                    }
                }
            }

            return eventLogs.Where(x => x.EntryType == eventLogEntryType).ToList();
        }
    }
}
