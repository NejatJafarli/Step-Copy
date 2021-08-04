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
    public partial class UserControl1 : UserControl
    {
        public void AllStudentCome()
        {
            RadioButtonRed.Checked = false;
            guna2RadioButton3.Checked = true;
        }
        public UserControl1(string nameSurname, string counter, string enteredMyStat)
        {
            InitializeComponent();
            lblDiamondCount = new Label();
            NameSurname = nameSurname;
            Counter = counter;
            EnteredMyStat = enteredMyStat;
        }

        public string NameSurname
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string Counter
        {
            get { return lblCounter.Text; }
            set { lblCounter.Text = value; }
        }
        public string EnteredMyStat
        {
            get { return lblEnteredMystat.Text; }
            set { lblEnteredMystat.Text = value; }
        }


        public Label lblDiamondCount { get; set; }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void RadioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonRed.Checked == false)
            {
                guna2ComboBox1.Enabled = true;
                guna2ComboBox2.Enabled = true;
            }
            else
            {

                guna2ComboBox1.Enabled = false;
                guna2ComboBox2.Enabled = false;
                pictureBox2_Click(null, null);
            }
        }
        public bool DiamondBtn1 { get; set; } = false;
        public bool DiamondBtn2 { get; set; } = false;
        public bool DiamondBtn3 { get; set; } = false;
        private void Diamond1_Click(object sender, EventArgs e)
        {
            lblDiamondCount.Text = Form1.ActiveForm.Tag as string;
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
                    else if (DiamondBtn2)
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
            Form1.ActiveForm.Tag = lblDiamondCount.Text;
        }
        private void Diamond2_Click(object sender, EventArgs e)
        {
            lblDiamondCount.Text = Form1.ActiveForm.Tag as string;
            if (RadioButtonRed.Checked == false)



                if (DiamondBtn3)
                {
                    Diamond1.Image = Properties.Resources.diamond;
                    Diamond2.Image = Properties.Resources.diamond;
                    Diamond3.Image = Properties.Resources.blackDiamond;
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) + 1}";
                    DiamondBtn3 = false;
                }
                else if (DiamondBtn1 && Convert.ToInt32(lblDiamondCount.Text) - 1 >= 0)
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
            Form1.ActiveForm.Tag = lblDiamondCount.Text;

        }

        private void Diamond3_Click(object sender, EventArgs e)
        {

            lblDiamondCount.Text = Form1.ActiveForm.Tag as string;
            if (RadioButtonRed.Checked == false)

                if (DiamondBtn2 && Convert.ToInt32(lblDiamondCount.Text) - 1 >= 0)
                {
                    DiamondBtn3 = true;
                    DiamondBtn1 = true;
                    Diamond1.Image = Properties.Resources.diamond;
                    Diamond2.Image = Properties.Resources.diamond;
                    Diamond3.Image = Properties.Resources.diamond;
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) - 1}";
                }
                else if (DiamondBtn1 && Convert.ToInt32(lblDiamondCount.Text) - 2 >= 0)
                {
                    DiamondBtn2 = true;
                    DiamondBtn3 = true;
                    Diamond1.Image = Properties.Resources.diamond;
                    Diamond2.Image = Properties.Resources.diamond;
                    Diamond3.Image = Properties.Resources.diamond;
                    lblDiamondCount.Text = $"{Convert.ToInt32(lblDiamondCount.Text) - 2}";
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
            Form1.ActiveForm.Tag = lblDiamondCount.Text;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblDiamondCount.Text = Form1.ActiveForm.Tag as string;
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
            Form1.ActiveForm.Tag = lblDiamondCount.Text;

        }



        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2ComboBox1.FillColor = Color.FromArgb(179, 158, 219);
            guna2ComboBox1.ForeColor = Color.FromArgb(255, 255, 255);
        }




        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            guna2ComboBox2.FillColor = Color.FromArgb(200, 225, 157);
            guna2ComboBox2.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {

        }
        public string oldText { get; set; }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtComment.Enabled = true;

            Size = new Size(this.Size.Width, this.Size.Height + 54);
            UserPanel.Size = this.Size;
            pictureBox1.Visible = false;
            lblEnteredMystat.Location = new Point(lblEnteredMystat.Location.X - 50, lblEnteredMystat.Location.Y);
            guna2RadioButton3.Location = new Point(guna2RadioButton3.Location.X - 50, guna2RadioButton3.Location.Y);
            guna2RadioButton2.Location = new Point(guna2RadioButton2.Location.X - 50, guna2RadioButton2.Location.Y);
            RadioButtonRed.Location = new Point(RadioButtonRed.Location.X - 50, RadioButtonRed.Location.Y);
            guna2ComboBox1.Location = new Point(guna2ComboBox1.Location.X - 50, guna2ComboBox1.Location.Y);
            guna2ComboBox2.Location = new Point(guna2ComboBox2.Location.X - 50, guna2ComboBox2.Location.Y);

            Diamond1.Location = new Point(Diamond1.Location.X - 50, Diamond1.Location.Y);
            Diamond2.Location = new Point(Diamond2.Location.X - 50, Diamond2.Location.Y);
            Diamond3.Location = new Point(Diamond3.Location.X - 50, Diamond3.Location.Y);

            pictureBox2.Location = new Point(pictureBox2.Location.X - 50, pictureBox2.Location.Y);

            txtComment.Visible = true;
            txtComment.BringToFront();
            oldText = txtComment.Text;
            txtComment.Location = new Point(978, 13);
            txtComment.Size = new Size(292, 69);

            lblDateTime.Visible = false;
            lblRey.Visible = true;
            lblRey.BringToFront();
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }
        //978, 13
        //292, 69

        //1021, 13
        //249, 35
        private void btnCancel_Click(object sender, EventArgs e)
        {

            Size = new Size(this.Size.Width, this.Size.Height - 54);
            UserPanel.Size = this.Size;
            lblEnteredMystat.Location = new Point(lblEnteredMystat.Location.X + 50, lblEnteredMystat.Location.Y);
            guna2RadioButton3.Location = new Point(guna2RadioButton3.Location.X + 50, guna2RadioButton3.Location.Y);
            guna2RadioButton2.Location = new Point(guna2RadioButton2.Location.X + 50, guna2RadioButton2.Location.Y);
            RadioButtonRed.Location = new Point(RadioButtonRed.Location.X + 50, RadioButtonRed.Location.Y);
            guna2ComboBox1.Location = new Point(guna2ComboBox1.Location.X + 50, guna2ComboBox1.Location.Y);
            guna2ComboBox2.Location = new Point(guna2ComboBox2.Location.X + 50, guna2ComboBox2.Location.Y);

            Diamond1.Location = new Point(Diamond1.Location.X + 50, Diamond1.Location.Y);
            Diamond2.Location = new Point(Diamond2.Location.X + 50, Diamond2.Location.Y);
            Diamond3.Location = new Point(Diamond3.Location.X + 50, Diamond3.Location.Y);

            pictureBox2.Location = new Point(pictureBox2.Location.X + 50, pictureBox2.Location.Y);

            lblRey.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;

            if (string.IsNullOrWhiteSpace(oldText))
            {
                lblDateTime.Visible = false;
                pictureBox1.Visible = true;
                txtComment.BringToFront();
                txtComment.Visible = false;
                txtComment.Location = new Point(978, 13);
                txtComment.Size = new Size(292, 69);
            }
            else
            {
                lblDateTime.Visible = true;
                pictureBox1.Visible = false;
                txtComment.Visible = true;
                lblDateTime.BringToFront();
                txtComment.Location = new Point(1021, 13);
                txtComment.Size = new Size(249, 40);
                txtComment.Text = oldText;
                txtComment.Enabled = false;

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Size = new Size(this.Size.Width, this.Size.Height - 54);
            UserPanel.Size = this.Size;
            lblEnteredMystat.Location = new Point(lblEnteredMystat.Location.X + 50, lblEnteredMystat.Location.Y);
            guna2RadioButton3.Location = new Point(guna2RadioButton3.Location.X + 50, guna2RadioButton3.Location.Y);
            guna2RadioButton2.Location = new Point(guna2RadioButton2.Location.X + 50, guna2RadioButton2.Location.Y);
            RadioButtonRed.Location = new Point(RadioButtonRed.Location.X + 50, RadioButtonRed.Location.Y);
            guna2ComboBox1.Location = new Point(guna2ComboBox1.Location.X + 50, guna2ComboBox1.Location.Y);
            guna2ComboBox2.Location = new Point(guna2ComboBox2.Location.X + 50, guna2ComboBox2.Location.Y);
            Diamond1.Location = new Point(Diamond1.Location.X + 50, Diamond1.Location.Y);
            Diamond2.Location = new Point(Diamond2.Location.X + 50, Diamond2.Location.Y);
            Diamond3.Location = new Point(Diamond3.Location.X + 50, Diamond3.Location.Y);

            pictureBox2.Location = new Point(pictureBox2.Location.X + 50, pictureBox2.Location.Y);

            lblRey.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            if (string.IsNullOrWhiteSpace(txtComment.Text))
            {
                lblDateTime.Visible = false;
                pictureBox1.Visible = true;
                txtComment.BringToFront();
                txtComment.Visible = false;
                txtComment.Location = new Point(978, 13);
                txtComment.Size = new Size(292, 69);
            }
            else
            {
                lblDateTime.Visible = true;
                lblDateTime.BringToFront();
                pictureBox1.Visible = false;
                txtComment.Visible = true;
                txtComment.Location = new Point(1021, 13);
                txtComment.Size = new Size(249, 40);
                oldText = txtComment.Text;
                txtComment.Enabled = false;
            }
        }
    }
}
