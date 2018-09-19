using System;
using System.Collections.Generic;
using System.IO;
using CustomTests.Testable;
using Moq;
using NUnit.Framework;
namespace CustomTests.UnitTests
{
    [TestFixture]
    public class TestableAPITests
    {
        private Mock<ITPersonAPIHelper> _helper;
        private TPersonAPI _controller;
        private Person testPerson;

        [SetUp]
        public void SetUp()
        {
            testPerson = new Person("Test", "Test", 007);
            _helper = new Mock<ITPersonAPIHelper>();
            _controller = new TPersonAPI(_helper.Object);
        }

        [Test]
        public void APIRemove_WhenCalled_RemovesPersonDB()
        {
            _controller.RemovePerson(1);
            _helper.Verify(s => s.Remove(1));
        }
        
        [Test]
        public void APIAdd_WhenCalled_AddsPersonToDB()
        {
            _controller.AddPerson(testPerson);
            _helper.Verify(s => s.Add(testPerson));
        }

        [Test]
        public void APIToList_WhenCalled_RetutrnsListOfPersons()
        {
            _helper.Setup(s => s.ToList()).Returns(new List<Person>
            {
                new Person("Test","Test",007)
            });
            var result = _controller.PersonsList();
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public void APIToDictionary_WhenCalled_RetutrnsDictionaryOfPersons()
        {
            _helper.Setup(s => s.ToDictionary()).Returns(new Dictionary<int, Person>()
            {
                {1,new Person("a","a",1)},
                {2,new Person("b","b",2)}
            });
            var result = _controller.PersonsDictioary();
            Assert.That(result, Contains.Key(2));  
        }

        [Test]
        public void APIToJson_InvalidPath_ThrowsException()
        {
            _helper.Setup(s => s.ToJson("..")).Throws<InvalidOperationException>();
            Assert.That(() => _controller.PrintPersonsInJson(".."), Throws.InvalidOperationException);
        }

        [Test]
        public void APIToJson_OkPath_CreatesFile()
        {
            _controller.PrintPersonsInJson("test.json");
            _helper.Verify(s => s.ToJson("test.json"));
        }





    }
}
