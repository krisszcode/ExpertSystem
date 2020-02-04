using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertSystem
{
    class ESProvider
    {
        public FactRepository factRepository;

        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
<<<<<<< HEAD
            factRepository = factParser.GetfactRepository();
=======
            FactRepository factRepo = new FactRepository();
>>>>>>> afa2477db1ee7425a968dcebd1830839d9d4e141
        }

        public void collectAnswers()
        {

        }

        public Boolean getAnswerByQuestion(string questionId)
        {

        }

        public string evaluate()
        {

        }

    }
}
