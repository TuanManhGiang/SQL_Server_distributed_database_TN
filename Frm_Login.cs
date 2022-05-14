using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiem_CSDLPT.Common;
using TracNghiem_CSDLPT.Share;

namespace CSDLPT_TN_0._1
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            InitDataForCmbBrand();

            lbl_Error_GV.Text = lbl_Error_SV.Text = "";
        }

        #region Function

        private void InitDataForCmbBrand()
        {
            SqlRequestFunction.GetListBrand();

            cmb_Brand_SV.DataSource = Program.bds_ListBrand;
            cmb_Brand_SV.DisplayMember = "TENCN";
            cmb_Brand_SV.ValueMember = "TENSERVER";

            cmb_Brand_GV.DataSource = Program.bds_ListBrand;
            cmb_Brand_GV.DisplayMember = "TENCN";
            cmb_Brand_GV.ValueMember = "TENSERVER";

            cmb_Brand_SV.SelectedIndex = -1;
            cmb_Brand_GV.SelectedIndex = -1;

            cmb_Brand_GV.Text = "Chọn cơ sở";
            cmb_Brand_SV.Text = "Chọn cơ sở";
        }

        private bool CheckValidateLogin(int indexBrand, String studentCode)
        {
            bool validate = true;
            if (indexBrand == -1)
            {
                ErrorHandler.ShowError(lbl_Error_SV, new string[] { "OxB001" });
                validate = false;
            }
            if (studentCode.Trim().Equals(String.Empty))
            {
                ErrorHandler.ShowError(lbl_Error_SV, new string[] { "OxB002" });
                validate = false;
            }

            return validate;
        }

        private bool CheckValidateLogin(int indexBrand, String userName, String password)
        {
            bool validate = true;
            if (indexBrand == -1)
            {
                ErrorHandler.ShowError(lbl_Error_GV, new string[] { "OxB001" });
                validate = false;
            }
            if (userName.Trim().Equals(String.Empty))
            {
                ErrorHandler.ShowError(lbl_Error_GV, new string[] { "OxB003" });
                validate = false;
            }
            if (password.Trim().Equals(String.Empty))
            {
                ErrorHandler.ShowError(lbl_Error_SV, new string[] { "OxB004" });
                validate = false;
            }

            return validate;
        }
        #endregion
        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_SV_Click(object sender, EventArgs e)
        {
            pnl_GV.Visible = false;
            pnl_SV.Visible = true;
            pnl_SV.BringToFront();
            btn_SV.BringToFront();
            btn_GV.SendToBack();
            btn_SV.BackColor = Color.DeepSkyBlue;
            btn_GV.BackColor = Color.SkyBlue;
        }
        private void btn_GV_Click(object sender, EventArgs e)
        {
            pnl_SV.Visible = false;
            pnl_GV.Visible = true;
            pnl_GV.BringToFront();
            btn_SV.SendToBack();
            btn_GV.BringToFront();

            btn_GV.BackColor = Color.SkyBlue;
            btn_SV.BackColor = Color.DeepSkyBlue;

        }
        private void btn_Login_SV_Click(object sender, EventArgs e) {
        }
        private void cmb_Brand_SV_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btn_Login_GV_Click(object sender, EventArgs e) { }
        private void cmb_Brand_GV_SelectedIndexChanged(object sender, EventArgs e) { }

        private void pnl_GV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Login_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSetPhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
           

        }
    }
}
