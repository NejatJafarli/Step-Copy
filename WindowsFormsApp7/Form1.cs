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
            userControl11.Tag = $"{lblDiamondCount.Text}";
            timer1.Start();
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
       



        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void userControl11_Click(object sender, EventArgs e)
        {
            userControl11.Tag = $"{lblDiamondCount.Text}";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDiamondCount.Text = userControl11.Tag as string;
        }
    }
}
