namespace DXApplication2.Forms.Employees
{
    partial class EmployeesOperationsForm
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
            dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            employeeBindingSource = new System.Windows.Forms.BindingSource(components);
            DepartmentTextEdit = new DevExpress.XtraEditors.TextEdit();
            PositionTextEdit = new DevExpress.XtraEditors.TextEdit();
            NationalIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            PhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForDepartment = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForPosition = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForNationalID = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForPhone = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
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
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
            dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DepartmentTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PositionTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NationalIDTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhoneTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IdTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForDepartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForNationalID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            dataLayoutControl1.Controls.Add(NameTextEdit);
            dataLayoutControl1.Controls.Add(DepartmentTextEdit);
            dataLayoutControl1.Controls.Add(PositionTextEdit);
            dataLayoutControl1.Controls.Add(NationalIDTextEdit);
            dataLayoutControl1.Controls.Add(PhoneTextEdit);
            dataLayoutControl1.Controls.Add(EmailTextEdit);
            dataLayoutControl1.Controls.Add(IdTextEdit);
            dataLayoutControl1.Controls.Add(simpleButton1);
            dataLayoutControl1.DataSource = employeeBindingSource;
            dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataLayoutControl1.Location = new System.Drawing.Point(0, 39);
            dataLayoutControl1.Name = "dataLayoutControl1";
            dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            dataLayoutControl1.Root = Root;
            dataLayoutControl1.Size = new System.Drawing.Size(761, 359);
            dataLayoutControl1.TabIndex = 0;
            dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // NameTextEdit
            // 
            NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeeBindingSource, "Name", true));
            NameTextEdit.Location = new System.Drawing.Point(14, 50);
            NameTextEdit.Name = "NameTextEdit";
            NameTextEdit.Size = new System.Drawing.Size(618, 32);
            NameTextEdit.StyleController = dataLayoutControl1;
            NameTextEdit.TabIndex = 4;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Entities.Employee);
            // 
            // DepartmentTextEdit
            // 
            DepartmentTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeeBindingSource, "Department", true));
            DepartmentTextEdit.Location = new System.Drawing.Point(14, 86);
            DepartmentTextEdit.Name = "DepartmentTextEdit";
            DepartmentTextEdit.Size = new System.Drawing.Size(618, 32);
            DepartmentTextEdit.StyleController = dataLayoutControl1;
            DepartmentTextEdit.TabIndex = 5;
            // 
            // PositionTextEdit
            // 
            PositionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeeBindingSource, "Position", true));
            PositionTextEdit.Location = new System.Drawing.Point(14, 122);
            PositionTextEdit.Name = "PositionTextEdit";
            PositionTextEdit.Size = new System.Drawing.Size(618, 32);
            PositionTextEdit.StyleController = dataLayoutControl1;
            PositionTextEdit.TabIndex = 6;
            // 
            // NationalIDTextEdit
            // 
            NationalIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeeBindingSource, "NationalID", true));
            NationalIDTextEdit.Location = new System.Drawing.Point(14, 158);
            NationalIDTextEdit.Name = "NationalIDTextEdit";
            NationalIDTextEdit.Size = new System.Drawing.Size(618, 32);
            NationalIDTextEdit.StyleController = dataLayoutControl1;
            NationalIDTextEdit.TabIndex = 7;
            // 
            // PhoneTextEdit
            // 
            PhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeeBindingSource, "Phone", true));
            PhoneTextEdit.Location = new System.Drawing.Point(14, 194);
            PhoneTextEdit.Name = "PhoneTextEdit";
            PhoneTextEdit.Size = new System.Drawing.Size(618, 32);
            PhoneTextEdit.StyleController = dataLayoutControl1;
            PhoneTextEdit.TabIndex = 8;
            // 
            // EmailTextEdit
            // 
            EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeeBindingSource, "Email", true));
            EmailTextEdit.Location = new System.Drawing.Point(14, 230);
            EmailTextEdit.Name = "EmailTextEdit";
            EmailTextEdit.Size = new System.Drawing.Size(618, 32);
            EmailTextEdit.StyleController = dataLayoutControl1;
            EmailTextEdit.TabIndex = 9;
            // 
            // IdTextEdit
            // 
            IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeeBindingSource, "Id", true));
            IdTextEdit.EditValue = "0";
            IdTextEdit.Location = new System.Drawing.Point(14, 14);
            IdTextEdit.Name = "IdTextEdit";
            IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            IdTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            IdTextEdit.Properties.MaskSettings.Set("mask", "N0");
            IdTextEdit.Properties.ReadOnly = true;
            IdTextEdit.Properties.UseReadOnlyAppearance = false;
            IdTextEdit.Size = new System.Drawing.Size(618, 32);
            IdTextEdit.StyleController = dataLayoutControl1;
            IdTextEdit.TabIndex = 10;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.SvgImage = Properties.Resources.Save;
            simpleButton1.Location = new System.Drawing.Point(14, 266);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(733, 44);
            simpleButton1.StyleController = dataLayoutControl1;
            simpleButton1.TabIndex = 11;
            simpleButton1.Text = "حفظ";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(761, 359);
            Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.AllowDrawBackground = false;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { ItemForName, ItemForDepartment, ItemForPosition, ItemForNationalID, ItemForPhone, ItemForEmail, ItemForId, layoutControlItem1 });
            layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            layoutControlGroup1.Name = "autoGeneratedGroup0";
            layoutControlGroup1.Size = new System.Drawing.Size(737, 335);
            // 
            // ItemForName
            // 
            ItemForName.Control = NameTextEdit;
            ItemForName.Location = new System.Drawing.Point(0, 36);
            ItemForName.Name = "ItemForName";
            ItemForName.Size = new System.Drawing.Size(737, 36);
            ItemForName.Text = "الاسم";
            ItemForName.TextSize = new System.Drawing.Size(100, 26);
            // 
            // ItemForDepartment
            // 
            ItemForDepartment.Control = DepartmentTextEdit;
            ItemForDepartment.Location = new System.Drawing.Point(0, 72);
            ItemForDepartment.Name = "ItemForDepartment";
            ItemForDepartment.Size = new System.Drawing.Size(737, 36);
            ItemForDepartment.Text = "مكان العمل";
            ItemForDepartment.TextSize = new System.Drawing.Size(100, 26);
            // 
            // ItemForPosition
            // 
            ItemForPosition.Control = PositionTextEdit;
            ItemForPosition.Location = new System.Drawing.Point(0, 108);
            ItemForPosition.Name = "ItemForPosition";
            ItemForPosition.Size = new System.Drawing.Size(737, 36);
            ItemForPosition.Text = "المنصب";
            ItemForPosition.TextSize = new System.Drawing.Size(100, 26);
            // 
            // ItemForNationalID
            // 
            ItemForNationalID.Control = NationalIDTextEdit;
            ItemForNationalID.Location = new System.Drawing.Point(0, 144);
            ItemForNationalID.Name = "ItemForNationalID";
            ItemForNationalID.Size = new System.Drawing.Size(737, 36);
            ItemForNationalID.Text = "الرقم الوظيفي";
            ItemForNationalID.TextSize = new System.Drawing.Size(100, 26);
            // 
            // ItemForPhone
            // 
            ItemForPhone.Control = PhoneTextEdit;
            ItemForPhone.Location = new System.Drawing.Point(0, 180);
            ItemForPhone.Name = "ItemForPhone";
            ItemForPhone.Size = new System.Drawing.Size(737, 36);
            ItemForPhone.Text = "رقم الهاتف";
            ItemForPhone.TextSize = new System.Drawing.Size(100, 26);
            // 
            // ItemForEmail
            // 
            ItemForEmail.Control = EmailTextEdit;
            ItemForEmail.Location = new System.Drawing.Point(0, 216);
            ItemForEmail.Name = "ItemForEmail";
            ItemForEmail.Size = new System.Drawing.Size(737, 36);
            ItemForEmail.Text = "الايميل";
            ItemForEmail.TextSize = new System.Drawing.Size(100, 26);
            // 
            // ItemForId
            // 
            ItemForId.Control = IdTextEdit;
            ItemForId.Location = new System.Drawing.Point(0, 0);
            ItemForId.Name = "ItemForId";
            ItemForId.Size = new System.Drawing.Size(737, 36);
            ItemForId.Text = "ت";
            ItemForId.TextSize = new System.Drawing.Size(100, 26);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = simpleButton1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 252);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(737, 83);
            layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1, barButtonItem2, barButtonItem3, btnFirst, btnLast, btnPrevious, btnNext, lblCurrentIndex });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 8;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem1) });
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
            barDockControlTop.Size = new System.Drawing.Size(761, 39);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 398);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            barDockControlBottom.Size = new System.Drawing.Size(761, 37);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            barDockControlLeft.Size = new System.Drawing.Size(0, 359);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(761, 39);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            barDockControlRight.Size = new System.Drawing.Size(0, 359);
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
            // EmployeesOperationsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(761, 435);
            Controls.Add(dataLayoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeesOperationsForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "اضافة او تعديل موظف";
            Load += EmployeesOperationsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
            dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DepartmentTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PositionTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)NationalIDTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhoneTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)IdTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForDepartment).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForNationalID).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForId).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DevExpress.XtraEditors.TextEdit DepartmentTextEdit;
        private DevExpress.XtraEditors.TextEdit PositionTextEdit;
        private DevExpress.XtraEditors.TextEdit NationalIDTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit IdTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDepartment;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPosition;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNationalID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForId;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
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
    }
}