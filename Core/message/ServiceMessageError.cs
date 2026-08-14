using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001C3B")]
public static class ServiceMessageError
{
	[Token(Token = "0x400B3F0")]
	public const uint Login_BadRequest = 400u;

	[Token(Token = "0x400B3F1")]
	public const uint Login_Forbidden = 403u;

	[Token(Token = "0x400B3F2")]
	public const uint Login_UserNotExisted = 404u;

	[Token(Token = "0x400B3F3")]
	public const uint Register_StatusBadRequest = 400u;

	[Token(Token = "0x400B3F4")]
	public const uint BR_AUTH_SERVER_PROTECT_IS_OPEN = 800u;

	[Token(Token = "0x400B3F5")]
	public const uint BR_GEOIP_REGION_NOT_OPEN = 801u;

	[Token(Token = "0x400B3F6")]
	public const uint BR_FB_CONNECTED_GAS_ONLY = 802u;

	[Token(Token = "0x400B3F7")]
	public const uint InvalidMsdkErrorCode = 900u;

	[Token(Token = "0x400B3F8")]
	public const uint Match_Result_NoResultFound = 404u;
}
