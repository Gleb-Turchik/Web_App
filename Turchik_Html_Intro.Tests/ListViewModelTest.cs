using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Turchik_Html_Intro.DAL.Entities;
using Turchik_Html_Intro.Models;

namespace Turchik_Html_Intro.Tests
{
    public class ListViewModelTest
    {
        [Fact]
        public void ListViewModelCountPages()
        {
            //Act
            var model = ListViewModel<Drug>
                                    .GetModel(TestData.GetDrugList(), 1, 3);

            //Assert
            Assert.Equal(2, model.TotalPages);
        }

        [Theory]
        [MemberData(memberName: nameof(TestData.Params), MemberType =typeof(TestData))]
        public void ListViewModelSelectsCorrectQty(int page, int qty)
        {
            //Act
            var model = ListViewModel<Drug>.GetModel(TestData.GetDrugList(), page, 3);

            //Assert
            Assert.Equal(qty, model.Count);
        }

        [Theory]
        [MemberData(memberName: nameof(TestData.Params), MemberType = typeof(TestData))]
        public void ListViewModelHasCorrectData(int page, int id)
        {
            //Act
            var model = ListViewModel<Drug>.GetModel(TestData.GetDrugList(), page, 3);

            //Assert
            Assert.Equal(id, model[0].Id);
        }
    }
}