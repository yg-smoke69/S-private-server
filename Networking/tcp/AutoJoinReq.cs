using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C92")]
public class AutoJoinReq
{
	[Token(Token = "0x400B532")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cclan_id_003Ek__BackingField;

	[Token(Token = "0x400B533")]
	[FieldOffset(Offset = "0x10")]
	private string _003Cclan_channel_secret_003Ek__BackingField;

	[Token(Token = "0x17000A6C")]
	public ulong clan_id
	{
		[Token(Token = "0x60083DB")]
		[Address(RVA = "0x33E7E68", Offset = "0x33E7E68", VA = "0x33E7E68")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083DC")]
		[Address(RVA = "0x33E7E70", Offset = "0x33E7E70", VA = "0x33E7E70")]
		set
		{
		}
	}

	[Token(Token = "0x17000A6D")]
	public string clan_channel_secret
	{
		[Token(Token = "0x60083DD")]
		[Address(RVA = "0x33E7E80", Offset = "0x33E7E80", VA = "0x33E7E80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60083DE")]
		[Address(RVA = "0x33E7E60", Offset = "0x33E7E60", VA = "0x33E7E60")]
		set
		{
		}
	}

	[Token(Token = "0x60083DA")]
	[Address(RVA = "0x33E7DC0", Offset = "0x33E7DC0", VA = "0x33E7DC0")]
	public AutoJoinReq()
	{
	}
}
