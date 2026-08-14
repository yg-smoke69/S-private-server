using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C4B")]
public class EActivity
{
	[Token(Token = "0x2001C4C")]
	public enum Proto
	{
		[Token(Token = "0x400B438")]
		Proto_NONE,
		[Token(Token = "0x400B439")]
		Proto_UPDATE_NTF
	}

	[Token(Token = "0x2001C4D")]
	public enum ErrCode
	{
		[Token(Token = "0x400B43B")]
		ErrCode_SUSS
	}

	[Token(Token = "0x60082B4")]
	[Address(RVA = "0x33E8FC4", Offset = "0x33E8FC4", VA = "0x33E8FC4")]
	public EActivity()
	{
	}
}
