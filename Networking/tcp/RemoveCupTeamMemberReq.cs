using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CA8")]
public class RemoveCupTeamMemberReq
{
	[Token(Token = "0x400B56F")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Ccup_team_id_003Ek__BackingField;

	[Token(Token = "0x400B570")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cremovee_id_003Ek__BackingField;

	[Token(Token = "0x400B571")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Ccup_type_003Ek__BackingField;

	[Token(Token = "0x400B572")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Ccup_id_003Ek__BackingField;

	[Token(Token = "0x17000A97")]
	public ulong cup_team_id
	{
		[Token(Token = "0x6008443")]
		[Address(RVA = "0x435D438", Offset = "0x435D438", VA = "0x435D438")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008444")]
		[Address(RVA = "0x435D440", Offset = "0x435D440", VA = "0x435D440")]
		set
		{
		}
	}

	[Token(Token = "0x17000A98")]
	public ulong removee_id
	{
		[Token(Token = "0x6008445")]
		[Address(RVA = "0x435D450", Offset = "0x435D450", VA = "0x435D450")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008446")]
		[Address(RVA = "0x435D458", Offset = "0x435D458", VA = "0x435D458")]
		set
		{
		}
	}

	[Token(Token = "0x17000A99")]
	public uint cup_type
	{
		[Token(Token = "0x6008447")]
		[Address(RVA = "0x435D468", Offset = "0x435D468", VA = "0x435D468")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008448")]
		[Address(RVA = "0x435D470", Offset = "0x435D470", VA = "0x435D470")]
		set
		{
		}
	}

	[Token(Token = "0x17000A9A")]
	public uint cup_id
	{
		[Token(Token = "0x6008449")]
		[Address(RVA = "0x435D478", Offset = "0x435D478", VA = "0x435D478")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600844A")]
		[Address(RVA = "0x435D480", Offset = "0x435D480", VA = "0x435D480")]
		set
		{
		}
	}

	[Token(Token = "0x6008442")]
	[Address(RVA = "0x435D430", Offset = "0x435D430", VA = "0x435D430")]
	public RemoveCupTeamMemberReq()
	{
	}
}
