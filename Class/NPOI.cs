namespace PaperlessKitting.Class
{
    internal class NPOI
    {
        /// <summary>Set view position at given coordinates.</summary>
        /// <param name="sheet">A reference to the Excel sheet.</param>
        /// <param name="topLeftCell">The coordinates of the cell that will show in top left corner when you open the Excel sheet (example: "A1").</param>
        /// <param name="onlyFirstView">If true, only first sheet view will have position adjusted. If false, every views from the sheet will have have position adjusted.</param>
        public static void SetViewPosition(ref global::NPOI.SS.UserModel.ISheet sheet, string topLeftCell = "A1", bool onlyFirstView = true)
        {
            global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet worksheet = (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet)(typeof(global::NPOI.XSSF.UserModel.XSSFSheet).GetField("worksheet", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue((global::NPOI.XSSF.UserModel.XSSFSheet)sheet));
            if (worksheet?.sheetViews?.sheetView != null && worksheet.sheetViews.sheetView.Count > 0)
            {
                if (onlyFirstView)
                    worksheet.sheetViews.sheetView[0].topLeftCell = topLeftCell;
                else
                    foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetView view in worksheet.sheetViews.sheetView)
                        view.topLeftCell = topLeftCell;
            }
        }
    }
}