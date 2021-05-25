using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VRC.Model;

namespace VRC_UnitTest
{
    [TestClass]
    public class UnitTest1_RecordcardListnameBox
    {
        [TestMethod]
        public void TesteLeerMitText()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.Text;
            recordcard.Topic = "";
            //recordcard.QuestionText = "";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("|", result);
        }

        [TestMethod]
        public void TesteNormalMitText()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.Text;
            recordcard.Topic = "Hallo";
            //recordcard.QuestionText = "Test";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("Hallo|Test", result);
        }

        [TestMethod]
        public void TesteTopicOverflowMitText()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.Text;
            recordcard.Topic = "HalloHallo";
            //recordcard.QuestionText = "Test";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("HalloHa|Test", result);
        }

        [TestMethod]
        public void TesteQuestionOverflowMitText()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
           // recordcard.KarteikartenTyp = KarteikartenTyp.Text;
            recordcard.Topic = "Hallo";
            //recordcard.QuestionText = "TestTestTest";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("Hallo|TestTes", result);
        }

        [TestMethod]
        public void TesteNormalMitAbbildung()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.Abbildung;
            recordcard.Topic = "Hallo";
            //recordcard.QuestionAbbildung = "Test";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("Hallo|Test", result);
        }

        [TestMethod]
        public void TesteNormalMitAufzaehlung()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.Aufzaehlung;
            recordcard.Topic = "Hallo";
           // recordcard.QuestionAufzaehlung = "Test";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("Hallo|Test", result);
        }

        [TestMethod]
        public void TesteNormalMitMultipleChoice()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.MultipleChoice;
            recordcard.Topic = "Hallo";
           // recordcard.QuestionMultipleChoice = "Test";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("Hallo|Test", result);
        }


    }
}
