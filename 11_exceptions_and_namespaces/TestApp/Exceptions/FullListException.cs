using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Exceptions;

public class FullListException : InvalidOperationException
{
    public FullListException() : base("List is full")
    {
    }
}
