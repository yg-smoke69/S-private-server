using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DA6")]
public class ClanWarMemberMatchInfo
{
	[Token(Token = "0x400BBE9")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cmember_id_003Ek__BackingField;

	[Token(Token = "0x400BBEA")]
	[FieldOffset(Offset = "0x10")]
	private string _003Csignature_md5_003Ek__BackingField;

	[Token(Token = "0x400BBEB")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cusing_version_003Ek__BackingField;

	[Token(Token = "0x400BBEC")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Csystem_platform_003Ek__BackingField;

	[Token(Token = "0x400BBED")]
	[FieldOffset(Offset = "0x1C")]
	private MatchClientInfo _003Cclient_info_003Ek__BackingField;

	[Token(Token = "0x17000E95")]
	public ulong member_id
	{
		[Token(Token = "0x6008CFC")]
		[Address(RVA = "0x33E8770", Offset = "0x33E8770", VA = "0x33E8770")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008CFD")]
		[Address(RVA = "0x33E8778", Offset = "0x33E8778", VA = "0x33E8778")]
		set
		{
		}
	}

	[Token(Token = "0x17000E96")]
	public string signature_md5
	{
		[Token(Token = "0x6008CFE")]
		[Address(RVA = "0x33E8788", Offset = "0x33E8788", VA = "0x33E8788")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008CFF")]
		[Address(RVA = "0x33E8768", Offset = "0x33E8768", VA = "0x33E8768")]
		set
		{
		}
	}

	[Token(Token = "0x17000E97")]
	public uint using_version
	{
		[Token(Token = "0x6008D00")]
		[Address(RVA = "0x33E8790", Offset = "0x33E8790", VA = "0x33E8790")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D01")]
		[Address(RVA = "0x33E8798", Offset = "0x33E8798", VA = "0x33E8798")]
		set
		{
		}
	}

	[Token(Token = "0x17000E98")]
	public uint system_platform
	{
		[Token(Token = "0x6008D02")]
		[Address(RVA = "0x33E87A0", Offset = "0x33E87A0", VA = "0x33E87A0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D03")]
		[Address(RVA = "0x33E87A8", Offset = "0x33E87A8", VA = "0x33E87A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000E99")]
	public MatchClientInfo client_info
	{
		[Token(Token = "0x6008D04")]
		[Address(RVA = "0x33E87B0", Offset = "0x33E87B0", VA = "0x33E87B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008D05")]
		[Address(RVA = "0x33E87B8", Offset = "0x33E87B8", VA = "0x33E87B8")]
		set
		{
		}
	}

	[Token(Token = "0x6008CFB")]
	[Address(RVA = "0x33E86C8", Offset = "0x33E86C8", VA = "0x33E86C8")]
	public ClanWarMemberMatchInfo()
	{
	}
}
