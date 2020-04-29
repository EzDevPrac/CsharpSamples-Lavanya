using System;
namespace CommandPattern
{
    public class OpenCommand : ICommand
    {
        private Document document;
        public OpenCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
             string str=document.Open();
            Console.WriteLine(str);
        }
    }
}