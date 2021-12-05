using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManagerBook
{
    public partial class frmMainTainBook : Form
    {
        //Khai bao doi tuong de thao tac
        BookManager mb = new BookManager();
        //khai bao doi tuong DataTable luu lu lieu doc duoc tu DB
        DataTable dtBook;
        public frmMainTainBook()
        {
            InitializeComponent();
            getAllBook();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtBookID.Text);
            string title = txtBookTitle.Text;
            float price = float.Parse(txtBookPrice.Text);
            int quantity = int.Parse(txtBookQuantity.Text);
            Book book = new Book
            {
                BookID = ID,
                BookTitle = title,
                BookPrice = price,
                BookQuantity = quantity
            };
            //Goi phuong thuc cap nhat
            bool r = mb.addnew(book);
            string s = (r == true ? "Successful" : "Fail");
            MessageBox.Show("Add " + s);
            //Refresh du lieu
            getAllBook();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtBookID.Text);
            string title = txtBookTitle.Text;
            float price = float.Parse(txtBookPrice.Text);
            int quantity = int.Parse(txtBookQuantity.Text);
            Book book = new Book
            {
                BookID = ID,
                BookTitle = title,
                BookPrice = price,
                BookQuantity = quantity
            };
            //Goi phuong thuc cap nhat
            bool r = mb.updateBook(book);
            string s = (r == true ? "Successful" : "Fail");
            MessageBox.Show("Update " + s);
            //Refresh du lieu
            getAllBook();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtBookID.Text);
            //Goi ham xoa
            bool r = mb.deleteBook(ID);
            string s = (r == true ? "Successful" : "Fail");
            MessageBox.Show("Delete " + s);
            //Refresh du lieu
            getAllBook();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            getAllBook();
        }

        //phuong thức doc du lieu bang Book
        private void getAllBook()
        {
            //lay du lieu tu bang
            dtBook = mb.getBoooks();
            //Xoa rang buoc du lieu tren cac textBoxes de Binding lai lan sau
            txtBookID.DataBindings.Clear();
            txtBookTitle.DataBindings.Clear();
            txtBookPrice.DataBindings.Clear();
            txtBookQuantity.DataBindings.Clear();
            //Rang buoc du lieu tren TextBoxes
            txtBookID.DataBindings.Add("Text", dtBook, "BookID");
            txtBookTitle.DataBindings.Add("Text", dtBook, "BookTitile");
            txtBookPrice.DataBindings.Add("Text", dtBook, "BookPrice");
            txtBookQuantity.DataBindings.Add("Text", dtBook, "BookQuantity");
            //Rang buoc du lieu cho GridView
            dgvBookList.DataSource = dtBook;
            //Tinh tong so luong sach
            lbTotalQuantity.Text = "TotalQuantity :" +
                                   dtBook.Compute("SUM(BookQuantity)", string.Empty);
        } 

        private void txtTitleFilter_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtBook.DefaultView;
            string filter = "BookTitle like '%" + txtTitleFilter.Text + "%'";
            dv.RowFilter = filter;
            //Hien thi len lable
            lbTotalQuantity.Text = "TotalQuantity :" + dtBook.Compute("SUM(BookQuantity)", filter);
        }
    }
}
