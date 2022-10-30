using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetLight_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ////SLDocument sl = new SLDocument();
            ////sl.SaveAs("MaNewClothes.xlsx");

            //using (SLDocument sl = new SLDocument("MahNewShoes.xlsx"))
            //{
            //    //sl.SetCellValue("B3", "It costs what for a Jimmy choo?!?");
            //    SLPicture pic = new SLPicture("chess.png");
            //    pic.SetPosition(5, 5);
            //    sl.InsertPicture(pic);
            //    sl.SaveAs("MahNewShoes.xlsx");
            //}

            //Console.WriteLine("ExcelCreated! :)");

            SLDocument sl = new SLDocument();

            SLDataValidation dv;

            dv = sl.CreateDataValidation("B3");
            // equal to 5 and ignore blanks
            dv.AllowWholeNumber(SLDataValidationSingleOperandValues.Equal, 5, true);
            sl.AddDataValidation(dv);

            dv = sl.CreateDataValidation("B4");
            // is between 0.1 and 7.4 (set the first boolean to false for "not between").
            // And don't ignore blanks (last boolean).
            dv.AllowDecimal(true, 0.1, 7.4, false);
            sl.AddDataValidation(dv);

            sl.SetCellValue("B1", "Apple");
            sl.SetCellValue("C1", "Banana");
            sl.SetCellValue("D1", "Cherry");
            sl.SetCellValue("E1", "Durian");
            sl.SetCellValue("F1", "Elderberry");

            dv = sl.CreateDataValidation("B5");
            // true to ignore blanks
            // true to have in-cell dropdown
            dv.AllowList(SLConvert.ToCellRange(1, 2, 1, 6, true), true, true);
            // The ToCellRange() lets you create absolute/relative references easily.
            // Or you could do it by hand:
            //dv.AllowList("$B$1:$F$1", true, true);
            sl.AddDataValidation(dv);

            dv = sl.CreateDataValidation("B6");
            // dates greater than 9 May 3141 and ignore blanks.
            dv.AllowDate(SLDataValidationSingleOperandValues.GreaterThan, new DateTime(3141, 5, 9), true);
            sl.AddDataValidation(dv);

            dv = sl.CreateDataValidation("B7");
            // time less than or equal to 3:34:48 PM (15 is military time for 3PM).
            // Oh yeah, and ignore blanks.
            dv.AllowTime(SLDataValidationSingleOperandValues.LessThanOrEqual, 15, 34, 48, true);
            sl.AddDataValidation(dv);

            dv = sl.CreateDataValidation("B8");
            // allow text lengths not equal to 8 characters
            // Oh yeah, and ignore blanks.
            dv.AllowTextLength(SLDataValidationSingleOperandValues.NotEqual, 8, true);
            sl.AddDataValidation(dv);

            // It's custom, but I don't really understand what's going on. Really...
            dv = sl.CreateDataValidation("B9");
            // any formula will do here. I'm using a simple one
            dv.AllowCustom("5+8", true);
            sl.AddDataValidation(dv);

            dv = sl.CreateDataValidation("B10");
            // is between 3 and 8 and ignore blanks
            dv.AllowWholeNumber(true, 3, 8, true);
            dv.SetInputMessage("Whole foods!", "We only accept 3 to 8 buns at a time.");
            dv.SetErrorAlert(DataValidationErrorStyleValues.Warning, "Uh uh uh...", "You didn't give the magic number...");
            sl.AddDataValidation(dv);

            sl.SaveAs("DataValidations.xlsx");

            Console.WriteLine("End of program");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
