

namespace Monzon.BL.Repository
{
    using System;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;
    using Model;

    /// <summary>
    /// Base service with common functionalities for services
    /// </summary>
    /// <typeparam name="T">Type of object</typeparam>
    public class BaseRepository<T> where T : class
    {
        #region Constants
        #endregion

        #region Fields
        #endregion

        #region Lifetime
        #endregion

        #region Properties
        #endregion

        #region Public Methods

        /// <summary>
        /// Get an entity by its unique identifier
        /// </summary>
        /// <param name="id">Entity unique identifier</param>
        /// <returns>The entity</returns>
        public T Get(long id)
        {
            T entity;

            try
            {
                using (var context = new MonzonEntities())
                {
                    entity = context.Set<T>().Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Error getting entity with id {0}", id), ex);
            }

            return entity;
        }

        /// <summary>
        /// Get an entity by its unique identifier
        /// </summary>
        /// <param name="entity">Entity unique identifier</param>
        /// <returns>The entity</returns>
        public T New(T entity)
        {
            try
            {
                using (var context = new MonzonEntities())
                {
                    entity = context.Set<T>().Add(entity);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Error creating entity"), ex);
            }

            return entity;
        }

        /// <summary>
        /// Returns the entity number of rows
        /// </summary>
        /// <returns>Entity number of rows</returns>
        public long Count()
        {
            long count;

            try
            {
                using (MonzonEntities context = new MonzonEntities())
                {
                    count = context.Set<T>().Count();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading entity number of rows", ex);
            }

            return count;
        }

        /// <summary>
        /// returns the entity validation error from a <c>DbEntityValidationException</c>
        /// </summary>
        /// <param name="exc">Exception to be evaluated</param>
        /// <returns>String information with the exception evaluated</returns>
        protected string GetValidationInformation(Exception exc)
        {
            StringBuilder validationMessage = new StringBuilder();

            if (exc is DbEntityValidationException)
            {
                foreach (var entityValidationError in ((DbEntityValidationException)exc).EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationError.ValidationErrors)
                    {
                        validationMessage.AppendFormat("[Property: \"{0}\", Error: \"{1}\"]", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

            return validationMessage.ToString();
        }

        #endregion

        /// <summary>
        /// Class with all constants related to to synchronization operation types
        /// </summary>
        public class SynchronizationOperation
        {
            #region Constants

            /// <summary>
            /// Constant for the value of the Insert operation
            /// </summary>
            public const string Insert = "INSERT";

            /// <summary>
            /// Constant for the value of the Update operation
            /// </summary>
            public const string Update = "UPDATE";

            /// <summary>
            /// Constant for the value of the Delete operation
            /// </summary>
            public const string Delete = "DELETE";

            #endregion
        }
    }
}
