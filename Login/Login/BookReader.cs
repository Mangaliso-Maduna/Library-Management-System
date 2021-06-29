using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class BookReader
    {
        public String BOOKNAME { get; set; }
        public String AUTHORSNAME { get; set; }
        public String BOOKID{ get; set; }

        static string path = Environment.CurrentDirectory + "/" + "BookRecords.txt";

        /* public static void ReadUser(Login obj)
         {
             StreamReader SR = new StreamReader(path);
             obj.Username = SR.ReadLine();
             obj.Password = SR.ReadLine();
             SR.Close();

             public override string ToString()
        {
            return BOOKNAME+" "+AUTHORSNAME+" "+BOOKID;
        }
         }*/

        public static void ReadaBook(BookReader obj)
        {
            StreamReader SR = new StreamReader(path);
            obj.BOOKNAME = SR.ReadLine();
            obj.BOOKID = SR.ReadLine();
            obj.AUTHORSNAME = SR.ReadLine();
            SR.Close();
        }
       

    }
}
