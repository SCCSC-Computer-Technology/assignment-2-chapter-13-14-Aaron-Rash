//Aaron Rash
//CPT 206
//Lab-1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aaron_Rash_CPT_206_Lab_1
{
    //I left in both a datagrid view and a listbox, because i thought it was kinda neat to have an easy read mode
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //On form load
        private void Form1_Load(object sender, EventArgs e)
        {
            //Create data context object
            ProductDBDataContext db = new ProductDBDataContext();

            //Select items to populate grid
            var products = from product in db.Products
                           orderby product.Units_On_Hand ascending
                           select product;

            //Fill grid with selected items (all)
            foreach (Product product in products)
            {
                productDataGridView.DataSource = products.ToList();
                ProductListBox.Items.Add(product.Description);
            }
        }

        //Search by number button
        private void bSearchProductNum_Click(object sender, EventArgs e)
        {
            //Data context object
            ProductDBDataContext db = new ProductDBDataContext();

            //clear list (So items dont just get added to end of list)
            ProductListBox.Items.Clear();

            //Get results with matching product number
            var results = from product in db.Products
                          where product.Product_Number == tSearchProductNum.Text
                          select product;

            //Fill grid with filtered results
            foreach(Product product in results)
            {
                productDataGridView.DataSource = results.ToList();
                ProductListBox.Items.Add(product.Description);
            }
        }

        //Search by Description Button
        private void bSearchProductDesc_Click(object sender, EventArgs e)
        {
            //New data context object
            ProductDBDataContext db = new ProductDBDataContext();

            //clear list (So items dont just get added to end of list)
            ProductListBox.Items.Clear();

            //Get results with matching description
            var results = from product in db.Products
                          where product.Description == tSearchProductDesc.Text
                          select product;

            //Fill grid with filtered results
            foreach (Product product in results)
            {
                productDataGridView.DataSource = results.ToList();
                ProductListBox.Items.Add(product.Description);
            }

        }

        //More Than Button
        private void bMoreThan_Click(object sender, EventArgs e)
        {
            //New data context object
            ProductDBDataContext db = new ProductDBDataContext();

            //clear list (So items dont just get added to end of list)
            ProductListBox.Items.Clear();

            try //Error handling for when no user input (Textbox blank)
            {
                //Get results with units greater than user input
                var results = from product in db.Products
                              where product.Units_On_Hand > int.Parse(tMoreThan.Text)
                              select product;

                //Populate grid with filtered results
                foreach (Product product in results)
                {
                    productDataGridView.DataSource = results.ToList();
                    ProductListBox.Items.Add(product.Description);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number"); //Show message if error occurs
            }
        }

        //Less Than Button
        private void bLessThan_Click(object sender, EventArgs e)
        {
            //New data context object
            ProductDBDataContext db = new ProductDBDataContext();

            //clear list (So items dont just get added to end of list)
            ProductListBox.Items.Clear();

            try //Error handling for when no user input (Textbox blank)
            {
                //Get items with less units than user input
                var results = from product in db.Products
                              where product.Units_On_Hand < int.Parse(tLessThan.Text)
                              select product;

                //Populate grid with filtered results
                foreach (Product product in results)
                {
                    productDataGridView.DataSource = results.ToList();
                    ProductListBox.Items.Add(product.Description);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Number");
            }
        }

        //Between Button
        private void bBetween_Click(object sender, EventArgs e)
        {
            //New data context object
            ProductDBDataContext db = new ProductDBDataContext();

            //clear list (So items dont just get added to end of list)
            ProductListBox.Items.Clear();

            try //Error handling for when no user input (Textbox blank)
            {
                //Get items with less units than user input
                var results = from product in db.Products
                              where product.Price <= decimal.Parse(tMax.Text) && product.Price >= decimal.Parse(tMin.Text) //Must be decimal since price data is decimal
                              select product;

                //Populate grid with filtered results
                foreach (Product product in results)
                {
                    productDataGridView.DataSource = results.ToList();
                    ProductListBox.Items.Add(product.Description);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Number in Both 'Min' & 'Max' Boxes");
            }
        }

        //Sort by Price Button
        private void bSortPrice_Click(object sender, EventArgs e)
        {
            ProductDBDataContext db = new ProductDBDataContext();

            //clear list (So items dont just get added to end of list)
            ProductListBox.Items.Clear();

            //Select all items and sort by price ascending
            var products = from product in db.Products
                           orderby product.Price ascending //Sort price ascending
                           select product;

            //Populate grid with filtered results
            foreach (Product product in products)
            {
                productDataGridView.DataSource = products.ToList();
                ProductListBox.Items.Add(product.Description);

            }
        }

        //Sort by Units Button
        private void bSortUnits_Click(object sender, EventArgs e)
        {
            //New data context button
            ProductDBDataContext db = new ProductDBDataContext();

            //clear list (So items dont just get added to end of list)
            ProductListBox.Items.Clear();

            //Sort by units ascending
            var products = from product in db.Products
                           orderby product.Units_On_Hand ascending //Sort by units ascending
                           select product;

            //Populate grid with filtered results
            foreach (Product product in products)
            {
                productDataGridView.DataSource = products.ToList();
                ProductListBox.Items.Add(product.Description);
            }
        }  

        //Close Button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close this ;)
        }
    }
}
