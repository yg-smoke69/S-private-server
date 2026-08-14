using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C9C")]
public class InviteToClanWarReq
{
	[Token(Token = "0x400B54A")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cinviter_id_003Ek__BackingField;

	[Token(Token = "0x17000A84")]
	public ulong inviter_id
	{
		[Token(Token = "0x6008415")]
		[Address(RVA = "0x33EBD98", Offset = "0x33EBD98", VA = "0x33EBD98")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008416")]
		[Address(RVA = "0x33EBDA0", Offset = "0x33EBDA0", VA = "0x33EBDA0")]
		set
		{
		}
	}

	[Token(Token = "0x6008414")]
	[Address(RVA = "0x33EBD90", Offset = "0x33EBD90", VA = "0x33EBD90")]
	public InviteToClanWarReq()
	{
	}
}
