using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    interface Iloan
    {
        void getIntrest();
    }
    interface Gloan:Iloan //interface supports inheritance
    {
        void getGoldIntrest();
    }
    interface Idmat
    {
        void getIdmatIntrest();
    }
    public abstract class Bank
    {
       protected string bname;
        protected string location;
        public Bank(string bname,string location)
        {
            this.bname = bname;
            this.location = location;

        }
    }
    public class SBI:Bank,Gloan
    {
        string bmanager;
        public SBI(string bname, string location,string bmanager):base(bname,location)
        {
            this.bmanager = bmanager;
        }
        public void displayDetails()
        {
            Console.WriteLine(this.bname + " " + this.location + " " + this.bmanager);
        }
        public void getIntrest()
        {
            Console.WriteLine("sbi loan intrest rate is 12% ");
        }
        public void getGoldIntrest()
        {
            Console.WriteLine("sbi loan intrest rate is 12% ");
        }
    }
    public class ICICI:Bank,Iloan,Idmat
    {
        string bhead;
        public ICICI(string bname, string location, string bhead) : base(bname, location)
        {
            this.bhead = bhead;
        }
        public void getIntrest()
        {
            Console.WriteLine("icici loan intrest rate is 17% ");
        }
        public void getIdmatIntrest()
        {
            Console.WriteLine("icici loan intrest rate is 17% ");
        }
        public void displayDetails()
        {
            Console.WriteLine(this.bname + " " + this.location + " " + this.bhead);
        }
    }
}
