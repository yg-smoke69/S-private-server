using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CC1")]
public class IntimacyChangeNtf
{
	[Token(Token = "0x400B5C9")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Crelated_friend_id_003Ek__BackingField;

	[Token(Token = "0x400B5CA")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Crelation_type_003Ek__BackingField;

	[Token(Token = "0x400B5CB")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cadd_value_003Ek__BackingField;

	[Token(Token = "0x17000AD7")]
	public ulong related_friend_id
	{
		[Token(Token = "0x60084D6")]
		[Address(RVA = "0x33EB83C", Offset = "0x33EB83C", VA = "0x33EB83C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60084D7")]
		[Address(RVA = "0x33EB844", Offset = "0x33EB844", VA = "0x33EB844")]
		set
		{
		}
	}

	[Token(Token = "0x17000AD8")]
	public uint relation_type
	{
		[Token(Token = "0x60084D8")]
		[Address(RVA = "0x33EB854", Offset = "0x33EB854", VA = "0x33EB854")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084D9")]
		[Address(RVA = "0x33EB85C", Offset = "0x33EB85C", VA = "0x33EB85C")]
		set
		{
		}
	}

	[Token(Token = "0x17000AD9")]
	public uint add_value
	{
		[Token(Token = "0x60084DA")]
		[Address(RVA = "0x33EB864", Offset = "0x33EB864", VA = "0x33EB864")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084DB")]
		[Address(RVA = "0x33EB86C", Offset = "0x33EB86C", VA = "0x33EB86C")]
		set
		{
		}
	}

	[Token(Token = "0x60084D5")]
	[Address(RVA = "0x33EB834", Offset = "0x33EB834", VA = "0x33EB834")]
	public IntimacyChangeNtf()
	{
	}
}
