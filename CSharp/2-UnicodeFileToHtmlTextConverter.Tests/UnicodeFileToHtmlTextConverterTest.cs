using FluentAssertions;
using Xunit;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public class UnicodeFileToHtmlTextConverterTest
    {
        [Fact]
        public void foobar()
        {
            UnicodeFileToHtmlTextConverter converter = new UnicodeFileToHtmlTextConverter("foobar.txt");
            //converter.GetFilename().Should().Be("fixme");
        }
    }
}
