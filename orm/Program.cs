﻿using System;
using orm.Configuration;
using orm.Connection;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using orm.Attributes;
using orm.Mapper;

namespace orm
{
    class Program
    {
        static void Main(string[] args)
        {
            MSSqlConnection conn = MSSqlConnection.GetInstance();
            ConnConfiguration conf = new ConnConfiguration("KAROLINA-PC\\SQLEXPRESS", "Test");
            conn.setConfiguration(conf);
            Manager mng = new Manager(conn);
            mng.insert();
            //conn.ConnectAndOpen();
            //SqlDataReader r=conn.executeReader(conn.execute("SELECT * FROM Users; "));
            //Console.WriteLine("Wiersze tabeli:");
            //while (r.Read())
            //{
            //    Console.WriteLine(r["id"].ToString() + "   " + r["name"].ToString());
            //}
            //r.Close();
            //conn.Dispose();
            
            User user1 = new User(18, "John");
            PropertiesMapper mapper = new PropertiesMapper();
            
            Console.WriteLine("Hello World!");

        }
    }
}
