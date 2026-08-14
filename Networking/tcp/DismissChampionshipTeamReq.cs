using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C6D")]
public class DismissChampionshipTeamReq
{
	[Token(Token = "0x400B498")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cteam_id_003Ek__BackingField;

	[Token(Token = "0x400B499")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cdismisser_id_003Ek__BackingField;

	[Token(Token = "0x400B49A")]
	[FieldOffset(Offset = "0x18")]
	private string _003Cteam_name_003Ek__BackingField;

	[Token(Token = "0x17000A25")]
	public ulong team_id
	{
		[Token(Token = "0x6008333")]
		[Address(RVA = "0x33E8DA4", Offset = "0x33E8DA4", VA = "0x33E8DA4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008334")]
		[Address(RVA = "0x33E8DAC", Offset = "0x33E8DAC", VA = "0x33E8DAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000A26")]
	public ulong dismisser_id
	{
		[Token(Token = "0x6008335")]
		[Address(RVA = "0x33E8DBC", Offset = "0x33E8DBC", VA = "0x33E8DBC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008336")]
		[Address(RVA = "0x33E8DC4", Offset = "0x33E8DC4", VA = "0x33E8DC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000A27")]
	public string team_name
	{
		[Token(Token = "0x6008337")]
		[Address(RVA = "0x33E8DD4", Offset = "0x33E8DD4", VA = "0x33E8DD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008338")]
		[Address(RVA = "0x33E8D9C", Offset = "0x33E8D9C", VA = "0x33E8D9C")]
		set
		{
		}
	}

	[Token(Token = "0x6008332")]
	[Address(RVA = "0x33E8CFC", Offset = "0x33E8CFC", VA = "0x33E8CFC")]
	public DismissChampionshipTeamReq()
	{
	}
}
