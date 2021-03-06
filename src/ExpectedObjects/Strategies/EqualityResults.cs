﻿using System.Collections.Generic;
using System.Linq;

namespace ExpectedObjects.Strategies
{
    public class EqualityResults
    {
        readonly List<EqualityResult> _results = new List<EqualityResult>();

        public bool Status => AllEqual(_results);

        public IEnumerable<EqualityResult> Results => _results;

        bool AllEqual(List<EqualityResult> results)
        {
            return results.Where(r => r.Status == false).Count() == 0;
        }

        public void AddResult(EqualityResult result)
        {
            _results.Add(result);
        }
    }
}