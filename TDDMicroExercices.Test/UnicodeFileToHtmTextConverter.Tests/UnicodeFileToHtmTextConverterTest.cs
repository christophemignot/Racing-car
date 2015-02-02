namespace TDDMicroExercises.UnicodeFileToHtmTextConverter
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnicodeFileToHtmTextConverterTest
    {
        [TestMethod]
        public void WhenInitializedThenInstanceSetedUp()
        {
            var converter = new UnicodeFileToHtmTextConverter("../../Data/UnicodeToHtml.txt");

            Assert.IsNotNull(converter);
        }

        [TestMethod]
        public void WhenFileConvertedThenHtmlIsOk()
        {
            var converter = new UnicodeFileToHtmTextConverter("../../Data/UnicodeToHtml.txt");

            var html = converter.ConvertToHtml();
            
            Assert.AreEqual("This is a sample<br />unicode file<br />With &#233; &#224; &amp;<br />", html);
        }
    }
}
