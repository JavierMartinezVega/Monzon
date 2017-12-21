
namespace Monzon.BL.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;
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
                return db.PLACE.Include(p => p.PLACE_TYPE).Where(p => !p.DELETED).ToList();
            }
        }


        public List<PLACE> GetHives()
        {
            using (var db = new MonzonEntities())
            {
                return null;
                //return db.PLACE.Where(p => !p.DELETED && p.HIVE_ID != null).ToList();
            }
        }
    }
}
