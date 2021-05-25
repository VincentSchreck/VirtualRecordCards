using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VRC.Model;

namespace VRC_UnitTest
{
    [TestClass]
    public class UnitTest2_RecordcardSetZufallsreihenfolge
    {
        [TestMethod]
        public void TesteZufallsreihenfolge()
        {
            // arrange 
            RecordcardSet recordcardSet = new RecordcardSet();
            List<Recordcard> recordcardlist = new List<Recordcard>();
            //recordcardlist.Add(new Recordcard() { QuestionText = "Test1"});
            //recordcardlist.Add(new Recordcard() { QuestionText = "Test2" });
            //recordcardlist.Add(new Recordcard() { QuestionText = "Test3" });
            recordcardSet.RecordcardList = recordcardlist;

            // act
            recordcardSet.wendeZufallsreihenfolgeAn(); // Mock einsetzen, der maximale zahl zurückgibt- => Dependency Injection

            // assert


        }
    }
}
