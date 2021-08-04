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
        public List<UserControl1> users = new List<UserControl1>();
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
            users.Add(new UserControl1("Nicat Ceferli Rasim", "1", "02.08.21"));
            users.Add(new UserControl1("Eliyev Emiraslan Isa", "2", "02.08.21"));
            users.Add(new UserControl1("Hesenzade Ilqar Ilham", "3", "02.08.21"));
            users.Add(new UserControl1("Idayatov Kenan Ilqar", "4", "02.08.21"));
            users.Add(new UserControl1("Nebili Nebi Elcin", "5", "02.08.21"));
            users.Add(new UserControl1("Rustamov Yusif Habid", "6", "26.07.21"));
            users.Add(new UserControl1("Vahabzade Zahid Yusif", "7", "02.08.21"));
            users.Add(new UserControl1("Velizade Emin Elnur", "8", "02.08.21"));
            this.Tag = $"{lblDiamondCount.Text}";
            for (int i = 0; i < users.Count; i++)
            {
                this.Controls.Add(users[i]);
                PanelUsers.Controls.Add(users[i]);
                users[i].Dock = DockStyle.Top;
                users[i].BringToFront();
            }
            timer1.Start();
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
            this.Tag = $"{lblDiamondCount.Text}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDiamondCount.Text = Tag as string;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButton1.Checked)
            {
                guna2RadioButton1.Checked = false;
                for (int i = 0; i < users.Count; i++)
                {
                    users[i].AllStudentCome();
                }
            }
        }
    }
}
