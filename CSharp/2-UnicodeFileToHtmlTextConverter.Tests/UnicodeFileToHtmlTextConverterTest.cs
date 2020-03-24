using FluentAssertions;
using System.IO;
using Xunit;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public class UnicodeFileToHtmlTextConverterTest
    {
        [Fact]
        public void convertToHtml_simpleText()
        {
            UnicodeFileToHtmlTextConverter converter = new UnicodeFileToHtmlTextConverterMock("foobar.txt");
            converter.ConvertToHtml().Should().Be("Hello World!<br />");
        }
    }

	public class UnicodeFileToHtmlTextConverterMock : UnicodeFileToHtmlTextConverter
	{
		public UnicodeFileToHtmlTextConverterMock(string fullFilenameWithPath):base(fullFilenameWithPath)
		{
			
		}

		protected override TextReader GetTextToConvert()
		{
			return new StringReader("Hello World!");
		}
	}
}
