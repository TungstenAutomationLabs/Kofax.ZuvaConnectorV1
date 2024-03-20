using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Kofax.ZuvaConnectorV1;

namespace ZuvaUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestZuvaFlow()
        {
            string zuvatoken = "Bearer ";
            string fieldID = "<Zuva Field ID>";
            ZuvaConnector zuvaConnector = new ZuvaConnector();
        
            string fileid = zuvaConnector.ZuvaUploadFileKTASDK("<Document.InstanceID>", "https://<your tenant here>//services/sdk/", "<Your SessionID here>", zuvatoken);
            Assert.IsNotNull(fileid);


            //string classification = zuvaConnector.ZuvaGetClassificationResult(fileid, zuvatoken);
            //Assert.IsNotNull(classification);

            string extraction = zuvaConnector.ZuvaGetExtractionResult(fileid, fieldID, zuvatoken);
            //string extraction = zuvaConnector.ZuvaExtractAndConcat(fileid, fieldID, zuvatoken, "TEST");
            //string extraction = zuvaConnector.ZuvaGetAnswerResult(fileid, fieldID, zuvatoken);
            Assert.IsNotNull(extraction);

            //string norm = zuvaConnector.GetNormalizationFieldFromExtractionResultForField(extraction, fieldID, "durations");
            //Assert.IsNotNull(norm);

            //string answer = zuvaConnector.GetAnswerResultsForField(fieldID, extraction);
            //Assert.IsNotNull(answer);

            string concat = zuvaConnector.ConcatExtractionResultsForField(fieldID, extraction);
            Assert.IsNotNull(concat);

            string first = zuvaConnector.GetFirstFromExtractionResultForField(fieldID, extraction);
            Assert.IsNotNull(first);

            string last = zuvaConnector.GetLastFromExtractionResultForField(fieldID, extraction);
            Assert.IsNotNull(last);

            string firstnum = zuvaConnector.GetFirstNumberFromExtractionResultForField(fieldID, extraction);
            Assert.IsNotNull(firstnum);

            string lastnum = zuvaConnector.GetLastNumberFromExtractionResultForField(fieldID, extraction);
            Assert.IsNotNull(lastnum);

            string sum = zuvaConnector.GetSumOfAllNumbersFromExtractionResultForField(fieldID, extraction);
            Assert.IsNotNull(sum);

            string firstdate = zuvaConnector.GetFirstDateFromExtractionResultForField(fieldID, extraction);
            Assert.IsNotNull(firstdate);

            string lastdate = zuvaConnector.GetLastDateFromExtractionResultForField(fieldID, extraction);
            Assert.IsNotNull(lastdate);

            string earliest = zuvaConnector.GetEarliestDateFromExtractionResultForField(fieldID, extraction);
            Assert.IsNotNull(earliest);

            string latest = zuvaConnector.GetLatestDateFromExtractionResultForField(fieldID, extraction);
            Assert.IsNotNull(latest);

        }
    }
}
