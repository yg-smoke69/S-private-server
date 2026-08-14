using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C87")]
public class ChummyDismissedNtf
{
	[Token(Token = "0x400B509")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cchummy_id_003Ek__BackingField;

	[Token(Token = "0x400B50A")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cmulti_relation_type_003Ek__BackingField;

	[Token(Token = "0x17000A58")]
	public ulong chummy_id
	{
		[Token(Token = "0x60083AA")]
		[Address(RVA = "0x33E84EC", Offset = "0x33E84EC", VA = "0x33E84EC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083AB")]
		[Address(RVA = "0x33E84F4", Offset = "0x33E84F4", VA = "0x33E84F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000A59")]
	public uint multi_relation_type
	{
		[Token(Token = "0x60083AC")]
		[Address(RVA = "0x33E8504", Offset = "0x33E8504", VA = "0x33E8504")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60083AD")]
		[Address(RVA = "0x33E850C", Offset = "0x33E850C", VA = "0x33E850C")]
		set
		{
		}
	}

	[Token(Token = "0x60083A9")]
	[Address(RVA = "0x33E84E4", Offset = "0x33E84E4", VA = "0x33E84E4")]
	public ChummyDismissedNtf()
	{
	}
}
