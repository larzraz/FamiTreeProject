using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.Models
{
    public class TestClassDataC
    {
        public IEnumerable<TestClass> GetTestClass()
        {
            return new[]
            {
                new TestClass
                {
                    id = 1,
                    name = "Hanna",
                    parent = 0,


                },
                new TestClass
                {
                     id = 2,
                    name = "Hanna",
                    parent = 1,

                },
                new TestClass
                {
                     id = 3,
                    name = "Henna",
                    parent = 2,

                },
                new TestClass
                {
                    id = 4,
                    name = "Jorah",
                    parent = 2,

                //},
                //new TestClass
                //{
                //   ID = 5,
                //    Name = "Rasmus",
                //    Parent = 2,
                //},
                //new TestClass
                //{
                //    ID = 6,
                //    Name = "Jehna",
                //    Parent = 4,
                //},
                //new TestClass
                //{
                //    ID = 7,
                //    Name = "Benjamin",
                //    Parent = 4,
                //},
            } };
        }
    }
}

