using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C6B")]
public class InviteToChampionshipTeamReq
{
	[Token(Token = "0x400B492")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cinviter_id_003Ek__BackingField;

	[Token(Token = "0x400B493")]
	[FieldOffset(Offset = "0x10")]
	private string _003Cinviter_name_003Ek__BackingField;

	[Token(Token = "0x400B494")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Cteam_id_003Ek__BackingField;

	[Token(Token = "0x400B495")]
	[FieldOffset(Offset = "0x20")]
	private string _003Cteam_name_003Ek__BackingField;

	[Token(Token = "0x17000A1F")]
	public ulong inviter_id
	{
		[Token(Token = "0x6008325")]
		[Address(RVA = "0x33EBC54", Offset = "0x33EBC54", VA = "0x33EBC54")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008326")]
		[Address(RVA = "0x33EBC5C", Offset = "0x33EBC5C", VA = "0x33EBC5C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A20")]
	public string inviter_name
	{
		[Token(Token = "0x6008327")]
		[Address(RVA = "0x33EBC6C", Offset = "0x33EBC6C", VA = "0x33EBC6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008328")]
		[Address(RVA = "0x33EBC44", Offset = "0x33EBC44", VA = "0x33EBC44")]
		set
		{
		}
	}

	[Token(Token = "0x17000A21")]
	public ulong team_id
	{
		[Token(Token = "0x6008329")]
		[Address(RVA = "0x33EBC74", Offset = "0x33EBC74", VA = "0x33EBC74")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600832A")]
		[Address(RVA = "0x33EBC7C", Offset = "0x33EBC7C", VA = "0x33EBC7C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A22")]
	public string team_name
	{
		[Token(Token = "0x600832B")]
		[Address(RVA = "0x33EBC8C", Offset = "0x33EBC8C", VA = "0x33EBC8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600832C")]
		[Address(RVA = "0x33EBC4C", Offset = "0x33EBC4C", VA = "0x33EBC4C")]
		set
		{
		}
	}

	[Token(Token = "0x6008324")]
	[Address(RVA = "0x33EBB98", Offset = "0x33EBB98", VA = "0x33EBB98")]
	public InviteToChampionshipTeamReq()
	{
	}
}
