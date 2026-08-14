using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CAA")]
public class ApproveCupTeamInvitationReq
{
	[Token(Token = "0x400B57B")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cinvitee_id_003Ek__BackingField;

	[Token(Token = "0x400B57C")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Ccup_team_id_003Ek__BackingField;

	[Token(Token = "0x400B57D")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Ccup_type_003Ek__BackingField;

	[Token(Token = "0x400B57E")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Ccup_id_003Ek__BackingField;

	[Token(Token = "0x17000AA3")]
	public ulong invitee_id
	{
		[Token(Token = "0x600845D")]
		[Address(RVA = "0x33E7D38", Offset = "0x33E7D38", VA = "0x33E7D38")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600845E")]
		[Address(RVA = "0x33E7D40", Offset = "0x33E7D40", VA = "0x33E7D40")]
		set
		{
		}
	}

	[Token(Token = "0x17000AA4")]
	public ulong cup_team_id
	{
		[Token(Token = "0x600845F")]
		[Address(RVA = "0x33E7D50", Offset = "0x33E7D50", VA = "0x33E7D50")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008460")]
		[Address(RVA = "0x33E7D58", Offset = "0x33E7D58", VA = "0x33E7D58")]
		set
		{
		}
	}

	[Token(Token = "0x17000AA5")]
	public uint cup_type
	{
		[Token(Token = "0x6008461")]
		[Address(RVA = "0x33E7D68", Offset = "0x33E7D68", VA = "0x33E7D68")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008462")]
		[Address(RVA = "0x33E7D70", Offset = "0x33E7D70", VA = "0x33E7D70")]
		set
		{
		}
	}

	[Token(Token = "0x17000AA6")]
	public uint cup_id
	{
		[Token(Token = "0x6008463")]
		[Address(RVA = "0x33E7D78", Offset = "0x33E7D78", VA = "0x33E7D78")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008464")]
		[Address(RVA = "0x33E7D80", Offset = "0x33E7D80", VA = "0x33E7D80")]
		set
		{
		}
	}

	[Token(Token = "0x600845C")]
	[Address(RVA = "0x33E7D30", Offset = "0x33E7D30", VA = "0x33E7D30")]
	public ApproveCupTeamInvitationReq()
	{
	}
}
