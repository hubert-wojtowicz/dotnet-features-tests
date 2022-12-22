using Assembly.A;
using FluentAssertions;

namespace Assembly.B
{
    public class TimeServiceTests
    {
        [Fact]
        public void GetDescription_WhenEightHour_ShouldReturnMorning()
        {
            var sut = new TimeService();
            var dayPartDescription = sut.GetDescription(new DateTime(2022, 1, 1, 8, 0, 0));
            dayPartDescription.Should().Be("Morning");
        }
    }
}