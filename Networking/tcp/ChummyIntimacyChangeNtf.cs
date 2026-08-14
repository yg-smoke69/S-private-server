using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C89")]
public class ChummyIntimacyChangeNtf
{
	[Token(Token = "0x400B50C")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cchummy_id_003Ek__BackingField;

	[Token(Token = "0x400B50D")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cmulti_relation_type_003Ek__BackingField;

	[Token(Token = "0x400B50E")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Ctotal_intimacy_003Ek__BackingField;

	[Token(Token = "0x17000A5B")]
	public ulong chummy_id
	{
		[Token(Token = "0x60083B2")]
		[Address(RVA = "0x33E851C", Offset = "0x33E851C", VA = "0x33E851C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083B3")]
		[Address(RVA = "0x33E8524", Offset = "0x33E8524", VA = "0x33E8524")]
		set
		{
		}
	}

	[Token(Token = "0x17000A5C")]
	public uint multi_relation_type
	{
		[Token(Token = "0x60083B4")]
		[Address(RVA = "0x33E8534", Offset = "0x33E8534", VA = "0x33E8534")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60083B5")]
		[Address(RVA = "0x33E853C", Offset = "0x33E853C", VA = "0x33E853C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A5D")]
	public uint total_intimacy
	{
		[Token(Token = "0x60083B6")]
		[Address(RVA = "0x33E8544", Offset = "0x33E8544", VA = "0x33E8544")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60083B7")]
		[Address(RVA = "0x33E854C", Offset = "0x33E854C", VA = "0x33E854C")]
		set
		{
		}
	}

	[Token(Token = "0x60083B1")]
	[Address(RVA = "0x33E8514", Offset = "0x33E8514", VA = "0x33E8514")]
	public ChummyIntimacyChangeNtf()
	{
	}
}
