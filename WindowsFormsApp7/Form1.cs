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

        }
        public bool IsTrue { get; set; } = true;
        private void PictureBoxPencil_Click(object sender, EventArgs e)
        {
            if (RadioButtonOne.Checked || RadioButtonTwo.Checked)
            {
                if (IsTrue)
                {
                    PanelUsers.Location = new Point(126, 170);
                    lblLessonText.Visible = false;
                    panelChangeLessonText.Visible = true;
                    panelChangeLessonText.Enabled = true;
                    txtLesson.Text = lblLessonText.Text;
                    IsTrue = false;
                    PictureBoxPencil.Location = new Point(710, 43);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelChangeLessonText.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PanelUsers.Location = new Point(126, 73);

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

            panelChangeLessonText.Visible = false;
            panelChangeLessonText.Enabled = false;
            lblLessonText.Visible = true;
            txtLesson.Text = "";
            IsTrue = true;
            PictureBoxPencil.Location = new Point(PictureBoxPencil.Location.X + lblLessonText.Size.Width, PictureBoxPencil.Location.Y);
        }
    }
}
