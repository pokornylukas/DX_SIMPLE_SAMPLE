namespace Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.MainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.EditButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ExportToXslButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.RefreshDataButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.FillDatabaseButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.personBindingSource = new System.Windows.Forms.BindingSource();
            this.MainGridControl = new DevExpress.XtraGrid.GridControl();
            this.MainGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeleteRowButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.DataLoadingProgressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRowButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MainRibbonControl
            // 
            this.MainRibbonControl.ExpandCollapseItem.Id = 0;
            this.MainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MainRibbonControl.ExpandCollapseItem,
            this.EditButtonItem,
            this.DeleteButtonItem,
            this.ExportToXslButtonItem,
            this.RefreshDataButtonItem,
            this.FillDatabaseButtonItem});
            this.MainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.MainRibbonControl.MaxItemId = 6;
            this.MainRibbonControl.Name = "MainRibbonControl";
            this.MainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.MainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.MainRibbonControl.Size = new System.Drawing.Size(758, 144);
            // 
            // EditButtonItem
            // 
            this.EditButtonItem.Caption = "Edit";
            this.EditButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("EditButtonItem.Glyph")));
            this.EditButtonItem.Id = 1;
            this.EditButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("EditButtonItem.LargeGlyph")));
            this.EditButtonItem.Name = "EditButtonItem";
            this.EditButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditButtonItem_ItemClick);
            // 
            // DeleteButtonItem
            // 
            this.DeleteButtonItem.Caption = "Delete";
            this.DeleteButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("DeleteButtonItem.Glyph")));
            this.DeleteButtonItem.Id = 2;
            this.DeleteButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("DeleteButtonItem.LargeGlyph")));
            this.DeleteButtonItem.Name = "DeleteButtonItem";
            this.DeleteButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteButtonItem_ItemClick);
            // 
            // ExportToXslButtonItem
            // 
            this.ExportToXslButtonItem.Caption = "Export to XSL";
            this.ExportToXslButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ExportToXslButtonItem.Glyph")));
            this.ExportToXslButtonItem.Id = 3;
            this.ExportToXslButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ExportToXslButtonItem.LargeGlyph")));
            this.ExportToXslButtonItem.Name = "ExportToXslButtonItem";
            this.ExportToXslButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExportToXslButtonItem_ItemClick);
            // 
            // RefreshDataButtonItem
            // 
            this.RefreshDataButtonItem.Caption = "Refresh Data";
            this.RefreshDataButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("RefreshDataButtonItem.Glyph")));
            this.RefreshDataButtonItem.Id = 4;
            this.RefreshDataButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("RefreshDataButtonItem.LargeGlyph")));
            this.RefreshDataButtonItem.Name = "RefreshDataButtonItem";
            this.RefreshDataButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // FillDatabaseButtonItem
            // 
            this.FillDatabaseButtonItem.Caption = "Fill Database With 10000 Records";
            this.FillDatabaseButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("FillDatabaseButtonItem.Glyph")));
            this.FillDatabaseButtonItem.Id = 5;
            this.FillDatabaseButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("FillDatabaseButtonItem.LargeGlyph")));
            this.FillDatabaseButtonItem.Name = "FillDatabaseButtonItem";
            this.FillDatabaseButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FillDatabaseButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Persons";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.EditButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.DeleteButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Item";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.ExportToXslButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.RefreshDataButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.FillDatabaseButtonItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Actions";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Client.PersonsReference.Person);
            // 
            // MainGridControl
            // 
            this.MainGridControl.DataSource = this.personBindingSource;
            this.MainGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGridControl.Location = new System.Drawing.Point(0, 144);
            this.MainGridControl.MainView = this.MainGridView;
            this.MainGridControl.MenuManager = this.MainRibbonControl;
            this.MainGridControl.Name = "MainGridControl";
            this.MainGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DeleteRowButton});
            this.MainGridControl.Size = new System.Drawing.Size(758, 216);
            this.MainGridControl.TabIndex = 3;
            this.MainGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainGridView});
            this.MainGridControl.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.MainGridControl_ProcessGridKey);
            // 
            // MainGridView
            // 
            this.MainGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBirthDate,
            this.colFirstName,
            this.colLastName});
            this.MainGridView.GridControl = this.MainGridControl;
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.MainGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.MainGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.MainGridView.OptionsView.ShowGroupPanel = false;
            this.MainGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.MainGridView_RowUpdated);
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 2;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsEditForm.StartNewRow = true;
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsEditForm.StartNewRow = true;
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 0;
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.AutoHeight = false;
            this.DeleteRowButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("DeleteRowButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.DeleteRowButton.Name = "DeleteRowButton";
            // 
            // DataLoadingProgressPanel
            // 
            this.DataLoadingProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.DataLoadingProgressPanel.Appearance.Options.UseBackColor = true;
            this.DataLoadingProgressPanel.Appearance.Options.UseTextOptions = true;
            this.DataLoadingProgressPanel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DataLoadingProgressPanel.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DataLoadingProgressPanel.AppearanceCaption.Options.UseFont = true;
            this.DataLoadingProgressPanel.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DataLoadingProgressPanel.AppearanceDescription.Options.UseFont = true;
            this.DataLoadingProgressPanel.Description = "Loading data from DB ...";
            this.DataLoadingProgressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataLoadingProgressPanel.Location = new System.Drawing.Point(0, 144);
            this.DataLoadingProgressPanel.Name = "DataLoadingProgressPanel";
            this.DataLoadingProgressPanel.Size = new System.Drawing.Size(758, 216);
            this.DataLoadingProgressPanel.TabIndex = 5;
            this.DataLoadingProgressPanel.Text = "progressPanel1";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.DataLoadingProgressPanel);
            this.Controls.Add(this.MainGridControl);
            this.Controls.Add(this.MainRibbonControl);
            this.Name = "MainForm";
            this.Ribbon = this.MainRibbonControl;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRowButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl MainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem EditButtonItem;
        private DevExpress.XtraBars.BarButtonItem DeleteButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource personBindingSource;
        private DevExpress.XtraGrid.GridControl MainGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView MainGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraBars.BarButtonItem ExportToXslButtonItem;
        private DevExpress.XtraWaitForm.ProgressPanel DataLoadingProgressPanel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit DeleteRowButton;
        private DevExpress.XtraBars.BarButtonItem RefreshDataButtonItem;
        private DevExpress.XtraBars.BarButtonItem FillDatabaseButtonItem;
    }
}

