using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014FE")]
public enum NetworkMetricEvent
{
	[Token(Token = "0x4009079")]
	NetworkMetricEvent_NONE,
	[Token(Token = "0x400907A")]
	NetworkMetricEvent_LOGIN_GS_NETWORK_TIMEOUT,
	[Token(Token = "0x400907B")]
	NetworkMetricEvent_LOGIN_GS_LOADING_TIMEOUT,
	[Token(Token = "0x400907C")]
	NetworkMetricEvent_GS_DISCONNECT,
	[Token(Token = "0x400907D")]
	NetworkMetricEvent_CDN_DOWNLOAD_FAILED,
	[Token(Token = "0x400907E")]
	NetworkMetricEvent_GCS_UPLOAD_FAILED
}
