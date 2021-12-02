using System;
namespace classmailpassword
{
    public class Account
    {
        public string mail;
        public int password;

        
        
            
      

    public void AccountSign()
        {
            if(mail== "cavid@code.edu.az" && password==12345)
            {
                Console.WriteLine("giris olundu");
            }
            else
            {
                Console.WriteLine("mail veya  password sehvdir");
            }


        }
    }
}
