using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ExcelReportBuilder : ReportBuilder<Employee>
    {
        public ExcelReportBuilder(Employee obj) : base(obj)
        {
        }

        public override void SetBody()
        {
            _report.Body = $"This is excel body {_obj.FirstName}, {_obj.LastName}";
        }

        public override void SetContent()
        {
            _report.Content = $"This is excel content {_obj.ID}";
        }

        public override void SetFooter()
        {
            _report.Footer = $"This is excel footer {_obj.Address}";
        }

        public override void SetHeader()
        {
            _report.Header = $"This is excel header {_obj.Department}";
        }
    }
}
