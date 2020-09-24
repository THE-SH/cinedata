using System;
using System.Collections.Generic;
using System.Linq;
using CineDataAPI.Domain.Entities;
using CineDataAPI.Domain.Repository.Interfaces;

namespace CineDataAPI.Domain.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private List<Movie> moviesMock = new List<Movie>(){
            new Movie(){
                Id = 1,
                Title = "Matrix Revolution"
            }, 
            new Movie(){
                Id = 2,
                Title = "Vingadores Ultimato"
            }
        };

        public bool Add(Movie entity)
        {
            moviesMock.Add(entity);
            return true;
        }

        public bool Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> ListAll(bool lazyLoading)
        {
            return moviesMock.ToList();
        }

        public bool Update(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}