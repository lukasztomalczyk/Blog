using BussinesLayer.Converter;
using BussinesLayer.Objects;
using DataAccessLayer;

namespace BussinesLayer.Services
{
    public class PostService : IPostService
    {
        private DataAccess _dataAccess;
        private ConvertPost Converter;
        public PostService(DataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
            ConvertPost Converter = new ConvertPost();
        }

        public PostObject CreatePostObject (PostObject postObject)
        {
            using (IEntryToDatabase entryToDatabase = _dataAccess.EntryToDatabase)
            {
                entryToDatabase.PostRepository.Create(Converter.ConvertBussinesObjectToPost(postObject));
                entryToDatabase.Save();
            }
            return postObject;
        }
    }
}