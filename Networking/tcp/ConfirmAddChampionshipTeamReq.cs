using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C69")]
public class ConfirmAddChampionshipTeamReq
{
	[Token(Token = "0x400B48E")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cteam_id_003Ek__BackingField;

	[Token(Token = "0x400B48F")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cconfirmer_id_003Ek__BackingField;

	[Token(Token = "0x17000A1B")]
	public ulong team_id
	{
		[Token(Token = "0x600831B")]
		[Address(RVA = "0x33E87C8", Offset = "0x33E87C8", VA = "0x33E87C8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600831C")]
		[Address(RVA = "0x33E87D0", Offset = "0x33E87D0", VA = "0x33E87D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A1C")]
	public ulong confirmer_id
	{
		[Token(Token = "0x600831D")]
		[Address(RVA = "0x33E87E0", Offset = "0x33E87E0", VA = "0x33E87E0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600831E")]
		[Address(RVA = "0x33E87E8", Offset = "0x33E87E8", VA = "0x33E87E8")]
		set
		{
		}
	}

	[Token(Token = "0x600831A")]
	[Address(RVA = "0x33E87C0", Offset = "0x33E87C0", VA = "0x33E87C0")]
	public ConfirmAddChampionshipTeamReq()
	{
	}
}
