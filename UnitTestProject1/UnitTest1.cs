using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleSchool.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StudentUnitTest()
        {//Arrange
            StudentUnitTestController controller = new StudentUnitTestController();
            //Act
            IActionResult result = controller.Index() as IActionResult;
            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CourseUnitTest()
        {//Arrange
            CourseUnitTestController controller = new CourseUnitTestController();
            //Act
            IActionResult result = controller.Index() as IActionResult;
            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void EnrolmentUnitTest()
        {//Arrange
            EnrollmentUnitTestController controller = new EnrollmentUnitTestController();
            //Act
            IActionResult result = controller.Index() as IActionResult;
            //Assert
            Assert.IsNotNull(result);
        }
    }
}
