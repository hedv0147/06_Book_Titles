using _06_Book_Titles;

namespace _06_Book_Titles
{  
    public class Book
 
    {

       private string title;
        public string GetTitle()
        {
            return this.Title;
        }
        public void SetTitle(string v)
        {
            string[] words = v.Split(' ');
            string result="";
            bool firstWord = true;
            foreach (string word in words)
            {
                if (word == "the"|| word == "a" || word == "an" || word == "and" || word == "in" || word == "of" || word == "to" && firstWord==false)
                    {
                    result = result + word + " ";
                    }
                else
                    {
                    string firstLetter = "";
                    firstLetter = word.Substring(0, 1);
                    result = result + firstLetter.ToUpper() + word.Substring(1) + " ";
                    }
                firstWord = false;
                }
            this.Title = result;
            //return result;
            }
            //v = v.Substring(0, 1);
            //v = v.ToUpper();
            //return v.ToUpper()+v.Substring(0, 1) ;
        }
         
    }
