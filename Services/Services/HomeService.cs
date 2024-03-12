using AutoMapper;
using Port.Data.Entities;
using Port.Data.Repository;

namespace Port.Services
{
    public class HomeService: IHomeService
    {
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;
        #region ctor
        public HomeService(IHomeRepository homeRepository, IMapper mapper)
        {
            this._homeRepository = homeRepository;
            _mapper = mapper;
        }
        #endregion

        public List<Home> GetHomes()
        {
            var homeEn = _homeRepository.GetHomes();
            return homeEn;
        }
    }
}
