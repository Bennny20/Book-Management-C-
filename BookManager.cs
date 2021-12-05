using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ManagerBook
{
    public class BookManager
    {
        string strConnect;
        public BookManager()
        {
            strConnect = getConnect();
        }

        //phương thức lay chuoi ket noi
        public string getConnect()
        {
            String strConnection = @"Data Source=.;Initial Catalog=Manager;uid=sa;pwd=123";
            return strConnection;
        }

        //Phuong thuc lay tat ca Book
        public DataTable getBoooks()
        {
            string sql = "Select * from Books";
            SqlConnection con = new SqlConnection(strConnect);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtBook = new DataTable();
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(dtBook);
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dtBook;
        }

        //Phuong thuc them moi sach
        public bool addnew(Book book)
        {
            SqlConnection con = new SqlConnection(strConnect);
            string sql = "Insert Books values(@BookID,@BookTitile,@BookPrice,@BookQuantity)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BookID", book.BookID);
            cmd.Parameters.AddWithValue("@BookTitile", book.BookTitle);
            cmd.Parameters.AddWithValue("@BookPrice", book.BookPrice);
            cmd.Parameters.AddWithValue("@BookQuantity", book.BookQuantity);
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }

        //Phuong thuc cap nhat Book
        public bool updateBook(Book book)
        {
            SqlConnection con = new SqlConnection(strConnect);
            string sql = "Update Books set BookTitile=@BookTitile,BookPrice=@BookPrice," +
                         "BookQuantity=@BookQuantity where BookID=@BookID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BookID", book.BookID);
            cmd.Parameters.AddWithValue("@BookTitile", book.BookTitle);
            cmd.Parameters.AddWithValue("@BookPrice", book.BookPrice);
            cmd.Parameters.AddWithValue("@BookQuantity", book.BookQuantity);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        
        //Phuong thuc xoa sach
        public bool deleteBook(int BookID)
        {
            SqlConnection con = new SqlConnection(strConnect);
            string sql = "Delete Books where BookID=@BookID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BookID", BookID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }

    }//End class
}//End namspace
