using System;
namespace CommandPattern
{
    class CloseCommand : ICommand
    {
        private Document document;
        public CloseCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
          string str = document.Close();
            Console.WriteLine(str);
        }
    }
}