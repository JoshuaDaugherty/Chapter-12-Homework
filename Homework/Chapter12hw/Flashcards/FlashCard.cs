using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class FlashCard
    {
       
        String _term;
        String _definition;

        public FlashCard(String term, String definition)
        {
            _term = term;
            _definition = definition;
        }

        public String getTerm()
        {
            return _term;
        }

        public String getDefinition()
        {
            return _definition;
        }
         
    }
}

