using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP2000v1;

namespace SapApiHelperLibrary
{
    public static class SapConnector
    {
        //dimension the SapObject as cOAPI type
        public static cOAPI mySapObject { get; private set; }
        public static cSapModel Model { get; private set; }
        public static cHelper myHelper { get; private set; }

        public static void ConnectToSap()
        {
            //create API helper object
            try
            {
                myHelper = new Helper();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot create an instance of the Helper object");
                return;
            }

            //attach to a running instance of SAP2000
            try
            {
                //get the active SapObject
                mySapObject = myHelper.GetObject("CSI.SAP2000.API.SapObject");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No running instance of the program found or failed to attach.");
                return;
            }

            //create SapModel object
            Model = mySapObject.SapModel;
        }

        public static void CloseConnectionToSap()
        {
            //close SAP2000

            myHelper = null;
            Model = null;
            mySapObject = null;
        }
    }
}
