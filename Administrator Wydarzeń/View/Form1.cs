using Administrator_Wydarzeń.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Administrator_Wydarzeń.View
{
    public partial class Form1 : Form, IEventView
    {
        public Form1()
        {
            InitializeComponent();
            _associateAndRaiseViewEvents();
        }

        // właściwości
        public string Title { get => titleBox.Text; set => titleBox.Text = value;}
        public string Description { get => descriptionRichTextBox.Text; set => descriptionRichTextBox.Text = value;}
        public string Date { get => dateTimePicker1.Text; set => dateTimePicker1.Text = value;}
        public List<string> Type { get => GetAllSelectedTypes(typeCheckedListBox); set => SetAllSelectedTypes(value);}
        public string Priority { get => priorityComboBox.Text; set => priorityComboBox.Text = value; }
        public DataGridView DataGridView { get => dataGridViewEvents; }
        public string SortType { get => sortComboBox.Text; set => sortComboBox.Text = value; }
        public string FilterType { get => filtercomboBox.Text; set => filtercomboBox.Text = value; } 
        public string ElementFilterType { get => elementsFilterComboBox.Text; set => elementsFilterComboBox.Text = value; }

        private List<string> GetAllSelectedTypes(CheckedListBox checkedListBox)
        {
            List<string> selectedTypes = new List<string>();

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    selectedTypes.Add(checkedListBox.Items[i].ToString());
                }
            }

            return selectedTypes;
        }

        private void SetAllSelectedTypes(List<string> selectedTypes)
        {
            for (int i = 0; i < typeCheckedListBox.Items.Count; i++)
            {
                typeCheckedListBox.SetItemChecked(i, selectedTypes.Contains(typeCheckedListBox.Items[i].ToString()));
            }
        }

        // zdarzenia 
        public event EventHandler AddNewEvent;
        public event EventHandler RemoveEvent;
        public event EventHandler LoadEvents;
        public event EventHandler SaveEvents;
        public event EventHandler ShowEvent;
        public event EventHandler SortEvents;
        public event EventHandler FilterEvents;

        // metody
        public void SetEventListBindingSourse(BindingSource eventList)
        {
            dataGridViewEvents.DataSource = eventList;
        }

        private void _associateAndRaiseViewEvents()
        {
            addButton.Click += (sender, e) => AddNewEvent?.Invoke(this, EventArgs.Empty);
            deletebutton.Click += (sender, e) => RemoveEvent?.Invoke(this, EventArgs.Empty);
            loadButton.Click += (sender, e) => LoadEvents?.Invoke(this, EventArgs.Empty);
            saveButton.Click += (sender, e) => SaveEvents?.Invoke(this, EventArgs.Empty);
            DataGridView.CellClick += (sender, e) => ShowEvent?.Invoke(this, EventArgs.Empty);
            sortButton.Click += (sender, e) => SortEvents?.Invoke(this, EventArgs.Empty);
            filterButton.Click += (sender, e) => FilterEvents?.Invoke(this, EventArgs.Empty);
            filtercomboBox.SelectedIndexChanged += FilterComboBoxSelectedIndexChanged;
        }

        private void FilterComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filtercomboBox.SelectedItem as string)
            {
                case "typ":
                    elementsFilterComboBox.Items.Clear();
                    elementsFilterComboBox.Items.AddRange(new object[] { "rodzina", "praca", "rozrywka", "zdrowie", "sport" });
                    break;
                case "priorytet":
                    elementsFilterComboBox.Items.Clear();
                    elementsFilterComboBox.Items.AddRange(new object[] { "niski", "średni", "wysoki" });
                    break;
                case "data":
                    elementsFilterComboBox.Items.Clear();
                    elementsFilterComboBox.Items.AddRange(new object[] { "styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec", "lipiec", "sierpień", "wrzesień", "październik", "listopad", "grudzień", });
                    break;
                default:
                    elementsFilterComboBox.Items.Clear();
                    break;
            }

            elementsFilterComboBox.Enabled = true;
        }
    }
}

