using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C82")]
public class EChummy
{
	[Token(Token = "0x2001C83")]
	public enum Proto
	{
		[Token(Token = "0x400B4FC")]
		Proto_NONE,
		[Token(Token = "0x400B4FD")]
		Proto_REQUEST_NTF,
		[Token(Token = "0x400B4FE")]
		Proto_CONFIRM_ADDING_CHUMMY_NTF,
		[Token(Token = "0x400B4FF")]
		Proto_CHUMMY_STATE_CHANGE,
		[Token(Token = "0x400B500")]
		Proto_CHUMMY_DISMISSED,
		[Token(Token = "0x400B501")]
		Proto_INTIMACY_CHANGE_NTF
	}

	[Token(Token = "0x2001C84")]
	public enum ErrCode
	{
		[Token(Token = "0x400B503")]
		ErrCode_SUSS
	}

	[Token(Token = "0x600839C")]
	[Address(RVA = "0x33E8FF4", Offset = "0x33E8FF4", VA = "0x33E8FF4")]
	public EChummy()
	{
	}
}
