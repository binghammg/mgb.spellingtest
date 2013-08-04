using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;

namespace mgb.spellingtest
{
    
    public class SpellingTestService : ISpellingTestService
    {

        public Test[] GetTestList(string userName)
        {
            List<Test> TestList = new List<Test>();

            using (SpellingTestEntities SpellTestDB = new SpellingTestEntities())
            {
                var tests = (from st in SpellTestDB.Tests select st);

                foreach (var singleTest in tests)
                {
                    Test test = new Test()
                    {
                        Name = singleTest.Name,
                        Description = singleTest.Description
                    };

                    TestList.Add(test);
                }
            }
            
            return TestList.ToArray();
        }        
    }
}
