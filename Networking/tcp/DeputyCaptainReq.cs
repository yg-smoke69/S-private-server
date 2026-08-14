using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C96")]
public class DeputyCaptainReq
{
	[Token(Token = "0x400B53E")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cclan_id_003Ek__BackingField;

	[Token(Token = "0x400B53F")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cdeputy_id_003Ek__BackingField;

	[Token(Token = "0x17000A78")]
	public ulong clan_id
	{
		[Token(Token = "0x60083F7")]
		[Address(RVA = "0x33E8C9C", Offset = "0x33E8C9C", VA = "0x33E8C9C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083F8")]
		[Address(RVA = "0x33E8CA4", Offset = "0x33E8CA4", VA = "0x33E8CA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000A79")]
	public ulong deputy_id
	{
		[Token(Token = "0x60083F9")]
		[Address(RVA = "0x33E8CB4", Offset = "0x33E8CB4", VA = "0x33E8CB4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083FA")]
		[Address(RVA = "0x33E8CBC", Offset = "0x33E8CBC", VA = "0x33E8CBC")]
		set
		{
		}
	}

	[Token(Token = "0x60083F6")]
	[Address(RVA = "0x33E8C94", Offset = "0x33E8C94", VA = "0x33E8C94")]
	public DeputyCaptainReq()
	{
	}
}
