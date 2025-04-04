using MeuProjeto.SendMessage;
using MeuProjeto.SendMessage.Adapters;
using Moq;
using Xunit;

namespace MeuProjeto.Tests;

public class SendMessageClientTest
{
    [Fact]
    public async Task SendMessage_ShouldCallProviderWithCorrectParams()
    {
        var sendMessageProvider = new Mock<SendMessageInterface>();
        var sut = new SendMessageClient(sendMessageProvider.Object);
        
        var message = "Test message";
        var expectedMessage = "Test message";
        
        sendMessageProvider.Setup(m => m.SendMessage(It.IsAny<string>()))
            .ReturnsAsync(expectedMessage);
        
        await sut.Send(message);
        
        sendMessageProvider.Verify( m => m.SendMessage(expectedMessage), Times.Once);
    }
    
    [Fact]
    public async Task SendMessage_ShouldNotifyObservers()
    {
        var sendMessageProvider = new Mock<SendMessageInterface>();
        var sut = new SendMessageClient(sendMessageProvider.Object);
        
        var message = "Test message";
        var expectedMessage = "Test message";
        
        sendMessageProvider.Setup(m => m.SendMessage(It.IsAny<string>()))
            .ReturnsAsync(expectedMessage);
        
        var observerMock = new Mock<IObserver>();
        sut.AddObserver(observerMock.Object);
        
        await sut.Send(message);
        
        observerMock.Verify(o => o.Call(expectedMessage), Times.Once);
    }
    
    [Fact]
    public async Task SendMessage_ShouldHandleMultipleObservers()
    {
        var sendMessageProvider = new Mock<SendMessageInterface>();
        var sut = new SendMessageClient(sendMessageProvider.Object);
        
        var message = "Test message";
        var expectedMessage = "Test message";
        
        sendMessageProvider.Setup(m => m.SendMessage(It.IsAny<string>()))
            .ReturnsAsync(expectedMessage);
        
        var observerMock1 = new Mock<IObserver>();
        var observerMock2 = new Mock<IObserver>();
        
        sut.AddObserver(observerMock1.Object);
        sut.AddObserver(observerMock2.Object);
        
        await sut.Send(message);
        
        observerMock1.Verify(o => o.Call(expectedMessage), Times.Once);
        observerMock2.Verify(o => o.Call(expectedMessage), Times.Once);
    }
}
