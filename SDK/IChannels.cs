using ChatSDK.Model;

namespace ChatSDK.SDK
{
    public interface IChannels
    {
        Task<StringIdResponse> Create(CreateChannel createChannel);
    }
}