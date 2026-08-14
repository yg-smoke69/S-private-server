using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C5E")]
public class EVeteranTask
{
	[Token(Token = "0x2001C5F")]
	public enum Proto
	{
		[Token(Token = "0x400B473")]
		Proto_NONE,
		[Token(Token = "0x400B474")]
		Proto_UPDATE_NTF
	}

	[Token(Token = "0x2001C60")]
	public enum ErrCode
	{
		[Token(Token = "0x400B476")]
		ErrCode_SUSS
	}

	[Token(Token = "0x60082FF")]
	[Address(RVA = "0x33E9238", Offset = "0x33E9238", VA = "0x33E9238")]
	public EVeteranTask()
	{
	}
}
