using AR.Data.Interfaces;
using AR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AR.Data.Imp
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ContextoPrincipal _db;

        public CategoriaRepository(ContextoPrincipal db)
        {
            _db = db;
        }

        public async Task Add(Categoria entity)
        {
           await _db.AddAsync(entity);
           await _db.SaveChangesAsync();
        }

        public IQueryable<Categoria> GetAll()
        {
            return _db.Categoria;
        }
    }
}
