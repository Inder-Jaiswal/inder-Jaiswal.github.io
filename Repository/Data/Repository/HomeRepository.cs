using Port.Data.Entities;

namespace Port.Data.Repository
{
    public class HomeRepository:IHomeRepository
    {
        public List<Home> GetHomes()
        {

            var projectDesc = new Home();
            {
                projectDesc.Name = "inder-PortFolio";
                projectDesc.Id = "1st";
                projectDesc.Description = "the site is built using angular.js , bootstrap, di, html, css, js and other technologies to support this data ";
                projectDesc.PArchitecture = "Angular on .net";
            };
            var projectReviewList = new List<Home>();
            projectReviewList.Add(projectDesc);
            return projectReviewList;
        }
    }
}
