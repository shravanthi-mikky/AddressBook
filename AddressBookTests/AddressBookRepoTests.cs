using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Tests
{
    [TestClass()]
    public class AddressBookRepoTests
    {
        AddressBookRepo repo = new AddressBookRepo();

        [TestMethod()]
        public void GetAllContactOf_AddressBookTest()
        {
            Console.WriteLine("Display of AddressBook");
            repo.GetAllContactOf_AddressBook();
            Console.WriteLine("*********************************************************");
        }

        [TestMethod()]
        public void GetAllContactOf_PersonDetail1Test()
        {
            Console.WriteLine("Display of PersonDetail1");
            repo.GetAllContactOf_PersonDetail1();
            Console.WriteLine("*********************************************************");
        }

        [TestMethod()]
        public void GetAllContactOf_Address_Book1Test()
        {
            Console.WriteLine("Display of Address_Book1");
            repo.GetAllContactOf_Address_Book1();
            Console.WriteLine("*********************************************************");
        }

        [TestMethod()]
        public void GetAllContactOf_PersonTypes1Test1()
        {
            Console.WriteLine("Display of PersonTypes1");
            repo.GetAllContactOf_PersonTypes1();
            Console.WriteLine("*********************************************************");
        }

        [TestMethod()]
        public void GetAllContactOf_PersonsDetail_Type1Test()
        {
            Console.WriteLine("Display of PersonsDetail_Type1");
            repo.GetAllContactOf_PersonsDetail_Type1();
            Console.WriteLine("*********************************************************");
        }

        [TestMethod()]
        public void GetAllContactOf_Employee_Department1Test()
        {
            Console.WriteLine("Display of Employee_Department1");
            repo.GetAllContactOf_Employee_Department1();
            Console.WriteLine("*********************************************************");
        }
    }
}