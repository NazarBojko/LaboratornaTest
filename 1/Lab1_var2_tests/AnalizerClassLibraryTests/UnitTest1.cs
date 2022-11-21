using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AnalizerClassLibraryTests
{
    [TestClass]
    public class AnalaizerClassTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "testData.xml",
            "Test",
            DataAccessMethod.Sequential)]

        [TestMethod()]
        public void CreateStackTest()
        {
            // Arrange
            string expected = Convert.ToString(TestContext.DataRow["expected"]);
            AnalaizerClass.expression = Convert.ToString(TestContext.DataRow["initial"]);

            // Actual
            string actual = string.Join("", AnalaizerClass.CreateStack().ToArray());

            // Assert
            Assert.AreEqual(expected, actual);


        }
    }
}
