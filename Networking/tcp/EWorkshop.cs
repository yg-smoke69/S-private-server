using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DBD")]
public class EWorkshop
{
	[Token(Token = "0x2001DBE")]
	public enum Proto
	{
		[Token(Token = "0x400BC68")]
		Proto_NONE,
		[Token(Token = "0x400BC69")]
		Proto_FREE_ROOM_TIMES_CHANGE_NTF
	}

	[Token(Token = "0x2001DBF")]
	public enum ErrCode
	{
		[Token(Token = "0x400BC6B")]
		ErrCode_SUSS
	}

	[Token(Token = "0x6008DEA")]
	[Address(RVA = "0x33E9248", Offset = "0x33E9248", VA = "0x33E9248")]
	public EWorkshop()
	{
	}
}
