//Library access
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace AngularProjectOne.Models
{
[Table(Name = "Address")]
public class Address
{
    //private storage fields      
    private int customerID;
    private string country;
    private string city;
    private string state;
    private string street;

	public Address()
    {
        country = "";
        city = "";
        state = "";
        street = "";
    }//Empty Constructor

    //public property access fields
    //customerID public accessor with primaryKey clause
    [Column(Storage = "customerID", DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int CustomerID
    {
        get
        {
            return this.customerID;
        }
        //auto set by database
    }

    [Column(Storage = "country")]
    public string Country
    {
        get
        {
            return this.country;
        }
        set
        {
            this.country = value;
        }
    }

    [Column(Storage = "state")]
    public string State
    {
        get
        {
            return this.state;
        }
        set
        {
            this.state = value;
        }
    }


    [Column(Storage = "city")]
    public string City
    { 
        get
        {
            return this.city;
        }
        set
        {
            this.city = value;
        }
    }

    [Column(Storage = "street")]
    public string Street
    {
        get
        {
            return this.street;
        }
        set
        {
            this.street = value;
        }
    }
    //public Contact getContact(string email, string password)//Query method to get customer information from credentials
    //{
    //    DataContext db = new DataContext//sets reference of database context
    //        (/*INSERT DATABASE REF HERE*/);
    //
    //    Table<Contact> Contacts = db.GetTable<Contact>();//gets table from database
    //    IQueryable <Contacts> emailQuery = //SQL query to get contact associated with email
    //        from cont in Contact
    //        where email == Contact.Email
    //        select cont;
    //    foreach(Contact c in emailQuery)
    //    {
    //        if (c.Customer.Password == password)
    //            return c;
    //    }
    //    return null;
    //}
}
}
