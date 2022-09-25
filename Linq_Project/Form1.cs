using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Project
{
    public partial class Form1 : Form
    {

        private int[] sayilar = { 1, -2, 4, -6, 8, -9, 13, 3,7,5 };
        List<string> words = new List<string>();
        public Form1()
        {
            words.Add("pencil");
            words.Add("counrty");
            words.Add("mist");
            words.Add("denote");
            words.Add("zip");
            words.Add("airpod");
            words.Add("watch");
            words.Add("keep");
            

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sayilar_hepsi_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.ToList();

        }

        private void negatif_sayilar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.Where(x => x < 0).ToList();
        }

        private void pozitif_sayilar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.Where(x => x > 0).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.OrderByDescending(x => x).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.OrderBy(x => x).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.Where(x => x%2== 0).OrderByDescending(x=>x).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.Where(x => x % 2 != 0).OrderBy(x=>x).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int show = sayilar.Max();
            MessageBox.Show(Convert.ToString(show));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int show = sayilar.Min();
            MessageBox.Show(Convert.ToString(show));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = words.OrderBy(x => x).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = words.OrderByDescending(x => x).ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = words.OrderBy(t=>t).Select(x => x.Length).ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = words.Where(x => x.Contains("a")).ToList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            var list = orders.Select(x => new
            {
                SiparisNo = x.OrderID,
                Tarih = x.OrderDate,
                Musteri = x.Customer.ContactName
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list.ToList();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Select(x=>x.OrderDate).ToList();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.OrderBy(x => x.OrderDate).Take(5).Select(x => new {


                SiparisNo = x.OrderID,
                Tarih = x.OrderDate,
                Musteri = x.Customer.ContactName

            }).ToList();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.OrderByDescending(x => x.OrderDate).Take(5).Select(x=> new {


                SiparisNo = x.OrderID,
                Tarih = x.OrderDate,
                Musteri = x.Customer.ContactName

            }).ToList();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            var filter = orders.Where(x => x.Customer.ContactName == "Yang Wang").ToList();
            dataGridView1.DataSource = filter;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            int sayi = orders.Count;
            MessageBox.Show(sayi.ToString());
        }
    }
}
