using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyline.Common.MVVM;
using Skyline.Common.Tools;
using Skyline.DataMiner.Client.Controls.DataDisplay.Table;
using Skyline.DataMiner.Client.RouterControl.Interfaces;
using Skyline.DataMiner.Client.RouterControl.ViewModel;

namespace RouterControlButtonDesigner.ViewModel
{
    public class MatrixIO : ViewModelBase
    {
        public TableRow Model { get; } = new TableRow();

        private int _index;
        public int Index
        {
            get { return _index; }
            set
            {
                if (_index != value)
                {
                    _index = value;
                    RaisePropertyChanged(nameof(Index));
                }
            }
        }

        private string _label;
        public string Label
        {
            get { return _label; }
            set
            {
                if (_label != value)
                {
                    _label = value;
                    RaisePropertyChanged(nameof(Label));
                }
            }
        }

        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set
            {
                if (_notes != value)
                {
                    _notes = value;
                    RaisePropertyChanged(nameof(Notes));
                }
            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged(nameof(Description));
                }
            }
        }

        private string _connectionsInfo;
        public string ConnectionsInfo
        {
            get { return _connectionsInfo; }
            set
            {
                if (_connectionsInfo != value)
                {
                    _connectionsInfo = value;
                    RaisePropertyChanged(nameof(ConnectionsInfo));
                }
            }
        }
                      
        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    RaisePropertyChanged(nameof(IsSelected));
                }
            }
        }

        private bool _isHighlighted;
        public bool IsHighlighted
        {
            get { return _isHighlighted; }
            set
            {
                if (_isHighlighted != value)
                {
                    _isHighlighted = value;
                    RaisePropertyChanged(nameof(IsHighlighted));
                }
            }
        }

        private bool _isLocked;
        public bool IsLocked
        {
            get { return _isLocked; }
            set
            {
                if (_isLocked != value)
                {
                    _isLocked = value;
                    RaisePropertyChanged(nameof(IsLocked));
                }
            }
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    RaisePropertyChanged(nameof(IsEnabled));
                }
            }
        }

        private bool _isConnected;
        public bool IsConnected
        {
            get { return _isConnected; }
            set
            {
                if (_isConnected != value)
                {
                    _isConnected = value;
                    RaisePropertyChanged(nameof(IsConnected));
                }
            }
        }

        private bool _isMultiConnected;
        public bool IsMultiConnected
        {
            get { return _isMultiConnected; }
            set
            {
                if (_isMultiConnected != value)
                {
                    _isMultiConnected = value;
                    RaisePropertyChanged(nameof(IsMultiConnected));
                }
            }
        }

        private IndexResolver<int, string> _cellDisplayValue;
        public IndexResolver<int, string> CellDisplayValue
        {
            get
            {
                if (_cellDisplayValue == null)
                    _cellDisplayValue = new IndexResolver<int, string>() { Resolve = index => GetRowCellValueByIndex(index)?.DisplayValue ?? String.Empty };
                return _cellDisplayValue;
            }
        }

        private IndexResolver<int, bool> _cellHasValue;
        public IndexResolver<int, bool> CellHasValue
        {
            get
            {
                if (_cellHasValue == null)
                    _cellHasValue = new IndexResolver<int, bool>() { Resolve = index => GetRowCellValueByIndex(index)?.HasValue == true };
                return _cellHasValue;
            }
        }

        private DTCell GetRowCellValueByIndex(int index)
        {
            return null;
        }
    }

    public class MatrixInput : MatrixIO
    {
    }

    public class MatrixOutput : MatrixIO
    {
    }

    public class TableRow
    {
        public List<string> Values { get; } = new List<string>();

        private IndexResolver<int, string> _cellDisplayValue;
        public IndexResolver<int, string> CellDisplayValue
        {
            get
            {
                if (_cellDisplayValue == null)
                    _cellDisplayValue = new IndexResolver<int, string>() { Resolve = index => GetRowCellValueByIndex(index) ?? String.Empty };
                return _cellDisplayValue;
            }
        }

        private IndexResolver<int, bool> _cellHasValue;
        public IndexResolver<int, bool> CellHasValue
        {
            get
            {
                if (_cellHasValue == null)
                    _cellHasValue = new IndexResolver<int, bool>() { Resolve = index => GetRowCellValueByIndex(index) != null };
                return _cellHasValue;
            }
        }

        private string GetRowCellValueByIndex(int index)
        {
            if (index < 0 || index >= Values.Count)
                return null;
            return Values[index];
        }
    }
}
