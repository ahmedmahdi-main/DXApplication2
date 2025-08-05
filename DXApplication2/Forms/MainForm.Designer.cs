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
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)navBarControl1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5, barButtonItem6, skinDropDownButtonItem1, skinPaletteDropDownButtonItem1 });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 9;
            ribbon.Name = "ribbon";
            ribbon.PageHeaderItemLinks.Add(skinDropDownButtonItem1);
            ribbon.PageHeaderItemLinks.Add(skinPaletteDropDownButtonItem1);
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new System.Drawing.Size(1206, 253);
            ribbon.StatusBar = ribbonStatusBar;
            // ribbon.Click += ribbon_Click;
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
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new System.Drawing.Point(0, 682);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(1206, 38);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "قائمة الموظفين";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.SvgImage = Properties.Resources.PersonalFolder;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "قائمة المواد";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.SvgImage = Properties.Resources.QuarentinedItems;
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "قائمة الذمم";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.SvgImage = Properties.Resources.VPN;
            barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem5);
            ribbonPageGroup2.ItemLinks.Add(barButtonItem6);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "أضافة موظف";
            barButtonItem4.Id = 4;
            barButtonItem4.ImageOptions.SvgImage = Properties.Resources.AddFriend;
            barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "أضافة مادة";
            barButtonItem5.Id = 5;
            barButtonItem5.ImageOptions.SvgImage = Properties.Resources.SubscriptionAdd;
            barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "اضافة ذمة";
            barButtonItem6.Id = 6;
            barButtonItem6.ImageOptions.SvgImage = Properties.Resources.AddSurfaceHub;
            barButtonItem6.Name = "barButtonItem6";
            // 
            // navBarControl1
            // 
            navBarControl1.ActiveGroup = navBarGroup1;
            navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] { navBarGroup1 });
            navBarControl1.Location = new System.Drawing.Point(0, 253);
            navBarControl1.Name = "navBarControl1";
            navBarControl1.Size = new System.Drawing.Size(246, 429);
            navBarControl1.TabIndex = 2;
            navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            navBarGroup1.Caption = "التقارير";
            navBarGroup1.Expanded = true;
            navBarGroup1.Name = "navBarGroup1";
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
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1206, 720);
            Controls.Add(navBarControl1);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IconOptions.SvgImage = Properties.Resources.HomeSolid;
            Name = "MainForm";
            Ribbon = ribbon;
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StatusBar = ribbonStatusBar;
            Text = "الصفحة الرئيسية";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)navBarControl1).EndInit();
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
    }
}