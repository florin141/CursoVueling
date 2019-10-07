using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core;
using ControlPlagas.Core.Data;

namespace ControlPlagas.Data
{
    public class ControlPlagasRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbContext _dbContext;
        private IDbSet<TEntity> _entities;

        public ControlPlagasRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region Methods
        public TEntity GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public void Insert(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            this.Entities.Add(entity);

            this._dbContext.SaveChanges();
        }

        public virtual void Insert(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            foreach (var entity in entities)
                this.Entities.Add(entity);

            this._dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            this._dbContext.SaveChanges();
        }

        public virtual void Update(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            this._dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            this.Entities.Remove(entity);

            this._dbContext.SaveChanges();
        }

        public virtual void Delete(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            foreach (var entity in entities)
                this.Entities.Remove(entity);

            this._dbContext.SaveChanges();
        }
        #endregion

        #region Properties

        public IQueryable<TEntity> Table
        {
            get
            {
                return this.Entities;
            }
        }

        protected virtual IDbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _dbContext.Set<TEntity>();
                }

                return _entities;
            }
        }

        #endregion
    }
}
