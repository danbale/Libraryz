using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSUABC.Repositorios.Repositorio_Generico
{
    interface IRepositorioGenerico<Entity> where Entity : class
    {
        IEnumerable<Entity> BuscarTodos();
        Entity BuscarPorId(int id);
        void Agregar(Entity entity);
        void Borrar(Entity entity);
        void Modificar(Entity entity);
    }
}
