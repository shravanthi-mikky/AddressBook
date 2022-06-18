using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookRepo
    {
        AddressBookModel addressmodel = new();
        PersonDetail1 personDetail1 = new PersonDetail1();
        Address_Book1 address_Book1 = new Address_Book1();
        PersonTypes1 personTypes1 = new PersonTypes1();
        PersonsDetail_Type1 personsDetail_Type1 = new();
        Employee_Department1 employee_Department1 = new();
        private SqlConnection Connection;

        //Method to retreive data
        public void GetAllContactOf_AddressBook()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from AddressBook";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            addressmodel.ID = datareader.GetInt32(0);
                            addressmodel.FirstName = datareader.GetString(1);
                            addressmodel.LastName = datareader.GetString(2);
                            addressmodel.Address = datareader.GetString(3);
                            addressmodel.City = datareader.GetString(4);
                            addressmodel.State = datareader.GetString(5);
                            addressmodel.Zip = datareader.GetInt32(6);
                            addressmodel.PhoneNumber = datareader.GetString(7);
                            addressmodel.Email_ID = datareader.GetString(8);
                            addressmodel.DateAdded = datareader.GetDateTime(9);

                            Console.WriteLine(addressmodel.FirstName + " " +
                                addressmodel.LastName + " " +
                                addressmodel.Address + " " +
                                addressmodel.City + " " +
                                addressmodel.State + " " +
                                addressmodel.Zip + " " +
                                addressmodel.PhoneNumber + " " +
                                addressmodel.Email_ID + " " +
                                addressmodel.DateAdded
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Retrieve PersonDetail1
        public void GetAllContactOf_PersonDetail1()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from PersonDetail1";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            personDetail1.PersonId = datareader.GetInt32(0);
                            personDetail1.AddressBookId = datareader.GetInt32(1);
                            personDetail1.FirstName = datareader.GetString(2);
                            personDetail1.LastName = datareader.GetString(3);
                            personDetail1.Address = datareader.GetString(4);
                            personDetail1.City = datareader.GetString(5);
                            personDetail1.State = datareader.GetString(6);
                            personDetail1.Zip = datareader.GetInt32(7);
                            personDetail1.PhoneNumber = datareader.GetInt64(8);
                            personDetail1.Email_ID = datareader.GetString(9);
                            personDetail1.DateAdded = datareader.GetDateTime(10);

                            Console.WriteLine(personDetail1.FirstName + " " +
                                personDetail1.LastName + " " +
                                personDetail1.Address + " " +
                                personDetail1.City + " " +
                                personDetail1.State + " " +
                                personDetail1.Zip + " " +
                                personDetail1.PhoneNumber + " " +
                                personDetail1.Email_ID + " " +
                                personDetail1.DateAdded
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // Display of address_Book1
        public void GetAllContactOf_Address_Book1()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from Address_Book1";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            address_Book1.AddressBookId = datareader.GetInt32(0);
                            address_Book1.AddressBookName = datareader.GetString(1);

                            Console.WriteLine(address_Book1.AddressBookId + " " +
                                address_Book1.AddressBookName + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // Display of PersonTypes1
        public void GetAllContactOf_PersonTypes1()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from PersonTypes1";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            personTypes1.PersonTypeId = datareader.GetInt32(0);
                            personTypes1.PersonType = datareader.GetString(1);

                            Console.WriteLine(personTypes1.PersonTypeId + " " +
                                personTypes1.PersonType + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Display of PersonsDetail_Type1
        public void GetAllContactOf_PersonsDetail_Type1()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from PersonsDetail_Type1";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            personsDetail_Type1.PersonId = datareader.GetInt32(0);
                            personsDetail_Type1.PersonTypeId = datareader.GetInt32(1);

                            Console.WriteLine(personsDetail_Type1.PersonId + " " +
                                personsDetail_Type1.PersonTypeId + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Display of Employee_Department1
        public void GetAllContactOf_Employee_Department1()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from Employee_Department1";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            employee_Department1.PersonId = datareader.GetInt32(0);
                            employee_Department1.EmployeeID = datareader.GetInt32(1);
                            employee_Department1.DepartmentID = datareader.GetInt32(2);


                            Console.WriteLine(employee_Department1.PersonId + " " +
                                employee_Department1.EmployeeID + " " +
                                employee_Department1.DepartmentID + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string updateEmployeeDetails()
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
            Connection.Open();
            SqlCommand command = new SqlCommand("update PersonDetail1 set Address='Updated Colony' where FirstName='Shravanthi'", Connection);

            int effectedRow = command.ExecuteNonQuery();
            if (effectedRow == 1)
            {
                string query = @"Select Address from PersonDetail1 where FirstName='Shravanthi';";
                SqlCommand cmd = new SqlCommand(query, Connection);
                object res = cmd.ExecuteScalar();
                Connection.Close();
                addressmodel.Address = (string)res;
            }
            Connection.Close();
            return (addressmodel.Address);
        }
        public void AddColumn_DateAdded_EmployeeDetails()
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
            Connection.Open();
            SqlCommand command = new SqlCommand("Alter table AddressBook add DateAdded DateTime;", Connection);

            int effectedRow = command.ExecuteNonQuery();
            if (effectedRow == 1)
            {
                string query = @"update AddressBook set DateAdded=Date.Now ;";
                SqlCommand cmd = new SqlCommand(query, Connection);
                object res = cmd.ExecuteScalar();
                Connection.Close();
                addressmodel.Address = (string)res;
            }
            Connection.Close();
            
        }
        public void AddColumn_DateAdded_PersonDetails1()
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
            Connection.Open();
            SqlCommand command = new SqlCommand("Alter table PersonDetails1 add DateAdded DateTime;", Connection);

            int effectedRow = command.ExecuteNonQuery();
            if (effectedRow == 1)
            {
                
                string query = @"update PersonDetails1 set DateAdded=Date.Now ;";
                SqlCommand cmd = new SqlCommand(query, Connection);
                object res = cmd.ExecuteScalar();
                Connection.Close();
                addressmodel.Address = (string)res;
            }
            Connection.Close();

        }
        public void GetDetailsInPeroid()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
            connection.Open();
            string query = @"select * from PersonDetail1 where DateAdded between CAST('2020-01-01' as date) and CAST('2022-01-02' as date);";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            SqlDataReader data = cmd.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    personDetail1.PersonId = data.GetInt32(0);
                    personDetail1.AddressBookId = data.GetInt32(1);
                    personDetail1.FirstName = data.GetString(2);
                    personDetail1.LastName = data.GetString(3);
                    personDetail1.Address = data.GetString(4);
                    personDetail1.City = data.GetString(5);
                    personDetail1.State = data.GetString(6);
                    personDetail1.Zip = data.GetInt32(7);
                    personDetail1.PhoneNumber = data.GetInt64(8);
                    personDetail1.Email_ID = data.GetString(9);
                    personDetail1.DateAdded = data.GetDateTime(10);

                    Console.WriteLine(personDetail1.FirstName + " " +
                        personDetail1.LastName + " " +
                        personDetail1.Address + " " +
                        personDetail1.City + " " +
                        personDetail1.State + " " +
                        personDetail1.Zip + " " +
                        personDetail1.PhoneNumber + " " +
                        personDetail1.Email_ID + " " +
                        personDetail1.DateAdded
                        );
                }
            }
            connection.Close();
        }
    }
}
