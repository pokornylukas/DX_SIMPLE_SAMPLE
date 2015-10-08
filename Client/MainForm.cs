using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
              
        /// <summary>
        /// Load data from DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                MainRibbonControl.Enabled = false;
                DataLoadingProgressPanel.Visible = true;
                using (PersonsReference.PersonsServiceClient client = new PersonsReference.PersonsServiceClient())
                {
                    personBindingSource.DataSource = (await client.GetPersonsAsync()).ToList();
                    MainGridControl.RefreshDataSource();
                }
                MainRibbonControl.Enabled = true;
                DataLoadingProgressPanel.Visible = false;
                RefreshDataButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            catch
            {
                ShowErrorMessage(Properties.Resources.DataLoadingError);
                RefreshDataButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                MainRibbonControl.Enabled = true;
            }
        }

        /// <summary>
        /// Save updated person into DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                using (PersonsReference.PersonsServiceClient client = new PersonsReference.PersonsServiceClient())
                {
                    ShowErrorMessage((await client.UpdatePersonAsync((PersonsReference.Person)e.Row)).Result); 
                    #warning ToDo: Add here code for reutrn original values to modified person object
                }
            }
            catch
            {
                this.ShowErrorMessage(Properties.Resources.OtherErrorMessage);
            }
        }

        /// <summary>
        /// Alternative call of edit dialog from ribbon menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] rows = MainGridView.GetSelectedRows();
            if (rows.Count() > 0)
            {
                MainGridView.ShowEditForm();
            }
        }

        /// <summary>
        /// Export GridView content to XLS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportToXslButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "xls";
                sfd.Filter = "Excel sheet (*.xls)|*.xls";
                sfd.InitialDirectory = System.Environment.SpecialFolder.MyDocuments.ToString();
                DialogResult result = sfd.ShowDialog();
                if (sfd != null && result == DialogResult.OK && sfd.FileName != null && sfd.FileName != string.Empty)
                {
                    MainGridView.ExportToXls(sfd.FileName);
                }
            }
            catch
            {
                ShowErrorMessage(Properties.Resources.ErrorDuringSavingXls);
            }
        }
        
        /// <summary>
        /// Performs delete of row by press Delete Key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainGridControl_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Delete)
            {
                DeleteSelectedPersonsFromDataGrid();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Performs row deleting by click on button in Ribbon menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteSelectedPersonsFromDataGrid();
        }

        /// <summary>
        /// DX doesn't support onRowDeleted event, so I have to reduce code redundancy by this way.
        /// </summary>
        /// <returns></returns>
        private async void DeleteSelectedPersonsFromDataGrid()
        {
            try
            {
                using (PersonsReference.PersonsServiceClient client = new PersonsReference.PersonsServiceClient())
                {
                    foreach (int rowNr in MainGridView.GetSelectedRows())
                    {
                        PersonsReference.Person person = MainGridView.GetRow(rowNr) as PersonsReference.Person;                        
                        ShowErrorMessage((await client.DeletePersonAsync(person)).Result);                        
                    }
                }
                MainGridView.DeleteSelectedRows();
            }
            catch
            {
                this.ShowErrorMessage(Properties.Resources.OtherErrorMessage);
            }
        }

        private void ShowErrorMessage(PersonsReference.DataModificationResult.Results result)
        { 
            switch(result)
            {
                case PersonsReference.DataModificationResult.Results.OptimisticConcurrencyException:
                        this.ShowErrorMessage(Properties.Resources.ConflictMessage);
                        this.MainForm_Load(null, null);
                    break;
                case PersonsReference.DataModificationResult.Results.GeneralException:
                    break;
            }
        }

        private void ShowErrorMessage(string messageText)
        {
            MessageBox.Show(messageText, Properties.Resources.ErrorMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void FillDatabaseButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataLoadingProgressPanel.Description = "Inserting data into DB ...";
                DataLoadingProgressPanel.Visible = true;
                using (PersonsReference.PersonsServiceClient client = new PersonsReference.PersonsServiceClient())
                {
                    await client.BulkInsert10000RecordsAsync();
                }                
            }
            catch
            {
                this.ShowErrorMessage(Properties.Resources.OtherErrorMessage);
            }
            finally
            {
                DataLoadingProgressPanel.Visible = false;
                DataLoadingProgressPanel.Description = "Loading data from DB ...";
                MainForm_Load(null, null);
            }
        }
    }
}
