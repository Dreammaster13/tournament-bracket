using System;
using System.Collections.Generic;
using TournamentBracket.Data;
using TournamentBracket.Dtos;
using System.Data.Entity;
using System.Linq;
using TournamentBracket.Models;

namespace TournamentBracket.Services
{
    public class EntrantService : IEntrantService
    {
        public EntrantService(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.Entrants;
            _cache = cacheProvider.GetCache();
        }

        public EntrantAddOrUpdateResponseDto AddOrUpdate(EntrantAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new Entrant());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new EntrantAddOrUpdateResponseDto(entity);
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        public ICollection<EntrantDto> Get()
        {
            ICollection<EntrantDto> response = new HashSet<EntrantDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach(var entity in entities) { response.Add(new EntrantDto(entity)); }    
            return response;
        }


        public EntrantDto GetById(int id)
        {
            return new EntrantDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        protected readonly IUow _uow;
        protected readonly IRepository<Entrant> _repository;
        protected readonly ICache _cache;
    }
}
