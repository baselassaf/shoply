using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndPrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndPrandsSpecification()
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x => x.ProductBrand);
        }

        public ProductsWithTypesAndPrandsSpecification(int id) 
        : base(x => x.Id == id)
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}