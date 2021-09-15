﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-QTLH4POT\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void f2_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayData()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = "Select * from orderDetails";
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();

                int sn = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    sn++;
                    dataGridView1.Rows.Add(sn, dataRow["category"], dataRow["items"], dataRow["quantity"], dataRow["unitprice"], dataRow["totalprice"]);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            get_GrandTotal();
        }

        private void get_GrandTotal()
        {
            float grandTotal = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                grandTotal += float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            grandTotalLabel.Text = "Rs. " + grandTotal.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void label85_Click(object sender, EventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void label96_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void label100_Click(object sender, EventArgs e)
        {

        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secondaryTab.SelectedTab == snacks)
            {
                categoryBox.Text = "Snacks";
            }
            else if (secondaryTab.SelectedTab == mainCourse)
            {
                categoryBox2.Text = "Main Course";
            }
            else if (secondaryTab.SelectedTab == dessert)
            {
                categoryBox3.Text = "Dessert";
            }
            else if (secondaryTab.SelectedTab == coldDrinks)
            {
                categoryBox4.Text = "Cold Drinks";
            }
            else
            {
                categoryBox5.Text = "Beverages";
            }
        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void categoryBox_TextChanged(object sender, EventArgs e)
        {

        }

        string unitPrice;
        private void snackComboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = snackComboList.GetItemText(snackComboList.SelectedItem);
            string pricetxt;
            snackQuantity.Value = 0;
            switch (txt)
            {
                case "French Fries":
                    pricetxt = label18.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    snackUnitPrice.Text = unitPrice;
                    break;
                case "Sandwich":
                    pricetxt = label13.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    snackUnitPrice.Text = unitPrice;
                    break;
                case "Devil Eggs":
                    pricetxt = label14.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    snackUnitPrice.Text = unitPrice;
                    break;
                case "Oreos":
                    pricetxt = label15.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    snackUnitPrice.Text = unitPrice;
                    break;
                case "Bake and Shark":
                    pricetxt = bakeSharklabel.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    snackUnitPrice.Text = unitPrice;
                    break;
                case "Chocolate Chips":
                    pricetxt = label07.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    snackUnitPrice.Text = unitPrice;
                    break;
                case "Bacon":
                    pricetxt = label19.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    snackUnitPrice.Text = unitPrice;
                    break;
                case "Clam Cakes":
                    pricetxt = label20.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    snackUnitPrice.Text = unitPrice;
                    break;
                case "Bear Claw":
                    pricetxt = label21.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    snackUnitPrice.Text = unitPrice;
                    break;
                case "Ham Biscuits":
                    pricetxt = label22.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    snackUnitPrice.Text = unitPrice;
                    break;
                default:
                    MessageBox.Show("Items not available");
                    break;
            }
        }

        private void snackQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal cost = snackQuantity.Value;
            float total = (float)cost * float.Parse(unitPrice);
            snackTotalPrice.Text = total.ToString();
        }

        private void snackQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void addSnacksToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                if(snackTotalPrice.Text != "0" && snackTotalPrice.Text != "")
                {
                    string category = categoryBox.Text;
                    string snackItems = snackComboList.Text;
                    string quantity = snackQuantity.Text;
                    string price = snackUnitPrice.Text;
                    string totalPrice = snackTotalPrice.Text;
                    string query = "Insert into orderDetails (category, items, quantity, unitprice, totalprice) values (@parameter_category, @parameter_items, @parameter_quantity, @parameter_unitprice, @parameter_totalprice)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@parameter_category", category);
                    cmd.Parameters.AddWithValue("@parameter_items", snackItems);
                    cmd.Parameters.AddWithValue("@parameter_quantity", quantity);
                    cmd.Parameters.AddWithValue("@parameter_unitprice", price);
                    cmd.Parameters.AddWithValue("@parameter_totalprice", totalPrice);
                    cmd.ExecuteNonQuery();
                    snackComboList.Text = "";
                    snackQuantity.Value = 0;
                    snackUnitPrice.Clear();
                    snackTotalPrice.Clear();
                    MessageBox.Show("Items added to cart successfully");
                    //DisplayData();
                } else
                {
                    MessageBox.Show("Order at least one item", "Order First", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void mainCourseComboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = mainCourseComboList.GetItemText(mainCourseComboList.SelectedItem);
            string pricetxt;
            mainCourseQuantity.Value = 0;
            switch (txt)
            {
                case "Momo":
                    pricetxt = label47.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    mainCourseUnitPrice.Text = unitPrice;
                    break;
                case "Pizza":
                    pricetxt = label52.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    mainCourseUnitPrice.Text = unitPrice;
                    break;
                case "Chow-Mein":
                    pricetxt = label51.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    mainCourseUnitPrice.Text = unitPrice;
                    break;
                case "Burger":
                    pricetxt = label50.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    mainCourseUnitPrice.Text = unitPrice;
                    break;
                case "spaghetti":
                    pricetxt = label49.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    mainCourseUnitPrice.Text = unitPrice;
                    break;
                case "FryRice":
                    pricetxt = label48.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    mainCourseUnitPrice.Text = unitPrice;
                    break;
                case "Chicken-Roast":
                    pricetxt = label46.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    mainCourseUnitPrice.Text = unitPrice;
                    break;
                case "Biryani":
                    pricetxt = label45.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    mainCourseUnitPrice.Text = unitPrice;
                    break;
                case "Pork Chops":
                    pricetxt = label44.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    mainCourseUnitPrice.Text = unitPrice;
                    break;
                case "Ham Toast":
                    pricetxt = label43.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    mainCourseUnitPrice.Text = unitPrice;
                    break;
                default:
                    MessageBox.Show("Items not available");
                    break;
            }
        }

        private void mainCourseQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal cost = mainCourseQuantity.Value;
            float total = (float)cost * float.Parse(unitPrice);
            mainCourseTotalPrice.Text = total.ToString();
        }

        private void addmainCourseToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                if(mainCourseTotalPrice.Text != "0" && mainCourseTotalPrice.Text != "")
                {
                    string category = categoryBox2.Text;
                    string Items = mainCourseComboList.Text;
                    string quantity = mainCourseQuantity.Text;
                    string price = mainCourseUnitPrice.Text;
                    string totalPrice = mainCourseTotalPrice.Text;
                    string query = "Insert into orderDetails (category, items, quantity, unitprice, totalprice) values (@parameter_category, @parameter_items, @parameter_quantity, @parameter_unitprice, @parameter_totalprice)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@parameter_category", category);
                    cmd.Parameters.AddWithValue("@parameter_items", Items);
                    cmd.Parameters.AddWithValue("@parameter_quantity", quantity);
                    cmd.Parameters.AddWithValue("@parameter_unitprice", price);
                    cmd.Parameters.AddWithValue("@parameter_totalprice", totalPrice);
                    cmd.ExecuteNonQuery();
                    mainCourseComboList.Text = "";
                    mainCourseQuantity.Value = 0;
                    mainCourseUnitPrice.Clear();
                    mainCourseTotalPrice.Clear();
                    MessageBox.Show("Items added to cart successfully");
                    //DisplayData();
                }else
                {
                    MessageBox.Show("Order at least one item", "Order First", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void dessertComboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = dessertComboList.GetItemText(dessertComboList.SelectedItem);
            string pricetxt;
            dessertQuantity.Value = 0;
            switch (txt)
            {
                case "Lava cake":
                    pricetxt = label67.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    dessertUnitPrice.Text = unitPrice;
                    break;
                case "Cake":
                    pricetxt = label72.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    dessertUnitPrice.Text = unitPrice;
                    break;
                case "Cheesecake":
                    pricetxt = label71.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    dessertUnitPrice.Text = unitPrice;
                    break;
                case "Chocolate":
                    pricetxt = label70.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    dessertUnitPrice.Text = unitPrice;
                    break;
                case "Brownies":
                    pricetxt = label69.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    dessertUnitPrice.Text = unitPrice;
                    break;
                case "Fried Ice cream":
                    pricetxt = label68.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    dessertUnitPrice.Text = unitPrice;
                    break;
                case "Waffles":
                    pricetxt = label66.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    dessertUnitPrice.Text = unitPrice;
                    break;
                case "Caramet apple tart":
                    pricetxt = label65.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    dessertUnitPrice.Text = unitPrice;
                    break;
                case "Nut Truffle":
                    pricetxt = label64.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    dessertUnitPrice.Text = unitPrice;
                    break;
                case "Classic Cannoli":
                    pricetxt = label63.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    dessertUnitPrice.Text = unitPrice;
                    break;
                default:
                    MessageBox.Show("Items not available");
                    break;
            }
        }

        private void dessertQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal cost = dessertQuantity.Value;
            float total = (float)cost * float.Parse(unitPrice);
            dessertTotalPrice.Text = total.ToString();
        }

        private void addDessertToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                if(dessertTotalPrice.Text != "0" && dessertTotalPrice.Text != "")
                {
                    string category = categoryBox3.Text;
                    string Items = dessertComboList.Text;
                    string quantity = dessertQuantity.Text;
                    string price = dessertUnitPrice.Text;
                    string totalPrice = dessertTotalPrice.Text;
                    string query = "Insert into orderDetails (category, items, quantity, unitprice, totalprice) values (@parameter_category, @parameter_items, @parameter_quantity, @parameter_unitprice, @parameter_totalprice)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@parameter_category", category);
                    cmd.Parameters.AddWithValue("@parameter_items", Items);
                    cmd.Parameters.AddWithValue("@parameter_quantity", quantity);
                    cmd.Parameters.AddWithValue("@parameter_unitprice", price);
                    cmd.Parameters.AddWithValue("@parameter_totalprice", totalPrice);
                    cmd.ExecuteNonQuery();
                    dessertComboList.Text = "";
                    dessertQuantity.Value = 0;
                    dessertUnitPrice.Clear();
                    dessertTotalPrice.Clear();
                    MessageBox.Show("Items added to cart successfully");
                    //DisplayData();
                }
                else
                {
                    MessageBox.Show("Order at least one item", "Order First", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void coldDrinkItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = coldDrinkItems.GetItemText(coldDrinkItems.SelectedItem);
            string pricetxt;
            coldDrinkQuantity.Value = 0;
            switch (txt)
            {
                case "CocaCola":
                    pricetxt = label27.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    coldDrinkUnitPrice.Text = unitPrice;
                    break;
                case "Fanta":
                    pricetxt = label32.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    coldDrinkUnitPrice.Text = unitPrice;
                    break;
                case "Mountain-Dew":
                    pricetxt = label31.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    coldDrinkUnitPrice.Text = unitPrice;
                    break;
                case "Milk-Shake":
                    pricetxt = label30.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    coldDrinkUnitPrice.Text = unitPrice;
                    break;
                case "Lemonade":
                    pricetxt = label29.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    coldDrinkUnitPrice.Text = unitPrice;
                    break;
                case "Soda":
                    pricetxt = label28.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    coldDrinkUnitPrice.Text = unitPrice;
                    break;
                case "Ice-Tea":
                    pricetxt = label26.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    coldDrinkUnitPrice.Text = unitPrice;
                    break;
                case "Pepsi":
                    pricetxt = label25.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    coldDrinkUnitPrice.Text = unitPrice;
                    break;
                case "Apple-Juice":
                    pricetxt = label24.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    coldDrinkUnitPrice.Text = unitPrice;
                    break;
                case "Mango-Juice":
                    pricetxt = label23.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    coldDrinkUnitPrice.Text = unitPrice;
                    break;
                default:
                    MessageBox.Show("Items not available");
                    break;
            }
        }

        private void coldDrinkQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal cost = coldDrinkQuantity.Value;
            float total = (float)cost * float.Parse(unitPrice);
            coldDrinkTotalPrice.Text = total.ToString();
        }

        private void addDrinksToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                if(coldDrinkTotalPrice.Text != "0" && coldDrinkTotalPrice.Text != "")
                {
                    string category = categoryBox4.Text;
                    string Items = coldDrinkItems.Text;
                    string quantity = coldDrinkQuantity.Text;
                    string price = coldDrinkUnitPrice.Text;
                    string totalPrice = coldDrinkTotalPrice.Text;
                    string query = "Insert into orderDetails (category, items, quantity, unitprice, totalprice) values (@parameter_category, @parameter_items, @parameter_quantity, @parameter_unitprice, @parameter_totalprice)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@parameter_category", category);
                    cmd.Parameters.AddWithValue("@parameter_items", Items);
                    cmd.Parameters.AddWithValue("@parameter_quantity", quantity);
                    cmd.Parameters.AddWithValue("@parameter_unitprice", price);
                    cmd.Parameters.AddWithValue("@parameter_totalprice", totalPrice);
                    cmd.ExecuteNonQuery();
                    coldDrinkItems.Text = "";
                    coldDrinkQuantity.Value = 0;
                    coldDrinkUnitPrice.Clear();
                    coldDrinkTotalPrice.Clear();
                    MessageBox.Show("Items added to cart successfully");
                    //DisplayData();
                }
                else
                {
                    MessageBox.Show("Order at least one item", "Order First", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void beverageItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = beverageItems.GetItemText(beverageItems.SelectedItem);
            string pricetxt;
            beverageQuantity.Value = 0;
            switch (txt)
            {
                case "Pink Lady":
                    pricetxt = label87.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    beverageUnitPrice.Text = unitPrice;
                    break;
                case "Cuba Libre":
                    pricetxt = label92.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    beverageUnitPrice.Text = unitPrice;
                    break;
                case "Whiskey Sour":
                    pricetxt = label91.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    beverageUnitPrice.Text = unitPrice;
                    break;
                case "Old Fashioned":
                    pricetxt = label90.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    beverageUnitPrice.Text = unitPrice;
                    break;
                case "Bloody Mary":
                    pricetxt = label89.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    beverageUnitPrice.Text = unitPrice;
                    break;
                case "Mint Julep":
                    pricetxt = label88.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    beverageUnitPrice.Text = unitPrice;
                    break;
                case "Frozen Daiquiri":
                    pricetxt = label86.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    beverageUnitPrice.Text = unitPrice;
                    break;
                case "Vodka Gimlet":
                    pricetxt = label85.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    beverageUnitPrice.Text = unitPrice;
                    break;
                case "Planter's Punch":
                    pricetxt = label84.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    beverageUnitPrice.Text = unitPrice;
                    break;
                case "Sweet Mimosa":
                    pricetxt = label83.Text;
                    unitPrice = pricetxt.Substring(3, pricetxt.Length - 5);
                    beverageUnitPrice.Text = unitPrice;
                    break;
                default:
                    MessageBox.Show("Items not available");
                    break;
            }
        }

        private void beverageQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal cost = beverageQuantity.Value;
            float total = (float)cost * float.Parse(unitPrice);
            beverageTotalPrice.Text = total.ToString();
        }

        private void addBeverageToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                if(beverageTotalPrice.Text != "0" && beverageTotalPrice.Text != "")
                {
                    string category = categoryBox5.Text;
                    string Items = beverageItems.Text;
                    string quantity = beverageQuantity.Text;
                    string price = beverageUnitPrice.Text;
                    string totalPrice = beverageTotalPrice.Text;
                    string query = "Insert into orderDetails (category, items, quantity, unitprice, totalprice) values (@parameter_category, @parameter_items, @parameter_quantity, @parameter_unitprice, @parameter_totalprice)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@parameter_category", category);
                    cmd.Parameters.AddWithValue("@parameter_items", Items);
                    cmd.Parameters.AddWithValue("@parameter_quantity", quantity);
                    cmd.Parameters.AddWithValue("@parameter_unitprice", price);
                    cmd.Parameters.AddWithValue("@parameter_totalprice", totalPrice);
                    cmd.ExecuteNonQuery();
                    beverageItems.Text = "";
                    beverageQuantity.Value = 0;
                    beverageUnitPrice.Clear();
                    beverageTotalPrice.Clear();
                    MessageBox.Show("Items added to cart successfully");
                    //DisplayData();
                }
                else
                {
                    MessageBox.Show("Order at least one item", "Order First", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == payment )
            {
                DisplayData();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // for deleting single rows
                    //student_list.Rows.RemoveAt(student_list.SelectedRows[0].Index);

                    // for deleting multiple rows
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        string query = "Delete from orderDetails where id = @parameter_id";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@parameter_id", id);
                        cmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed Successfully");
                        get_GrandTotal();
                    }
                }
                else
                {
                    MessageBox.Show("Selected the row first");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
    }
}
    