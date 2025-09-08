namespace DXApplication2.Forms.Reports
{
    partial class EmployeesNameForm
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            itemAssignmentBindingSource = new System.Windows.Forms.BindingSource(components);
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colUlid = new DevExpress.XtraGrid.Columns.GridColumn();
            colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            colAssignmentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colAssignmentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colReturnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colConditionOnReturn = new DevExpress.XtraGrid.Columns.GridColumn();
            colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemAssignmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1444, 87);
            panelControl1.TabIndex = 1;
            // 
            // itemAssignmentBindingSource
            // 
            itemAssignmentBindingSource.DataSource = typeof(Entities.ItemAssignment);
            // 
            // gridControl1
            // 
            gridControl1.DataSource = itemAssignmentBindingSource;
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            gridControl1.Location = new System.Drawing.Point(0, 87);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonEdit1 });
            gridControl1.Size = new System.Drawing.Size(1444, 527);
            gridControl1.TabIndex = 2;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colUlid, colItemId, colEmployeeId, colCount, colAssignmentNumber, colAssignmentDate, colReturnDate, colConditionOnReturn, colNotes, colId, gridColumn1, gridColumn2 });
            gridView1.DetailHeight = 349;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.AllowCellMerge = true;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colUlid
            // 
            colUlid.FieldName = "Ulid";
            colUlid.MinWidth = 24;
            colUlid.Name = "colUlid";
            colUlid.Width = 95;
            // 
            // colItemId
            // 
            colItemId.Caption = "اسم المادة";
            colItemId.FieldName = "ItemName";
            colItemId.MinWidth = 24;
            colItemId.Name = "colItemId";
            colItemId.OptionsColumn.AllowEdit = false;
            colItemId.OptionsColumn.AllowFocus = false;
            colItemId.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colItemId.Visible = true;
            colItemId.VisibleIndex = 2;
            colItemId.Width = 303;
            // 
            // colEmployeeId
            // 
            colEmployeeId.Caption = "الموظف";
            colEmployeeId.FieldName = "EmployeeName";
            colEmployeeId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            colEmployeeId.MinWidth = 24;
            colEmployeeId.Name = "colEmployeeId";
            colEmployeeId.OptionsColumn.AllowEdit = false;
            colEmployeeId.OptionsColumn.AllowFocus = false;
            colEmployeeId.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            colEmployeeId.Visible = true;
            colEmployeeId.VisibleIndex = 1;
            colEmployeeId.Width = 325;
            // 
            // colCount
            // 
            colCount.Caption = "العدد";
            colCount.FieldName = "Count";
            colCount.MinWidth = 24;
            colCount.Name = "colCount";
            colCount.OptionsColumn.AllowEdit = false;
            colCount.OptionsColumn.AllowFocus = false;
            colCount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colCount.Visible = true;
            colCount.VisibleIndex = 3;
            colCount.Width = 76;
            // 
            // colAssignmentNumber
            // 
            colAssignmentNumber.Caption = "رقم الاخراج";
            colAssignmentNumber.FieldName = "AssignmentNumber";
            colAssignmentNumber.MinWidth = 24;
            colAssignmentNumber.Name = "colAssignmentNumber";
            colAssignmentNumber.OptionsColumn.AllowEdit = false;
            colAssignmentNumber.OptionsColumn.AllowFocus = false;
            colAssignmentNumber.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colAssignmentNumber.Visible = true;
            colAssignmentNumber.VisibleIndex = 4;
            colAssignmentNumber.Width = 176;
            // 
            // colAssignmentDate
            // 
            colAssignmentDate.Caption = "تاريخ الاخراج";
            colAssignmentDate.FieldName = "AssignmentDate";
            colAssignmentDate.MinWidth = 24;
            colAssignmentDate.Name = "colAssignmentDate";
            colAssignmentDate.OptionsColumn.AllowEdit = false;
            colAssignmentDate.OptionsColumn.AllowFocus = false;
            colAssignmentDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colAssignmentDate.Visible = true;
            colAssignmentDate.VisibleIndex = 5;
            colAssignmentDate.Width = 176;
            // 
            // colReturnDate
            // 
            colReturnDate.Caption = "تاريخ الاعادة";
            colReturnDate.FieldName = "ReturnDate";
            colReturnDate.MinWidth = 24;
            colReturnDate.Name = "colReturnDate";
            colReturnDate.OptionsColumn.AllowEdit = false;
            colReturnDate.OptionsColumn.AllowFocus = false;
            colReturnDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colReturnDate.Visible = true;
            colReturnDate.VisibleIndex = 6;
            colReturnDate.Width = 176;
            // 
            // colConditionOnReturn
            // 
            colConditionOnReturn.Caption = "الحالة اثناء الاعادة";
            colConditionOnReturn.FieldName = "ConditionOnReturn";
            colConditionOnReturn.MinWidth = 24;
            colConditionOnReturn.Name = "colConditionOnReturn";
            colConditionOnReturn.OptionsColumn.AllowEdit = false;
            colConditionOnReturn.OptionsColumn.AllowFocus = false;
            colConditionOnReturn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colConditionOnReturn.Visible = true;
            colConditionOnReturn.VisibleIndex = 7;
            colConditionOnReturn.Width = 197;
            // 
            // colNotes
            // 
            colNotes.Caption = "الملاحظات";
            colNotes.FieldName = "Notes";
            colNotes.MinWidth = 24;
            colNotes.Name = "colNotes";
            colNotes.OptionsColumn.AllowEdit = false;
            colNotes.OptionsColumn.AllowFocus = false;
            colNotes.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colNotes.Visible = true;
            colNotes.VisibleIndex = 8;
            colNotes.Width = 410;
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
            colId.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colId.Visible = true;
            colId.VisibleIndex = 0;
            colId.Width = 72;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "#";
            gridColumn1.ColumnEdit = repositoryItemButtonEdit1;
            gridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            gridColumn1.MinWidth = 24;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 10;
            gridColumn1.Width = 121;
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = Properties.Resources.Edit;
            editorButtonImageOptions2.SvgImage = Properties.Resources.Delete1;
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "btn_edit", null, DevExpress.Utils.ToolTipAnchor.Default), new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", "btn_delete", null, DevExpress.Utils.ToolTipAnchor.Default) });
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "gridColumn2";
            gridColumn2.MinWidth = 24;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 9;
            gridColumn2.Width = 95;
            // 
            // EmployeesNameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1444, 614);
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Font = new System.Drawing.Font("Times New Roman", 13.8F);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EmployeesNameForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "تقرير الموظفين";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemAssignmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource itemAssignmentBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUlid;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colAssignmentNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAssignmentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReturnDate;
        private DevExpress.XtraGrid.Columns.GridColumn colConditionOnReturn;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}