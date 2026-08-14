using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C95")]
public class ApplyForDeputyReq
{
	[Token(Token = "0x400B53D")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cclan_id_003Ek__BackingField;

	[Token(Token = "0x17000A77")]
	public ulong clan_id
	{
		[Token(Token = "0x60083F4")]
		[Address(RVA = "0x33E7CA8", Offset = "0x33E7CA8", VA = "0x33E7CA8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083F5")]
		[Address(RVA = "0x33E7CB0", Offset = "0x33E7CB0", VA = "0x33E7CB0")]
		set
		{
		}
	}

	[Token(Token = "0x60083F3")]
	[Address(RVA = "0x33E7CA0", Offset = "0x33E7CA0", VA = "0x33E7CA0")]
	public ApplyForDeputyReq()
	{
	}
}
