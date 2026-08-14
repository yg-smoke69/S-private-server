using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C9A")]
public class AppointClanWarNewCaptainReq
{
	[Token(Token = "0x400B546")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cold_captain_id_003Ek__BackingField;

	[Token(Token = "0x400B547")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cnew_captain_id_003Ek__BackingField;

	[Token(Token = "0x17000A80")]
	public ulong old_captain_id
	{
		[Token(Token = "0x600840B")]
		[Address(RVA = "0x33E7CC8", Offset = "0x33E7CC8", VA = "0x33E7CC8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600840C")]
		[Address(RVA = "0x33E7CD0", Offset = "0x33E7CD0", VA = "0x33E7CD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A81")]
	public ulong new_captain_id
	{
		[Token(Token = "0x600840D")]
		[Address(RVA = "0x33E7CE0", Offset = "0x33E7CE0", VA = "0x33E7CE0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600840E")]
		[Address(RVA = "0x33E7CE8", Offset = "0x33E7CE8", VA = "0x33E7CE8")]
		set
		{
		}
	}

	[Token(Token = "0x600840A")]
	[Address(RVA = "0x33E7CC0", Offset = "0x33E7CC0", VA = "0x33E7CC0")]
	public AppointClanWarNewCaptainReq()
	{
	}
}
