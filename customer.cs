using System;
using System.Linq;

namespace code
{
    public class Customer
    {
    private string city="";    
    private string customerid=""; 

    public Customer(string customerid,string city)
    {
        this.customerid=customerid;
        this.city= city;
    }   
    public string CustomerID
    {
        get {return this.customerid;}
        set{this.customerid=value;}
    }

    public string City
    {
        get{return this.city;}
        set{this.city= value;}
    }

     public override  string ToString()
    {
      return customerid + "\t" + city;
    }

    public static void Main(string[] args)
    {
        List<Customer> customerList = new List<Customer>();
        
        customerList.Add(new Customer("A1","London"));
        customerList.Add(new Customer("B1","Surat"));
        customerList.Add(new Customer("C1","Rajkot"));
        customerList.Add(new Customer("D1","Nadiad"));
        customerList.Add(new Customer("E1","London"));
        customerList.Add(new Customer("F1","Rampur"));
        customerList.Add(new Customer("G1","Surat"));
        customerList.Add(new Customer("H1","Anand"));
        customerList.Add(new Customer("I1","London"));
        customerList.Add(new Customer("J1","Luni"));

        var cityLondon = 
        from cust in customerList 
        where cust.city == "London"
        select cust;

        foreach(var i in cityLondon)
        {
            Console.WriteLine(" "+i);
        }


        int count = 
        (from cust in customerList 
        select cust).Count();

        Console.WriteLine("Count= "+count);

        var custA = 
        from cust in customerList 
        where cust.customerid == "A1"
        select cust;

        foreach(var i in custA)
        {
            Console.WriteLine(" "+i);
        }

    
    }
    }
} 