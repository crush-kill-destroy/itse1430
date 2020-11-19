/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 04
 */
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm ()
        {
            InitializeComponent();
        }
        #endregion

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            _gridProducts.AutoGenerateColumns = false;

            UpdateList();
        }

        #region Event Handlers

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnProductAdd ( object sender, EventArgs e )
        {
            try
            {
                var child = new ProductDetailForm("Product Details");
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                //Save product
                _database.Add(child.Product);
                UpdateList();
            } catch (SqlException)
            {
                ErrorMessage("Database failure!", "Add Failed!");
            } catch (Exception ex)
            {
                ErrorMessage(ex.Message, "Add failed!");
            }
        }

        private void OnProductEdit ( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("No products available.");
                return;
            };

            EditProduct(product);
        }

        private void OnProductDelete ( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
                return;

            DeleteProduct(product);
        }

        private void OnEditRow ( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            //Handle column clicks
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Product;

            if (item != null)
                EditProduct(item);
        }

        private void OnKeyDownGrid ( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var product = GetSelectedProduct();
            if (product != null)
                DeleteProduct(product);

            //Don't continue with key
            e.SuppressKeyPress = true;
        }

        #endregion

        #region Private Members

        private void DeleteProduct ( Product product )
        {
            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                //Delete product
                _database.Remove(product.Id);
                UpdateList();
            } catch (SqlException)
            {
                throw new Exception("Database failure!");
            } catch (Exception e)
            {
                ErrorMessage(e.Message, "Deletion Failed!");
            }
        }

        private void EditProduct ( Product product )
        {
            var child = new ProductDetailForm("Product Details");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                //Save product
                _database.Update(child.Product);
                UpdateList();
            } catch (SqlException)
            {
                ErrorMessage("Database Failure", "Edit Failed!");
            } catch (Exception e)
            {
                ErrorMessage(e.Message, "Edit Failed!");
            }
        }

        private Product GetSelectedProduct ()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList ()
        {
            try
            {
                _bsProducts.DataSource = _database.GetAll();
            } catch (SqlException)
            {
                throw new Exception("Database failure!");
            } catch
            {
                ErrorMessage("Database Failure", "Update Failed!");
            }
        }
        #endregion

        private void _miAbout_Click ( object sender, EventArgs e )
        {
            var about = new AboutBox();
            about.ShowDialog(this);
        }

        private void ErrorMessage ( string error, string title )
        {
            MessageBox.Show(this, error, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static string s_connectionString = ConfigurationManager.ConnectionStrings["NileDbConnectionString"].ConnectionString;
        private IProductDatabase _database = new Nile.Stores.Sql.SqlProductDatabase(s_connectionString);
    }
}
