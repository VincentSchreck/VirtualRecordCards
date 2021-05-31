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
                    .Setup(x => x.ErhalteQuestion())
                    .Returns("Frage");

                mock.Mock<RecordCardContent>()
                    .Setup(x => x.ErhalteRecordCardType())
                    .Returns("Typ");

                var cls = mock.Create<Recordcard>();
                cls.Thema = "Thema";
                var actual = cls.ErhalteRecordcardName();

                mock.Mock<RecordCardContent>()
                    .Verify(x => x.ErhalteQuestion());

                mock.Mock<RecordCardContent>()
                    .Verify(x => x.ErhalteRecordCardType());

                Assert.Equal("Typ|Thema|Frage", actual);
            }
        }
        
        [Fact]
        public void Test_RecordcardGetListboxNameLangerName()
        {
            using (var mock = AutoMock.GetStrict())
            {
                mock.Mock<RecordCardContent>()
                    .Setup(x => x.ErhalteQuestion())
                    .Returns("FrageFrage");

                mock.Mock<RecordCardContent>()
                    .Setup(x => x.ErhalteRecordCardType())
                    .Returns("Typ");

                var cls = mock.Create<Recordcard>();
                cls.Thema = "Thema";
                var actual = cls.ErhalteRecordcardName();

                mock.Mock<RecordCardContent>()
                    .Verify(x => x.ErhalteQuestion());

                mock.Mock<RecordCardContent>()
                    .Verify(x => x.ErhalteRecordCardType());

                Assert.Equal("Typ|Thema|FrageFr", actual);
            }
        }
    }
}
