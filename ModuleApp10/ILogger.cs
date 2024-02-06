using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal interface ILogger
    {
        void ShowResult(double value);

        void ColorTheException(Exception ex);

        void Event(string value);
    }
}
