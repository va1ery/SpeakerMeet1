using System;
using Xunit;
using SpeakerMeet.API.Controllers; //<-- directive to add
namespace SpeakerMeet.API.Tests
{
public class SpeakerControllerSearchTests //<-- to rename
{
[Fact]
public void ItExists()
{
var controller = new SpeakerController();
}
}
}