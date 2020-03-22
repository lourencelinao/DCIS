using DB;
using Object_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class ItemForm : Form
    {
        private List<item> item_list;
        private int i;
        private string original; //this is for the where clause when updating or deleting fields
        public ItemForm()
        {
            InitializeComponent();
            this.Text = "Items";
            loadItemsToList();


        }

       
 

        private void addItem_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(addItemNameTextBox.Text) || string.IsNullOrEmpty(addItemDescriptionTextBox.Text))
                {
                    MessageBox.Show("Enter an item name and/or an item description.", "Error",
                        MessageBoxButtons.OK);

                }
                else
                {
                    string name = addItemNameTextBox.Text;
                    string description = addItemDescriptionTextBox.Text;
                    //int department = addItemDepartmentGroupBox.SelectedIndex + 1;


                    //capitalize first letter
                    name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
                    //add to db
                    string query = "insert into item(item_name, item_description)" +
                        "values('" + name + "', '" + description + "') ";
                    DBConnect dbc = new DBConnect();
                    dbc.query(query);
                    //add to listview
                    listViewItems.Items.Add(new ListViewItem(new string[] {
                    name, description
                }));

                    MessageBox.Show("Item Added Succesfully!");
                    addItemNameTextBox.Clear();
                    addItemDescriptionTextBox.Clear();
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void loadItemsToList()
        {
            DBConnect dbc = new DBConnect();
            string query = "SELECT * FROM item";
            item_list = dbc.DBToItemList(query);
            foreach(var item in item_list)
            {
                listViewItems.Items.Add(new ListViewItem(new string[] {
                    item.Item_Name, item.Item_Description
                }));
            }

            listViewItems.Refresh();
            
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewItems.SelectedItems.Count == 1)
            {
                int checker = 0;
                for(i = listViewItems.Items.Count - 1; i >= 0 && checker != 1; i--)
                {
                    if(listViewItems.Items[i].Selected == true)
                    {
                        addItemNameTextBox.Text = listViewItems.Items[i].SubItems[0].Text;
                        original = addItemNameTextBox.Text; //this is for the where clause when updating fields
                        addItemDescriptionTextBox.Text = listViewItems.Items[i].SubItems[1].Text;
                        checker = 1;
                    }
                }
                editItem.Enabled = true;
                deleteItem.Enabled = true;
                addItem.Enabled = false;
            }
            else if(listViewItems.SelectedItems.Count == 0 || listViewItems.SelectedItems.Count > 1)
            {
                addItem.Enabled = true;
                clear();
            }
        }

        private void clearBtn_MouseClick(object sender, MouseEventArgs e)
        {
            clear();
        }

        private void clear()
        {
            editItem.Enabled = false;
            deleteItem.Enabled = false;
            addItemNameTextBox.Clear();
            addItemDescriptionTextBox.Clear();
            addItem.Enabled = true;
            searchItemTextBox.Clear();
        }

        private void editItem_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(addItemNameTextBox.Text) || string.IsNullOrEmpty(addItemDescriptionTextBox.Text))
                {
                    MessageBox.Show("Update fields should not be empty!", "Update error!", MessageBoxButtons.OK);
                }
                else
                {
                    int x = i + 1;
                    string name = addItemNameTextBox.Text;                  
                    string description = addItemDescriptionTextBox.Text;

                    //capitalize first letter
                    name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
                    string query = "update item set item_name='"+name+"', item_description='"+description+"' where " +
                        "item_name='"+original+"' ";

                    //update db
                    DBConnect dbc = new DBConnect();
                    dbc.query(query);

                    //update listview
                    ListViewItem item = new ListViewItem(new string[] {name, description });
                    listViewItems.Items.RemoveAt(x);
                    listViewItems.Items.Insert(x, item);
                    MessageBox.Show("Item updated successfully!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteItem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if(listViewItems.SelectedItems.Count == 1)
                {
                    int x = i + 1;
                    DBConnect dbc = new DBConnect();
                    string query = "delete from item where item_name='"+original+"' ";
                    dbc.query(query);

                    listViewItems.Items.RemoveAt(x);
                    MessageBox.Show("Item deleted succesfully!");
                }

            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void searchItemTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(searchItemTextBox.Text != "")
            {
                string search = searchItemTextBox.Text;
                search = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(search.ToLower());
                foreach (ListViewItem item in listViewItems.Items)
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
