﻿using DataDomain.Context;
using DataDomain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MyAppDbContext context = new MyAppDbContext(
                new DbContextOptionsBuilder<MyAppDbContext>()
                    .UseSqlServer(new SqlConnectionStringBuilder
                    {
                        DataSource = "127.0.0.1",
                        InitialCatalog = "Univercity",
                        IntegratedSecurity = true
                    }.ConnectionString)
                    .Options);
            


            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Faculties.Add(new Faculty { Name = "F2" });
            context.SaveChanges();

            InitializeComponent();
        }
    }
}
