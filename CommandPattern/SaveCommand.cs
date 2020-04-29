using System;
namespace CommandPattern
{
    class SaveCommand : ICommand
    {
        private Document document;
        public SaveCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
           string str = document.Save();
            Console.WriteLine(str);
        }
    }
}