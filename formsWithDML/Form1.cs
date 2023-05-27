using System.Data.SqlClient;
using System.Data;
namespace formsWithDML
{

    public partial class Form1 : Form
    {
        string Firstname="";
        string Lastname="";
        string Gender = "";
        string Age="";
        string Myaddress = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-VQ226Q4\\SQLEXPRESS; Initial Catalog=Personaldetails; Integrated Security=true;";
            SqlConnection connectionobject = new SqlConnection(connectionString);
            connectionobject.Open();
            if(connectionobject.State==ConnectionState.Open)
            {
                MessageBox.Show("Data Inserted Successfully !");
            }
            string query = "insert into personalinformation values (@Firstname,@Lastname,@Gender,@Age,@Myaddress)";
            SqlCommand sqlCommandobject = new SqlCommand(query, connectionobject);
            sqlCommandobject.Parameters.AddWithValue("@Firstname", textBox1.Text);
            sqlCommandobject.Parameters.AddWithValue("@Lastname", textBox4.Text);
            sqlCommandobject.Parameters.AddWithValue("@Gender", textBox5.Text);
            sqlCommandobject.Parameters.AddWithValue("@Age", textBox3.Text);
            sqlCommandobject.Parameters.AddWithValue("@Myaddress", textBox2.Text);


            sqlCommandobject.ExecuteNonQuery();


            connectionobject.Close();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}