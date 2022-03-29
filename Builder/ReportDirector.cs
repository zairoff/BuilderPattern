using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ReportDirector<T>
    {
        public Report MakeFullReport(ReportBuilder<T> reportBuilder)
        {
            reportBuilder.CreatReport();
            reportBuilder.SetHeader();
            reportBuilder.SetContent();
            reportBuilder.SetBody();
            reportBuilder.SetFooter();

            return reportBuilder.GetReport();
        }
    }
}
