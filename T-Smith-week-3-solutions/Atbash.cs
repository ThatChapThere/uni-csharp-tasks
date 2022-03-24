using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    class Atbash
    {
        public string encode(string text, bool transpose)
        {
            string newString = "";

            // Note: only works with letters
            if(transpose){
                foreach(char character in text)
                    newString += ((int) character < 91) ?
                        $"{character - 64 :00}":
                        $"{character - 96 :00}";
            }else{
                foreach(char character in text)
                    newString += ((int) character < 91) ?
                        (char) (155 - character):
                        (char) (219 - character);
            }

            return newString;
        }

        public string decode(string text)
        {
            if(text.Length == 0) return "Warning! You attempted to decode an empty file";
            
            // if the first character is a number, it must have been transposed
            if(text[0] < 65){
                string newString = "";
                for(int i = 0; i < text.Length - 1; i += 2)
                    newString += (char) (int.Parse(text.Substring(i,2)) + 96);
                return newString;
            }else return encode(text, false);
        }
    }
}
