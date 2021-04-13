using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class EmptyException: Exception
    {
        public override string Message
        {
            get
            {
                return "Error - Linked list is empty";
            }
        }
    }
}
