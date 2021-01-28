using System;
using Xunit;
using SpeakerMeet.API.Controllers; 
using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using System.Linq; // <- Добавить директиву!
using Moq;

namespace SpeakerMeet.API.Tests
{
        public interface ISpeakerService
    {
        IEnumerable<Speaker> Search(string searchString);
    }
public class SpeakerControllerSearchTests 
    {

        private readonly SpeakerController _controller;
        private static Mock<ISpeakerService> _speakerServiceMock;
        private readonly List<Speaker> _speakers;

        public SpeakerControllerSearchTests()
        {
            _speakers = new List<Speaker> { new Speaker
            {
                Name = "test"
            } };

            // define the mock
            _speakerServiceMock = new Mock<ISpeakerService>();

            // when search is called, return list of speakers containing speaker
            _speakerServiceMock.Setup(x => x.Search(It.IsAny<string>()))
                .Returns(() => _speakers);

            // pass mock object as ISpeakerService
            _controller = new SpeakerController(_speakerServiceMock.Object);
        }

        [Fact]
        public void ItReturnsCollectionOfSpeakers()
        {
            // Arrange
            // Act
            var result = _controller.Search("Jos") as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.Value);
            Assert.IsType<List<Speaker>>(result.Value);
        }
    }
}
