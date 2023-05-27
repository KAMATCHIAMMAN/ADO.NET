using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace mssqlconnection
{
    public  class Program
    {
        private static SqlConnection conn;
        private static string query;
        private static object dataSet;

        static void Main(string[] args)
        {
            establishConnection();
        }
        static void establishConnection() 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                //string query = "select *from Customer;select * from Orders; select *from Employee;";
                //SqlCommand sqlCommandobj = new SqlCommand(query, conn);

                // sqlCommandobj.CommandText = query;

                try
                {

                    //dataadapter dataset
                    string  query = "myprocedure";
                    SqlCommand sqlCommandobj = new SqlCommand(query, conn);
                    sqlCommandobj.CommandType = CommandType.StoredProcedure;
                    sqlCommandobj.CommandText = query;
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommandobj);
                   
                   //DataSet dataSet =new DataSet(); 
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    Console.WriteLine("My original table");
                    foreach(DataRow row in dataTable.Rows)
                    {
                        Console.WriteLine(row[0]+" " + row[1]);
                    }


                    Console.WriteLine("My copied table");

                    DataTable dataTableCopied = dataTable.Copy();
                    if (dataTableCopied != null)
                    {
                        foreach (DataRow row in dataTableCopied.Rows)
                        {
                            Console.WriteLine(row[0] + " " + row[1]);
                        }
                    }


                    Console.WriteLine("My cloned table");


                    DataTable dataTableCloned= dataTable.Clone();
                    if(dataTableCloned.Rows.Count>0)
                    {
                        foreach (DataRow row in dataTableCloned.Rows)
                        {
                            Console.WriteLine(row[0] + " " + row[1]);
                        }
                    }

                    Console.WriteLine("add the data");
                    dataTableCloned.Rows.Add(7389, "kamatchi");


                    foreach (DataRow row in dataTableCloned.Rows)
                    {
                        Console.WriteLine(row[0] + " " + row[1]);
                    }


                    Console.WriteLine("delete the data");

                    foreach (DataRow row in dataTableCloned.Rows)
                    {
                        if (row[0].ToString()=="kamatchi")
                        {
                            row.Delete();
                        }
                    }


                    Console.WriteLine("After  deletion");
                    foreach (DataRow row in dataTableCloned.Rows)
                    {
                        Console.WriteLine(row[0] + " " + row[1]);
                    }


                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row[0].ToString() == "matin s")
                        {
                            dataTable.Rows.Remove(row);
                        }
                    }

                    Console.WriteLine("After remove");

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Console.WriteLine(row[0] + " " + row[1]);
                    }

                    ///-----sqldatareader methods ------------------



                    //string stringqueryforoperation = "myprocedure";
                    //SqlCommand sqlcommandobject=new SqlCommand(stringqueryforoperation, conn);
                    //sqlcommandobject.CommandType = CommandType.StoredProcedure;
                    //conn.Open();
                    //SqlDataReader dataReader = sqlCommandobj.ExecuteReader();

                    //while (dataReader.Read())
                    //{
                    //    Console.WriteLine( dataReader["customer_id"] + " " + dataReader["contactname"]+" " + dataReader["city"]);
                    //}
                    //Console.WriteLine("----------------");
                    //if(dataReader.NextResult())
                    //{
                    //    while(dataReader.Read())
                    //    {
                    //        Console.WriteLine(dataReader[0] + " " + dataReader[1] + " " + dataReader[2] + " " + dataReader[3] + " " + dataReader[4] + " " + dataReader[5] + " " + dataReader[6] + " " + dataReader[7]);
                    //    }
                    //}
                    //if (dataReader.NextResult())
                    //{
                    //    while (dataReader.Read())
                    //    {
                    //        Console.WriteLine(dataReader[0] + " " + dataReader[1] + " " + dataReader[2] + " " + dataReader[3] + " " + dataReader[4]);
                    //    }
                    //}


                    //----Execute reader--------------


                    //Console.WriteLine(dataReader.FieldCount);
                    //Console.WriteLine(dataReader.HasRows);

                    //string query = "select count(studentname) from new_table";
                    //SqlCommand sqlCommand = new SqlCommand(query, conn);
                    //conn.Open();

                    //int numberofstudents = (int)(sqlCommand.ExecuteScalar());
                    //Console.WriteLine("total number of students are"+numberofstudents);

                    //string querytwo = "select AVG(studentno) from new_table";
                    //SqlCommand sqlCommandtwo = new SqlCommand(querytwo, conn);
                    //int avergaestudentnumber= (int)(sqlCommand.ExecuteScalar());
                    //Console.WriteLine("Averge of student number" + avergaestudentnumber);


                    //string querythree = "select studentname from new_table where studentno=MAX(stuentno)";
                    //SqlCommand sqlCommandthree = new SqlCommand(querythree, conn);
                    //int laststudent = (int)(sqlCommand.ExecuteScalar());
                    //Console.WriteLine("Last student" + laststudent);

                    //string queryfour  = "select studentname from new_table where studentno=MIN(stuentno)";
                    //SqlCommand sqlCommandfour = new SqlCommand(queryfour, conn);
                    //string firststudent = (string)(sqlCommand.ExecuteScalar());
                    //Console.WriteLine("First student" + firststudent);




                    ///Execute Nonquery


                    // Console.WriteLine("Enter studentname,class,studentno,game,gradeone,supw,gradetwo,newcolumn");
                    // string studentname = Console.ReadLine();
                    // string standard=Console.ReadLine();
                    // string studentno= Console.ReadLine();
                    // string game= Console.ReadLine();
                    // string gradeone= Console.ReadLine();
                    // string supw= Console.ReadLine();
                    // string gradetwo= Console.ReadLine();
                    //string newcolumn= Console.ReadLine();


                    ///insert

                    // string stringqueryforoperation = "insert into new_table values(@studentname,@standard,@studentno,@game,@gradeone,@supw,@gradetwo,@newcolumn)";
                    // SqlCommand sqlcommandobject = new SqlCommand(stringqueryforoperation, conn);



                    //sqlcommandobject.Parameters.AddWithValue("@studentname", studentname);
                    //sqlcommandobject.Parameters.AddWithValue("@standard", standard);
                    //sqlcommandobject.Parameters.AddWithValue("@studentno", studentno);
                    //sqlcommandobject.Parameters.AddWithValue("@game", game);
                    //sqlcommandobject.Parameters.AddWithValue("@gradeone", gradeone);
                    //sqlcommandobject.Parameters.AddWithValue("@supw", supw);
                    //sqlcommandobject.Parameters.AddWithValue("@gradetwo", gradetwo);
                    //sqlcommandobject.Parameters.AddWithValue("@newcolumn", newcolumn);
                    //conn.Open();
                    //int rows = sqlcommandobject.ExecuteNonQuery();
                    //if(rows>0)
                    //{
                    //    Console.WriteLine("Data inserted sucessfully");
                    //}
                    //else
                    //{

                    //    Console.WriteLine("Data is not inserted ");
                    //}

                    // update 


                    //string newstudentname = "srimathi";
                    //string newstudentnumber = "123";

                    //string stringqueryforoperationone = "update new_table set studentname=@newstudentname where studentno=@newstudentnumber";
                    //SqlCommand sqlCommand1 = new SqlCommand(stringqueryforoperationone, conn);
                    //sqlCommand.Parameters.AddWithValue("@newstudentname", newstudentname);
                    //sqlCommand.Parameters.AddWithValue("@newstudentnumber", newstudentnumber)






                    //----


                    //Execute reader
                    //string stringqueryforoperation = "myprocedure";
                    //SqlCommand sqlcommandobject=new SqlCommand(stringqueryforoperation, conn);
                    //sqlcommandobject.CommandType = CommandType.StoredProcedure;
                    //conn.Open(); 




                    
                    //SqlDataReader datareader = sqlcommandobject.ExecuteReader();
                    //while(datareader.Read())
                    //{
                    //    Console.WriteLine(datareader["game"]+" "+ datareader["gradeone"]);
                    //}



                    //----connection class----


                    //if(conn.State==ConnectionState.Open)
                    //{
                    //    Console.WriteLine("Connection established Successfully");
                    //}
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                /*
                finally
                {
                    conn.Close();
                }
                */
            }
        }
    }
}