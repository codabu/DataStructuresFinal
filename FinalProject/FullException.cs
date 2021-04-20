using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
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
