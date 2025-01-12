using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.DesignPattern.FactoriesPattern.BuilderDesignPattern.Example
{
    public class ConcreteBuilder
    {
        public void BuildPart()
        {

        }

        public ProductModel GetResult()
        {
            return new ProductModel();
        }
    }
}
