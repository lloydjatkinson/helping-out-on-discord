using System;

namespace MissingDieVisualAttachmentEmailer
{
    public sealed class LotInformation
    {
        public string LotName { get; }
        public bool IsSow { get; }
        public bool IsDrawing { get; }
        public bool IsMap { get; }
        public string ProductName { get; }
        public string WorkFlow { get; }
        public string CurrentStep { get; }

        public LotInformation(string lotName, bool isSow, bool isDrawing, bool isMap, string productName, string workFlow, string currentStep)
        {
            LotName = lotName;
            IsSow = isSow;
            IsDrawing = isDrawing;
            IsMap = isMap;
            ProductName = productName;
            WorkFlow = workFlow;
            CurrentStep = currentStep;
        }
    }
}
