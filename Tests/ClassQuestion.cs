using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class ClassQuestion
    {
        public string textQuestion, answers;
        public int typeQuestion;    
                              
        
        
        public ClassQuestion(string textQ, int typeQ, string ans)
        {
            textQuestion = textQ;
            typeQuestion = typeQ;
            answers = ans;
        }
    }
}
