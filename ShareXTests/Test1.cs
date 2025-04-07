using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShareX.HelpersLib;
using System;
using System.Drawing;

namespace ShareX.ScreenCaptureLib.Tests
{
    [TestClass]
    public class ScreenshotTests
    {
        private Screenshot screenshot;

        [TestInitialize]
        public void Setup()
        {
            screenshot = new Screenshot();
        }

        [TestMethod]
        public void CaptureRectangle_ValidRectangle_ReturnsBitmap()
        {
            // Arrange
            Rectangle rect = new Rectangle(0, 0, 100, 100);

            // Act
            Bitmap result = screenshot.CaptureRectangle(rect);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(100, result.Width);
            Assert.AreEqual(100, result.Height);
        }

        [TestMethod]
        public void CaptureFullscreen_ReturnsBitmap()
        {
            // Act
            Bitmap result = screenshot.CaptureFullscreen();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CaptureWindow_ValidHandle_ReturnsBitmap()
        {
            // Arrange
            IntPtr handle = NativeMethods.GetForegroundWindow();

            // Act
            Bitmap result = screenshot.CaptureWindow(handle);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CaptureActiveWindow_ReturnsBitmap()
        {
            // Act
            Bitmap result = screenshot.CaptureActiveWindow();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CaptureActiveMonitor_ReturnsBitmap()
        { // Act
            Bitmap result = screenshot.CaptureActiveMonitor();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}