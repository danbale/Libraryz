using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SSUABC.Repositorios.Repositorio_Generico
{
    public abstract class RepostorioCRUD<Entity> : IRepositorioGenerico<Entity> where Entity : class  
    {
        protected DbContext context;

        public RepostorioCRUD(DbContext context)
        {
            this.context = context;
        }


        public IEnumerable<Entity> BuscarTodos()
        {
            return context.Set<Entity>().ToList<Entity>();
        }

        public Entity BuscarPorId(int id)
        {
            return context.Set<Entity>().Find(id);
        }

        public void Agregar(Entity entity)
        {
            context.Set<Entity>().Add(entity);
            context.SaveChanges();
        }

        public void Borrar(Entity entity)
        {
            context.Set<Entity>().Remove(entity);
            context.SaveChanges();
        }

        public void Modificar(Entity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}