using System;
using System.Collections.Generic;
using System.Text;

namespace Problem7
{
   public class Film :Item
    { 
      private string director;
            
      private string mainActor, mainActress;
            public Film(string director, string mainActor, string mainActress)
            {
                this.director = director;
                this.mainActor = mainActor;
                this.mainActress = mainActress;
            }

            public void SetDirector(string name)
            {
            director = name;
            }
            public string GetDirector()
            {
            return director;
            }
            public void SetMainActor(string name)
            {
              mainActor = name;
            }
             public string GetMainActor()
             {
                 return mainActor;
             }
        public void SetMainActress(string name)
        {
            mainActress = name;
        }
        public string GetMainActress()
        {
            return mainActress;
        }
        public void Play()
            {
            Console.WriteLine("Film is playing");
            }
            public void RetrieveInformation()
            {
            Console.WriteLine("RetrieveInformatiom");
            }
        }
}
