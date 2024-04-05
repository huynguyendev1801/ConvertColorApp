using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertColorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool updatingValues = false;

        private void UpdateColorValues(bool updateRGB, bool updateCMYK, bool updateHSV)
        {
            if (updatingValues) return;
            updatingValues = true;
            // Lấy giá trị từ các control NumericUpdown
            int r = (int)nudRGBR.Value;
            int g = (int)nudRGBG.Value;
            int b = (int)nudRGBB.Value;

            int c = (int)nudCMYKC.Value;
            int m = (int)nudCMYKM.Value;
            int y = (int)nudCMYKY.Value;
            int k = (int)nudCMYKK.Value;

            int h = (int)nudHSVH.Value;
            int s = (int)nudHSVS.Value;
            int v = (int)nudHSVV.Value;

            // Cập nhật giá trị tương ứng
            if (updateRGB)
            {
                (c, m, y, k) = ColorConversion.RGBtoCMYK(r, g, b);
                (h, s, v) = ColorConversion.RGBtoHSV(r, g, b);
            }
            else if (updateCMYK)
            {
                (r, g, b) = ColorConversion.CMYKtoRGB(c, m, y, k);
                (h, s, v) = ColorConversion.RGBtoHSV(r, g, b);
            }
            else if (updateHSV)
            {
                (r, g, b) = ColorConversion.HSVtoRGB(h, s, v);
                (c, m, y, k) = ColorConversion.RGBtoCMYK(r, g, b);
            }

            // Cập nhật giá trị cho các control NumericUpdown

            nudRGBR.Value = r;
            nudRGBG.Value = g;
            nudRGBB.Value = b;
            nudCMYKC.Value = c;
            nudCMYKM.Value = m;
            nudCMYKY.Value = y;
            nudCMYKK.Value = k;
            nudHSVH.Value = h;
            nudHSVS.Value = s;
            nudHSVV.Value = v;

            // Đặt màu cho panelColor
            labelTitle.ForeColor = Color.FromArgb(r, g, b);
            updatingValues = false;
        }

        private void nudRGBR_ValueChanged(object sender, EventArgs e)
        {
            tbRGBR.Value = (int)nudRGBR.Value;
            UpdateColorValues(true, false, false);
        }

        private void nudRGBG_ValueChanged(object sender, EventArgs e)
        {
            tbRGBG.Value = (int)nudRGBG.Value;
            UpdateColorValues(true, false, false);
        }

        private void nudRGBB_ValueChanged(object sender, EventArgs e)
        {
            tbRGBB.Value = (int)nudRGBB.Value;
            UpdateColorValues(true, false, false);
        }

        private void nudCMYKC_ValueChanged(object sender, EventArgs e)
        {
            tbCMYKC.Value = (int)nudCMYKC.Value;
            UpdateColorValues(false, true, false);
        }

        private void nudCMYKM_ValueChanged(object sender, EventArgs e)
        {
            tbCMYKM.Value = (int)nudCMYKM.Value;
            UpdateColorValues(false, true, false);
        }

        private void nudCMYKY_ValueChanged(object sender, EventArgs e)
        {
            tbCMYKY.Value = (int)nudCMYKY.Value;
            UpdateColorValues(false, true, false);
        }

        private void nudCMYKK_ValueChanged(object sender, EventArgs e)
        {
            tbCMYKK.Value = (int)nudCMYKK.Value;
            UpdateColorValues(false, true, false);
        }

        private void nudHSVH_ValueChanged(object sender, EventArgs e)
        {
            tbHSVH.Value = (int)nudHSVH.Value;
            UpdateColorValues(false, false, true);
        }

        private void nudHSVS_ValueChanged(object sender, EventArgs e)
        {
            tbHSVS.Value = (int)nudHSVS.Value;
            UpdateColorValues(false, false, true);
        }

        private void nudHSVV_ValueChanged(object sender, EventArgs e)
        {
            tbHSVV.Value = (int)nudHSVV.Value;
            UpdateColorValues(false, false, true);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tbRGBR.Scroll += TbRGB_Scroll;
            tbRGBG.Scroll += TbRGB_Scroll;
            tbRGBB.Scroll += TbRGB_Scroll;
            tbCMYKC.Scroll += TbCMYK_Scroll;
            tbCMYKM.Scroll += TbCMYK_Scroll;
            tbCMYKY.Scroll += TbCMYK_Scroll;
            tbCMYKK.Scroll += TbCMYK_Scroll;
            tbHSVH.Scroll += TbHSV_Scroll;
            tbHSVS.Scroll += TbHSV_Scroll;
            tbHSVV.Scroll += TbHSV_Scroll;
            UpdateColorValues(true, false, false);
        }
        private void TbRGB_Scroll(object sender, EventArgs e)
        {
            // Lấy giá trị từ TrackBar và cập nhật cho NumericUpDown tương ứng
            nudRGBR.Value = tbRGBR.Value;
            nudRGBG.Value = tbRGBG.Value;
            nudRGBB.Value = tbRGBB.Value;

            // Gọi hàm cập nhật màu
            UpdateColorValues(true, false, false);
        }

        private void TbCMYK_Scroll(object sender, EventArgs e)
        {
            // Lấy giá trị từ TrackBar và cập nhật cho NumericUpDown tương ứng
            nudCMYKC.Value = tbCMYKC.Value;
            nudCMYKM.Value = tbCMYKM.Value;
            nudCMYKY.Value = tbCMYKY.Value;
            nudCMYKK.Value = tbCMYKK.Value;

            // Gọi hàm cập nhật màu
            UpdateColorValues(false, true, false);
        }

        private void TbHSV_Scroll(object sender, EventArgs e)
        {
            // Lấy giá trị từ TrackBar và cập nhật cho NumericUpDown tương ứng
            nudHSVH.Value = tbHSVH.Value;
            nudHSVS.Value = tbHSVS.Value;
            nudHSVV.Value = tbHSVV.Value;

            // Gọi hàm cập nhật màu
            UpdateColorValues(false, false, true);
        }
    }
}
