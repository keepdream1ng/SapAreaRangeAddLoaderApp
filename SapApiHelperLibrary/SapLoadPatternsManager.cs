using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP2000v1;

namespace SapApiHelperLibrary
{
    public class SapLoadPatternsManager
    {
        public eLoadPatternType LoadTypeToCreate { get; set; }

        public int CreateNewLoadAndCaseByName(string name)
        {
            return SapConnector.Model.LoadPatterns.Add(name, LoadTypeToCreate);
        }
    }
}
