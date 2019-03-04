using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinitabApplication.Handler
{
    class ExcelHandler
    {
        private string fileName = null;
        private IWorkbook workbook = null;

        public ExcelHandler(string filename)
        {
            this.fileName = filename;
        }

        /// <summary>
        /// Excel读取成DataTable,多个Sheet用字典存储
        /// </summary>
        public Dictionary<string,DataTable> ExcelToTable() 
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                ISheet sheet = null;
                Dictionary<string, DataTable> Map = new Dictionary<string, DataTable>();
                try
                {

                    if (fileName.IndexOf(".xlsx") > 0)
                        workbook = new XSSFWorkbook(fs);
                    else if (fileName.IndexOf(".xls") > 0)
                        workbook = new HSSFWorkbook(fs);
                    for (int s = 0; s < workbook.NumberOfSheets; s++)
                    {
                        DataTable dt = new DataTable();
                        sheet = workbook.GetSheetAt(s);
                        string sheetName = sheet.SheetName;
                        IRow row = sheet.GetRow(sheet.FirstRowNum);//第一行为表头名
                        //IRow row1 = sheet.GetRow(sheet.FirstRowNum+1);//第二行用来获取数据类型
                        int lastRow = sheet.LastRowNum + 1;
                        int lastColumn = row.LastCellNum;

                        //DataTable 创建默认类型为string的列
                        for (int c = 0; c < lastColumn; c++)
                        {
                            ICell cell = row.GetCell(c);
                            if (cell == null) continue;
                            //Type type = System.Type.GetType("System." + (row1.GetCell(c).CellType.ToString() == "Numeric" 
                            //    ?(DateUtil.IsCellDateFormatted(row1.GetCell(c))?"DateTime":"Double") : row1.GetCell(c).CellType.ToString()));
                            DataColumn dc = new DataColumn(cell.ToString());//,type
                            dt.Columns.Add(dc);
                        }

                        //DataTable添加行数据
                        for ( int r = 1; r <= lastRow; r++)
                        {
                            DataRow dr = dt.NewRow();
                            if (sheet.GetRow(r) == null) continue;
                            int columnCheckCount = 0;//check one row whether is null or not
                            for (int c = 0; c < sheet.GetRow(r).LastCellNum; c++)
                            {
                                ICell cell = sheet.GetRow(r).GetCell(c);
                                if (cell == null) continue;
                                if (cell.ToString().Trim().Length > 0)
                                    columnCheckCount++;
                                //dr[c] = GetValueType(cell);
                                dr[c] = cell.ToString();
                            }
                            if (columnCheckCount != 0)
                                dt.Rows.Add(dr);
                        }
                        Map.Add(sheetName, dt);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Map;
            }
        }

        /// <summary>
        /// DataTable保存为Excel
        /// </summary>
        public void TableToExcel(DataTable dt) {
            if (Path.GetExtension(fileName) == ".xls")
                workbook = new HSSFWorkbook();
            else if (Path.GetExtension(fileName) == ".xlsx")
                workbook = new XSSFWorkbook();
            else
                return;
            ISheet sheet= workbook.CreateSheet(string.IsNullOrEmpty(dt.TableName)?"Sheet1":dt.TableName);
            //表头
            IRow row = sheet.CreateRow(0);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                ICell cell = row.CreateCell(i);
                cell.SetCellValue(dt.Columns[i].ColumnName);
            }
            //行数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                IRow ir = sheet.CreateRow(i+1);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ICell cell = ir.CreateCell(j);
                    cell.SetCellValue(dt.Rows[i][j].ToString());
                }
            }

            //转为字节数组  
            MemoryStream stream = new MemoryStream();
            workbook.Write(stream);
            var buf = stream.ToArray();

            //保存为Excel文件  
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                fs.Write(buf, 0, buf.Length);
                fs.Flush();
            }
        }

        public void TableToExcel(DataTable dt,Image img)
        {
            if (Path.GetExtension(fileName) == ".xls")
                workbook = new HSSFWorkbook();
            else if (Path.GetExtension(fileName) == ".xlsx")
                workbook = new XSSFWorkbook();
            else
                return;
            ISheet sheet = workbook.CreateSheet(string.IsNullOrEmpty(dt.TableName) ? "Sheet1" : dt.TableName);


            MemoryStream ms=new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            HSSFPatriarch patriarch =(HSSFPatriarch)sheet.CreateDrawingPatriarch();
            HSSFClientAnchor anchor = new HSSFClientAnchor(0, 0, 1023, 255,2,2,14,34);
            HSSFPicture pict = (HSSFPicture)patriarch.CreatePicture(anchor, workbook.AddPicture(ms.ToArray(),PictureType.PNG));
            pict.Resize();
            ms.Close();
            //表头
            IRow row = sheet.CreateRow(anchor.Row2+1);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                ICell cell = row.CreateCell(i);
                cell.SetCellValue(dt.Columns[i].ColumnName);
            }
            //行数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                IRow ir = sheet.CreateRow(i + anchor.Row2 + 2);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ICell cell = ir.CreateCell(j);
                    cell.SetCellValue(dt.Rows[i][j].ToString());
                }
            }

            //转为字节数组  
            MemoryStream stream = new MemoryStream();
            workbook.Write(stream);
            var buf = stream.ToArray();

            //保存为Excel文件  
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                fs.Write(buf, 0, buf.Length);
                fs.Flush();
            }
        }

        /// <summary>
        /// 返回单元格对应的类型值
        /// </summary>
        private static object GetValueType(ICell cell)
        {
            if (cell == null)
                return null;
            switch (cell.CellType)
            {
                case CellType.Blank: //BLANK:  
                    return null;
                case CellType.Boolean: //BOOLEAN:  
                    return cell.BooleanCellValue;
                case CellType.Numeric: //NUMERIC:  
                    if(DateUtil.IsCellDateFormatted(cell))
                        return cell.DateCellValue;
                    else
                        return cell.NumericCellValue;
                case CellType.String: //STRING:  
                    return cell.StringCellValue;
                case CellType.Error: //ERROR:  
                    return cell.ErrorCellValue;
                case CellType.Formula: //FORMULA:  
                default:
                    return "=" + cell.CellFormula;
            }
        }
    }
}
