using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ChatClient;
using ChatClient.DataBase;
using System.Linq;
using System.Windows;
using NUnit.Framework;

namespace job_finder.Test
{
    [TestClass]
    public class ChatTests
    {
        [TestMethod]
        public void MainWindow_Initialization_Success()
        {
            MainWindow mainWindow = new MainWindow();
            NUnit.Framework.Assert.IsNotNull(mainWindow);
        }

        [TestMethod]
        public void MainWindow_Window_Closing_Success()
        {
            MainWindow mainWindow = new MainWindow();
            NUnit.Framework.Assert.DoesNotThrow(() => mainWindow.Window_Closing(null, null));
        }

        [TestMethod]
        public void MainWindow_Window_Loaded_Success()
        {
            MainWindow mainWindow = new MainWindow();
            NUnit.Framework.Assert.DoesNotThrow(() => mainWindow.Window_Loaded(null, null));
        }
        [TestMethod]
        public void Worker_Initialization_Success()
        {
            Worker worker = new Worker();
            NUnit.Framework.Assert.IsNotNull(worker);
        }

        [TestMethod]
        public void Worker_Window_Closing_Success()
        {
            Worker worker = new Worker();
            NUnit.Framework.Assert.DoesNotThrow(() => worker.Window_Closing(null, null));
        }

        [TestMethod]
        public void Worker_Window_Loaded_Success()
        {
            Worker worker = new Worker();
            NUnit.Framework.Assert.DoesNotThrow(() => worker.Window_Loaded(null, null));
        }
        [TestMethod]
        public void Emploer_Initialization_Success()
        {
            Employer employer = new Employer();
            NUnit.Framework.Assert.IsNotNull(employer);
        }
        [TestMethod]
        public void ChatE_Initialization_Success()
        {
            Chat chat = new Chat();
            NUnit.Framework.Assert.IsNotNull(chat);
        }
        [TestMethod]
        public void DialoguesW_Initialization_Success()
        {
            DialoguesW dialoguesW = new DialoguesW();
            NUnit.Framework.Assert.IsNotNull(dialoguesW);
        }
    }
}
