using SAP2000v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapApiHelperLibrary
{
    public static class SelectionManager
    {
        public static string[] GetSelectedObjectsNames(SapObjectType type)
        {
            int objNum = 0;
            int[] objectTypes = null;
            string[] objNames = null;
            int typeToCheckFor = (int)type;
            if ((typeToCheckFor == 0) ||
                (SapConnector.Model.SelectObj.GetSelected(ref objNum, ref objectTypes, ref objNames) != 0) ||
                (objNum == 0))
            {
                return null;
            }
            int objectsWithSelectedType = objectTypes.Where(x => x == typeToCheckFor).Count();
            if (objectsWithSelectedType == objNum)
            {
                return objNames;
            }
            // Some other objects rathen then needed are selected, so we filter objects with passed SapObjectType.
            string[] filteredNames = new string[objectsWithSelectedType];
            for (int i = 0; i < objNum; i++)
            {
                if (objectTypes[i] == typeToCheckFor)
                {
                    filteredNames[--objectsWithSelectedType] = objNames[i];
                }
            }
            return filteredNames;
        }
    }
}
