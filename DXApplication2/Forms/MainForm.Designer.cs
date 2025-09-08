namespace DXApplication2.Forms
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
            components = new System.ComponentModel.Container();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)navBarControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(30, 29, 30, 29);
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5, barButtonItem6, skinDropDownButtonItem1, skinPaletteDropDownButtonItem1, barButtonItem7, barButtonItem8, barButtonItem9, barButtonItem10, barButtonItem11, skinPaletteRibbonGalleryBarItem1 });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ribbon.MaxItemId = 15;
            ribbon.Name = "ribbon";
            ribbon.OptionsMenuMinWidth = 331;
            ribbon.PageHeaderItemLinks.Add(skinDropDownButtonItem1);
            ribbon.PageHeaderItemLinks.Add(skinPaletteDropDownButtonItem1);
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2 });
            ribbon.Size = new System.Drawing.Size(1439, 253);
            ribbon.StatusBar = ribbonStatusBar;
            ribbon.Click += ribbon_Click;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "قائمة الموظفين";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.SvgImage = Properties.Resources.PersonalFolder;
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "قائمة المواد";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.SvgImage = Properties.Resources.QuarentinedItems;
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "قائمة الذمم";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.SvgImage = Properties.Resources.VPN;
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.ItemClick += barButtonItem3_ItemClick;
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "أضافة موظف";
            barButtonItem4.Id = 4;
            barButtonItem4.ImageOptions.SvgImage = Properties.Resources.AddFriend;
            barButtonItem4.Name = "barButtonItem4";
            barButtonItem4.ItemClick += barButtonItem4_ItemClick;
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "أضافة مادة";
            barButtonItem5.Id = 5;
            barButtonItem5.ImageOptions.SvgImage = Properties.Resources.SubscriptionAdd;
            barButtonItem5.Name = "barButtonItem5";
            barButtonItem5.ItemClick += barButtonItem5_ItemClick;
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "اضافة ذمة";
            barButtonItem6.Id = 6;
            barButtonItem6.ImageOptions.SvgImage = Properties.Resources.AddSurfaceHub;
            barButtonItem6.Name = "barButtonItem6";
            barButtonItem6.ItemClick += barButtonItem6_ItemClick;
            // 
            // skinDropDownButtonItem1
            // 
            skinDropDownButtonItem1.Id = 7;
            skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            skinPaletteDropDownButtonItem1.ActAsDropDown = true;
            skinPaletteDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinPaletteDropDownButtonItem1.Id = 8;
            skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // barButtonItem7
            // 
            barButtonItem7.Caption = "سلة المحذوفات";
            barButtonItem7.Id = 9;
            barButtonItem7.ImageOptions.SvgImage = Properties.Resources.Delete1;
            barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            barButtonItem8.Caption = "النسخ الاحتياطي والاستعادة";
            barButtonItem8.Id = 10;
            barButtonItem8.ImageOptions.SvgImage = Properties.Resources.DevUpdate;
            barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            barButtonItem9.Caption = "سلة المحذوفات الذمم";
            barButtonItem9.Id = 11;
            barButtonItem9.ImageOptions.SvgImage = Properties.Resources.Delete1;
            barButtonItem9.Name = "barButtonItem9";
            barButtonItem9.ItemClick += barButtonItem9_ItemClick;
            // 
            // barButtonItem10
            // 
            barButtonItem10.Caption = "تصميم الطباعة";
            barButtonItem10.Id = 12;
            barButtonItem10.ImageOptions.SvgImage = Properties.Resources.ReportDocument;
            barButtonItem10.Name = "barButtonItem10";
            barButtonItem10.ItemClick += barButtonItem10_ItemClick;
            // 
            // barButtonItem11
            // 
            barButtonItem11.Caption = "سلة المحذوفات المواد";
            barButtonItem11.Id = 13;
            barButtonItem11.ImageOptions.SvgImage = Properties.Resources.ChipCardCreditCardReader;
            barButtonItem11.Name = "barButtonItem11";
            barButtonItem11.ItemClick += barButtonItem11_ItemClick;
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            skinPaletteRibbonGalleryBarItem1.Id = 14;
            skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2 });
            ribbonPage1.ImageOptions.SvgImage = Properties.Resources.HomeSolid;
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "الرئيسية";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem5);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem6);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3 });
            ribbonPage2.ImageOptions.SvgImage = Properties.Resources.Setting;
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "الاعدادت";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItem8, true);
            ribbonPageGroup3.ItemLinks.Add(barButtonItem9, true);
            ribbonPageGroup3.ItemLinks.Add(barButtonItem11);
            ribbonPageGroup3.ItemLinks.Add(barButtonItem10);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new System.Drawing.Point(0, 683);
            ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(1439, 38);
            // 
            // navBarControl1
            // 
            navBarControl1.ActiveGroup = navBarGroup1;
            navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] { navBarGroup1 });
            navBarControl1.Location = new System.Drawing.Point(0, 253);
            navBarControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            navBarControl1.Name = "navBarControl1";
            navBarControl1.OptionsNavPane.ExpandedWidth = 245;
            navBarControl1.Size = new System.Drawing.Size(245, 430);
            navBarControl1.TabIndex = 2;
            navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            navBarGroup1.Caption = "التقارير";
            navBarGroup1.Expanded = true;
            navBarGroup1.Name = "navBarGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1439, 721);
            Controls.Add(navBarControl1);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IconOptions.SvgImage = Properties.Resources.HomeSolid;
            IsMdiContainer = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Ribbon = ribbon;
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StatusBar = ribbonStatusBar;
            Text = "الصفحة الرئيسية";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)navBarControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
    }
}