using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    class Message
    {
        //private field
        private string _message = "";

        //public property hiding private field
        public string message
        {
            get { return _message; }
            private set { _message = value; }
        }

        //read the message to encrypt from a file
        public void readMessageFromFile(string filename)
        {
            //Read text from a file
            //Could we do this any better?
            message = File.ReadAllText(filename);
        }

        //read the message to encrypt from input
        public void readMessageFromInput()
        {
            Console.WriteLine("Enter your message to encode...");

            string line = "";
            var a = new Atbash();

            while(true){
                line = Console.ReadLine();
                if(line == "") break;

                if(message.Length > 0) message += "\n";
                message += line;
            }

            writeMessageToFile();
        }

        public void writeMessageToFile(){
            string fileString = "";
            var a = new Atbash();

            // line[0] % 2 == 0 makes it a mixture of both encoding types
            foreach(string line in message.Split("\n")){
                if(fileString.Length > 0) fileString += "\n";
                fileString += a.encode(line, line[0] % 2 == 0);
            }

            string fileName = $"{DateTime.Now.ToString("yyyy-MM-dd-hh-mm")}.txt";
            File.Create(fileName).Close();
            File.WriteAllText(fileName, fileString);
        }
    }
}