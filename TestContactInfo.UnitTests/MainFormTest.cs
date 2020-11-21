using System;
using System.Windows.Forms;
using ContactListApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestContactInfo.UnitTests
{
    [TestClass]
    public class MainFormTest
    {
        /**
         * #Description
         * The test case will test the search functionality on phone number listbox.
         * The items we are trying to insert are not sorted. But the method will insert
         * them in sorted order and binary search is used in search method.
         * #PRE-Condition
         * Items should be in sorted order.
         * First Entity in list should be searched
         * #POST-Condition
         * The method will return the index of the searched item. [0 based]
         * The method will return 0 as the index of searched item.
         */
        [TestMethod]
        public void SearchByPhoneNumber_EntityExists_First()
        {
            ListBox listBox1 = new ListBox();
            ListBox listBox2 = new ListBox();
            ListBox listBox3 = new ListBox();
            MyDataStructure myDataStructure = new MyDataStructure(listBox1, listBox2, listBox3);
            myDataStructure.addEntry("111111", "FirstBoy1", "LastBoy1");
            myDataStructure.addEntry("111115", "FirstBoy5", "LastBoy5");
            myDataStructure.addEntry("111114", "FirstBoy4", "LastBoy4");
            myDataStructure.addEntry("111113", "FirstBoy3", "LastBoy3");
            myDataStructure.addEntry("111116", "FirstBoy6", "LastBoy6");
            myDataStructure.addEntry("111112", "FirstBoy2", "LastBoy2");
            int searchIndex = myDataStructure.searchPhoneNumber("111111");
            Assert.AreEqual(0, searchIndex);
        }

        /**
         * #Description
         * The test case will test the search functionality on phone number listbox.
         * The items we are trying to insert are not sorted. But the method will insert
         * them in sorted order and binary search is used in search method.
         * #PRE-Condition
         * Items should be in sorted order.
         * Middle entity in list should be searched
         * #POST-Condition
         * The method will return the index of the searched item. [0 based]
         * The method will return 2 as the index of searched item.
         */
        [TestMethod]
        public void SearchByPhoneNumber_EntityExists_Middle()
        {
            ListBox listBox1 = new ListBox();
            ListBox listBox2 = new ListBox();
            ListBox listBox3 = new ListBox();
            MyDataStructure myDataStructure = new MyDataStructure(listBox1, listBox2, listBox3);
            myDataStructure.addEntry("111111", "FirstBoy1", "LastBoy1");
            myDataStructure.addEntry("111115", "FirstBoy5", "LastBoy5");
            myDataStructure.addEntry("111114", "FirstBoy4", "LastBoy4");
            myDataStructure.addEntry("111113", "FirstBoy3", "LastBoy3");
            myDataStructure.addEntry("111116", "FirstBoy6", "LastBoy6");
            myDataStructure.addEntry("111112", "FirstBoy2", "LastBoy2");
            int searchIndex = myDataStructure.searchPhoneNumber("111113");
            Assert.AreEqual(2, searchIndex);
        }

        /**
         * #Description
         * The test case will test the search functionality on phone number listbox.
         * The items we are trying to insert are not sorted. But the method will insert
         * them in sorted order and binary search is used in search method.
         * #PRE-Condition
         * Items should be in sorted order.
         * Last entity in list should be searched
         * #POST-Condition
         * The method will return the index of the searched item. [0 based]
         * The method will return 5 as the index of searched item.
         */
        [TestMethod]
        public void SearchByPhoneNumber_EntityExists_Last()
        {
            ListBox listBox1 = new ListBox();
            ListBox listBox2 = new ListBox();
            ListBox listBox3 = new ListBox();
            MyDataStructure myDataStructure = new MyDataStructure(listBox1, listBox2, listBox3);
            myDataStructure.addEntry("111111", "FirstBoy1", "LastBoy1");
            myDataStructure.addEntry("111115", "FirstBoy5", "LastBoy5");
            myDataStructure.addEntry("111114", "FirstBoy4", "LastBoy4");
            myDataStructure.addEntry("111113", "FirstBoy3", "LastBoy3");
            myDataStructure.addEntry("111116", "FirstBoy6", "LastBoy6");
            myDataStructure.addEntry("111112", "FirstBoy2", "LastBoy2");
            int searchIndex = myDataStructure.searchPhoneNumber("111116");
            Assert.AreEqual(5, searchIndex);
        }

        /**
         * #Description
         * The test case will test the search functionality on phone number listbox.
         * The items we are trying to insert are not sorted. But the method will insert
         * them in sorted order and binary search is used in search method.
         * #PRE-Condition
         * Items should be in sorted order.
         * Search entity should be lower than first entity in list
         * #POST-Condition
         * The method will return the index of the searched item else -1. [0 based]
         * The method will return -1 as item is not in list.
         */
        [TestMethod]
        public void SearchByPhoneNumber_EntityNotExists_Smaller()
        {
            ListBox listBox1 = new ListBox();
            ListBox listBox2 = new ListBox();
            ListBox listBox3 = new ListBox();
            MyDataStructure myDataStructure = new MyDataStructure(listBox1, listBox2, listBox3);
            myDataStructure.addEntry("111111", "FirstBoy1", "LastBoy1");
            myDataStructure.addEntry("111115", "FirstBoy5", "LastBoy5");
            myDataStructure.addEntry("111114", "FirstBoy4", "LastBoy4");
            myDataStructure.addEntry("111113", "FirstBoy3", "LastBoy3");
            myDataStructure.addEntry("111116", "FirstBoy6", "LastBoy6");
            myDataStructure.addEntry("111112", "FirstBoy2", "LastBoy2");
            int searchIndex = myDataStructure.searchPhoneNumber("111110");
            Assert.AreEqual(-1, searchIndex);
        }

        /**
         * #Description
         * The test case will test the search functionality on phone number listbox.
         * The items we are trying to insert are not sorted. But the method will insert
         * them in sorted order and binary search is used in search method.
         * #PRE-Condition
         * Items should be in sorted order.
         * Search entity should be greater than last entity in list
         * #POST-Condition
         * The method will return the index of the searched item else -1. [0 based]
         * The method will return -1 as item is not in list.
         */
        [TestMethod]
        public void SearchByPhoneNumber_EntityNotExists_Greater()
        {
            ListBox listBox1 = new ListBox();
            ListBox listBox2 = new ListBox();
            ListBox listBox3 = new ListBox();
            MyDataStructure myDataStructure = new MyDataStructure(listBox1, listBox2, listBox3);
            myDataStructure.addEntry("111111", "FirstBoy1", "LastBoy1");
            myDataStructure.addEntry("111115", "FirstBoy5", "LastBoy5");
            myDataStructure.addEntry("111114", "FirstBoy4", "LastBoy4");
            myDataStructure.addEntry("111113", "FirstBoy3", "LastBoy3");
            myDataStructure.addEntry("111116", "FirstBoy6", "LastBoy6");
            myDataStructure.addEntry("111112", "FirstBoy2", "LastBoy2");
            int searchIndex = myDataStructure.searchPhoneNumber("111117");
            Assert.AreEqual(-1, searchIndex);
        }

        /**
         * #Description
         * The test case will test the search functionality on phone number listbox.
         * The item's first name list is not sorted. 
         * #PRE-Condition
         * Search entity should be in the list
         * #POST-Condition
         * The method will return the index of the searched item else -1. [0 based]
         * The method will return 1 as index of searched item.
         */
        [TestMethod]
        public void SearchByFirstName_EntityExists()
        {
            ListBox listBox1 = new ListBox();
            ListBox listBox2 = new ListBox();
            ListBox listBox3 = new ListBox();
            MyDataStructure myDataStructure = new MyDataStructure(listBox1, listBox2, listBox3);
            myDataStructure.addEntry("111111", "FirstBoy1", "LastBoy1");
            myDataStructure.addEntry("111115", "FirstBoy5", "LastBoy5");
            myDataStructure.addEntry("111114", "FirstBoy4", "LastBoy4");
            myDataStructure.addEntry("111113", "FirstBoy3", "LastBoy3");
            myDataStructure.addEntry("111116", "FirstBoy6", "LastBoy6");
            myDataStructure.addEntry("111112", "FirstBoy2", "LastBoy2");
            int searchIndex = myDataStructure.searchFirstName("FirstBoy2");
            Assert.AreEqual(1, searchIndex);
        }

        /**
         * #Description
         * The test case will test the search functionality on phone number listbox.
         * The item's first name list is not sorted. 
         * #PRE-Condition
         * Search entity should not be in the list
         * #POST-Condition
         * The method will return the index of the searched item else -1. [0 based]
         * The method will return -1 as item is not in list.
         */
        [TestMethod]
        public void SearchByFirstName_EntityNotExists()
        {
            ListBox listBox1 = new ListBox();
            ListBox listBox2 = new ListBox();
            ListBox listBox3 = new ListBox();
            MyDataStructure myDataStructure = new MyDataStructure(listBox1, listBox2, listBox3);
            myDataStructure.addEntry("111111", "FirstBoy1", "LastBoy1");
            myDataStructure.addEntry("111115", "FirstBoy5", "LastBoy5");
            myDataStructure.addEntry("111114", "FirstBoy4", "LastBoy4");
            myDataStructure.addEntry("111113", "FirstBoy3", "LastBoy3");
            myDataStructure.addEntry("111116", "FirstBoy6", "LastBoy6");
            myDataStructure.addEntry("111112", "FirstBoy2", "LastBoy2");
            int searchIndex = myDataStructure.searchFirstName("FirstBoy7");
            Assert.AreEqual(-1, searchIndex);
        }

        /**
         * #Description
         * The test case will test the search functionality on phone number listbox.
         * The item's last name list is not sorted. 
         * #PRE-Condition
         * Search entity should be in the list
         * #POST-Condition
         * The method will return the index of the searched item else -1. [0 based]
         * The method will return 5 as index of searched item.
         */
        [TestMethod]
        public void SearchByLastName_EntityExists()
        {
            ListBox listBox1 = new ListBox();
            ListBox listBox2 = new ListBox();
            ListBox listBox3 = new ListBox();
            MyDataStructure myDataStructure = new MyDataStructure(listBox1, listBox2, listBox3);
            myDataStructure.addEntry("111111", "FirstBoy1", "LastBoy1");
            myDataStructure.addEntry("111115", "FirstBoy5", "LastBoy5");
            myDataStructure.addEntry("111114", "FirstBoy4", "LastBoy4");
            myDataStructure.addEntry("111113", "FirstBoy3", "LastBoy3");
            myDataStructure.addEntry("111116", "FirstBoy6", "LastBoy6");
            myDataStructure.addEntry("111112", "FirstBoy2", "LastBoy2");
            int searchIndex = myDataStructure.searchLastName("LastBoy6");
            Assert.AreEqual(5, searchIndex);
        }

        /**
         * #Description
         * The test case will test the search functionality on phone number listbox.
         * The item's last name list is not sorted. 
         * #PRE-Condition
         * Search entity should not be in the list
         * #POST-Condition
         * The method will return the index of the searched item else -1. [0 based]
         * The method will return -1 as item is not in list.
         */
        [TestMethod]
        public void SearchByLastName_EntityNotExists()
        {
            ListBox listBox1 = new ListBox();
            ListBox listBox2 = new ListBox();
            ListBox listBox3 = new ListBox();
            MyDataStructure myDataStructure = new MyDataStructure(listBox1, listBox2, listBox3);
            myDataStructure.addEntry("111111", "FirstBoy1", "LastBoy1");
            myDataStructure.addEntry("111115", "FirstBoy5", "LastBoy5");
            myDataStructure.addEntry("111114", "FirstBoy4", "LastBoy4");
            myDataStructure.addEntry("111113", "FirstBoy3", "LastBoy3");
            myDataStructure.addEntry("111116", "FirstBoy6", "LastBoy6");
            myDataStructure.addEntry("111112", "FirstBoy2", "LastBoy2");
            int searchIndex = myDataStructure.searchLastName("LastBoy7");
            Assert.AreEqual(-1, searchIndex);
        }
    }
}
