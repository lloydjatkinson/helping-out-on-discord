using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissingDieVisualAttachmentEmailer
{
    public sealed class BusinessLogic
    {
        public IEnumerable<LotInformation> CompareLotInformation(IEnumerable<LotInformation> current, IEnumerable<LotInformation> additional)
        {
            //List<LotInformation> output = additional.ToList();
            //for (int i = 0; i < current.Count; i++)
            //{
            //    bool found = false;
            //    for (int j = 0; j < additional.Count; j++)
            //    {
            //        if (additional[j].LotName == current[i].LotName)
            //        {
            //            found = true;
            //            if (!current[i].IsSow) { output[j].IsSow = false; }
            //            if (!current[i].IsDrawing) { output[j].IsDrawing = false; }
            //            if (!current[i].Map) { output[j].Map = false; }
            //        }
            //    }
            //    if (!found)
            //    {
            //        output.Add(current[i]);
            //    }
            //}
            //return output;


            var output = new List<LotInformation>();
            foreach (var currentLot in current)
            {
                foreach (var additionalLot in additional)
                {
                    if (additionalLot.LotName != currentLot.LotName)
                    {
                        output.Add(new LotInformation
                        (
                            lotName: currentLot.LotName,
                            isSow: currentLot.IsSow,
                            isDrawing: currentLot.IsDrawing,
                            isMap: currentLot.IsMap,
                            productName: currentLot.ProductName,
                            workFlow: currentLot.WorkFlow,
                            currentStep: currentLot.CurrentStep
                        ));
                    }
                }
            }

            return output;
        }
    }
}
