using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCrud.Oops
{
    public class Test1
    {
        public int MyProperty { get; set; }


        public void GetMarrks()
        {

        }
    }

    public class Test2 : Test1
    {
        public void GetStudents()
        {

        }
    }

    interface IMobile
    {
        void ChargerPort();
    }


    public class Charger : IMobile
    {
        public void ChargerPort()
        {
           
        }
    }

}
