using BussinesLayer.Objects;
using DataAccessLayer.Models;

namespace BussinesLayer.Converter
{
    public class ConvertPost
    {
        public Post ConvertBussinesObjectToPost(PostObject postObject)
        {
            Post _newPost = new Post() {
                PostId = postObject.PostId,
                PostName = postObject.PostName,
                Text = postObject.Text,
                Category = postObject.Category,
                DataTime = postObject.DataTime,
            };

            return _newPost;
        }
    }
}