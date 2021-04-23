using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int rno;
        public string sname;
        public string subject;
        public void setdata(int r,string nm,string sub)
        {
            this.rno = r;
            this.sname = nm;
            this.subject = sub;
        }

        public void getdata()
        {
            Console.WriteLine(rno + "\t" + sname.ToString() + "\t" + subject.ToString()) ;
        }

        
    }
}
