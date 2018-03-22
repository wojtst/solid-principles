using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidPrinciples.Ocp.Step2
{
    public class EmployeeDescriptionGeneratorFactory
    {
        private readonly IEnumerable<IEmployeeDescriptionGeneratorStrategy> _strategies;

        public EmployeeDescriptionGeneratorFactory(
            IEnumerable<IEmployeeDescriptionGeneratorStrategy> strategies)
        {
            _strategies = strategies;
        }

        public IEmployeeDescriptionGeneratorStrategy Create(DescriptionType descriptionType)
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