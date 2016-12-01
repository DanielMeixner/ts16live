using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BusinessLogic.Tests
{
    [TestClass()]
    public class DevSkillComputerTests
    {
        [TestMethod()]
        public void ComputeDeveloperCodingsSkillsTest()
        {
            double expectedResult = 6;
            var result = DevSkillComputer.ComputeDeveloperCodingsSkills(7, 0, 2, 46);
            Debug.WriteLine(result);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void ComputeDeveloperCodingsSkillsTest870()
        {
            double d;
            d =  DevSkillComputer.ComputeDeveloperCodingsSkills(1, 0, 0, 0);
            Assert.AreEqual<double>(0, d);
        }

        [TestMethod]
       public void ComputeDeveloperCodingsSkillsTest929()
        {
            double d;
            d =  DevSkillComputer.ComputeDeveloperCodingsSkills(8, 0, 0, 47);
            Assert.AreEqual<double>(5, d);
        }

        [TestMethod]
       public void ComputeDeveloperCodingsSkillsTest662()
        {
            double d;
            d =  DevSkillComputer.ComputeDeveloperCodingsSkills(11, 0, 0, 47);
            Assert.AreEqual<double>(4, d);
        }

        [TestMethod]
       public void ComputeDeveloperCodingsSkillsTest371()
        {
            double d;
            d =  DevSkillComputer.ComputeDeveloperCodingsSkills(0, 0, 1, 0);
            Assert.AreEqual<double>(1, d);
        }

        [TestMethod]
       public void ComputeDeveloperCodingsSkillsTest700()
        {
            double d;
            d =  DevSkillComputer.ComputeDeveloperCodingsSkills(11, 0, 14, 47);
            Assert.AreEqual<double>(4, d);
        }

        [TestMethod]
        
        public void ComputeDeveloperCodingsSkillsTest281()
        {
            double d;
            d =  DevSkillComputer.ComputeDeveloperCodingsSkills(1, 11, 0, 0);
            Assert.IsTrue(-2< d);
        }

        [TestMethod]
        public void ComputeDeveloperCodingsSkillsTest282()
        {
            double d;
            d = DevSkillComputer.ComputeDeveloperCodingsSkills(1, 11,1, 0);
            Assert.IsTrue(12 < d);
        }

        [TestMethod]
        
        public void ComputeDeveloperCodingsSkillsTest462()
        {
            double d;
            d =  DevSkillComputer.ComputeDeveloperCodingsSkills(11, 0, 0, 36);
            Assert.AreEqual<double>(3, d);
        }

        [TestMethod]        
        public void ComputeDeveloperCodingsSkillsTest166()
        {
            double d;
            d =  DevSkillComputer.ComputeDeveloperCodingsSkills(1, 0, 0, 47);
            Assert.AreEqual<double>(47, d);
        }

    }
}