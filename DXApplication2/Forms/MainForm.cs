using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Helpers;
using DXApplication2.Forms.Employees;
using DXApplication2.Forms.Items;
using static DXApplication2.Properties.Settings;
namespace DXApplication2.Forms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            SkinCaption();
        }
        private void SkinCaption()
        {
            SkinHelper.InitSkinPaletteGallery(skinPaletteRibbonGalleryBarItem1);
            var palletName = Default["ApplicationSkinPaletteName"].ToString();
            var skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
            SvgPalette palette = skin.CustomSvgPalettes[palletName];
            skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(palette);
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new EmployeesFrom { MdiParent = this };
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new ItemsForm { MdiParent = this };
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new ItemAssignment.ItemAssignmentForm { MdiParent = this };
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new EmployeesOperationsForm();
            frm.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new ItemsOperationsFrom();
            frm.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new ItemAssignment.ItemAssignmentOperationsForm();
            frm.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new ItemAssignment.ItemAssignmentFormRecycle { MdiParent = this };
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new Reports.ReportDesignerForm();
            frm.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new ItemsRecycle() { MdiParent = this };
            frm.Show();
        }

        private void ribbon_Click(object sender, System.EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Default["ApplicationSkinPaletteName"] = skinPaletteRibbonGalleryBarItem1.Gallery.GetCheckedItem().Caption;
            Default.Save();
        }
    }
}