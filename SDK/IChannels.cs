using ITStreamSDK.Model;

namespace ITStreamSDK.SDK
{
    public interface IChannels
    {
        Task<StringIdResponse> Create(CreateChannel createChannel);
    }
}