using System;
using System.Collections.Generic;
using System.Linq;

using Shouldly;
using Xunit;

namespace MissingDieVisualAttachmentEmailer.Tests
{
    public class BusinessLogicTests
    {
        [Fact]
        public void ShouldNotReturnAnyItemsWhenNoAdditionalItemsPassed()
        {
            var logic = new BusinessLogic();

            var current = new List<LotInformation>()
            {
                new LotInformation
                (
                    lotName: "abc",
                    isSow: false,
                    isDrawing: false,
                    isMap: false,
                    productName: "product 1",
                    workFlow: "workflow 1",
                    currentStep: "step 1"
                ),
                new LotInformation
                (
                    lotName: "abc",
                    isSow: false,
                    isDrawing: false,
                    isMap: false,
                    productName: "product 1",
                    workFlow: "workflow 1",
                    currentStep: "step 1"
                )
            };

            var additional = new List<LotInformation>();

            logic.CompareLotInformation(current, additional).Count().ShouldBe(0);
        }

        [Fact]
        public void ShouldReturnAdditionalItemsNotInCurrent()
        {
            var logic = new BusinessLogic();

            var current = new List<LotInformation>()
            {
                new LotInformation
                (
                    lotName: "abc",
                    isSow: false,
                    isDrawing: false,
                    isMap: false,
                    productName: "product 1",
                    workFlow: "workflow 1",
                    currentStep: "step 1"
                ),
                new LotInformation
                (
                    lotName: "def",
                    isSow: false,
                    isDrawing: false,
                    isMap: false,
                    productName: "product 1",
                    workFlow: "workflow 1",
                    currentStep: "step 1"
                )
            };

            var additional = new List<LotInformation>()
            {
                new LotInformation
                (
                    lotName: "abc",
                    isSow: false,
                    isDrawing: false,
                    isMap: false,
                    productName: "product 1",
                    workFlow: "workflow 1",
                    currentStep: "step 1"
                ),
                new LotInformation
                (
                    lotName: "ghi",
                    isSow: false,
                    isDrawing: false,
                    isMap: false,
                    productName: "product 1",
                    workFlow: "workflow 1",
                    currentStep: "step 1"
                )
            };

            logic.CompareLotInformation(current, additional).Count().ShouldBe(1);
        }
    }
}
