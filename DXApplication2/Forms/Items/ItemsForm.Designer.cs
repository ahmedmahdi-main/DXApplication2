namespace DXApplication2.Forms.Items
{
    partial class ItemsForm
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
            components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            userBindingSource = new System.Windows.Forms.BindingSource(components);
            itemBindingSource = new System.Windows.Forms.BindingSource(components);
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colULID = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colType = new DevExpress.XtraGrid.Columns.GridColumn();
            colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            colCondition = new DevExpress.XtraGrid.Columns.GridColumn();
            colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            colPurchaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            Price = new DevExpress.XtraGrid.Columns.GridColumn();
            NumericTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            StockEntryNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            StockEntryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            btnFirst = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            btnLast = new DevExpress.XtraBars.BarButtonItem();
            btnPrevious = new DevExpress.XtraBars.BarButtonItem();
            btnNext = new DevExpress.XtraBars.BarButtonItem();
            lblCurrentIndex = new DevExpress.XtraBars.BarStaticItem();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Entities.User);
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Entities.Item);
            // 
            // gridControl1
            // 
            gridControl1.DataSource = itemBindingSource;
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            gridControl1.Location = new System.Drawing.Point(0, 114);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonEdit1, NumericTextEdit });
            gridControl1.Size = new System.Drawing.Size(1315, 567);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colULID, colName, colType, colSerialNumber, colStatus, colCondition, colBrand, colModel, colPurchaseDate, colNotes, colId, gridColumn1, gridColumn2, Price, StockEntryNumber, StockEntryDate });
            gridView1.DetailHeight = 349;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colULID
            // 
            colULID.FieldName = "Ulid";
            colULID.MinWidth = 24;
            colULID.Name = "colULID";
            colULID.Width = 95;
            // 
            // colName
            // 
            colName.Caption = "اسم المادة";
            colName.FieldName = "Name";
            colName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            colName.MinWidth = 24;
            colName.Name = "colName";
            colName.OptionsColumn.AllowEdit = false;
            colName.OptionsColumn.AllowFocus = false;
            colName.Visible = true;
            colName.VisibleIndex = 1;
            colName.Width = 288;
            // 
            // colType
            // 
            colType.Caption = "النوع";
            colType.FieldName = "Type";
            colType.MinWidth = 24;
            colType.Name = "colType";
            colType.OptionsColumn.AllowEdit = false;
            colType.OptionsColumn.AllowFocus = false;
            colType.Visible = true;
            colType.VisibleIndex = 4;
            colType.Width = 150;
            // 
            // colSerialNumber
            // 
            colSerialNumber.Caption = "السريال";
            colSerialNumber.FieldName = "SerialNumber";
            colSerialNumber.MinWidth = 24;
            colSerialNumber.Name = "colSerialNumber";
            colSerialNumber.OptionsColumn.AllowEdit = false;
            colSerialNumber.OptionsColumn.AllowFocus = false;
            colSerialNumber.Visible = true;
            colSerialNumber.VisibleIndex = 6;
            colSerialNumber.Width = 158;
            // 
            // colStatus
            // 
            colStatus.Caption = "الوضع الحالي";
            colStatus.FieldName = "Status";
            colStatus.MinWidth = 24;
            colStatus.Name = "colStatus";
            colStatus.OptionsColumn.AllowEdit = false;
            colStatus.OptionsColumn.AllowFocus = false;
            colStatus.Width = 191;
            // 
            // colCondition
            // 
            colCondition.Caption = "الحالة";
            colCondition.FieldName = "Condition";
            colCondition.MinWidth = 24;
            colCondition.Name = "colCondition";
            colCondition.OptionsColumn.AllowEdit = false;
            colCondition.OptionsColumn.AllowFocus = false;
            colCondition.Visible = true;
            colCondition.VisibleIndex = 10;
            colCondition.Width = 163;
            // 
            // colBrand
            // 
            colBrand.Caption = "اسم الجهة المجهزة";
            colBrand.FieldName = "Brand";
            colBrand.MinWidth = 24;
            colBrand.Name = "colBrand";
            colBrand.OptionsColumn.AllowEdit = false;
            colBrand.OptionsColumn.AllowFocus = false;
            colBrand.Visible = true;
            colBrand.VisibleIndex = 9;
            colBrand.Width = 206;
            // 
            // colModel
            // 
            colModel.Caption = "الموديل";
            colModel.FieldName = "Model";
            colModel.MinWidth = 24;
            colModel.Name = "colModel";
            colModel.OptionsColumn.AllowEdit = false;
            colModel.OptionsColumn.AllowFocus = false;
            colModel.Visible = true;
            colModel.VisibleIndex = 11;
            colModel.Width = 119;
            // 
            // colPurchaseDate
            // 
            colPurchaseDate.Caption = "تاريخ التجهيز";
            colPurchaseDate.FieldName = "PurchaseDate";
            colPurchaseDate.MinWidth = 24;
            colPurchaseDate.Name = "colPurchaseDate";
            colPurchaseDate.OptionsColumn.AllowEdit = false;
            colPurchaseDate.OptionsColumn.AllowFocus = false;
            colPurchaseDate.Visible = true;
            colPurchaseDate.VisibleIndex = 8;
            colPurchaseDate.Width = 167;
            // 
            // colNotes
            // 
            colNotes.Caption = "ملاحظات";
            colNotes.FieldName = "Notes";
            colNotes.MinWidth = 24;
            colNotes.Name = "colNotes";
            colNotes.OptionsColumn.AllowEdit = false;
            colNotes.OptionsColumn.AllowFocus = false;
            colNotes.Visible = true;
            colNotes.VisibleIndex = 12;
            colNotes.Width = 390;
            // 
            // colId
            // 
            colId.Caption = "ت";
            colId.FieldName = "Id";
            colId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            colId.MinWidth = 24;
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            colId.OptionsColumn.AllowFocus = false;
            colId.Visible = true;
            colId.VisibleIndex = 0;
            colId.Width = 59;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "رقم التجهيز";
            gridColumn1.FieldName = "PurchaseNumber";
            gridColumn1.MinWidth = 24;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.OptionsColumn.AllowEdit = false;
            gridColumn1.OptionsColumn.AllowFocus = false;
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 7;
            gridColumn1.Width = 195;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "#";
            gridColumn2.ColumnEdit = repositoryItemButtonEdit1;
            gridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            gridColumn2.MinWidth = 24;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 13;
            gridColumn2.Width = 100;
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = Properties.Resources.Edit;
            editorButtonImageOptions2.SvgImage = Properties.Resources.Delete1;
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "btn_edit", null, DevExpress.Utils.ToolTipAnchor.Default), new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", "btn_delete", null, DevExpress.Utils.ToolTipAnchor.Default) });
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit1.ButtonClick += repositoryItemButtonEdit1_ButtonClick;
            // 
            // Price
            // 
            Price.Caption = "السعر";
            Price.ColumnEdit = NumericTextEdit;
            Price.FieldName = "Price";
            Price.MinWidth = 24;
            Price.Name = "Price";
            Price.OptionsColumn.AllowEdit = false;
            Price.OptionsColumn.AllowFocus = false;
            Price.Visible = true;
            Price.VisibleIndex = 5;
            Price.Width = 154;
            // 
            // NumericTextEdit
            // 
            NumericTextEdit.AutoHeight = false;
            NumericTextEdit.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            NumericTextEdit.MaskSettings.Set("mask", "N0");
            NumericTextEdit.Name = "NumericTextEdit";
            NumericTextEdit.UseMaskAsDisplayFormat = true;
            // 
            // StockEntryNumber
            // 
            StockEntryNumber.Caption = "رقم الادخال";
            StockEntryNumber.FieldName = "StockEntryNumber";
            StockEntryNumber.MinWidth = 24;
            StockEntryNumber.Name = "StockEntryNumber";
            StockEntryNumber.OptionsColumn.AllowEdit = false;
            StockEntryNumber.OptionsColumn.AllowFocus = false;
            StockEntryNumber.Visible = true;
            StockEntryNumber.VisibleIndex = 2;
            StockEntryNumber.Width = 171;
            // 
            // StockEntryDate
            // 
            StockEntryDate.Caption = "تاريخ الادخال";
            StockEntryDate.FieldName = "StockEntryDate";
            StockEntryDate.MinWidth = 24;
            StockEntryDate.Name = "StockEntryDate";
            StockEntryDate.OptionsColumn.AllowEdit = false;
            StockEntryDate.OptionsColumn.AllowFocus = false;
            StockEntryDate.Visible = true;
            StockEntryDate.VisibleIndex = 3;
            StockEntryDate.Width = 184;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1, barButtonItem2, barButtonItem3, btnFirst, btnLast, btnPrevious, btnNext, lblCurrentIndex, barButtonItem4, barButtonItem5 });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 10;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem1), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem4), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem5) });
            bar2.OptionsBar.DrawBorder = false;
            bar2.OptionsBar.DrawDragBorder = false;
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "جديد";
            barButtonItem1.Id = 0;
            barButtonItem1.ImageOptions.SvgImage = Properties.Resources.AddFriend;
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "طباعة";
            barButtonItem4.Id = 8;
            barButtonItem4.ImageOptions.SvgImage = Properties.Resources.Print;
            barButtonItem4.Name = "barButtonItem4";
            barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barButtonItem4.ItemClick += barButtonItem4_ItemClick;
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "تحديث";
            barButtonItem5.Id = 9;
            barButtonItem5.ImageOptions.SvgImage = Properties.Resources.UpdateRestore;
            barButtonItem5.Name = "barButtonItem5";
            barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barButtonItem5.ItemClick += barButtonItem5_ItemClick;
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnFirst) });
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // btnFirst
            // 
            btnFirst.Id = 3;
            btnFirst.Name = "btnFirst";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            barDockControlTop.Size = new System.Drawing.Size(1315, 39);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 681);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            barDockControlBottom.Size = new System.Drawing.Size(1315, 37);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            barDockControlLeft.Size = new System.Drawing.Size(0, 642);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1315, 39);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            barDockControlRight.Size = new System.Drawing.Size(0, 642);
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "تعديل";
            barButtonItem2.Id = 1;
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "حذف";
            barButtonItem3.Id = 2;
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnLast
            // 
            btnLast.Caption = "barButtonItem5";
            btnLast.Id = 4;
            btnLast.Name = "btnLast";
            // 
            // btnPrevious
            // 
            btnPrevious.Caption = "barButtonItem6";
            btnPrevious.Id = 5;
            btnPrevious.Name = "btnPrevious";
            // 
            // btnNext
            // 
            btnNext.Caption = "barButtonItem7";
            btnNext.Id = 6;
            btnNext.Name = "btnNext";
            // 
            // lblCurrentIndex
            // 
            lblCurrentIndex.Caption = "0";
            lblCurrentIndex.Id = 7;
            lblCurrentIndex.Name = "lblCurrentIndex";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(dateEdit1);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(textEdit1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 39);
            panelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1315, 75);
            panelControl1.TabIndex = 5;
            // 
            // labelControl2
            // 
            labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelControl2.Location = new System.Drawing.Point(758, 24);
            labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(101, 26);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "تاريخ الادخال";
            // 
            // dateEdit1
            // 
            dateEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            dateEdit1.EditValue = null;
            dateEdit1.Location = new System.Drawing.Point(425, 21);
            dateEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateEdit1.MenuManager = barManager1;
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new System.Drawing.Size(314, 32);
            dateEdit1.TabIndex = 2;
            dateEdit1.EditValueChanged += dateEdit1_EditValueChanged_1;
            // 
            // labelControl1
            // 
            labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelControl1.Location = new System.Drawing.Point(1250, 24);
            labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(34, 26);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "بحث";
            // 
            // textEdit1
            // 
            textEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textEdit1.Location = new System.Drawing.Point(879, 21);
            textEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textEdit1.MenuManager = barManager1;
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(351, 32);
            textEdit1.TabIndex = 0;
            textEdit1.EditValueChanged += textEdit1_EditValueChanged;
            // 
            // ItemsForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1315, 718);
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Font = new System.Drawing.Font("Times New Roman", 13.8F);
            IconOptions.SvgImage = Properties.Resources.QuarentinedItems;
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "ItemsForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "قائمة المواد";
            Load += ItemsForm_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colULID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnFirst;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnLast;
        private DevExpress.XtraBars.BarButtonItem btnPrevious;
        private DevExpress.XtraBars.BarButtonItem btnNext;
        private DevExpress.XtraBars.BarStaticItem lblCurrentIndex;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn StockEntryNumber;
        private DevExpress.XtraGrid.Columns.GridColumn StockEntryDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit NumericTextEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}