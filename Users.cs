using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 CREATE TABLE Users (
    userid NUMBER PRIMARY KEY,
    username VARCHAR2(100) NOT NULL,
    password VARCHAR2(100) NOT NULL,
    usertype VARCHAR2(50) NOT NULL,
    email VARCHAR2(100) NOT NULL,
    phonenumber VARCHAR2(20) NOT NULL
);
 */
namespace POSapp
{
    internal class Users
    {
        public int UserId;
        public string UserName;
        public string Password;
        public string UserType;
        public string Email;
        public string PhoneNumber;

        public Users() { }
            public Users(int userId, string userName, string password, string userType, string email, string phoneNumber)
            {
                UserId = userId;
                UserName = userName;
                Password = password;
                UserType = userType;
                Email = email;
                PhoneNumber = phoneNumber;
        }
        public void SetUserId(int userId)
        {
            UserId = userId;
        }
        public void SetUserName(string userName)
        {
            UserName = userName;
        }
        public void SetPassword(string password) 
        { 
            Password = password;
        }
        public void SetUserType(string userType)
        {
            UserType = userType;
        }   
        public void SetEmail(string email)
        {
            Email = email;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
        public int GetUserId()
        {
            return UserId;
        }
        public string GetUserName()
        {
            return UserName;
        }
        public string GetPassword()
        {
            return Password;
        }
        public string GetUserType()
        {
            return UserType;
        }   
        public string GetEmail()
        {
            return Email;
        }   
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }



    }
}
