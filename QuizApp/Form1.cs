using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public static Form1 Instance { get; private set; }
        private DevExpress.XtraEditors.XtraForm activeForm = null;
        private string pathWay = null;
        public Form1()
        {
            
            InitializeComponent();
            Instance = this;
        }
        private void openChildForm(DevExpress.XtraEditors.XtraForm childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void closeChildForm()
        {
            if (activeForm != null)
            {

                activeForm.Close();
                activeForm = null;
            }
        }
        private void btnOkay_Click(object sender, EventArgs e)
        {
            if(pathWay != null && pathWay != "")
            {
                openChildForm(new QuizForm(pathWay));
            }
            else
            {
                XtraMessageBox.Show("Lütfen .json formatında bir dosya seçiniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathWay = openFileDialog.FileName;
                txtFilePath.Text = pathWay;
            }
        }
    }
}
