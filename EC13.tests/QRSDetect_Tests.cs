using Microsoft.VisualStudio.TestTools.UnitTesting;
using QRSDetectClient;
using Utilities;

namespace EC13.tests
{
    [TestClass]
    public class QRSDetect_Tests
    {
        private ECGDataProcessor _ecgDataProcessor;

        [TestInitialize]
        public void Initialize()
        {
            _ecgDataProcessor = new ECGDataProcessor();
        }

        [TestMethod]
        public void QRSDetect_Should_Process_EC13_1()
        {
            int[] samples = _ecgDataProcessor.TestData["EC13_1"];

            foreach (var sample in samples)
            {
                int qrs = QrsDetect.QRSDetProc(sample, 0);

                if (qrs > 0)
                {

                }
            }
        }

        [TestMethod]
        public void QRSDetect_Should_Process_EC13_28()
        {
            int[] samples = _ecgDataProcessor.TestData["EC13_28"];

            foreach (var sample in samples)
            {
                int qrs = QrsDetect.QRSDetProc(sample, 0);

                if (qrs > 0)
                {

                }
            }
        }

        [TestMethod]
        public void QRSDetect_Should_Process_EC13_29()
        {
            int[] samples = _ecgDataProcessor.TestData["EC13_29"];

            foreach (var sample in samples)
            {
                int qrs = QrsDetect.QRSDetProc(sample, 0);

                if (qrs > 0)
                {

                }
            }
        }

        [TestMethod]
        public void QRSDetect_Should_Process_EC13_30()
        {
            int[] samples = _ecgDataProcessor.TestData["EC13_30"];

            foreach (var sample in samples)
            {
                int qrs = QrsDetect.QRSDetProc(sample, 0);

                if (qrs > 0)
                {

                }
            }
        }

        [TestMethod]
        public void QRSDetect_Should_Process_EC13_31()
        {
            int[] samples = _ecgDataProcessor.TestData["EC13_31"];

            foreach (var sample in samples)
            {
                int qrs = QrsDetect.QRSDetProc(sample, 0);

                if (qrs > 0)
                {

                }
            }
        }

        [TestMethod]
        public void QRSDetect_Should_Process_EC13_40()
        {
            int[] samples = _ecgDataProcessor.TestData["EC13_40"];

            foreach (var sample in samples)
            {
                int qrs = QrsDetect.QRSDetProc(sample, 0);

                if (qrs > 0)
                {

                }
            }
        }

        [TestMethod]
        public void QRSDetect_Should_Process_EC13_41()
        {
            int[] samples = _ecgDataProcessor.TestData["EC13_41"];

            foreach (var sample in samples)
            {
                int qrs = QrsDetect.QRSDetProc(sample, 0);

                if (qrs > 0)
                {

                }
            }
        }
    }
}
