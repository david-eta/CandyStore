using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CSharpestServer.Models;

//	Last modified by: David Eta
//	Windows Prog 547
//	Last Updated : 11/20/23

public class Customer : IComparable<Customer>
{
    public Guid Id { get; set; } // primary key: cartId
    public Guid CartId { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; } //not addressing security
    public string? Phone { get; set; }
    public string? Address { get; set; }

    public Customer(string email, string firstName, string lastName, string password, string? phone, string? address)
    {
        Id = Guid.NewGuid();
        CartId = Guid.NewGuid();
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        Password = password;
        Phone = phone;
        Address = address;
    }

    public Customer() { }

    // comparison method to allow Item to be included in SortedSet
    public int CompareTo(Customer other)
    {
        // checks if other item is null or not
        if (other != null)
        {
            return this.Id.CompareTo(other.Id); // compares by id
        }
        // if null or otherwise, return 
        return 1;
    }
}
