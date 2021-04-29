using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    /***************************************************************
    * Name        : FullException
    * Author      : Corry Burton
    ***************************************************************/


    public class FullException : Exception
    {
        public override string Message
        {
            get
            {
                return "Error - Linked List is full";
            }
        }
    }
}
