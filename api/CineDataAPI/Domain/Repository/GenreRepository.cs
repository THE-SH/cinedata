using System.Collections.Generic;
using CineDataAPI.Data;
using CineDataAPI.Domain.Entities;
using CineDataAPI.Domain.Repository.Interfaces;

namespace CineDataAPI.Domain.Repository{
    public class GenreRepository : BaseRepository<Genre>, IGenreRepository
    {
        public GenreRepository(DataContext context) : base(context)
        {
        }

        public override void Add(Genre entity)
        {
            base.Add(entity);
        }

        public override void Delete(Genre entity)
        {
            base.Delete(entity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override Genre GetById(int id)
        {
            return base.GetById(id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override List<Genre> ListAll(bool lazyLoading)
        {
            return base.ListAll(lazyLoading);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Update(Genre entity)
        {
            base.Update(entity);
        }
    }
}