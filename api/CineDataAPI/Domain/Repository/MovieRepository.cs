using System;
using System.Collections.Generic;
using System.Linq;
using CineDataAPI.Data;
using CineDataAPI.Domain.Entities;
using CineDataAPI.Domain.Repository.Interfaces;

namespace CineDataAPI.Domain.Repository
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(DataContext context) : base(context)
        {
        }

        public override void Add(Movie entity)
        {   
            if(_db.Movies.Any(x=>x.Id == entity.Id))
                throw new ArgumentException("Este filme já está cadastrado!");
            _db.Movies.Add(entity);
            _db.SaveChanges();
        } 

        public override void Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public override Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Movie> ListAll(bool lazyLoading)
        {
            return _db.Movies.ToList();
        }

        public override void Update(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}