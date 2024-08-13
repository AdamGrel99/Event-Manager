using Administrator_Wydarzeń.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator_Wydarzeń.View
{
    public interface IEventView
    {
        // Właściwości
        string Title { get; set; }
        string Description { get; set; }
        string Date { get; set; }
        List<string> Type { get; set; }
        string Priority { get; set; }
        DataGridView DataGridView { get; }
        string SortType { get; set; }
        string FilterType { get; set; }
        string ElementFilterType { get; set; }

        // Zdarzenia 
        event EventHandler AddNewEvent;
        event EventHandler RemoveEvent;
        event EventHandler SaveEvents;
        event EventHandler LoadEvents;
        event EventHandler ShowEvent;
        event EventHandler SortEvents;
        event EventHandler FilterEvents;

        // Metody
        void SetEventListBindingSourse(BindingSource eventList);
    }
}
