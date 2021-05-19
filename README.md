# RestSharp port for Unity
This is original [RestSharp](https://github.com/restsharp/RestSharp) library ported to Unity3D with minor changes:
- Removed all serializers except default & Newtonsoft
- Added csc.rsp to link System.Web.dll library

## How to install
- Open Unity Package Manager (Window/Package Manager).
- Pres add button and select *add package from git url*.
- Use repository url (https://github.com/spaskhalov/UnityRestSharp.git). 

## How to use
Basic usage example:
```C#
using RestSharp;
using RestSharp.Authenticators;

var client = new RestClient("https://api.twitter.com/1.1");
client.Authenticator = new HttpBasicAuthenticator("username", "password");

var request = new RestRequest("statuses/home_timeline.json", DataFormat.Json);

var response = client.Get(request);
```

You can find more examples in [offical RestSharp documentation](https://restsharp.dev/usage/).