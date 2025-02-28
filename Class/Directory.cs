using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperlessKitting.Class
{
    class Directory
    {
        private bool isDebug = Properties.Settings.Default.IsDebug;

        public string DirDefault()
        {
            string dir = string.Empty;

            try
            {
                if (isDebug == true)
                {
                    dir = @"B:\Users BACKUP\NBCP-LT-144\Desktop\Attachment\Production\3_KITTING\KITTING FORM";
                }
                else
                {
                    dir = @"\\192.168.20.11\Production\3_KITTING\KITTING FORM";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dir;
        }

        public string DirFormType(int i)
        {
            string dir = string.Empty;

            try
            {
                switch (i)
                {
                    case 1:
                        dir =  @"1 DAILY OPERATION REPORT";
                        break;

                    case 2:
                        dir =  @"2 DAILY OPERATION REPORT (LEVERCON)";
                        break;

                    case 3:
                        dir =  @"3 DUMMY SEAL_CLIP CLAMP";
                        break;

                    case 4:
                        dir =  @"4 JOINTED WIRE";
                        break;

                    case 5:
                        dir =  @"5 WIRE TAPING-PARTS PREP";
                        break;

                    case 6:
                        dir =  @"6 WIRE TAPING";
                        break;

                    case 7:
                        dir =  @"7 COT WITH SLIT";
                        break;

                    case 8:
                        dir =  @"8 RAW MATERIALS";
                        break;

                    default:
                        dir =  @"8 RAW MATERIALS";
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dir;
        }

        public string DirTemplate(int i)
        {
            string dir = string.Empty;
            
            try
            {
                switch (i)
                {
                    case 1:
                        dir = Path.Combine(DirDefault(), @"TEMPLATES\Daily Operation Report.xlsm");
                        break;

                    case 2:
                        dir = Path.Combine(DirDefault(), @"TEMPLATES\(BOX 1) Daily Operation Report.xlsx");
                        break;

                    case 3:
                        dir = Path.Combine(DirDefault(), @"TEMPLATES\Daily Operation Report (DUMMY SEAL INSERTION).xlsx");
                        break;

                    case 4:
                        dir = Path.Combine(DirDefault(), @"TEMPLATES\Daily Operation Report (JOINTED WIRE).xlsx");
                        break;

                    case 5:
                        dir = Path.Combine(DirDefault(), @"TEMPLATES\Daily Operation Report (PARTS SETTING FOR WIRE TAPING).xlsx");
                        break;

                    case 6:
                        dir = Path.Combine(DirDefault(), @"TEMPLATES\Daily Operation Report (WIRE TAPING PROCESS).xlsx");
                        break;

                    case 7:
                        dir = Path.Combine(DirDefault(), @"TEMPLATES\Daily Operation Report (COT WITH SLIT).xlsx");
                        break;

                    case 8:
                        dir = Path.Combine(DirDefault(), @"TEMPLATES\Loose Parts Monitoring.xlsm");
                        break;

                    default:
                        dir = Path.Combine(DirDefault(), @"TEMPLATES\Loose Parts Monitoring.xlsm");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dir;
        }

        public string DirTemplate2(int i)
        {
            string dir = string.Empty;

            try
            {
                switch (i)
                {
                    case 2:
                        dir = Path.Combine(DirDefault(), @"TEMPLATES\(BOX 2) Daily Operation Report.xlsx");
                        break;

                    default:
                        dir = Path.Combine(DirDefault(), @"TEMPLATES\(BOX 2) Daily Operation Report.xlsx");
                        break;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dir;
        }

        public string TemplateName(int i)
        {
            string name = string.Empty;

            try
            {
                switch (i)
                {
                    case 1:
                        name = "Daily Operation Report.xlsx";
                        break;

                    case 2:
                        name = "Daily Operation Report (Levercon).xlsx";
                        break;

                    case 3:
                        name = "Daily Operation Report (Dummy Seal Insertion).xlsx";
                        break;

                    case 4:
                        name = "Daily Operation Report (Jointed Wire).xlsx";
                        break;

                    case 5:
                        name = "Daily Operation Report (Parts Setting for Wire Taping).xlsx";
                        break;

                    case 6:
                        name = "Daily Operation Report (Wire Taping Process).xlsx";
                        break;

                    case 7:
                        name = "Daily Operation Report (COT WITH SLIT).xlsx";
                        break;

                    case 8:
                        name = "Loose Parts Monitoring.xlsm";
                        break;

                    default:
                        name = "Loose Parts Monitoring.xlsm";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return name;
        }

        public string DirLiveForm(DateTime dt, int formId)
        {
            string dir = string.Empty;

            try
            {
                dir = Path.Combine(DirDefault(), dt.ToString("yyyy"), MonthNumber(dt.ToString("MMMM")) + " " + dt.ToString("MMMM"), DirFormType(formId));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dir;
        }

        public int MonthNumber(string monthName)
        {
            int monthNo = 0;

            try
            {
                switch (monthName)
                {
                    case "January":
                        monthNo = 1;
                        break;

                    case "February":
                        monthNo = 2;
                        break;

                    case "March":
                        monthNo = 3;
                        break;

                    case "April":
                        monthNo = 4;
                        break;

                    case "May":
                        monthNo = 5;
                        break;

                    case "June":
                        monthNo = 6;
                        break;

                    case "July":
                        monthNo = 7;
                        break;

                    case "August":
                        monthNo = 8;
                        break;

                    case "September":
                        monthNo = 9;
                        break;

                    case "October":
                        monthNo = 10;
                        break;

                    case "November":
                        monthNo = 11;
                        break;

                    case "December":
                        monthNo = 12;
                        break;

                    default:
                        monthNo = 1;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return monthNo;
        }
    }
}
