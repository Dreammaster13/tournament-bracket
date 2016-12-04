using System;
using System.Collections.Generic;
using TournamentBracket.Data;
using TournamentBracket.Dtos;
using System.Data.Entity;
using System.Linq;
using TournamentBracket.Models;

namespace TournamentBracket.Services
{
    public class DivisionService : IDivisionService
    {
        public DivisionService(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.Divisions;
            _cache = cacheProvider.GetCache();
        }

        public DivisionAddOrUpdateResponseDto AddOrUpdate(DivisionAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new Division());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new DivisionAddOrUpdateResponseDto(entity);
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        public ICollection<DivisionDto> Get()
        {
            ICollection<DivisionDto> response = new HashSet<DivisionDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach(var entity in entities) { response.Add(new DivisionDto(entity)); }    
            return response;
        }


        public DivisionDto GetById(int id)
        {
            return new DivisionDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        protected readonly IUow _uow;
        protected readonly IRepository<Division> _repository;
        protected readonly ICache _cache;
    }
}
