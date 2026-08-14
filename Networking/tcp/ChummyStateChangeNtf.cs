using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C86")]
public class ChummyStateChangeNtf
{
	[Token(Token = "0x400B505")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cchummy_id_003Ek__BackingField;

	[Token(Token = "0x400B506")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cmulti_relation_type_003Ek__BackingField;

	[Token(Token = "0x400B507")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Crelation_state_003Ek__BackingField;

	[Token(Token = "0x400B508")]
	[FieldOffset(Offset = "0x18")]
	private long _003Cstate_update_at_003Ek__BackingField;

	[Token(Token = "0x17000A54")]
	public ulong chummy_id
	{
		[Token(Token = "0x60083A1")]
		[Address(RVA = "0x33E857C", Offset = "0x33E857C", VA = "0x33E857C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083A2")]
		[Address(RVA = "0x33E8584", Offset = "0x33E8584", VA = "0x33E8584")]
		set
		{
		}
	}

	[Token(Token = "0x17000A55")]
	public uint multi_relation_type
	{
		[Token(Token = "0x60083A3")]
		[Address(RVA = "0x33E8594", Offset = "0x33E8594", VA = "0x33E8594")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60083A4")]
		[Address(RVA = "0x33E859C", Offset = "0x33E859C", VA = "0x33E859C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A56")]
	public uint relation_state
	{
		[Token(Token = "0x60083A5")]
		[Address(RVA = "0x33E85A4", Offset = "0x33E85A4", VA = "0x33E85A4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60083A6")]
		[Address(RVA = "0x33E85AC", Offset = "0x33E85AC", VA = "0x33E85AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000A57")]
	public long state_update_at
	{
		[Token(Token = "0x60083A7")]
		[Address(RVA = "0x33E85B4", Offset = "0x33E85B4", VA = "0x33E85B4")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60083A8")]
		[Address(RVA = "0x33E85BC", Offset = "0x33E85BC", VA = "0x33E85BC")]
		set
		{
		}
	}

	[Token(Token = "0x60083A0")]
	[Address(RVA = "0x33E8574", Offset = "0x33E8574", VA = "0x33E8574")]
	public ChummyStateChangeNtf()
	{
	}
}
