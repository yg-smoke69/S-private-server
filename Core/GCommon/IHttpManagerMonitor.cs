using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004056")]
public interface IHttpManagerMonitor
{
	[Token(Token = "0x601A30E")]
	void OnStartRequest(HttpManager.EHttpChannel channel, HttpRequest curHttpReq);

	[Token(Token = "0x601A30F")]
	void OnEndRequest(HttpManager.EHttpChannel channel, string cmd, bool hasNext, HttpRequest curHttpReq);

	[Token(Token = "0x601A310")]
	void OnUnauthorized(HttpManager.EHttpChannel channel);

	[Token(Token = "0x601A311")]
	void OnRetryFailed(HttpManager.EHttpChannel channel, HttpRequest curHttpReq);

	[Token(Token = "0x601A312")]
	void OnNewRequest(HttpRequest NewHttpReq);

	[Token(Token = "0x601A313")]
	void OnRemoveRequest(HttpRequest req);
}
