using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Players_Service.Model
{
    public class PlayersModel
    {
        string filePath = "";
        public void writeEmail(string playersEmail)
        {

             filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filePath = filePath + @"\Emails\";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            string text = @"Dear player,
                          In order to log in to your account so you can change your password
                          click the following link:

                          < URL here pointing to the second endpoint described below>

                          Note that this link is only valid for 1 hour, after which it expires!
 
                         Happy playing!
                         Greentube Support Team>";
 

             File.WriteAllText(filePath+playersEmail+".txt", text);

        }
    }
}