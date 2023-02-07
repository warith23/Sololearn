 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloLearn
{
    public class Post
    {
        private string text;
        
        public Post()
        {
          Console.WriteLine("New Post");
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }
        
        public string Text 
        {
            get{return text;} 
            set{text= value;}
        }

    }
}