
namespace Monzon.BL.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using Model;

    public class PlaceRepository : BaseRepository<PLACE>
    {

        /// <summary>
        /// unique instance 
        /// </summary>
        private static readonly PlaceRepository ServiceInstance = new PlaceRepository();

        /// <summary>
        /// Gets the unique instance
        /// </summary>
        public static PlaceRepository Instance => ServiceInstance;

        public List<PLACE> GetPlaces()
        {
            using (var db = new MonzonEntities())
            {
                return db.PLACE.Where(p => !p.DELETED && p.HIVE_ID == null).ToList();
            }
        }


        public List<PLACE> GetHives()
        {
            using (var db = new MonzonEntities())
            {
                return db.PLACE.Where(p => !p.DELETED && p.HIVE_ID != null).ToList();
            }
        }
    }
}
