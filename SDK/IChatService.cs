namespace ChatSDK.SDK
{
    public interface IChatService
    {
        IAuth Auth { get; set; }
        ICustomers Customers { get; set; }
        IChannels Channels { get; set; }

        Task UpdateToken();
    }
}