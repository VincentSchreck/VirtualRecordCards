using Moq;
using Xunit;
using Autofac.Extras.Moq;
using VRC.Domain;

namespace VRC_XUnitTest
{
    public class UnitTest_Mock
    {
        [Fact]
        public void Test_RecordcardGetListboxName()
        {
            using (var mock = AutoMock.GetStrict())
            {
                mock.Mock<RecordCardContent>()
                    .Setup(x => x.getQuestion())
                    .Returns("Frage");

                mock.Mock<RecordCardContent>()
                    .Setup(x => x.getRecordCardType())
                    .Returns("Typ");

                var cls = mock.Create<Recordcard>();
                cls.Thema = "Thema";
                var actual = cls.getListboxName();

                mock.Mock<RecordCardContent>()
                    .Verify(x => x.getQuestion());

                mock.Mock<RecordCardContent>()
                    .Verify(x => x.getRecordCardType());

                Assert.Equal("Typ|Thema|Frage", actual);
            }
        }
        
        [Fact]
        public void Test_RecordcardGetListboxNameLangerName()
        {
            using (var mock = AutoMock.GetStrict())
            {
                mock.Mock<RecordCardContent>()
                    .Setup(x => x.getQuestion())
                    .Returns("FrageFrage");

                mock.Mock<RecordCardContent>()
                    .Setup(x => x.getRecordCardType())
                    .Returns("Typ");

                var cls = mock.Create<Recordcard>();
                cls.Thema = "Thema";
                var actual = cls.getListboxName();

                mock.Mock<RecordCardContent>()
                    .Verify(x => x.getQuestion());

                mock.Mock<RecordCardContent>()
                    .Verify(x => x.getRecordCardType());

                Assert.Equal("Typ|Thema|FrageFr", actual);
            }
        }
    }
}
