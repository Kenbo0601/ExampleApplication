using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApplication.Models;

namespace ExampleApplication.Services.Interfaces
{
    public interface ItestService
    {
        IEnumerable<Course> getData();
    }
}
