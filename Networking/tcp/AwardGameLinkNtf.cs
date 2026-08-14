using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D42")]
public class AwardGameLinkNtf
{
	[Token(Token = "0x400B87E")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cavatar_id_003Ek__BackingField;

	[Token(Token = "0x400B87F")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Caward_game_link_003Ek__BackingField;

	[Token(Token = "0x17000C4F")]
	public uint avatar_id
	{
		[Token(Token = "0x6008822")]
		[Address(RVA = "0x33E8010", Offset = "0x33E8010", VA = "0x33E8010")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008823")]
		[Address(RVA = "0x33E8018", Offset = "0x33E8018", VA = "0x33E8018")]
		set
		{
		}
	}

	[Token(Token = "0x17000C50")]
	public uint award_game_link
	{
		[Token(Token = "0x6008824")]
		[Address(RVA = "0x33E8020", Offset = "0x33E8020", VA = "0x33E8020")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008825")]
		[Address(RVA = "0x33E8028", Offset = "0x33E8028", VA = "0x33E8028")]
		set
		{
		}
	}

	[Token(Token = "0x6008821")]
	[Address(RVA = "0x33E8008", Offset = "0x33E8008", VA = "0x33E8008")]
	public AwardGameLinkNtf()
	{
	}
}
