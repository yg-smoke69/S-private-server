using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C6C")]
public class ApproveChampionshipTeamInvitationReq
{
	[Token(Token = "0x400B496")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cinvitee_id_003Ek__BackingField;

	[Token(Token = "0x400B497")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cteam_id_003Ek__BackingField;

	[Token(Token = "0x17000A23")]
	public ulong invitee_id
	{
		[Token(Token = "0x600832E")]
		[Address(RVA = "0x33E7D00", Offset = "0x33E7D00", VA = "0x33E7D00")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600832F")]
		[Address(RVA = "0x33E7D08", Offset = "0x33E7D08", VA = "0x33E7D08")]
		set
		{
		}
	}

	[Token(Token = "0x17000A24")]
	public ulong team_id
	{
		[Token(Token = "0x6008330")]
		[Address(RVA = "0x33E7D18", Offset = "0x33E7D18", VA = "0x33E7D18")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008331")]
		[Address(RVA = "0x33E7D20", Offset = "0x33E7D20", VA = "0x33E7D20")]
		set
		{
		}
	}

	[Token(Token = "0x600832D")]
	[Address(RVA = "0x33E7CF8", Offset = "0x33E7CF8", VA = "0x33E7CF8")]
	public ApproveChampionshipTeamInvitationReq()
	{
	}
}
