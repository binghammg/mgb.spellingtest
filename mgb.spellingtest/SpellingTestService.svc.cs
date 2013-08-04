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
                
                /*var testList = (from p in SpellTestDB select p);*/

                /*
                Test test = new Test()
                {
                    Name = ,
                    Description = 
                };*/

            }

            
            return TestList.ToArray();


        }        
    }
}
