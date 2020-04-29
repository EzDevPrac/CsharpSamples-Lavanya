using System;
namespace CommandPattern
{
    public class Document
    {
        public string Open()
        {
            return"Document Opened";
        }
        public string Save()
        {
            return "Document Saved";
        }
        public string Close()
        {
            return "Document Closed";
        }
    }
}