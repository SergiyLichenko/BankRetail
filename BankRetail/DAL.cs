using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace BankRetail
{
    class DAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString;//строка соединения

        public DataTable GetAllDebetors()
        {
            DataTable dataTable;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    dataTable = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Debetors order by name", con);
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null;
        }

        internal DataTable GetAllCreditsForDebetor(string debetorID)
        {
            DataTable dataTable;
            string query = "Select * from Credit where DebetorID = '"+debetorID+"' order by OpenDate";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    dataTable=new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query,con);
                    dataAdapter.Fill(dataTable);
                    if(dataTable.Rows.Count==0) return null;
                    return dataTable;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null;
        }

        internal DataTable GetAllPaymentsForCredit(string creditsID)
        {
            DataTable dataTable;
            string query = "Select * from Payments where CreditsID = '" + creditsID + "' order by PaymentDate";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    dataTable = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                    dataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 0) return null;
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null;
        }

        public bool SaveNewDebetor(string id,string name, string postnumber,string phonenumber)
        {
            bool flagResult = false;
            string query = String.Format("Insert into Debetors (ID,Name, PostNumber, PhoneNumber) values (@ID,@Name,@PostNumber,'{0}')",
                (phonenumber!=String.Empty)?phonenumber:null);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, con);

                SqlParameter param = new SqlParameter("@ID", id);
                command.Parameters.Add(param);
                param = new SqlParameter("@Name", name);
                command.Parameters.Add(param);
                param = new SqlParameter("@PostNumber", postnumber);
                command.Parameters.Add(param);
                
                
                try
                {
                    con.Open();
                    if (command.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return flagResult;
        }

        public bool SaveNewCredit(int ID,int DebetorID,int Amount,int Balance, string OpenDate)
        {
            bool flagResult = false;
            string query = String.Format("Insert into Credit (ID,DebetorID,Amount,Balance,OpenDate)values(@ID,@DebetorID,@Amount,@Balance,@OpenDate)");              
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, con);
                SqlParameter param = new SqlParameter();

                param.ParameterName="@ID";
                param.Value=ID;
                param.SqlDbType=SqlDbType.Int;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName="@DebetorID";
                param.Value=DebetorID;
                param.SqlDbType=SqlDbType.Int;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName="@Amount";
                param.Value=Amount;
                param.SqlDbType = SqlDbType.Int;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName="@Balance";
                param.Value=Balance;
                param.SqlDbType = SqlDbType.Int;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName="@OpenDate";
                param.Value=OpenDate;
                param.SqlDbType = SqlDbType.NVarChar;
                command.Parameters.Add(param);
                try
                {
                    con.Open();
                    if (command.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch (System.Data.Common.DbException)
                {
                    MessageBox.Show("Введенный ID недоступен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return flagResult;
        }

        internal bool SaveNewPayment(int ID, int CreditID, decimal paymentAmount, string dateTime)
        {
            bool flag=false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction sqlTransact = con.BeginTransaction();
                SqlCommand command = con.CreateCommand();
                command.Transaction = sqlTransact;
                try
                {
                    string payAmount = paymentAmount.ToString(CultureInfo.InvariantCulture.NumberFormat);
                    string query = string.Format("Insert into Payments (ID,CreditsID,Amount,PaymentDate) values(@ID,@CreditsID,@Amount,@PaymentDate)",
                        ID,CreditID,payAmount,dateTime);
                    SqlParameter param = new SqlParameter("@ID",ID);
                    command.Parameters.Add(param);
                    param = new SqlParameter("@CreditsID",CreditID);
                    command.Parameters.Add(param);
                    param = new SqlParameter("@Amount",payAmount);
                    command.Parameters.Add(param);
                    param = new SqlParameter("@PaymentDate",dateTime);
                    command.Parameters.Add(param);





                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    query=string.Format("Update Credit set Balance = (Balance - {0}) where ID = {1}",
                        payAmount,CreditID);
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    sqlTransact.Commit();
                    flag = true;
                    return flag;
                }
                catch (System.Data.Common.DbException)
                {
                    MessageBox.Show("Введенный ID кредита недоступен");
                }
                catch(Exception)
                {
                    sqlTransact.Rollback();
                    flag = false;
                }

            }



            return flag;
        }

        internal bool SaveToFile()
        {
            bool result=true;
            StreamWriter file = new StreamWriter(new FileStream("Debetors.csv", FileMode.Create), Encoding.GetEncoding(1251));
            string query;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    query = "Select * from Debetors";
                    SqlCommand command = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""Name"";""PostNumber"";""PhoneNumber""");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" +
                                reader.GetString(1) + @""";""" + reader[2].ToString() + @""";""" + reader[3].ToString() + @"""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("No data for saving");
                    }
                    file.WriteLine("End of file");
                    result = true;
                    file.Dispose();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    result=false;
                    return result;
                }
            }
            /////////////////////////////////////////////////////////////////
            
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Credits.csv", FileMode.Create), Encoding.GetEncoding(1251));
                    query = "Select * from Credit";
                    SqlCommand command = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""DebetorID"";""Amount"";""Balance"";""OpenDate""");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader[0].ToString() + @""";""" +reader[1].ToString() + @""";""" + 
                                reader[2].ToString() + @""";""" + reader[3].ToString() + @""";""" + reader[4].ToString() + @"""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("No data for saving");
                    }
                    file.WriteLine("End of file");
                    result = true;
                    file.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    result = false;
                    return result;
                }
            }
            /////////////////////////////////////////////////////////////
            

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Payments.csv", FileMode.Create), Encoding.GetEncoding(1251));
                    query = "Select * from Payments";
                    SqlCommand command = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""CreditsID"";""Amount"";""PaymentDate""");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader[0].ToString() + @""";""" + reader[1].ToString() + @""";""" +
                                reader[2].ToString() + @""";""" + reader[3].ToString() + @"""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("No data for saving");
                    }
                    file.WriteLine("End of file");
                    result = true;
                    file.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    result = false;
                    return result;
                }
            }
            return result;
        }

        public DataTable SearchDebitors(string debName, string debPostNumber, string debPhoneNumber)
        {
            DataTable searched = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                
                try
                {
                    con.Open();
                    var command = con.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SearchDebetor";
                    command.Parameters.AddWithValue("@Name", debName);
                    command.Parameters.AddWithValue("@PostNumber", debPostNumber);
                    command.Parameters.AddWithValue("@PhoneNumber", debPhoneNumber);
                  
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    
                    adapter.SelectCommand = command;
                    adapter.Fill(searched);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            return searched;
        }
    }
}
