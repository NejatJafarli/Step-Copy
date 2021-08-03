using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MystatWebPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveForm.BackgroundImage =Properties.Resources.MyImage;

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
            guna2ComboBox1.Enabled = EnteredTeacher;
            guna2Panel4.Enabled = true;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elave Olundu");
        }

        private void Diamond1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblDiamondCount.Text) - 1 >= 0)
                lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) - 1}";
        }

        private void Diamond2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblDiamondCount.Text) - 2 >= 0)
                lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) - 3}";
        }

        private void Diamond3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblDiamondCount.Text) - 3 >= 0)
            {
                lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) - 3}";
            }
        }
    }
}
