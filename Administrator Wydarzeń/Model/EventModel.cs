using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administrator_Wydarzeń.Repository;

namespace Administrator_Wydarzeń.Model
{
    public class EventModel : IEventModel
    {
        private List<Event> events = new List<Event>();
        private bool isLoadEventsFromDatabase = true;
        private List<Event> sortedEvents = new List<Event>();
        private List<Event> filteredEvents = new List<Event>();

        public EventModel(){}

        public IEnumerable<Event> GetAll()
        {
            var eventList = new List<Event>();

            foreach (var e in events)
            {
                eventList.Add(e);
            }

            return eventList;
        }

        public void Add(Event e) 
        {
            events.Add(e);
        }

        public void Remove(int e)
        {
            events.RemoveAt(e);
        }

        public IEnumerable<Event> Sort(string sortType)
        {
            if (sortType == "typ")
            {
                return events.OrderBy(e => e.Type).ToList();
            }
            else if(sortType == "priorytet")
            {
                return events.OrderBy(e => GetPriorityValue(e.Priority)).ToList();
            }
            else if (sortType == "data")
            {
                return events.OrderBy(e => DateTime.Parse(e.Date)).ToList();
            }
            return events;
        }

        public IEnumerable<Event> Filter(string filterType, string elementFilterType)
        {
            if(filterType == "typ")
            {   
                return events.Where(e => e.Type.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Contains(elementFilterType)).ToList();
            }
            else if(filterType == "priorytet")
            {
                return events.Where(e => e.Priority.Equals(elementFilterType, StringComparison.OrdinalIgnoreCase));
            }
            else if(filterType == "data")
            {
                int monthNumber = 0;
                if (!string.IsNullOrEmpty(elementFilterType) && monthNameToNumber.TryGetValue(elementFilterType, out int result))
                {
                    monthNumber = result;
                }

                return events.Where(e => monthNumber == 0 || DateTime.ParseExact(e.Date, "dd.MM.yyyy", CultureInfo.InvariantCulture).Month == monthNumber);
            }
            return events;
        }

        private static Dictionary<string, int> monthNameToNumber = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "styczeń", 1 },
            { "luty", 2 },
            { "marzec", 3 },
            { "kwiecień", 4 },
            { "maj", 5 },
            { "czerwiec", 6 },
            { "lipiec", 7 },
            { "sierpień", 8 },
            { "wrzesień", 9 },
            { "październik", 10 },
            { "listopad", 11 },
            { "grudzień", 12 }
        };

        private int GetPriorityValue(string priority)
        {
            switch (priority.ToLower())
            {
                case "niski":
                    return 3;
                case "średni":
                    return 2;
                case "wysoki":
                    return 1;
                default:
                    return 0;
            }
        }

        public void SaveToDatabase()
        {
            if (events.Count > 0) 
            {
                string currentDirectory = Environment.CurrentDirectory;
                string filePath = Path.Combine(currentDirectory, "baza.xml");
                string[,] array = new string[events.Count, 5];

                for (int i = 0; i < events.Count; i++)
                {
                    array[i, 0] = events[i].Title;
                    array[i, 1] = events[i].Description;
                    array[i, 2] = events[i].Date;
                    array[i, 3] = events[i].Type;
                    array[i, 4] = events[i].Priority;
                }

                XML.SaveToXml(array, filePath);
            }  
        }

        public void LoadFromDatabase()
        {
            if(isLoadEventsFromDatabase)
            {
                isLoadEventsFromDatabase = false;
                string currentDirectory = Environment.CurrentDirectory;
                string filePath = Path.Combine(currentDirectory, "baza.xml");
                string[,] array = XML.LoadFromXml(filePath);

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    string name = array[i, 0];
                    string description = array[i, 1];
                    string date = array[i, 2];
                    string tags = array[i, 3];
                    string priority = array[i, 4];

                    events.Add(new Event(name, description, date, tags, priority));
                }
            } 
        }

        public bool ifAllBracketsAreFill(string title, string description, string date, string priority, List<string> type)
        {
            return !string.IsNullOrEmpty(title) &&
                   !string.IsNullOrEmpty(description) &&
                   !string.IsNullOrEmpty(date) &&
                   !string.IsNullOrEmpty(priority) &&
                   type.Any();
        }
    }
}
