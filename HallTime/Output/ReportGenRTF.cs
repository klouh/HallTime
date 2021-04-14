using System;
using System.Collections.Generic;
using System.Text;
using SautinSoft.Document;


namespace HallTime.Output
{
    public class ReportGenRTF:IReportGenerator
    {
        public static string reportDefaultName = "Result.rtf";
        DocumentCore dc = new DocumentCore();

        public bool generate(string data, string fileName)
        {
            dc.Content.End.Insert(data, new CharacterFormat() { FontName = "Veranda", Size = 14, FontColor = Color.Black });
            dc.Save(fileName);

            

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(fileName) { UseShellExecute = true });
            return true;
        }


    }
}
