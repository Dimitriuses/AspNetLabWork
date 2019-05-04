using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace lab6._1.Models
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            context.Users.Add(new User { FullName = "Dmitrius Spak", ForumName = "Dmitrius", Email = "Dmitrius@gmail.com", Password = "parol123", IConfirmed = true  });
            //context.Users.Add(new User { Name = "Audi A5", Producer = "Deuchland", Price = 1357314 });
            //context.Users.Add(new User { Name = "Audi A3", Producer = "Deuchland", Price = 1865543 });
            //context.Users.Add(new User { Name = "Audi A6", Producer = "Deuchland", Price = 1458934 });
            //context.Users.Add(new User { Name = "Audi A7", Producer = "Deuchland", Price = 2068572 });
            //context.Users.Add(new User { Name = "Audi A1", Producer = "Deuchland", Price = 964735 });
            //context.Users.Add(new User { Name = "Audi A8", Producer = "Deuchland", Price = 2367837 });
            //context.Users.Add(new User { Name = "Audi Q2", Producer = "Deuchland", Price = 853337 });
            //context.Users.Add(new User { Name = "Audi Q3", Producer = "Deuchland", Price = 1054050 });
            //context.Users.Add(new User { Name = "Audi Q5", Producer = "Deuchland", Price = 1397802 });
            //context.Users.Add(new User { Name = "Audi Q7", Producer = "Deuchland", Price = 1846533 });
            //context.Users.Add(new User { Name = "Audi Q8", Producer = "Deuchland", Price = 1717064 });
            base.Seed(context);
        }
    }
}