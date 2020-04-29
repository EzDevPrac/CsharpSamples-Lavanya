using System;
using Xunit;

namespace CommandPattern.Testing
{
    public class DocumentTest
    {
        [Fact]
        public void DocumentOpen_ShouldReturn_DocumentOpened()
        {
            Document doc = new Document();
            string str = doc.Open();
            Assert.Equal("Document Opened", str);
        }
        [Fact]
        public void DocumentSave_ShouldReturn_DocumentSaved()
        {
            Document doc = new Document();
            string str = doc.Save();
            Assert.Equal("Document Saved", str);
        }
        [Fact]
        public void DocumentClose_ShouldReturn_Documentclosed()
        {
            Document doc = new Document();
            string str = doc.Close();
            Assert.Equal("Document Closed", str);
        }

    }
}
