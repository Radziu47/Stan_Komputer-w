using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace Stan_Komputerów
{
    public class Cutting2
    { 
        
        public static void Cutting(string logingData)
        {
            List<string> users = new List<string>();
           
            
            List<string> logins = new List<string>();
            List<string> passs = new List<string>();
            List<string> RootNoob = new List<string>();

            string[] arr = logingData.Split(',');

            foreach (var Var in arr)
            {
                if (Var != "")
                {
                    users.Add(Var);
                }
            }

            foreach (string Var in users)
            {
                List<string> usersNotFinal = new List<string>();
                
                string[] Cutted = Var.Split(':');
                usersNotFinal.Add(Cutted[1].Remove(0, 1));

                foreach (string Dupa in  usersNotFinal)
                {
                    List<string> userFinal = new List<string>();
                    
                    string[] DupaArray = Dupa.Split('}');

                    userFinal.Add(DupaArray[0]);


                    foreach (string final in userFinal)
                    {
                        string[] finals = final.Split('"');

                        for (int i = 0; i < 2; i++)
                        {
                            if (i == 0)
                            {
                                logins.Add(finals[i]);
                            }
                            if (i == 1)
                            {
                                passs.Add(finals[i]);
                            }
                            if (i == 2)
                            {
                                RootNoob.Add(finals[i]);
                            }
                        }
                    }
                }
            }

            foreach (var login in logins)
            {
                MessageBox.Show(login);
            }
        }
    }
}