using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C8E")]
public class ConfirmAddReq
{
	[Token(Token = "0x400B528")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cclan_id_003Ek__BackingField;

	[Token(Token = "0x400B529")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cconfirmer_id_003Ek__BackingField;

	[Token(Token = "0x400B52A")]
	[FieldOffset(Offset = "0x18")]
	private string _003Cclan_channel_secret_003Ek__BackingField;

	[Token(Token = "0x17000A62")]
	public ulong clan_id
	{
		[Token(Token = "0x60083C3")]
		[Address(RVA = "0x33E88F8", Offset = "0x33E88F8", VA = "0x33E88F8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083C4")]
		[Address(RVA = "0x33E8900", Offset = "0x33E8900", VA = "0x33E8900")]
		set
		{
		}
	}

	[Token(Token = "0x17000A63")]
	public ulong confirmer_id
	{
		[Token(Token = "0x60083C5")]
		[Address(RVA = "0x33E8910", Offset = "0x33E8910", VA = "0x33E8910")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083C6")]
		[Address(RVA = "0x33E8918", Offset = "0x33E8918", VA = "0x33E8918")]
		set
		{
		}
	}

	[Token(Token = "0x17000A64")]
	public string clan_channel_secret
	{
		[Token(Token = "0x60083C7")]
		[Address(RVA = "0x33E8928", Offset = "0x33E8928", VA = "0x33E8928")]
		get
		{
			return null;
		}
		[Token(Token = "0x60083C8")]
		[Address(RVA = "0x33E88F0", Offset = "0x33E88F0", VA = "0x33E88F0")]
		set
		{
		}
	}

	[Token(Token = "0x60083C2")]
	[Address(RVA = "0x33E8850", Offset = "0x33E8850", VA = "0x33E8850")]
	public ConfirmAddReq()
	{
	}
}
