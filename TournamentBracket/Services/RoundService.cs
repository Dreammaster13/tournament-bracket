using System;
using System.Collections.Generic;
using TournamentBracket.Dtos;
using TournamentBracket.Data;
using System.Linq;

namespace TournamentBracket.Services
{
    public class RoundService : IRoundService
    {
        public RoundService(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.Rounds;
            _cache = cacheProvider.GetCache();
        }

        public RoundAddOrUpdateResponseDto AddOrUpdate(RoundAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new Models.Round());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new RoundAddOrUpdateResponseDto(entity);
        }

        public ICollection<RoundDto> Get()
        {
            ICollection<RoundDto> response = new HashSet<RoundDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach (var entity in entities) { response.Add(new RoundDto(entity)); }
            return response;
        }

        public RoundDto GetById(int id)
        {
            return new RoundDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        protected readonly IUow _uow;
        protected readonly IRepository<Models.Round> _repository;
        protected readonly ICache _cache;
    }
}
