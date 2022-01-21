Console.WriteLine("");
var ch = new ChatSDK.SDK.ChatService("oogglkqspiprdpezhnlwqwmk", "QB^1Ok$%q*gJgnZi^Cxc4fl0g*.EL*lX&^cn9V66ato%Xqqf*.0nAG2P*$.==r&H", ChatSDK.SDK.ChatService.Environment.Dev);

var c = await ch.Customers.ListCustomers();

await ch.UpdateToken();


c = await ch.Customers.ListCustomers();

var cus = await ch.Customers.CreateCustomer(new ChatSDK.Model.CreateCustomerRequest { Name = "Dareczek" });
await ch.UpdateToken();
var cusTok = await ch.Customers.GetCustomerToken(cus.Id);



Console.WriteLine("");