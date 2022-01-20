namespace ChatSDK.SDK
{
    public interface IAuth
    {
        Task<Model.Auth.GetApiTokenResponse> Authorize(Model.Auth.GetApiTokenRequest apiTokenRequest);
        Task DisposeKeysPair(Model.Auth.DisposeKeyPairRequest disposeKeyPair);
        Task<List<Model.Auth.KeyPairResponse>> GetApiKeys();
    }
}