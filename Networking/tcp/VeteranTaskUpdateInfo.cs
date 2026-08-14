using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C62")]
public class VeteranTaskUpdateInfo
{
	[Token(Token = "0x400B479")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cid_003Ek__BackingField;

	[Token(Token = "0x400B47A")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cdata_003Ek__BackingField;

	[Token(Token = "0x400B47B")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cstate_003Ek__BackingField;

	[Token(Token = "0x400B47C")]
	[FieldOffset(Offset = "0x14")]
	private string _003Ccontext_003Ek__BackingField;

	[Token(Token = "0x17000A13")]
	public uint id
	{
		[Token(Token = "0x6008306")]
		[Address(RVA = "0x435FD04", Offset = "0x435FD04", VA = "0x435FD04")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008307")]
		[Address(RVA = "0x435FD0C", Offset = "0x435FD0C", VA = "0x435FD0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A14")]
	public uint data
	{
		[Token(Token = "0x6008308")]
		[Address(RVA = "0x435FD14", Offset = "0x435FD14", VA = "0x435FD14")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008309")]
		[Address(RVA = "0x435FD1C", Offset = "0x435FD1C", VA = "0x435FD1C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A15")]
	public uint state
	{
		[Token(Token = "0x600830A")]
		[Address(RVA = "0x435FD24", Offset = "0x435FD24", VA = "0x435FD24")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600830B")]
		[Address(RVA = "0x435FD2C", Offset = "0x435FD2C", VA = "0x435FD2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A16")]
	public string context
	{
		[Token(Token = "0x600830C")]
		[Address(RVA = "0x435FD34", Offset = "0x435FD34", VA = "0x435FD34")]
		get
		{
			return null;
		}
		[Token(Token = "0x600830D")]
		[Address(RVA = "0x435FCFC", Offset = "0x435FCFC", VA = "0x435FCFC")]
		set
		{
		}
	}

	[Token(Token = "0x6008305")]
	[Address(RVA = "0x435FC5C", Offset = "0x435FC5C", VA = "0x435FC5C")]
	public VeteranTaskUpdateInfo()
	{
	}
}
