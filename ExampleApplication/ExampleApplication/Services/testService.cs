using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApplication.Services.Interfaces;
using ExampleApplication.Repositories.Interfaces;
using ExampleApplication.Models;

namespace ExampleApplication.Services
{
    public class testService : ItestService
    {
        private readonly ItestRepository _testRepo;

        public testService(ItestRepository testRepo)
        {
            _testRepo = testRepo;
        }

        public IEnumerable<Course> getData() => _testRepo.getData();
    }
}
