using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProject.Data
{
    public static class EFExtension
    {

        public static void AddRange<TEntity>(this DbSet<TEntity> dbSet, IList<TEntity> entities) where TEntity : class
        {
            foreach (TEntity e in entities)
            {
                dbSet.Add(e);
            }
        }
    }
}
