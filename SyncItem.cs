using System.Collections.Generic;
using ViewsAndSheetsSync.UI;

namespace ViewsAndSheetsSync
{
    /// <summary>
    /// Defines whether the application is currently operating on Views or Sheets.
    /// This helps the universal SyncItem class and services know how to interpret the data.
    /// </summary>
    public enum SyncMode { Views, Sheets }

    /// <summary>
    /// Represents the state of an item when comparing the Revit model with the external data source.
    /// </summary>
    public enum SyncStatus { New, Update, Remove, Unchanged }

    /// <summary>
    /// A universal data model to represent a single, syncable item in the UI's DataGrid.
    /// This class is designed to flexibly hold data for either a View or a Sheet,
    /// simplifying the overall data management and UI binding logic.
    /// </summary>
    public class SyncItem : INotifyPropertyChangedBase
    {
        private bool _isSelected = true;

        /// <summary>
        /// Gets or sets whether this item is selected in the UI for an operation (e.g., Apply Changes).
        /// Bound to the checkbox in the DataGrid.
        /// </summary>
        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        /// <summary>
        /// The synchronization status of the item (New, Update, or Remove).
        /// This is displayed in the "Status" column of the DataGrid.
        /// </summary>
        public SyncStatus Status { get; set; }

        /// <summary>
        /// The mode (Views or Sheets) this item belongs to. This is used internally
        /// by services to know how to create, update, or delete the element.
        /// </summary>
        public SyncMode Mode { get; }

        /// <summary>
        /// The primary key used for matching this item between Revit and the external file.
        /// This value is read-only in the UI.
        /// For Views, this is the Original View Name.
        /// For Sheets, this is the Original Sheet Number.
        /// </summary>
        public string Key { get; }

        #region --- Generic Properties ---
        // These properties are given generic names so the same class can be used for both Views and Sheets.
        // Their headers in the DataGrid are set dynamically in the window's code-behind.

        public string Property1 { get; set; }

        public string Property2 { get; set; }

        public string Info1 { get; }

        public string Info2 { get; }
        #endregion

        #region --- Custom Parameters ---

        /// <summary>
        /// A user-friendly, read-only summary of all custom parameter values for display in a single DataGrid column.
        /// </summary>
        public string ParametersSummary { get; set; }

        /// <summary>
        /// The actual dictionary holding the names and values of custom parameters for backend processing.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();
        #endregion

        /// <summary>
        /// Initializes a new instance of the SyncItem class.
        /// </summary>
        /// <param name="key">The primary key for matching (original name or number).</param>
        /// <param name="mode">The mode of the item (Views or Sheets).</param>
        /// <param name="status">The initial synchronization status.</param>
        /// <param name="info1">Value for the first informational property (e.g., View Type).</param>
        /// <param name="info2">Value for the second informational property (e.g., Level).</param>
        public SyncItem(string key, SyncMode mode, SyncStatus status, string info1 = "", string info2 = "")
        {
            Key = key;
            Mode = mode;
            Status = status;
            Info1 = info1;
            Info2 = info2;
            Property1 = key;
        }
    }
}