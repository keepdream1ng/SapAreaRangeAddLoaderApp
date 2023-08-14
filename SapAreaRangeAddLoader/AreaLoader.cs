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

        public static bool CreateLoadsAndCasesForSelectedAreas()
        {
            string[] areasNames = SelectionManager.GetSelectedObjectsNames(SapObjectType.Area);
            string[] loadNames = areasNames.Select(areaName => $"{LoadPrefix}_{areaName}").ToArray();
            List<int> creationResult = loadNames.Select(loadName => LoadManager.CreateNewLoadAndCaseByName(loadName))
                .ToList();
            string comboName = $"{LoadPrefix}_range";
            creationResult.Add(SapConnector.Model.RespCombo.Add(comboName, 4));
            if (creationResult.Any(x => x != 0))
            {
                return false;
            }
            eCNameType type = eCNameType.LoadCase;
            creationResult = loadNames.Select(loadName => SapConnector.Model.RespCombo.SetCaseList(comboName, ref type, loadName, 1.0))
                .Where(x => x != 0)
                .ToList();
            return creationResult.Any();
        }
    }
}
