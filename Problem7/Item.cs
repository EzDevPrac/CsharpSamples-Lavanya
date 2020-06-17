using System;
using System.Collections.Generic;
using System.Text;

namespace Problem7
{
    public class Item
    {
        private string name { get; set; }
        private int code { get; set; }
        private string Category { get; set; }
        private int size { get; set; }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string Getname()
        {
            return name;
        }
        public void SetCode(int n)
        {
            code = n;
        }
        public int GetCode()
        {
            return code;
        }
        public void SetCategory(string temp)
        {
            Category = temp;
        }
        public string GetCategory()
        {
            return Category;
        }
        public void SetSize(int n)
        {
            size = n;
        }
        public int GetSize()
        {
            return size;
        }
    }
}
