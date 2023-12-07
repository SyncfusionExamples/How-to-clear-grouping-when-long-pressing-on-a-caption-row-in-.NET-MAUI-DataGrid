using Syncfusion.Maui.Data;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SfDataGrid_CellLongPress(object sender, DataGridCellLongPressEventArgs e)
        {
            if (e.RowData is Group)
                datagrid.GroupColumnDescriptions.Clear();
        }
    }
}
