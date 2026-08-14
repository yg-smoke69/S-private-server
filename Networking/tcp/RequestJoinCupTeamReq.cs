using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CA6")]
public class RequestJoinCupTeamReq
{
	[Token(Token = "0x400B566")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Capplicant_id_003Ek__BackingField;

	[Token(Token = "0x400B567")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Ccup_type_003Ek__BackingField;

	[Token(Token = "0x400B568")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Ccup_id_003Ek__BackingField;

	[Token(Token = "0x400B569")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Capplicant_tier_003Ek__BackingField;

	[Token(Token = "0x400B56A")]
	[FieldOffset(Offset = "0x1C")]
	private CupGroupMemberInfo _003Cgroup_member_info_003Ek__BackingField;

	[Token(Token = "0x17000A8E")]
	public ulong applicant_id
	{
		[Token(Token = "0x600842F")]
		[Address(RVA = "0x435D5C0", Offset = "0x435D5C0", VA = "0x435D5C0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008430")]
		[Address(RVA = "0x435D5C8", Offset = "0x435D5C8", VA = "0x435D5C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000A8F")]
	public uint cup_type
	{
		[Token(Token = "0x6008431")]
		[Address(RVA = "0x435D5D8", Offset = "0x435D5D8", VA = "0x435D5D8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008432")]
		[Address(RVA = "0x435D5E0", Offset = "0x435D5E0", VA = "0x435D5E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A90")]
	public uint cup_id
	{
		[Token(Token = "0x6008433")]
		[Address(RVA = "0x435D5E8", Offset = "0x435D5E8", VA = "0x435D5E8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008434")]
		[Address(RVA = "0x435D5F0", Offset = "0x435D5F0", VA = "0x435D5F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A91")]
	public uint applicant_tier
	{
		[Token(Token = "0x6008435")]
		[Address(RVA = "0x435D5F8", Offset = "0x435D5F8", VA = "0x435D5F8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008436")]
		[Address(RVA = "0x435D600", Offset = "0x435D600", VA = "0x435D600")]
		set
		{
		}
	}

	[Token(Token = "0x17000A92")]
	public CupGroupMemberInfo group_member_info
	{
		[Token(Token = "0x6008437")]
		[Address(RVA = "0x435D608", Offset = "0x435D608", VA = "0x435D608")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008438")]
		[Address(RVA = "0x435D610", Offset = "0x435D610", VA = "0x435D610")]
		set
		{
		}
	}

	[Token(Token = "0x600842E")]
	[Address(RVA = "0x435D5B8", Offset = "0x435D5B8", VA = "0x435D5B8")]
	public RequestJoinCupTeamReq()
	{
	}
}
