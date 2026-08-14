using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C68")]
public class RequestJoinChampionshipTeamReq
{
	[Token(Token = "0x400B48D")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Capplicant_id_003Ek__BackingField;

	[Token(Token = "0x17000A1A")]
	public ulong applicant_id
	{
		[Token(Token = "0x6008318")]
		[Address(RVA = "0x435D5A0", Offset = "0x435D5A0", VA = "0x435D5A0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008319")]
		[Address(RVA = "0x435D5A8", Offset = "0x435D5A8", VA = "0x435D5A8")]
		set
		{
		}
	}

	[Token(Token = "0x6008317")]
	[Address(RVA = "0x435D598", Offset = "0x435D598", VA = "0x435D598")]
	public RequestJoinChampionshipTeamReq()
	{
	}
}
