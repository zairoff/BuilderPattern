using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class ReportBuilder<T> 
    {
        protected readonly T _obj;

        protected Report _report;

        protected ReportBuilder(T obj)
        {
            _obj = obj;
        }

        public abstract void SetHeader();

        public abstract void SetContent();

        public abstract void SetBody();

        public abstract void SetFooter();

        public void CreatReport()
        {
            _report = new Report();
        }

        public Report GetReport()
        {
            return _report;
        }
    }
}
