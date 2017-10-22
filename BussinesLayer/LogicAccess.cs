using BussinesLayer.Services;
using DataAccessLayer;

namespace BussinesLayer
{
    public class LogicAccess
    {
        private DataAccess _dataAccess;
        DataAccess dataAccess = new DataAccess();

        public LogicAccess()
        {
            this._dataAccess = dataAccess;
        }

        public IPostService PostService
        {
            get { return new PostService(dataAccess); }
        }
    }
}