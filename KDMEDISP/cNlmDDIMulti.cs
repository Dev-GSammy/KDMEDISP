using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP2
{
    public class UserInput
    {
        public IList<string> sources { get; set; }
        public IList<string> rxcuis { get; set; }
    }

    public class MinConcept
    {
        public string rxcui { get; set; }
        public string name { get; set; }
        public string tty { get; set; }
    }

    public class MinConceptItem
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
        public MinConceptItem minConceptItem { get; set; }
        public SourceConceptItem sourceConceptItem { get; set; }
    }

    public class InteractionPair
    {
        public IList<InteractionConcept> interactionConcept { get; set; }
        public string description { get; set; }
    }

    public class FullInteractionType
    {
        public string comment { get; set; }
        public IList<MinConcept> minConcept { get; set; }
        public IList<InteractionPair> interactionPair { get; set; }
    }

    public class FullInteractionTypeGroup
    {
        public string sourceDisclaimer { get; set; }
        public string sourceName { get; set; }
        public IList<FullInteractionType> fullInteractionType { get; set; }
    }

    public class cNlmDDIMulti
    {
        public string nlmDisclaimer { get; set; }
        public UserInput userInput { get; set; }
        public IList<FullInteractionTypeGroup> fullInteractionTypeGroup { get; set; }
    }

}
