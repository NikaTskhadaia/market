using DatabaseHelper;
using Market.Models;
using Market.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using Market.Repository.Extensions;

namespace TestAppConsole
{
    class Program
    {
        static void Main()
        {
            CategoryRepository categoryRepository = new(@"server = NIKAS-THINKPAD\SQLEXPRESS;database=Market;integrated security=true");

            var categroy = categoryRepository.Select();

            //GroupRepository groupRepository = new(@"server = NIKAS-THINKPAD\SQLEXPRESS;database=Market;integrated security=true");

            //var groups = groupRepository.Get(2).Include("Users").Include("Permissions");



            Console.WriteLine("done");

            Console.ReadKey();
        }
    }
}