using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation
{
    class Book  
    {
        public string Title {
            get; set;
        }
        public double Price {
            get; set;
        }
        public string[] Text
        {
            get; set;
        }
        public int Id
        {
            get; set;
        }
        public double Evaluation
        {
            get; set;
        }
        public int NbPages
        {
            get; set;
        }

    }
}
