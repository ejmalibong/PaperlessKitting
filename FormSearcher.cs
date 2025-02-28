using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaperlessKitting.Class;
using System.Runtime;
using System.IO;
using System.Diagnostics;
using OfficeOpenXml;

namespace PaperlessKitting
{
    public partial class FormSearcher : Form
    {
        int formId = 0;
        private Class.Directory directory = new Class.Directory();
        private string dorPass = Properties.Settings.Default.DorPass;
        ModelValidator validator = new ModelValidator();

        public DateTime date { get; set; }

        public FormSearcher(int _i)
        {
            InitializeComponent();
            formId = _i;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            this.Close();
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtModel.Text.Trim()))
                {
                    MessageBox.Show("Please scan ID tag or type product model.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = txtModel;
                    return;
                }

                string model;
                string[] arrSplit;

                arrSplit = txtModel.Text.Trim().Split(null);

                if (arrSplit.Length == 3) //Prod id tag was scanned
                {
                    model = arrSplit[0].ToString();
                    txtModel.Text = arrSplit[0].ToString().Trim();
                }
                else
                {
                    model = txtModel.Text.Trim();
                }

                if (!validator.IsModelValid(model))
                {
                    MessageBox.Show("Invalid model.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = txtModel;
                    return;
                }

                string msg = Path.GetFileNameWithoutExtension(directory.DirTemplate(formId));
                if (!System.IO.Directory.Exists(directory.DirLiveForm(date, formId)))
                {
                    MessageBox.Show(msg + " folder does not exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (formId == 2)
                {
                    string msg2 = Path.GetFileNameWithoutExtension(directory.DirTemplate2(formId));
                    if (!System.IO.Directory.Exists(directory.DirLiveForm(date, formId)))
                    {
                        MessageBox.Show(msg2 + " folder does not exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string[] excelFiles1 = System.IO.Directory.GetFiles(directory.DirLiveForm(date, formId), "*(BOX 1) Daily Operation Report.*");
                    string targetFile1 = excelFiles1
                        .FirstOrDefault(f => Path.GetFileNameWithoutExtension(f).StartsWith(model + " "));

                    string[] excelFiles2 = System.IO.Directory.GetFiles(directory.DirLiveForm(date, formId), "*(BOX 2) Daily Operation Report.*");
                    string targetFile2 = excelFiles2
                        .FirstOrDefault(f => Path.GetFileNameWithoutExtension(f).StartsWith(model + " "));

                    if (targetFile1 == null)
                    {
                        MessageBox.Show("Form BOX 1 not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (targetFile2 == null)
                    {
                        MessageBox.Show("Form BOX 2 not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (targetFile1 != null  && targetFile2 != null)
                    {
                        Process prc = new Process();
                        prc.StartInfo.FileName = targetFile1;
                        prc.StartInfo.Arguments = "-n";
                        prc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                     
                        Process prc2 = new Process();
                        prc2.StartInfo.FileName = targetFile2;
                        prc2.StartInfo.Arguments = "-n";
                        prc2.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                        prc.Start();
                        prc2.Start();

                        prc.WaitForExit();
                        prc2.WaitForExit();
                    }
                } else
                {
                    // Search for a file that starts with the model name followed by a space
                    string[] excelFiles = System.IO.Directory.GetFiles(directory.DirLiveForm(date, formId), "*.*"); // Get all Excel files
                    string targetFile = excelFiles
                        .FirstOrDefault(f => Path.GetFileNameWithoutExtension(f).StartsWith(model + " "));

                    if (targetFile != null)
                    {
                        Process prc = new Process();
                        prc.StartInfo.FileName = targetFile;
                        prc.StartInfo.Arguments = "-n";
                        prc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                        prc.Start();
                        prc.WaitForExit();
                    }
                    else
                    {
                        MessageBox.Show("Form not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFormSearcher_Load(object sender, EventArgs e)
        {
            this.Activate();
            this.ActiveControl = txtModel;

            if (!btnCreate.Visible)
            {
                this.AcceptButton = btnSearch;
            }
            else
            {
                this.AcceptButton = btnCreate;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtModel.Text.Trim()))
                {
                    MessageBox.Show("Please scan ID tag or type product model.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = txtModel;
                    return;
                }

                string model;
                string qty;
                string lotNo;
                string[] arrSplit;

                arrSplit = txtModel.Text.Trim().Split(null);

                if (arrSplit.Length == 3) // Prod id tag was scanned
                {
                    model = arrSplit[0].ToString();
                    qty = arrSplit[1].ToString();
                    lotNo = arrSplit[2].ToString();
                    txtModel.Text = arrSplit[0].ToString().Trim();
                }
                else
                {
                    model = txtModel.Text.Trim();
                    qty = string.Empty;
                    lotNo = string.Empty;
                }

                if (!validator.IsModelValid(model))
                {
                    MessageBox.Show("Invalid model.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = txtModel;
                    return;
                }

                string msg = Path.GetFileNameWithoutExtension(directory.DirTemplate(formId));

                if (!System.IO.Directory.Exists(directory.DirLiveForm(date, formId)))
                {
                    MessageBox.Show(msg + " folder does not exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (formId == 2)
                {
                    if (!File.Exists(directory.DirTemplate(formId)))
                    {
                        MessageBox.Show("(BOX 1) DOR template does not exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!File.Exists(directory.DirTemplate2(formId)))
                    {
                        MessageBox.Show("(BOX 2) DOR template does not exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                } else
                {
                    if (!File.Exists(directory.DirTemplate(formId)))
                    {
                        MessageBox.Show(msg + " template does not exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (formId == 2)
                {
                    string file = directory.DirLiveForm(date, formId) + "\\" + model + " " + Path.GetFileName(directory.DirTemplate(formId));
                    string file2 = directory.DirLiveForm(date, formId) + "\\" + model + " " + Path.GetFileName(directory.DirTemplate2(formId));

                    string[] excelFiles1 = System.IO.Directory.GetFiles(directory.DirLiveForm(date, formId), "*(BOX 1) Daily Operation Report.*");
                    string targetFile1 = excelFiles1
                        .FirstOrDefault(f => Path.GetFileNameWithoutExtension(f).StartsWith(model + " "));

                    string[] excelFiles2 = System.IO.Directory.GetFiles(directory.DirLiveForm(date, formId), "*(BOX 2) Daily Operation Report.*");
                    string targetFile2 = excelFiles2
                        .FirstOrDefault(f => Path.GetFileNameWithoutExtension(f).StartsWith(model + " "));

                    if (targetFile1 != null)
                    {
                        string template = Path.GetFileNameWithoutExtension(directory.DirTemplate(formId));
                        MessageBox.Show(model + " " + template + " already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (targetFile2 != null)
                    {
                        string template = Path.GetFileNameWithoutExtension(directory.DirTemplate2(formId));
                        MessageBox.Show(model + " " + template + " already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (targetFile1 == null && targetFile2 == null)
                    {
                        File.Copy(directory.DirTemplate(formId), file, false);
                        File.Copy(directory.DirTemplate2(formId), file2, false);
                    }

                    FileInfo fileInfo1 = new FileInfo(file);
                    using (ExcelPackage package1 = new ExcelPackage(fileInfo1))
                    {
                        ExcelWorkbook workbook = package1.Workbook;

                        // Since this project targets .NET 4.5, index starts with 1
                        ExcelWorksheet sheet = package1.Workbook.Worksheets[1]; // Get first sheet

                        // Unprotect the sheet using the password
                        string sheetPassword = dorPass;  // Sheet password
                        sheet.Protection.IsProtected = false;
                        sheet.Protection.SetPassword(sheetPassword); // Unprotect the sheet

                        // Move horizontal scroll bar one column left
                        sheet.View.FreezePanes(1, 2);
                        sheet.View.UnFreezePanes();

                        sheet.View.ActiveCell = "A11";
                        sheet.View.ZoomScale = 35;
                        sheet.Cells[5, 3].Value = model;
                        sheet.Cells[5, 3].Style.Locked = true;
                        sheet.Cells[5, 24].Value = qty;
                        sheet.Cells[5, 24].Style.Locked = true;

                        // Reapply sheet protection with the same password
                        sheet.Protection.SetPassword(sheetPassword);
                        sheet.Protection.IsProtected = true;

                        // Save the file while preserving macros
                        package1.Save();
                    }

                    FileInfo fileInfo2 = new FileInfo(file2);
                    using (ExcelPackage package2 = new ExcelPackage(fileInfo2))
                    {
                        ExcelWorkbook workbook = package2.Workbook;

                        // Since this project targets .NET 4.5, index starts with 1
                        ExcelWorksheet sheet = package2.Workbook.Worksheets[1]; // Get first sheet

                        // Unprotect the sheet using the password
                        string sheetPassword = dorPass;  // Sheet password
                        sheet.Protection.IsProtected = false;
                        sheet.Protection.SetPassword(sheetPassword); // Unprotect the sheet

                        // Move horizontal scroll bar one column left
                        sheet.View.FreezePanes(1, 2);
                        sheet.View.UnFreezePanes();

                        sheet.View.ActiveCell = "A11";
                        sheet.View.ZoomScale = 35;
                        sheet.Cells[5, 2].Value = model;
                        sheet.Cells[5, 2].Style.Locked = true;
                        sheet.Cells[5, 19].Value = qty;
                        sheet.Cells[5, 19].Style.Locked = true;

                        // Reapply sheet protection with the same password
                        sheet.Protection.SetPassword(sheetPassword);
                        sheet.Protection.IsProtected = true;

                        // Save the file while preserving macros
                        package2.Save();
                    }

                    Process prc = new Process();
                    prc.StartInfo.FileName = file;
                    prc.StartInfo.Arguments = "-n";
                    prc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                    Process prc2 = new Process();
                    prc2.StartInfo.FileName = file2;
                    prc2.StartInfo.Arguments = "-n";
                    prc2.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                    prc.Start();
                    prc2.Start();

                    prc.WaitForExit();
                    prc2.WaitForExit();

                } else
                {
                    string file = directory.DirLiveForm(date, formId) + "\\" + model + " " + Path.GetFileName(directory.DirTemplate(formId));
                    string[] excelFiles = System.IO.Directory.GetFiles(directory.DirLiveForm(date, formId), "*.*");
                    string targetFile = excelFiles
                        .FirstOrDefault(f => Path.GetFileNameWithoutExtension(f).StartsWith(model + " "));

                    if (targetFile != null)
                    {
                        string template = Path.GetFileNameWithoutExtension(directory.DirTemplate(formId));
                        MessageBox.Show(model + " " + template + " already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        File.Copy(directory.DirTemplate(formId), file, false);
                    }

                    FileInfo fileInfo = new FileInfo(file);
                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        ExcelWorkbook workbook = package.Workbook;

                        // Since this project targets .NET 4.5, index starts with 1
                        ExcelWorksheet sheet = package.Workbook.Worksheets[1]; // Get first sheet

                        // Unprotect the sheet using the password
                        string sheetPassword = dorPass;  // Sheet password
                        sheet.Protection.IsProtected = false;
                        sheet.Protection.SetPassword(sheetPassword); // Unprotect the sheet

                        // Move horizontal scroll bar one column left
                        sheet.View.FreezePanes(1, 2);
                        sheet.View.UnFreezePanes();

                        switch (formId)
                        {
                            case 1: //dor
                                sheet.View.ActiveCell = "A8";
                                sheet.View.ZoomScale = 30;
                                sheet.Cells[3, 3].Value = model;
                                sheet.Cells[3, 3].Style.Locked = true;
                                sheet.Cells[3, 24].Value = qty;
                                sheet.Cells[3, 24].Style.Locked = true;
                                break;

                            case 3: //dummy seal
                                sheet.View.ActiveCell = "C11";
                                sheet.View.ZoomScale = 100;
                                sheet.Cells[5, 3].Value = model;
                                sheet.Cells[5, 3].Style.Locked = true;
                                sheet.Cells[6, 3].Value = qty;
                                sheet.Cells[6, 3].Style.Locked = true;
                                sheet.Cells[5, 14].Value = date.ToString("MMMM yyyy");
                                sheet.Cells[5, 14].Style.Locked = true;
                                break;

                            case 4: //jointed wire
                                sheet.View.ActiveCell = "C14";
                                sheet.View.ZoomScale = 85;
                                sheet.Cells[2, 3].Value = model;
                                sheet.Cells[2, 3].Style.Locked = true;
                                sheet.Cells[2, 25].Value = date.ToString("MMMM yyyy");
                                sheet.Cells[2, 25].Style.Locked = true;
                                break;

                            case 5: //parts prep - wt
                                sheet.View.ActiveCell = "A7";
                                sheet.View.ZoomScale = 100;
                                sheet.Cells[2, 3].Value = model;
                                sheet.Cells[2, 3].Style.Locked = true;
                                sheet.Cells[2, 11].Value = date.ToString("MMMM yyyy");
                                sheet.Cells[2, 11].Style.Locked = true;
                                break;

                            case 6: //wire taping
                                sheet.View.ActiveCell = "C12";
                                sheet.View.ZoomScale = 80;
                                sheet.Cells[2, 3].Value = model;
                                sheet.Cells[2, 3].Style.Locked = true;
                                sheet.Cells[2, 25].Value = date.ToString("MMMM yyyy");
                                sheet.Cells[2, 25].Style.Locked = true;
                                break;

                            case 7: //cot with slit
                                sheet.View.ActiveCell = "A12";
                                sheet.View.ZoomScale = 85;
                                sheet.Cells[6, 3].Value = model;
                                sheet.Cells[6, 3].Style.Locked = true;
                                sheet.Cells[6, 11].Value = date.ToString("MMMM yyyy");
                                sheet.Cells[6, 11].Style.Locked = true;
                                break;

                            case 8: //loose parts
                                sheet.View.ActiveCell = "A5";
                                sheet.View.ZoomScale = 200;
                                sheet.Cells[3, 2].Value = model;
                                sheet.Cells[3, 2].Style.Locked = true;
                                break;

                            default:
                                sheet.View.ActiveCell = "A5";
                                sheet.View.ZoomScale = 200;
                                sheet.Cells[3, 2].Value = model;
                                sheet.Cells[3, 2].Style.Locked = true;
                                break;
                        }

                        // Reapply sheet protection with the same password
                        sheet.Protection.SetPassword(sheetPassword);
                        sheet.Protection.IsProtected = true;

                        // Save the file while preserving macros
                        package.Save();
                    }

                    Process prc = new Process();
                    prc.StartInfo.FileName = file;
                    prc.StartInfo.Arguments = "-n";
                    prc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    prc.Start();
                    prc.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
