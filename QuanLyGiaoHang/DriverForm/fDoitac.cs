using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaoHang.DAO;
using QuanLyGiaoHang.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace QuanLyGiaoHang
{
    public partial class fDoitac : Form
    {
        public static string MADT;
        public fDoitac(string madt)
        {
            
            InitializeComponent();
            MADT = madt;
            textBox1.Text = madt;
            LoadStoreList(madt);
        }
        private void LoadStoreList(string madt)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Store> list = StoreDAO.Instance.LoadStoreList(madt);
            foreach (Store store in list)
            {
                Button button = new Button()
                {
                    Width = (int)OrderDAO.OrderWidth,
                    Height = (int)OrderDAO.OrderHeight,
                };
                button.Text = store.Addr2;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Button_Click;
                button.Tag = store;

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string macn = ((sender as Button).Tag as Store).MACN;
            textBox2.Text = ((sender as Button).Tag as Store).MACN;
            textBox3.Text = ((sender as Button).Tag as Store).Addr1 + ", " + ((sender as Button).Tag as Store).Addr2 + ", " + ((sender as Button).Tag as Store).Addr3;
            textBox4.Text = ((sender as Button).Tag as Store).Status;
            textBox5.Text = ((sender as Button).Tag as Store).Timeactivity;
            //dataGridView1.DataSource = MenuDAO.Instance.getData(macn);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void fDoitac_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //MenuInfo menuInfo = new MenuInfo(row.Cells[0].ToString(), row.Cells[1].ToString(), row.Cells[2].ToString(), row.Cells[3].ToString());
            //row.Tag = sender;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MenuInfo menuInfo = new MenuInfo((sender as DataGridViewRow).Cells[0].ToString(), (sender as DataGridViewRow).Cells[0].ToString(), (sender as DataGridViewRow).Cells[0].ToString(), (sender as DataGridViewRow).Cells[0].ToString());
           //if (menuInfo == null) MessageBox.Show("Bạn chưa chọn món!");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string macn = textBox2.Text;
            if(macn !="")
            {
                this.Hide();
                fMenu form = new fMenu(macn);
                form.ShowDialog();
                this.Show();
            }    
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            fInsertStore form = new fInsertStore(textBox1.Text);
            this.Hide();
            form.ShowDialog();
            this.Show();
            LoadStoreList(textBox1.Text);
        }

        private void xửLíĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXuLyDonHang form = new fXuLyDonHang(MADT);
            this.Hide();
            
            form.ShowDialog();
            this.Show();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHopDong form = new fHopDong(MADT);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}