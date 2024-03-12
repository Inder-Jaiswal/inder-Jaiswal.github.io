using Port.Data.Entities;
using Port.Data.Repository;

namespace Port.Services
{
    public class HomeService: IHomeService
    {
        private readonly IConfiguration _configuration;
        private readonly IHomeRepository _homeRepository;
        #region ctor
        public HomeService(IConfiguration configuration, IHomeRepository homeRepository)
        {
            this._configuration = configuration;
            this._homeRepository = homeRepository;
        }
        #endregion

        public List<Home>GetHomes()
        {
            return _homeRepository.GetHomeData();
        }
    }
}
