using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaperlessKitting.Class;

namespace PaperlessKitting
{
    public partial class Main : Form
    {
        private Directory directory = new Directory();
        private bool isDebug = Properties.Settings.Default.IsDebug;

        public Main()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDor_Click(object sender, EventArgs e)
        {
            openFormSearcher(1);
        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            openFormSearcher(2);
        }

        private void btnDummySeal_Click(object sender, EventArgs e)
        {
            openFormSearcher(3);
        }

        private void btnJointedWire_Click(object sender, EventArgs e)
        {
            openFormSearcher(4);
        }

        private void btnWireTapingPrep_Click(object sender, EventArgs e)
        {
            openFormSearcher(5);
        }

        private void btnWireTaping_Click(object sender, EventArgs e)
        {
            openFormSearcher(6);
        }

        private void btnCotSlit_Click(object sender, EventArgs e)
        {
            openFormSearcher(7);
        }

        private void btnLooseParts_Click(object sender, EventArgs e)
        {
            openFormSearcher(8);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            this.Text += " " + Application.ProductVersion.ToString();

            string hostname = WindowsIdentity.GetCurrent().Name.Split('\\')[0];
            if (hostname.ToString().Length >= 15) //check if one of the NBPVSPACESERVER
            {
                if (hostname.ToString().Substring(0, 15) == "NBPVSPACESERVER") //if yes
                {
                    lblLine.Text = Environment.UserName.ToString().Trim();
                }
                else //if no
                {
                    lblLine.Text = Environment.MachineName.ToString().Trim();
                }
            }
            else
            {
                lblLine.Text = Environment.MachineName.ToString().Trim();
            }

            this.ActiveControl = dtpDate;
        }

        void openFormSearcher(int _formId)
        {
            FormSearcher frm = new FormSearcher(_formId);
            frm.date = dtpDate.Value;
            this.Hide();
            frm.Show();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                e.Handled = true;
                switch (e.KeyCode)
                {
                    case Keys.D1:
                    case Keys.NumPad1:
                        btnDor.PerformClick();
                        break;

                    case Keys.D2:
                    case Keys.NumPad2:
                        btnDorLev.PerformClick();
                        break;

                    case Keys.D3:
                    case Keys.NumPad3:
                        btnDummySeal.PerformClick();
                        break;

                    case Keys.D4:
                    case Keys.NumPad4:
                        btnJointedWire.PerformClick();
                        break;

                    case Keys.D5:
                    case Keys.NumPad5:
                        btnWireTapingPrep.PerformClick();
                        break;

                    case Keys.D6:
                    case Keys.NumPad6:
                        btnWireTaping.PerformClick();
                        break;

                    case Keys.D7:
                    case Keys.NumPad7:
                        btnCotSlit.PerformClick();
                        break;

                    case Keys.D8:
                    case Keys.NumPad8:
                        btnLooseParts.PerformClick();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
