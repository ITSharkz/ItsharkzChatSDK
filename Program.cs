ChatSDK.SDK.ChatService chat = new ChatSDK.SDK.ChatService("", ChatSDK.SDK.ChatService.Environment.Dev);

string token = (await chat.Auth.Authorize(new ChatSDK.Model.Auth.GetApiTokenRequest { Key = "gpvtohqvmeblmebaffrykvrc", Secret = "^&H7p!$fw%DWHELba&*wO1Rfs.%=%I7jXY!uNq=c1$$V.6^K1wd.V!Cm!2%N=aD$" })).Token;


chat.UpdateToken(token);

var customer = await chat.Customers.CreateCustomer(new ChatSDK.Model.CreateCustomerRequest { Name = "Dżon", Tag = "" });
var customerToken = await chat.Customers.GetCustomerToken(customer.Id);
var listCustomers = await chat.Customers.ListCustomers();
Console.WriteLine("");
