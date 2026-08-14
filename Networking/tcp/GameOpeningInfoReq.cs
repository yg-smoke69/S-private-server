using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D25")]
public class GameOpeningInfoReq
{
	[Token(Token = "0x400B82F")]
	[FieldOffset(Offset = "0x8")]
	private string _003Cregion_003Ek__BackingField;

	[Token(Token = "0x400B830")]
	[FieldOffset(Offset = "0xC")]
	private string _003Clanguage_003Ek__BackingField;

	[Token(Token = "0x17000C1C")]
	public string region
	{
		[Token(Token = "0x60087A8")]
		[Address(RVA = "0x33E9E70", Offset = "0x33E9E70", VA = "0x33E9E70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087A9")]
		[Address(RVA = "0x33E9E60", Offset = "0x33E9E60", VA = "0x33E9E60")]
		set
		{
		}
	}

	[Token(Token = "0x17000C1D")]
	public string language
	{
		[Token(Token = "0x60087AA")]
		[Address(RVA = "0x33E9E78", Offset = "0x33E9E78", VA = "0x33E9E78")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087AB")]
		[Address(RVA = "0x33E9E68", Offset = "0x33E9E68", VA = "0x33E9E68")]
		set
		{
		}
	}

	[Token(Token = "0x60087A7")]
	[Address(RVA = "0x33E9DB4", Offset = "0x33E9DB4", VA = "0x33E9DB4")]
	public GameOpeningInfoReq()
	{
	}
}
