using System;
using System.Collections.Generic;
using TournamentBracket.Data;
using TournamentBracket.Dtos;
using System.Data.Entity;
using System.Linq;
using TournamentBracket.Models;

namespace TournamentBracket.Services
{
    public class MatchService : IMatchService
    {
        public MatchService(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.Matches;
            _cache = cacheProvider.GetCache();
        }

        public MatchAddOrUpdateResponseDto AddOrUpdate(MatchAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new Match());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new MatchAddOrUpdateResponseDto(entity);
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        public ICollection<MatchDto> Get()
        {
            ICollection<MatchDto> response = new HashSet<MatchDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach(var entity in entities) { response.Add(new MatchDto(entity)); }    
            return response;
        }


        public MatchDto GetById(int id)
        {
            return new MatchDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        protected readonly IUow _uow;
        protected readonly IRepository<Match> _repository;
        protected readonly ICache _cache;
    }
}
