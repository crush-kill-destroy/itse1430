/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 04
 */
using System;
using System.Collections.Generic;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        public Product Add ( Product product )
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            NameCheck(product.Name, product.Id);
            ObjectValidator.TryValidateFullObject(product);

            //Emulate database by storing copy
            return AddCore(product);
        }

        private void NameCheck ( string name, int id )
        {
            var products = GetAllCore();
            foreach (var product in products)
                if (product.Name == name && product.Id != id)
                    throw new InvalidOperationException("Names must be unique!");
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Must be greater than 0!");

            return GetCore(id);
        }

        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll ()
        {
            return GetAllCore();
        }

        /// <summary>Removes the product.</summary>
        /// <param name="id">The product to remove.</param>
        public void Remove ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than 0");

            RemoveCore(id);
        }

        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update ( Product product )
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            NameCheck(product.Name, product.Id);
            ObjectValidator.TryValidateFullObject(product);

            //Get existing product
            var existing = GetCore(product.Id);

            return UpdateCore(existing, product);
        }

        #region Protected Members

        protected abstract Product GetCore ( int id );

        protected abstract IEnumerable<Product> GetAllCore ();

        protected abstract void RemoveCore ( int id );

        protected abstract Product UpdateCore ( Product existing, Product newItem );

        protected abstract Product AddCore ( Product product );
        #endregion
    }
}
