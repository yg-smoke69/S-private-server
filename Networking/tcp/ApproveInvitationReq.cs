using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C8F")]
public class ApproveInvitationReq
{
	[Token(Token = "0x400B52B")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cinvitee_id_003Ek__BackingField;

	[Token(Token = "0x400B52C")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cclan_id_003Ek__BackingField;

	[Token(Token = "0x17000A65")]
	public ulong invitee_id
	{
		[Token(Token = "0x60083CA")]
		[Address(RVA = "0x33E7D90", Offset = "0x33E7D90", VA = "0x33E7D90")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083CB")]
		[Address(RVA = "0x33E7D98", Offset = "0x33E7D98", VA = "0x33E7D98")]
		set
		{
		}
	}

	[Token(Token = "0x17000A66")]
	public ulong clan_id
	{
		[Token(Token = "0x60083CC")]
		[Address(RVA = "0x33E7DA8", Offset = "0x33E7DA8", VA = "0x33E7DA8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083CD")]
		[Address(RVA = "0x33E7DB0", Offset = "0x33E7DB0", VA = "0x33E7DB0")]
		set
		{
		}
	}

	[Token(Token = "0x60083C9")]
	[Address(RVA = "0x33E7D88", Offset = "0x33E7D88", VA = "0x33E7D88")]
	public ApproveInvitationReq()
	{
	}
}
