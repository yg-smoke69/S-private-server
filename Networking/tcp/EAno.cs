using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C50")]
public class EAno
{
	[Token(Token = "0x2001C51")]
	public enum Proto
	{
		[Token(Token = "0x400B442")]
		Proto_NONE,
		[Token(Token = "0x400B443")]
		Proto_RECV_ANTI_DATA,
		[Token(Token = "0x400B444")]
		Proto_SEND_DATA_TO_CLIENT_NTF,
		[Token(Token = "0x400B445")]
		Proto_LIGHT_FEATURE_NTF,
		[Token(Token = "0x400B446")]
		Proto_TICK_USER,
		[Token(Token = "0x400B447")]
		Proto_SEC_REPORT_FLOW
	}

	[Token(Token = "0x2001C52")]
	public enum ErrCode
	{
		[Token(Token = "0x400B449")]
		ErrCode_SUSS
	}

	[Token(Token = "0x60082C1")]
	[Address(RVA = "0x33E8FCC", Offset = "0x33E8FCC", VA = "0x33E8FCC")]
	public EAno()
	{
	}
}
