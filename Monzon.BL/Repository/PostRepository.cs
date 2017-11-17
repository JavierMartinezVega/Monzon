
namespace Monzon.BL.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using Model;

    public class PostRepository : BaseRepository<POST>
    {
        /// <summary>
        /// Gets the unique instance
        /// </summary>
        public static PostRepository Instance { get; } = new PostRepository();

        public List<POST> GetDescendingDate(int page, int pageSize)
        {
            using (var db = new MonzonEntities())
            {
                return db.POST.OrderByDescending(x => x.POST_DATE).Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public POST GetPost(int idPost)
        {
            using (var db = new MonzonEntities())
            {
                return db.POST.FirstOrDefault(p => p.UNIQUE_ID == idPost);
            }
        }
    }
}
