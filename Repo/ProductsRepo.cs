using AutoMapper;
using PoojaProject.Exceptions;
using PoojaProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoojaProject.Repo
{
    public class ProductsRepo : IQuestionsrepo
    {
        readonly List<Question> products = new List<Question>()
        {
            new Question(1, "23+45=?",68,34,22),
            new Question(2, "26+3=?",45,29,9),
            new Question(3, "35*4=?",140,6,30),
            new Question(4, "4/2=?",45,2,9),
            new Question(5, "96/4=?",6,96,24),
            new Question(6, "29-9=?",10,20,30),
            new Question(7, "7*4=?",28,56,72),
            new Question(8, "8-5=?",5,3,8),
            new Question(9, "99/9=?",11,33,56),
            new Question(10, "106+4=?",110,120,340)
        };

        IMapper Mapper { get; }

        public ProductsRepo(IMapper mapper)
        {
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public IQueryable<Question> Get()
        {
            return products.Select(Mapper.Map<Question>).AsQueryable();
        }

        public void Create(Question p)
        {
            if (p == null)
                throw new ArgumentNullException(nameof(p));

            if (products.Any(x => x.Id == p.Id))
            {
                throw new DuplicateKeyException($"Can't create an object of a type {nameof(Question)} with the key '{p.Id}'. The object with the same key is already exists");
            }

            products.Add(Mapper.Map<Question>(p));
        }

        public void Delete(int id)
        {
            var p = products.FirstOrDefault(x => x.Id == id);
            if (p == null)
            {
                throw new KeyNotFoundException($"An object of a type '{nameof(Question)}' with the key '{id}' not found");
            }

            products.RemoveAll(x => x.Id == p.Id);
        }

        public void Update(Question p)
        {
            if (p == null)
                throw new ArgumentNullException(nameof(p));

            var stored = products.FirstOrDefault(x => x.Id == p.Id);
            if (stored == null)
            {
                throw new KeyNotFoundException($"An object of a type '{nameof(Question)}' with the key '{p.Id}' not found");
            }

            products.RemoveAll(x => x.Id == stored.Id);
            products.Add(Mapper.Map<Question>(p));
        }
    }
}
