using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySystem.Controler
{
    class AccountLoginException : Exception
    {


        protected AccountLoginException()
            : base()
        { }

        public AccountLoginException(string message)
            : base(message)
        {

        }



    }
}
