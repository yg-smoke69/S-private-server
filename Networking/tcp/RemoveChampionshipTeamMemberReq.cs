using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C6A")]
public class RemoveChampionshipTeamMemberReq
{
	[Token(Token = "0x400B490")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cteam_id_003Ek__BackingField;

	[Token(Token = "0x400B491")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cremovee_id_003Ek__BackingField;

	[Token(Token = "0x17000A1D")]
	public ulong team_id
	{
		[Token(Token = "0x6008320")]
		[Address(RVA = "0x435D3C8", Offset = "0x435D3C8", VA = "0x435D3C8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008321")]
		[Address(RVA = "0x435D3D0", Offset = "0x435D3D0", VA = "0x435D3D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A1E")]
	public ulong removee_id
	{
		[Token(Token = "0x6008322")]
		[Address(RVA = "0x435D3E0", Offset = "0x435D3E0", VA = "0x435D3E0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008323")]
		[Address(RVA = "0x435D3E8", Offset = "0x435D3E8", VA = "0x435D3E8")]
		set
		{
		}
	}

	[Token(Token = "0x600831F")]
	[Address(RVA = "0x435D3C0", Offset = "0x435D3C0", VA = "0x435D3C0")]
	public RemoveChampionshipTeamMemberReq()
	{
	}
}
