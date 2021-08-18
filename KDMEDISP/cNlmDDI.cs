using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
    public class UserInput
    {
        public List<string> sources { get; set; }
        public string rxcui { get; set; }
    }

    public class MinConceptItem
    {
        public string rxcui { get; set; }
        public string name { get; set; }
        public string tty { get; set; }
    }

    public class MinConceptItem2
    {
        public string rxcui { get; set; }
        public string name { get; set; }
        public string tty { get; set; }
    }

    public class SourceConceptItem
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class InteractionConcept
    {
        public MinConceptItem2 minConceptItem { get; set; }
        public SourceConceptItem sourceConceptItem { get; set; }
    }

    public class InteractionPair
    {
        public List<InteractionConcept> interactionConcept { get; set; }
        public string severity { get; set; }
        public string description { get; set; }
    }

    public class InteractionType
    {
        public string comment { get; set; }
        public MinConceptItem minConceptItem { get; set; }
        public List<InteractionPair> interactionPair { get; set; }
    }

    public class InteractionTypeGroup
    {
        public string sourceDisclaimer { get; set; }
        public string sourceName { get; set; }
        public List<InteractionType> interactionType { get; set; }
    }

    public class cNlmDDI
    {
        public string nlmDisclaimer { get; set; }
        public UserInput userInput { get; set; }
        public List<InteractionTypeGroup> interactionTypeGroup { get; set; }
    }

   
}
