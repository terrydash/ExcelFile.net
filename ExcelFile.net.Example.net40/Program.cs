﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ExcelFile.net.Example.net40
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var excel = new ExcelFile();
            //excel.Sheet("test sheet");
            //excel.Row().Cell("test1").Cell(2);
            //excel.Row().Cell("test2").Cell(3);
            //excel.Save("a.xls");
            //var excel2 = new ExcelFile();
            //excel2.Sheet("test2 sheet");
            //excel2.Row(25, excel2.NewStyle().Background(HSSFColor.Yellow.Index)).Empty(2).Cell("test1");
            //excel2.Row(15).Empty().Cell(1).Cell(2, excel2.NewStyle().Color(HSSFColor.Red.Index));
            //excel2.Save("b.xls");
            var excel = new ExcelEditor("c.xlsx", true);
            //excel.Set("测试", "sss");
            //excel.Set("测试2", 123.456);
            //excel.Set("测试3", false);
            //excel.Set("测试4", DateTime.Now);
            var testData = new List<ClassA>();
            for (var i = 0; i < 1000; i++)
            {
                testData.Add(new ClassA
                             {
                                 F1 = i.ToString(),
                                 F2 = i * i
                             });
            }
            excel.Set("测试5", testData, false);
            //excel.Set("测试6", testData, false);
            //excel.Set("测试7", new List<ClassA>());
            //excel.Set("测试8", new List<ClassA>(), false);
            excel.Save("d.xlsx");
            //foreach (var sheet in ExcelUtils.New("e.xls", FileMode.Open, FileAccess.Read).AsEnumerable())
            //{
            //    foreach (var row in sheet.AsEnumerable())
            //    {
            //        if (row == null)
            //        {
            //            continue;
            //        }
            //        foreach (var cell in row.AsEnumerable())
            //        {
            //            if (cell == null)
            //            {
            //                Console.WriteLine("null");
            //            }
            //            else if (cell.CellType == CellType.Blank)
            //            {
            //                Console.WriteLine("blank");
            //            }
            //            else if (cell.CellType == CellType.Boolean)
            //            {
            //                Console.WriteLine(cell.BooleanCellValue);
            //            }
            //            else if (cell.CellType == CellType.Numeric)
            //            {
            //                Console.WriteLine(cell.NumericCellValue);
            //            }
            //            else if (cell.CellType == CellType.String)
            //            {
            //                Console.WriteLine(cell.StringCellValue);
            //            }
            //        }
            //    }
            //}

            //var excel = ExcelUtils.New("c.xlsx", FileMode.Open, FileAccess.Read, true);
            //var b = excel.GetSheetAt(0).GetRow(0).GetCell(0).GetBoolean();
            //Console.Read();
        }
    }

    public class ClassA
    {
        public string F1 { get; set; }
        public int F2 { get; set; }
    }
}