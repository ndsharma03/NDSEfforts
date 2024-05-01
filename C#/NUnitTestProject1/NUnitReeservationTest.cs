using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class User
    {
        public bool IsAdmin { get; set; }

    }
    public class Reservation
    {
      public  User MadeBy { get; set; }
       

        public bool CanCancelReservation(User user)
        {
            if (user.IsAdmin)
            {
                return true;
            }
            if (user == MadeBy)
            {
                return true;
            }
            return false;
        }
    }
    [TestFixture]
    class ReeservationTests
    {
        //Naming Pattern:: CanCancelReservation_Scenario_ExpectedBehaviour

        // Scenario 1 : Admin user can cancel reservation made by anyone.
        [TestCase]
        public void CanCancelResetvation_IsAdmin_ReturnsTrue()
        {
            //3 parts in test methods
            // 1. Arrange --> intializaation of  objects

            var reservation = new Reservation();
            User adminUser = new User() { IsAdmin = true };
            
            //2. Act -->
            bool result=reservation.CanCancelReservation(adminUser);
            //3. Asserts
            Assert.IsTrue(result);
        }
        // Scenario 2 : user can cancel reservation made by himself.
        [TestCase]
        public void CanCancelResetvation_IsNotAdmin_ReturnsTrue()
        {
            //3 parts in test methods
            // 1. Arrange --> intializaation of  objects
            User user = new User { IsAdmin = false };
            var reservation = new Reservation { MadeBy =user  };
                       
            //2. Act -->
             bool result = reservation.CanCancelReservation(user);
            //3. Asserts
            Assert.IsTrue(result);
        }
        // Scenario 3 : user can't cancel reservation made by someone else.
        [TestCase]
        public void CanCancelReservation_MadeByAnotherUser_ReturnsFalse()
        {
            //1. Arrange
            var reservation = new Reservation { MadeBy = new User { IsAdmin = false } };
            User anotherUser = new User { IsAdmin = false };
            //2. Act
            bool result=reservation.CanCancelReservation(anotherUser);

            //3. Asserts
            Assert.IsFalse(result);

        }
    }
}
