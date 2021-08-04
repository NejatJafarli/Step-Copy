using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public bool IsTrue { get; set; } = true;
        private void PictureBoxPencil_Click(object sender, EventArgs e)
        {
            if (EnteredTeacher)
                if (IsTrue)
                {
                    PanelUsers.Location = new Point(126, 170);
                    guna2Button1.Location = new Point(1117, 118);
                    lblLessonText.Visible = false;
                    panelChangeLessonText.Visible = true;
                    panelChangeLessonText.Enabled = true;
                    txtLesson.Text = lblLessonText.Text;
                    IsTrue = false;
                    PictureBoxPencil.Location = new Point(710, 43);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelChangeLessonText.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PanelUsers.Location = new Point(126, 73);
            guna2Button1.Location = new Point(1117, 30);
            panelChangeLessonText.Visible = false;
            panelChangeLessonText.Enabled = false;
            lblLessonText.Visible = true;
            lblLessonText.Text = txtLesson.Text;
            txtLesson.Text = "";
            IsTrue = true;
            PictureBoxPencil.Location = new Point(PictureBoxPencil.Location.X + lblLessonText.Size.Width, PictureBoxPencil.Location.Y);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PanelUsers.Location = new Point(126, 73);
            guna2Button1.Location = new Point(1117, 30);

            panelChangeLessonText.Visible = false;
            panelChangeLessonText.Enabled = false;
            lblLessonText.Visible = true;
            txtLesson.Text = "";
            IsTrue = true;
            PictureBoxPencil.Location = new Point(PictureBoxPencil.Location.X + lblLessonText.Size.Width, PictureBoxPencil.Location.Y);
        }

        private void PanelUsers_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool EnteredTeacher { get; set; } = false;
        private void RadioButtonTwo_CheckedChanged(object sender, EventArgs e)
        {
            EnteredTeacher = true;
            PanelUsers.Enabled = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elave Olundu");
        }

        public bool DiamondBtn1 { get; set; } = false;
        public bool DiamondBtn2 { get; set; } = false;
        public bool DiamondBtn3 { get; set; } = false;
        private void Diamond1_Click(object sender, EventArgs e)
        {
            if (RadioButtonRed.Checked == false)
                if (DiamondBtn3 || DiamondBtn2)
                {
                    if (DiamondBtn3)
                    {
                        Diamond1.Image = Properties.Resources.diamond;
                        Diamond2.Image = Properties.Resources.blackDiamond;
                        Diamond3.Image = Properties.Resources.blackDiamond;
                        lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) + 2}";
                        DiamondBtn3 = false;
                        DiamondBtn2 = false;
                    }
                    else if(DiamondBtn2)
                    {
                        Diamond1.Image = Properties.Resources.diamond;
                        Diamond2.Image = Properties.Resources.blackDiamond;
                        Diamond3.Image = Properties.Resources.blackDiamond;
                        lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) + 1}";
                        DiamondBtn2 = false;
                    }
                }
                else if (DiamondBtn1)
                {
                    Diamond1.Image = Properties.Resources.blackDiamond;
                    Diamond2.Image = Properties.Resources.blackDiamond;
                    Diamond3.Image = Properties.Resources.blackDiamond;
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) + 1}";
                    DiamondBtn1 = false;
                }
                else if (Convert.ToInt32(lblDiamondCount.Text) - 1 >= 0)
                {
                    DiamondBtn1 = true;
                    Diamond1.Image = Properties.Resources.diamond;
                    Diamond2.Image = Properties.Resources.blackDiamond;
                    Diamond3.Image = Properties.Resources.blackDiamond;
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) - 1}";
                }
        }
        private void Diamond2_Click(object sender, EventArgs e)
        {
            if (RadioButtonRed.Checked == false)


                if (DiamondBtn3)
                {
                    Diamond1.Image = Properties.Resources.diamond;
                    Diamond2.Image = Properties.Resources.diamond;
                    Diamond3.Image = Properties.Resources.blackDiamond;
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) + 1}";
                    DiamondBtn3 = false;
                }
                else if (DiamondBtn1)
                {
                    DiamondBtn2 = true;
                    Diamond1.Image = Properties.Resources.diamond;
                    Diamond2.Image = Properties.Resources.diamond;
                    Diamond3.Image = Properties.Resources.blackDiamond;
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) - 1}";
                }
                else if (Convert.ToInt32(lblDiamondCount.Text) - 2 >= 0)
                {
                    DiamondBtn2 = true;
                    DiamondBtn1 = true;
                    Diamond1.Image = Properties.Resources.diamond;
                    Diamond2.Image = Properties.Resources.diamond;
                    Diamond3.Image = Properties.Resources.blackDiamond;
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) - 2}";
                }
        }

        private void Diamond3_Click(object sender, EventArgs e)
        {
            if (RadioButtonRed.Checked == false)

                if (DiamondBtn1)
                {
                    DiamondBtn3 = true;
                    Diamond1.Image = Properties.Resources.diamond;
                    Diamond2.Image = Properties.Resources.diamond;
                    Diamond3.Image = Properties.Resources.diamond;
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) - 2}";
                }
                else if (DiamondBtn2)
                {
                    DiamondBtn3 = true;
                    Diamond1.Image = Properties.Resources.diamond;
                    Diamond2.Image = Properties.Resources.diamond;
                    Diamond3.Image = Properties.Resources.diamond;
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) - 1}";
                }
                else if (Convert.ToInt32(lblDiamondCount.Text) - 3 >= 0)
                {
                    DiamondBtn3 = true;
                    DiamondBtn2 = true;
                    DiamondBtn1 = true;
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) - 3}";
                    Diamond1.Image = Properties.Resources.diamond;
                    Diamond2.Image = Properties.Resources.diamond;
                    Diamond3.Image = Properties.Resources.diamond;
                }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2ComboBox1.FillColor = Color.FromArgb(179, 158, 219);
            guna2ComboBox1.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void RadioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonRed.Checked == false)
            {
                guna2ComboBox1.Enabled = true;
                guna2ComboBox2.Enabled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (DiamondBtn1)
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) + 1}";
            if (DiamondBtn2)
                lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) + 1}";
            if (DiamondBtn3)
                lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) + 1}";
            DiamondBtn1 = false;
            DiamondBtn2 = false;
            DiamondBtn3 = false;
            Diamond1.Image = Properties.Resources.blackDiamond;
            Diamond2.Image = Properties.Resources.blackDiamond;
            Diamond3.Image = Properties.Resources.blackDiamond;
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            guna2ComboBox2.FillColor = Color.FromArgb(200, 225, 157);
            guna2ComboBox2.ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
}
