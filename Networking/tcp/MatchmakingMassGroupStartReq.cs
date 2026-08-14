using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D28")]
public class MatchmakingMassGroupStartReq
{
	[Token(Token = "0x400B837")]
	[FieldOffset(Offset = "0x8")]
	private uint[] _003Cmap_ids_003Ek__BackingField;

	[Token(Token = "0x400B838")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B839")]
	[FieldOffset(Offset = "0x18")]
	private EMatch.MatchMode _003Cmatch_mode_003Ek__BackingField;

	[Token(Token = "0x400B83A")]
	[FieldOffset(Offset = "0x1C")]
	private EMatch.GroupMode _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x400B83B")]
	[FieldOffset(Offset = "0x20")]
	private EMatch.GameMode _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B83C")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Cdifficulty_003Ek__BackingField;

	[Token(Token = "0x400B83D")]
	[FieldOffset(Offset = "0x28")]
	private ulong[] _003Cmember_ids_003Ek__BackingField;

	[Token(Token = "0x400B83E")]
	[FieldOffset(Offset = "0x2C")]
	private List<AccountIDCPingInfo> _003Cping_list_003Ek__BackingField;

	[Token(Token = "0x400B83F")]
	[FieldOffset(Offset = "0x30")]
	private uint _003Csystem_platform_003Ek__BackingField;

	[Token(Token = "0x400B840")]
	[FieldOffset(Offset = "0x34")]
	private MatchClientInfo _003Cclient_info_003Ek__BackingField;

	[Token(Token = "0x17000C24")]
	public uint[] map_ids
	{
		[Token(Token = "0x60087BB")]
		[Address(RVA = "0x435C20C", Offset = "0x435C20C", VA = "0x435C20C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087BC")]
		[Address(RVA = "0x435C214", Offset = "0x435C214", VA = "0x435C214")]
		set
		{
		}
	}

	[Token(Token = "0x17000C25")]
	public ulong group_id
	{
		[Token(Token = "0x60087BD")]
		[Address(RVA = "0x435C21C", Offset = "0x435C21C", VA = "0x435C21C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60087BE")]
		[Address(RVA = "0x435C224", Offset = "0x435C224", VA = "0x435C224")]
		set
		{
		}
	}

	[Token(Token = "0x17000C26")]
	public EMatch.MatchMode match_mode
	{
		[Token(Token = "0x60087BF")]
		[Address(RVA = "0x435C234", Offset = "0x435C234", VA = "0x435C234")]
		get
		{
			return default(EMatch.MatchMode);
		}
		[Token(Token = "0x60087C0")]
		[Address(RVA = "0x435C23C", Offset = "0x435C23C", VA = "0x435C23C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C27")]
	public EMatch.GroupMode group_mode
	{
		[Token(Token = "0x60087C1")]
		[Address(RVA = "0x435C244", Offset = "0x435C244", VA = "0x435C244")]
		get
		{
			return default(EMatch.GroupMode);
		}
		[Token(Token = "0x60087C2")]
		[Address(RVA = "0x435C24C", Offset = "0x435C24C", VA = "0x435C24C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C28")]
	public EMatch.GameMode game_mode
	{
		[Token(Token = "0x60087C3")]
		[Address(RVA = "0x435C254", Offset = "0x435C254", VA = "0x435C254")]
		get
		{
			return default(EMatch.GameMode);
		}
		[Token(Token = "0x60087C4")]
		[Address(RVA = "0x435C25C", Offset = "0x435C25C", VA = "0x435C25C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C29")]
	public uint difficulty
	{
		[Token(Token = "0x60087C5")]
		[Address(RVA = "0x435C264", Offset = "0x435C264", VA = "0x435C264")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087C6")]
		[Address(RVA = "0x435C26C", Offset = "0x435C26C", VA = "0x435C26C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C2A")]
	public ulong[] member_ids
	{
		[Token(Token = "0x60087C7")]
		[Address(RVA = "0x435C274", Offset = "0x435C274", VA = "0x435C274")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087C8")]
		[Address(RVA = "0x435C27C", Offset = "0x435C27C", VA = "0x435C27C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C2B")]
	public List<AccountIDCPingInfo> ping_list
	{
		[Token(Token = "0x60087C9")]
		[Address(RVA = "0x435C284", Offset = "0x435C284", VA = "0x435C284")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087CA")]
		[Address(RVA = "0x435C204", Offset = "0x435C204", VA = "0x435C204")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C2C")]
	public uint system_platform
	{
		[Token(Token = "0x60087CB")]
		[Address(RVA = "0x435C28C", Offset = "0x435C28C", VA = "0x435C28C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087CC")]
		[Address(RVA = "0x435C294", Offset = "0x435C294", VA = "0x435C294")]
		set
		{
		}
	}

	[Token(Token = "0x17000C2D")]
	public MatchClientInfo client_info
	{
		[Token(Token = "0x60087CD")]
		[Address(RVA = "0x435C29C", Offset = "0x435C29C", VA = "0x435C29C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087CE")]
		[Address(RVA = "0x435C2A4", Offset = "0x435C2A4", VA = "0x435C2A4")]
		set
		{
		}
	}

	[Token(Token = "0x60087BA")]
	[Address(RVA = "0x435C178", Offset = "0x435C178", VA = "0x435C178")]
	public MatchmakingMassGroupStartReq()
	{
	}
}
