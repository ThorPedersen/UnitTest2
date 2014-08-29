using System;
//using ClassLibrary1;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    

    [TestClass]
    public class UnitTest1
    {
        private ClassLibrary1.Person _p;

        [TestInitialize]
        public void BeginTest()
        {
            _p = new Person("Magne");
        }

        [TestMethod]
        public void TestAdult()
        {
            // Under 18 should return false
            _p.Age = 17;
            bool result = _p.isAdult();
            Assert.IsFalse(result);

            // Equal to 18 should return true
            _p.Age = 18;
            result = _p.isAdult();
            Assert.IsTrue(result);

            // Over 18 should return true
            _p.Age = 19;
            result = _p.isAdult();
            Assert.IsTrue(result);
        }

       [TestMethod]
       public void TestEquality()
       {
          Person p = new Person();
          p.Name = "Børge";
          p.Age = 24;

          Person otherP = new Person();
          otherP.Name = "Børge";
          otherP.Age = 24;

          Assert.AreEqual(p, otherP);
       }

       [TestMethod]
       public void TestInequality()
       {
          Person p = new Person();
          p.Name = "Børgen";
          p.Age = 24;

          Person otherP = new Person();
          otherP.Name = "Børge";
          otherP.Age = 24;

          Assert.AreNotEqual(p, otherP);
       }

       [TestMethod]
       public void TestAgeException()
       {
          Person p = new Person();
          p.Name = "Børgen";


          try
          {
             p.Age = -26;
             Assert.Fail();
          }
          catch (AgeException ae)
          {
             Assert.AreEqual("Alder for lav", ae.Message);
          }
          catch (Exception e)
          {
             Assert.Fail();
          }
          

       }


    }
}
