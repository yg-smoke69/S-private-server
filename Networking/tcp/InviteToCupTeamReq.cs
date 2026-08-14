using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CA9")]
public class InviteToCupTeamReq
{
	[Token(Token = "0x400B573")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cinviter_id_003Ek__BackingField;

	[Token(Token = "0x400B574")]
	[FieldOffset(Offset = "0x10")]
	private string _003Cinviter_name_003Ek__BackingField;

	[Token(Token = "0x400B575")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Ccup_team_id_003Ek__BackingField;

	[Token(Token = "0x400B576")]
	[FieldOffset(Offset = "0x20")]
	private string _003Ccup_team_name_003Ek__BackingField;

	[Token(Token = "0x400B577")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Ccup_type_003Ek__BackingField;

	[Token(Token = "0x400B578")]
	[FieldOffset(Offset = "0x28")]
	private uint _003Ccup_id_003Ek__BackingField;

	[Token(Token = "0x400B579")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003Cteam_tier_003Ek__BackingField;

	[Token(Token = "0x400B57A")]
	[FieldOffset(Offset = "0x30")]
	private CupGroupMemberInfo _003Cgroup_member_info_003Ek__BackingField;

	[Token(Token = "0x17000A9B")]
	public ulong inviter_id
	{
		[Token(Token = "0x600844C")]
		[Address(RVA = "0x33EBE6C", Offset = "0x33EBE6C", VA = "0x33EBE6C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600844D")]
		[Address(RVA = "0x33EBE74", Offset = "0x33EBE74", VA = "0x33EBE74")]
		set
		{
		}
	}

	[Token(Token = "0x17000A9C")]
	public string inviter_name
	{
		[Token(Token = "0x600844E")]
		[Address(RVA = "0x33EBE84", Offset = "0x33EBE84", VA = "0x33EBE84")]
		get
		{
			return null;
		}
		[Token(Token = "0x600844F")]
		[Address(RVA = "0x33EBE5C", Offset = "0x33EBE5C", VA = "0x33EBE5C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A9D")]
	public ulong cup_team_id
	{
		[Token(Token = "0x6008450")]
		[Address(RVA = "0x33EBE8C", Offset = "0x33EBE8C", VA = "0x33EBE8C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008451")]
		[Address(RVA = "0x33EBE94", Offset = "0x33EBE94", VA = "0x33EBE94")]
		set
		{
		}
	}

	[Token(Token = "0x17000A9E")]
	public string cup_team_name
	{
		[Token(Token = "0x6008452")]
		[Address(RVA = "0x33EBEA4", Offset = "0x33EBEA4", VA = "0x33EBEA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008453")]
		[Address(RVA = "0x33EBE64", Offset = "0x33EBE64", VA = "0x33EBE64")]
		set
		{
		}
	}

	[Token(Token = "0x17000A9F")]
	public uint cup_type
	{
		[Token(Token = "0x6008454")]
		[Address(RVA = "0x33EBEAC", Offset = "0x33EBEAC", VA = "0x33EBEAC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008455")]
		[Address(RVA = "0x33EBEB4", Offset = "0x33EBEB4", VA = "0x33EBEB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000AA0")]
	public uint cup_id
	{
		[Token(Token = "0x6008456")]
		[Address(RVA = "0x33EBEBC", Offset = "0x33EBEBC", VA = "0x33EBEBC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008457")]
		[Address(RVA = "0x33EBEC4", Offset = "0x33EBEC4", VA = "0x33EBEC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000AA1")]
	public uint team_tier
	{
		[Token(Token = "0x6008458")]
		[Address(RVA = "0x33EBECC", Offset = "0x33EBECC", VA = "0x33EBECC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008459")]
		[Address(RVA = "0x33EBED4", Offset = "0x33EBED4", VA = "0x33EBED4")]
		set
		{
		}
	}

	[Token(Token = "0x17000AA2")]
	public CupGroupMemberInfo group_member_info
	{
		[Token(Token = "0x600845A")]
		[Address(RVA = "0x33EBEDC", Offset = "0x33EBEDC", VA = "0x33EBEDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600845B")]
		[Address(RVA = "0x33EBEE4", Offset = "0x33EBEE4", VA = "0x33EBEE4")]
		set
		{
		}
	}

	[Token(Token = "0x600844B")]
	[Address(RVA = "0x33EBDB0", Offset = "0x33EBDB0", VA = "0x33EBDB0")]
	public InviteToCupTeamReq()
	{
	}
}
