using System;
using System.Reflection;
using Xunit;
using Moq;
using Autofac.Extras.Moq;
using VRC.Domain;

namespace VRC_XUnitTest
{
    public class UnitTest1
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

                var actual = cls.getListboxName();

                mock.Mock<RecordCardContent>()
                    .Verify(x => x.getQuestion());

                mock.Mock<RecordCardContent>()
                    .Verify(x => x.getRecordCardType());

                Assert.Equal("Typ||Frage", actual);
            }
        }
    }
}
