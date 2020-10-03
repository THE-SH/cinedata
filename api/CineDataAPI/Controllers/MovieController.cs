using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using CineDataAPI.Domain.Entities;
using CineDataAPI.Domain.Repository;
using CineDataAPI.Domain.Repository.Interfaces;

namespace CineDataAPI.Controlles{
    [ApiController]
    [Route("v1/movie")]
    public class MovieController : ControllerBase{

        private readonly IMovieRepository _movieRepository;
        private readonly ILogger<Movie> _logger;
        public MovieController(
            IMovieRepository movieRepository,
            ILogger<Movie> logger
        ){
            this._movieRepository = movieRepository;
            this._logger = logger;
        }

        [HttpGet]
        [Route("ListAll")]
        public async Task<ActionResult<List<Movie>>> ListAll(){
            try
            {
                return Ok(_movieRepository.ListAll(false));   
            }
            catch (ArgumentException ex)
            {
                _logger.Log(LogLevel.Error,ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError,ex.Message);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError,ex.Message);
            }
        }

        [HttpGet]
        [Route("Add")]
        public async Task<ActionResult<Movie>> Add(){
            try
            {
                Movie movie = new Movie(){
                    Id = 0,
                    Title = "Nova Irmandade"
                };
                _movieRepository.Add(movie);
                return Ok("Cadastrado com sucesso!");                
            }
            catch (ArgumentException ex)
            {
                _logger.Log(LogLevel.Error,ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error,ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}