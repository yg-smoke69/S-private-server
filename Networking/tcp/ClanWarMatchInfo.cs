using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DA5")]
public class ClanWarMatchInfo
{
	[Token(Token = "0x400BBE3")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cteam_id_003Ek__BackingField;

	[Token(Token = "0x400BBE4")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Ccaptain_id_003Ek__BackingField;

	[Token(Token = "0x400BBE5")]
	[FieldOffset(Offset = "0x18")]
	private ulong[] _003Cmember_ids_003Ek__BackingField;

	[Token(Token = "0x400BBE6")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cmin_player_003Ek__BackingField;

	[Token(Token = "0x400BBE7")]
	[FieldOffset(Offset = "0x20")]
	private List<ClanWarMemberMatchInfo> _003Cmembers_match_info_003Ek__BackingField;

	[Token(Token = "0x400BBE8")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Cclan_war_mmr_003Ek__BackingField;

	[Token(Token = "0x17000E8F")]
	public ulong team_id
	{
		[Token(Token = "0x6008CEF")]
		[Address(RVA = "0x33E8660", Offset = "0x33E8660", VA = "0x33E8660")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008CF0")]
		[Address(RVA = "0x33E8668", Offset = "0x33E8668", VA = "0x33E8668")]
		set
		{
		}
	}

	[Token(Token = "0x17000E90")]
	public ulong captain_id
	{
		[Token(Token = "0x6008CF1")]
		[Address(RVA = "0x33E8678", Offset = "0x33E8678", VA = "0x33E8678")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008CF2")]
		[Address(RVA = "0x33E8680", Offset = "0x33E8680", VA = "0x33E8680")]
		set
		{
		}
	}

	[Token(Token = "0x17000E91")]
	public ulong[] member_ids
	{
		[Token(Token = "0x6008CF3")]
		[Address(RVA = "0x33E8690", Offset = "0x33E8690", VA = "0x33E8690")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008CF4")]
		[Address(RVA = "0x33E8698", Offset = "0x33E8698", VA = "0x33E8698")]
		set
		{
		}
	}

	[Token(Token = "0x17000E92")]
	public uint min_player
	{
		[Token(Token = "0x6008CF5")]
		[Address(RVA = "0x33E86A0", Offset = "0x33E86A0", VA = "0x33E86A0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008CF6")]
		[Address(RVA = "0x33E86A8", Offset = "0x33E86A8", VA = "0x33E86A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000E93")]
	public List<ClanWarMemberMatchInfo> members_match_info
	{
		[Token(Token = "0x6008CF7")]
		[Address(RVA = "0x33E86B0", Offset = "0x33E86B0", VA = "0x33E86B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008CF8")]
		[Address(RVA = "0x33E8658", Offset = "0x33E8658", VA = "0x33E8658")]
		private set
		{
		}
	}

	[Token(Token = "0x17000E94")]
	public uint clan_war_mmr
	{
		[Token(Token = "0x6008CF9")]
		[Address(RVA = "0x33E86B8", Offset = "0x33E86B8", VA = "0x33E86B8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008CFA")]
		[Address(RVA = "0x33E86C0", Offset = "0x33E86C0", VA = "0x33E86C0")]
		set
		{
		}
	}

	[Token(Token = "0x6008CEE")]
	[Address(RVA = "0x33E85CC", Offset = "0x33E85CC", VA = "0x33E85CC")]
	public ClanWarMatchInfo()
	{
	}
}
