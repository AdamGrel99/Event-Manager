using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator_Wydarzeń.Presenter
{
    public class MainPresenter
    {
        private Model.IEventModel _model;
        private View.IEventView _view;
        private BindingSource _eventBindingSource;
        private IEnumerable<Model.Event> _eventList;

        public MainPresenter(View.IEventView view, Model.EventModel model)
        {
            _view = view;
            _model = model;
            _eventBindingSource = new BindingSource();

            _view.AddNewEvent += AddEvent;
            _view.RemoveEvent += RemoveEvent;
            _view.LoadEvents += LoadEvent;
            _view.SaveEvents += SaveEvent;
            _view.SortEvents += SortEvent;
            _view.FilterEvents += FilterEvent;
            _view.DataGridView.CellClick += dataGridView1_CellClick;
            _view.SetEventListBindingSourse(_eventBindingSource);
        }

        private void LoadAllEvents()
        {
            _eventList = _model.GetAll();
            _eventBindingSource.DataSource = _eventList;
        }

        private void AddEvent(object sender, EventArgs e)
        {
            if (_model.ifAllBracketsAreFill(_view.Title, _view.Description, _view.Date, _view.Priority, _view.Type))
            {
                var newEvent = new Model.Event(_view.Title, _view.Description, _view.Date, string.Join(", ", _view.Type), _view.Priority);

                _model.Add(newEvent);
                LoadAllEvents();

                ClearAll();
            }
            else
            {
                MessageBox.Show("Wszystkie pola musisz uzupełnić", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveEvent(object sender, EventArgs e)
        {
            Int32 selectedRowCount = _view.DataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    var index = _view.DataGridView.SelectedRows[i].Index;
                    _model.Remove(index);
                }
                LoadAllEvents();
            }
        }

        private void LoadEvent(object sender, EventArgs e)
        {
            _model.LoadFromDatabase();
            LoadAllEvents();
        }

        private void SaveEvent(object sender, EventArgs e)
        {
            _model.SaveToDatabase();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sprawdzamy, czy kliknięto na komórkę,a nie na np nagłówek kolumny
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = _view.DataGridView.Rows[e.RowIndex];
                List<string> list = new List<string>();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    list.Add(cell.Value?.ToString());
                }

                _view.Title = list[0];
                _view.Description = list[1];
                _view.Date = list[2];
                _view.Priority = list[4];
                _view.Type = list[3].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(item => item.Trim())
                                    .ToList();
            }
        }

        private void SortEvent(object sender, EventArgs e)
        {
            _eventList = _model.Sort(_view.SortType);
            _eventBindingSource.DataSource = _eventList;
        }

        private void FilterEvent(object sender, EventArgs e)
        {
            _eventList = _model.Filter(_view.FilterType, _view.ElementFilterType);
            _eventBindingSource.DataSource = _eventList;
        }

        private void ClearAll()
        {
            _view.Title = string.Empty;
            _view.Description = string.Empty;
            _view.Date = string.Empty;
            _view.Priority = string.Empty;
            _view.Type = new List<string>();
        }
    }
}
