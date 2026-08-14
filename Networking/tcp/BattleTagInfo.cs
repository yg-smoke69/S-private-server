using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DB0")]
public class BattleTagInfo
{
	[Token(Token = "0x400BC2C")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Ctag_id_003Ek__BackingField;

	[Token(Token = "0x400BC2D")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Ccount_003Ek__BackingField;

	[Token(Token = "0x17000ED2")]
	public uint tag_id
	{
		[Token(Token = "0x6008D7F")]
		[Address(RVA = "0x33E8038", Offset = "0x33E8038", VA = "0x33E8038")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D80")]
		[Address(RVA = "0x33E8040", Offset = "0x33E8040", VA = "0x33E8040")]
		set
		{
		}
	}

	[Token(Token = "0x17000ED3")]
	public uint count
	{
		[Token(Token = "0x6008D81")]
		[Address(RVA = "0x33E8048", Offset = "0x33E8048", VA = "0x33E8048")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D82")]
		[Address(RVA = "0x33E8050", Offset = "0x33E8050", VA = "0x33E8050")]
		set
		{
		}
	}

	[Token(Token = "0x6008D7E")]
	[Address(RVA = "0x33E8030", Offset = "0x33E8030", VA = "0x33E8030")]
	public BattleTagInfo()
	{
	}
}
