using DB;
using Object_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class ProductForm : Form
    {
        private int i;
        private List<product> product_list;
        private string original; // for where clause when deleting or updating
        public ProductForm()
        {
            InitializeComponent();
            this.Text = "Product";
            loadProductsToList();
        }

        private void addProduct_MouseClick(object sender, MouseEventArgs e)
        {
            AddProductForm product = new AddProductForm();
            product.ShowDialog();
        }

        private void editProduct_MouseClick(object sender, MouseEventArgs e)
        {
            EditProductForm product = new EditProductForm();
            product.ShowDialog();
        }

        private void loadProductsToList()
        {
            DBConnect dbc = new DBConnect();
            string query = "SELECT * from product";
            product_list =  dbc.DBToListProduct(query);
            foreach(var product in product_list)
            {
                listViewProducts.Items.Add(new ListViewItem(new string[]
                {
                    product.ProductName, product.ProductDescription, product.ProductQuantitiy.ToString(), product.ProductPrice.ToString()
                }));
            }
        }

        private void clear()
        {
            editProduct.Enabled = false;
            deleteProduct.Enabled = false;
            addProductNameTextBox.Clear();
            addProductDescriptionTextBox.Clear();
            addProductQuantity.Clear();
            addProductPrice.Clear();

            addProduct.Enabled = true;
            searchProductTextBox.Clear();
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count == 1)
            {
                int checker = 0;
                for (i = listViewProducts.Items.Count - 1; i >= 0 && checker != 1; i--)
                {
                    if (listViewProducts.Items[i].Selected == true)
                    {
                        addProductNameTextBox.Text = listViewProducts.Items[i].SubItems[0].Text;
                        addProductDescriptionTextBox.Text = listViewProducts.Items[i].SubItems[1].Text;
                        addProductQuantity.Text = listViewProducts.Items[i].SubItems[2].Text;
                        addProductPrice.Text = listViewProducts.Items[i].SubItems[3].Text;
                        checker = 1;
                        original = addProductNameTextBox.Text;
                    }
                }
                editProduct.Enabled = true;
                deleteProduct.Enabled = true;
                addProduct.Enabled = false;
            }
            else if (listViewProducts.SelectedItems.Count == 0 || listViewProducts.SelectedItems.Count > 1)
            {
                addProduct.Enabled = true;
                clear();
            }
        }

        private void addProduct_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(addProductNameTextBox.Text) || string.IsNullOrEmpty(addProductDescriptionTextBox.Text) ||
                    string.IsNullOrEmpty(addProductQuantity.Text) || string.IsNullOrEmpty(addProductPrice.Text))
                {
                    MessageBox.Show("Product fields must not be empty!", "Add Error", MessageBoxButtons.OK);
                }
                else
                {
                    string name = addProductNameTextBox.Text;
                    string description = addProductDescriptionTextBox.Text;
                    int qty = int.Parse(addProductQuantity.Text);
                    double price = double.Parse(addProductPrice.Text);

                    //capitalize words
                    name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

                    //db
                    string query = "insert into product(product_name, product_description, product_qty, product_price)" +
                        "values('"+name+ "', '"+description+ "', '"+qty+ "', '"+price+"')  ";
                    DBConnect dbc = new DBConnect();
                    dbc.query(query);
                    //listview
                    listViewProducts.Items.Add(new ListViewItem(new string[] { 
                        name, description, qty.ToString(), price.ToString()
                    }));

                    MessageBox.Show("Product added succesfully!");
                }
            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void clearBtn_MouseClick(object sender, MouseEventArgs e)
        {
            clear();
        }

        private void editProduct_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(addProductNameTextBox.Text) || string.IsNullOrEmpty(addProductDescriptionTextBox.Text) ||
                    string.IsNullOrEmpty(addProductQuantity.Text) || string.IsNullOrEmpty(addProductPrice.Text))
                {
                    MessageBox.Show("Update fields must not be empty!", "Update error!", MessageBoxButtons.OK);
                }
                else
                {
                    int x = i + 1;
                    string name = addProductNameTextBox.Text;
                    string description = addProductDescriptionTextBox.Text;
                    int qty = int.Parse(addProductQuantity.Text);
                    double price = double.Parse(addProductPrice.Text);

                    //capitalize words
                    name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

                    //db
                    DBConnect dbc = new DBConnect();
                    string query = "update product set product_name='"+name+"'," +
                        "product_description='"+description+"', product_qty='"+qty+"', product_price='"+price+"' " +
                        "where product_name='"+original+"' ";
                    dbc.query(query);

                    //listview
                    ListViewItem item = new ListViewItem(new string[] { name, description, qty.ToString(), price.ToString() });
                    listViewProducts.Items.RemoveAt(x);
                    listViewProducts.Items.Insert(x, item);
                    MessageBox.Show("Product updated succesfully!");
                }
            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void deleteProduct_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if(listViewProducts.SelectedItems.Count == 1)
                {
                    int x = i + 1;
                    DBConnect dbc = new DBConnect();
                    string query = "DELETE from product where product_name='" + original + "' ";
                    dbc.query(query);
                    listViewProducts.Items.RemoveAt(x);
                    MessageBox.Show("Product deleted succesfully!");
                }
            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void searchProductTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(searchProductTextBox.Text != "")
            {
                string search = searchProductTextBox.Text;
                search = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(search.ToLower());
                foreach(ListViewItem item in listViewProducts.Items)
                {
                    if(item.SubItems[0].Text == search)
                    {
                        item.Selected = true;
                    }
                    else
                    {
                        item.Selected = false;
                    }
                }
            }
        }
    }
 }

