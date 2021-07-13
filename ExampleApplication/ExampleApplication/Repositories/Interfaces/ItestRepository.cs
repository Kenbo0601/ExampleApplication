using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApplication.Models;

namespace ExampleApplication.Repositories.Interfaces
{
    public interface ItestRepository
    {
        IEnumerable<Course> getData();
    }
}
