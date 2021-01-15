using System;
using Xunit;
using SpeakerMeet.API.Controllers; 
using Microsoft.AspNetCore.Mvc; // <- Добавить директиву!

namespace SpeakerMeet.API.Tests
{
public class SpeakerControllerSearchTests 
    {
    [Fact(Skip = "Более не требуется")]
    public void ItExists()
        {
            var controller = new SpeakerController();
        }
        [Fact(Skip = "Более не требуется")]
    public void ItHasSearch() //Проверяем наличие метода Поиск
        {
            var controller = new SpeakerController();
            controller.Search("Jos");
        }

        [Fact]
        public void ItReturnsOkObjectResult()
        { 
            var controller = new SpeakerController();
            var result = controller.Search("Jos");
            Assert.NotNull(result);                    //Поиск принес результат?
            Assert.IsType<OkObjectResult>(result);     //Результат ОК?
        }
    }    
}
