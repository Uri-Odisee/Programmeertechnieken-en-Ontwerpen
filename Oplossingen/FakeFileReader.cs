using System;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests
{
    class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
