namespace ITStreamSDK.SDK
{
    public interface IITStreamService
    {
        IAuth Auth { get; set; }
        ICustomers Customers { get; set; }
        IChannels Channels { get; set; }

        Task UpdateToken();
    }
}