using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        Product tel = new Product();
        Product PR_MACHINE = new Product();
        Product Pos = new Product();
        List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            tel.COUNT = 5;
            tel.COLOR = "жовтий";
            tel.ID = 1;
            products.Add(tel);

            PR_MACHINE.COUNT = 10;
            PR_MACHINE.COLOR = "білий";
            PR_MACHINE.ID = 2;
            products.Add(PR_MACHINE);

            Pos.COUNT = 16;
            Pos.COLOR = "чорний";
            Pos.ID = 3;
            products.Add(Pos);
        }
        public class Product
        {
            public int COUNT { set; get; }
            public string COLOR { set; get; }
            public int ID { set; get; }
        }

        private Product GetProductDetails(string productName)
        {
            if (productName == "Телефон")
            {
                return tel;
            }
            else if (productName == "Пральна машина")
            {
                return PR_MACHINE;
            }
            else if (productName == "Посудомойка")
            {
                return Pos;
            }
            else
            {
                MessageBox.Show("Error");
                return null;
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string selectedProduct = comboBox1.SelectedItem.ToString();

            var productDetails = GetProductDetails(selectedProduct);


            var listViewItem = new ListViewItem(new[] { productDetails.COUNT.ToString(), productDetails.COLOR, productDetails.ID.ToString() });
            listView1.Items.Add(listViewItem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(textBox1.Text);
            int Count = Int32.Parse(textBox2.Text);
            foreach(var item in products)
            {
                if (ID == item.ID)
                {
                    if (Count <= item.COUNT)
                    {
                        item.COUNT = item.COUNT - Count;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}


