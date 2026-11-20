using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Helpers.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string mesage) : base(mesage) { }
    }
}
