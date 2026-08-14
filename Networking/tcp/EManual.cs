using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D14")]
public class EManual
{
	[Token(Token = "0x2001D15")]
	public enum Proto
	{
		[Token(Token = "0x400B7A0")]
		Proto_NONE,
		[Token(Token = "0x400B7A1")]
		Proto_WEAPON_REWARD_UPDATE_NTF,
		[Token(Token = "0x400B7A2")]
		Proto_MAP_REWARD_UPDATE_NTF
	}

	[Token(Token = "0x2001D16")]
	public enum ErrCode
	{
		[Token(Token = "0x400B7A4")]
		ErrCode_SUSS
	}

	[Token(Token = "0x6008714")]
	[Address(RVA = "0x33E906C", Offset = "0x33E906C", VA = "0x33E906C")]
	public EManual()
	{
	}
}
