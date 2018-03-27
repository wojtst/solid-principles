using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidPrinciples.Ocp.Step2.DescriptionGenerator
{
    public class EmployeeDescriptionGeneratorFactory
    {
        private readonly IEnumerable<IEmployeeDescriptionGenerator> _strategies;

        public EmployeeDescriptionGeneratorFactory(
            IEnumerable<IEmployeeDescriptionGenerator> strategies)
        {
            _strategies = strategies;
        }

        public IEmployeeDescriptionGenerator Create(DescriptionType descriptionType)
        {
            var strategy = _strategies.SingleOrDefault(x => x.DescriptionType == descriptionType);

            if (strategy == null)
            {
                throw new InvalidOperationException($"Not found generator for {descriptionType} description.");
            }

            return strategy;
        }
    }
}