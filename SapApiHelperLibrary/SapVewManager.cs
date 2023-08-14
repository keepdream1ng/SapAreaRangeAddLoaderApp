using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapApiHelperLibrary
{
    public class SapVewManager
    {
        public void RefreshWindow()
        {
            SapConnector.Model.View.RefreshWindow();
        }
        public void RefreshView()
        {
            SapConnector.Model.View.RefreshView();
        }
    }
}
