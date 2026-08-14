using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CBA")]
public class FreshActivityUpdateInfo
{
	[Token(Token = "0x400B5AF")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cid_003Ek__BackingField;

	[Token(Token = "0x400B5B0")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cdata_003Ek__BackingField;

	[Token(Token = "0x400B5B1")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cstate_003Ek__BackingField;

	[Token(Token = "0x17000ACA")]
	public uint id
	{
		[Token(Token = "0x60084B7")]
		[Address(RVA = "0x33E92E8", Offset = "0x33E92E8", VA = "0x33E92E8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084B8")]
		[Address(RVA = "0x33E92F0", Offset = "0x33E92F0", VA = "0x33E92F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000ACB")]
	public uint data
	{
		[Token(Token = "0x60084B9")]
		[Address(RVA = "0x33E92F8", Offset = "0x33E92F8", VA = "0x33E92F8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084BA")]
		[Address(RVA = "0x33E9300", Offset = "0x33E9300", VA = "0x33E9300")]
		set
		{
		}
	}

	[Token(Token = "0x17000ACC")]
	public uint state
	{
		[Token(Token = "0x60084BB")]
		[Address(RVA = "0x33E9308", Offset = "0x33E9308", VA = "0x33E9308")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084BC")]
		[Address(RVA = "0x33E9310", Offset = "0x33E9310", VA = "0x33E9310")]
		set
		{
		}
	}

	[Token(Token = "0x60084B6")]
	[Address(RVA = "0x33E92E0", Offset = "0x33E92E0", VA = "0x33E92E0")]
	public FreshActivityUpdateInfo()
	{
	}
}
