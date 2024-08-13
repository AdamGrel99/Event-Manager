using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator_Wydarzeń.Model
{
    public interface IEventModel
    {
        void Add(Event e);
        void Remove(int e);
        void SaveToDatabase();
        void LoadFromDatabase();
        IEnumerable<Event> Sort(string sortType);
        IEnumerable<Event> Filter(string filterType, string elementFilterType);
        IEnumerable<Event> GetAll();
        bool ifAllBracketsAreFill(string title, string description, string date, string priority, List<string> type);
    }
}
