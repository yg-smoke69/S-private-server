using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C6E")]
public class DeclineChampionshipTeamInvitationReq
{
	[Token(Token = "0x400B49B")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cinvitee_id_003Ek__BackingField;

	[Token(Token = "0x17000A28")]
	public ulong invitee_id
	{
		[Token(Token = "0x600833A")]
		[Address(RVA = "0x33E8C7C", Offset = "0x33E8C7C", VA = "0x33E8C7C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600833B")]
		[Address(RVA = "0x33E8C84", Offset = "0x33E8C84", VA = "0x33E8C84")]
		set
		{
		}
	}

	[Token(Token = "0x6008339")]
	[Address(RVA = "0x33E8C74", Offset = "0x33E8C74", VA = "0x33E8C74")]
	public DeclineChampionshipTeamInvitationReq()
	{
	}
}
