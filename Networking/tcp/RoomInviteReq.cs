using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D61")]
public class RoomInviteReq
{
	[Token(Token = "0x400B984")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cinvitee_id_003Ek__BackingField;

	[Token(Token = "0x17000CC4")]
	public ulong invitee_id
	{
		[Token(Token = "0x6008921")]
		[Address(RVA = "0x435E4A4", Offset = "0x435E4A4", VA = "0x435E4A4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008922")]
		[Address(RVA = "0x435E4AC", Offset = "0x435E4AC", VA = "0x435E4AC")]
		set
		{
		}
	}

	[Token(Token = "0x6008920")]
	[Address(RVA = "0x435E49C", Offset = "0x435E49C", VA = "0x435E49C")]
	public RoomInviteReq()
	{
	}
}
