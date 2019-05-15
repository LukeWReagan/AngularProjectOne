//Library accesss
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

[Table(Name = "Customer")]
public class Customer
{
    //private storage fields
    private int customerID;
    private string name;
    private string gender;
    private string birthday;
    private string password;

    public Customer()
    {
        name = "";
        gender = "";
        birthday = "";
        password = "";
    }//Empty Constructor

    //public property access fields
    //customerID public accessor
    [Column(Storage = "customerID", DbType = "Int NOT NULL IDENTITY" ,IsPrimaryKey = true, IsDbGenerated = true)]
    public int CustomerID
    {
        get
        {
            return this.customerID;
        }
    }

    [Column(Storage = "name")]
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    [Column(Storage = "gender")]
    public string Gender
    {
        get
        {
            return this.gender;
        }
        set
        {
            this.gender = value;
        }
    }


    [Column(Storage = "birthday")]
    public string Birthday
    {
        get
        {
            return this.birthday;
        }
        set
        {
            this.birthday = value;
        }
    }

    [Column(Storage = "password")]
    public string Password
    {
        get
        {
            return this.password;
        }
        set
        {
            this.password = value;
        }
    }
}
