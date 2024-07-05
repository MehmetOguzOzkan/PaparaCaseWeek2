﻿using WebApiCase1.Models;

namespace WebApiCase1.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        IEnumerable<Product> List(string name, string sortField, string sortOrder);

    }
}
