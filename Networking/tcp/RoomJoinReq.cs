using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D51")]
public class RoomJoinReq
{
	[Token(Token = "0x400B937")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B938")]
	[FieldOffset(Offset = "0x10")]
	private string _003Ccode_003Ek__BackingField;

	[Token(Token = "0x400B939")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B93A")]
	[FieldOffset(Offset = "0x20")]
	private bool _003Cis_solo_003Ek__BackingField;

	[Token(Token = "0x400B93B")]
	[FieldOffset(Offset = "0x24")]
	private List<JoinRoomPlayerInfo> _003Cplayers_003Ek__BackingField;

	[Token(Token = "0x400B93C")]
	[FieldOffset(Offset = "0x28")]
	private string _003Cgroup_name_003Ek__BackingField;

	[Token(Token = "0x400B93D")]
	[FieldOffset(Offset = "0x30")]
	private ulong _003Cinviter_account_id_003Ek__BackingField;

	[Token(Token = "0x400B93E")]
	[FieldOffset(Offset = "0x38")]
	private List<AccountIDCPingInfo> _003Cping_list_003Ek__BackingField;

	[Token(Token = "0x400B93F")]
	[FieldOffset(Offset = "0x3C")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B940")]
	[FieldOffset(Offset = "0x40")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x400B941")]
	[FieldOffset(Offset = "0x44")]
	private string _003Cgroup_abbr_name_003Ek__BackingField;

	[Token(Token = "0x400B942")]
	[FieldOffset(Offset = "0x48")]
	private int[] _003Cfilters_003Ek__BackingField;

	[Token(Token = "0x400B943")]
	[FieldOffset(Offset = "0x4C")]
	private uint _003Cjoin_type_003Ek__BackingField;

	[Token(Token = "0x400B944")]
	[FieldOffset(Offset = "0x50")]
	private uint _003Cjoin_scene_003Ek__BackingField;

	[Token(Token = "0x17000C77")]
	public ulong room_id
	{
		[Token(Token = "0x6008877")]
		[Address(RVA = "0x435E6C4", Offset = "0x435E6C4", VA = "0x435E6C4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008878")]
		[Address(RVA = "0x435E6CC", Offset = "0x435E6CC", VA = "0x435E6CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000C78")]
	public string code
	{
		[Token(Token = "0x6008879")]
		[Address(RVA = "0x435E6DC", Offset = "0x435E6DC", VA = "0x435E6DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600887A")]
		[Address(RVA = "0x435E69C", Offset = "0x435E69C", VA = "0x435E69C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C79")]
	public ulong group_id
	{
		[Token(Token = "0x600887B")]
		[Address(RVA = "0x435E6E4", Offset = "0x435E6E4", VA = "0x435E6E4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600887C")]
		[Address(RVA = "0x435E6EC", Offset = "0x435E6EC", VA = "0x435E6EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000C7A")]
	public bool is_solo
	{
		[Token(Token = "0x600887D")]
		[Address(RVA = "0x435E6FC", Offset = "0x435E6FC", VA = "0x435E6FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600887E")]
		[Address(RVA = "0x435E704", Offset = "0x435E704", VA = "0x435E704")]
		set
		{
		}
	}

	[Token(Token = "0x17000C7B")]
	public List<JoinRoomPlayerInfo> players
	{
		[Token(Token = "0x600887F")]
		[Address(RVA = "0x435E70C", Offset = "0x435E70C", VA = "0x435E70C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008880")]
		[Address(RVA = "0x435E6A4", Offset = "0x435E6A4", VA = "0x435E6A4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C7C")]
	public string group_name
	{
		[Token(Token = "0x6008881")]
		[Address(RVA = "0x435E714", Offset = "0x435E714", VA = "0x435E714")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008882")]
		[Address(RVA = "0x435E6AC", Offset = "0x435E6AC", VA = "0x435E6AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000C7D")]
	public ulong inviter_account_id
	{
		[Token(Token = "0x6008883")]
		[Address(RVA = "0x435E71C", Offset = "0x435E71C", VA = "0x435E71C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008884")]
		[Address(RVA = "0x435E724", Offset = "0x435E724", VA = "0x435E724")]
		set
		{
		}
	}

	[Token(Token = "0x17000C7E")]
	public List<AccountIDCPingInfo> ping_list
	{
		[Token(Token = "0x6008885")]
		[Address(RVA = "0x435E734", Offset = "0x435E734", VA = "0x435E734")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008886")]
		[Address(RVA = "0x435E6B4", Offset = "0x435E6B4", VA = "0x435E6B4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C7F")]
	public uint[] available_maps
	{
		[Token(Token = "0x6008887")]
		[Address(RVA = "0x435E73C", Offset = "0x435E73C", VA = "0x435E73C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008888")]
		[Address(RVA = "0x435E744", Offset = "0x435E744", VA = "0x435E744")]
		set
		{
		}
	}

	[Token(Token = "0x17000C80")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x6008889")]
		[Address(RVA = "0x435E74C", Offset = "0x435E74C", VA = "0x435E74C")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x600888A")]
		[Address(RVA = "0x435E754", Offset = "0x435E754", VA = "0x435E754")]
		set
		{
		}
	}

	[Token(Token = "0x17000C81")]
	public string group_abbr_name
	{
		[Token(Token = "0x600888B")]
		[Address(RVA = "0x435E75C", Offset = "0x435E75C", VA = "0x435E75C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600888C")]
		[Address(RVA = "0x435E6BC", Offset = "0x435E6BC", VA = "0x435E6BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000C82")]
	public int[] filters
	{
		[Token(Token = "0x600888D")]
		[Address(RVA = "0x435E764", Offset = "0x435E764", VA = "0x435E764")]
		get
		{
			return null;
		}
		[Token(Token = "0x600888E")]
		[Address(RVA = "0x435E76C", Offset = "0x435E76C", VA = "0x435E76C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C83")]
	public uint join_type
	{
		[Token(Token = "0x600888F")]
		[Address(RVA = "0x435E774", Offset = "0x435E774", VA = "0x435E774")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008890")]
		[Address(RVA = "0x435E77C", Offset = "0x435E77C", VA = "0x435E77C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C84")]
	public uint join_scene
	{
		[Token(Token = "0x6008891")]
		[Address(RVA = "0x435E784", Offset = "0x435E784", VA = "0x435E784")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008892")]
		[Address(RVA = "0x435E78C", Offset = "0x435E78C", VA = "0x435E78C")]
		set
		{
		}
	}

	[Token(Token = "0x6008876")]
	[Address(RVA = "0x435E568", Offset = "0x435E568", VA = "0x435E568")]
	public RoomJoinReq()
	{
	}
}
