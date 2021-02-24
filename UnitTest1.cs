using DynamicSeries.WebpAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace DynamicSeries.UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void GetSeriesData_Test1()
        {
            int a = 10;
            int b = 20;
            var expected = GetDataTest(a, b);

            var objCtl = new DynamicSeriesController();

            var actual = objCtl.GetSeriesData(a, b);

            Assert.Equal(expected.ToString(), actual.ToString());


        }

        private int GetDataTest(int number, int divisor)
        {
            int result;
            try
            {
                result = number / divisor;
            }
            catch (Exception ex)
            {
                result = -1;
            }

            return result;
        }
    }
}
