using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SapApiHelperLibrary;
using SAP2000v1;

namespace SapAreaRangeAddLoader
{
    public static class AreaLoader
    {
        public static SapLoadsManager LoadManager = new SapLoadsManager();
        public static string LoadPrefix = string.Empty;
        public static double LoadValue = 1.0;

        public static bool CreateAndApplyLoadsForSelectedAreas()
        {
            string[] areasNames = SelectionManager.GetSelectedObjectsNames(SapObjectType.Area);
            // Program will not apply loads to objects if loads or combo names had problems with creation.
            return (
                CreateLoadsAndComboForAreas(areasNames, out string[] loadNames)
                &&
                ApplyLoadForAreaAndNamePairs(areasNames, loadNames)
                );
        }
        private static bool CreateLoadsAndComboForAreas(string[] areasNames, out string[] loadNames)
        {
            string comboName = $"{LoadPrefix}_range";
            loadNames = null;
            if (SapConnector.Model.RespCombo.Add(comboName, 4) != 0)
                return false;
            loadNames = areasNames.Select(areaName => $"{LoadPrefix}_{areaName}").ToArray();
            var creationResult = loadNames.Select(loadName => LoadManager.CreateNewLoadAndCaseByName(loadName));
            eCNameType type = eCNameType.LoadCase;
            creationResult.Concat(loadNames.Select(loadName => SapConnector.Model.RespCombo.SetCaseList(comboName, ref type, loadName, 1.0)));
            // Check if any of operations were unsuccsesfull.
            return !creationResult.Any(x => x != 0);
        }

        private static bool ApplyLoadForAreaAndNamePairs(string[] areaNames, string[] loadNames)
        {
            var result = areaNames.Select((name, index) => SapConnector.Model.AreaObj.SetLoadUniformToFrame(name, loadNames[index], LoadValue, 11, 2));
            return !result.Any(x => x != 0);
        }
    }
}
