﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertSystem
{
    public class ESProvider
    {
        public FactRepository factRepository;
        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
            factRepository = factParser.GetfactRepository();
            // FactRepository factRepo = new FactRepository();
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
