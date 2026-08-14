using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CD1")]
public class GroupInviteNtf
{
	[Token(Token = "0x400B686")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B687")]
	[FieldOffset(Offset = "0x10")]
	private GroupMemberInfo _003Cinviter_info_003Ek__BackingField;

	[Token(Token = "0x400B688")]
	[FieldOffset(Offset = "0x14")]
	private uint[] _003Cmap_ids_003Ek__BackingField;

	[Token(Token = "0x400B689")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B68A")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x400B68B")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cmatch_mode_003Ek__BackingField;

	[Token(Token = "0x400B68C")]
	[FieldOffset(Offset = "0x24")]
	private string _003Csecret_code_003Ek__BackingField;

	[Token(Token = "0x17000AED")]
	public ulong group_id
	{
		[Token(Token = "0x6008506")]
		[Address(RVA = "0x33EA9A8", Offset = "0x33EA9A8", VA = "0x33EA9A8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008507")]
		[Address(RVA = "0x33EA9B0", Offset = "0x33EA9B0", VA = "0x33EA9B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000AEE")]
	public GroupMemberInfo inviter_info
	{
		[Token(Token = "0x6008508")]
		[Address(RVA = "0x33EA9C0", Offset = "0x33EA9C0", VA = "0x33EA9C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008509")]
		[Address(RVA = "0x33EA9C8", Offset = "0x33EA9C8", VA = "0x33EA9C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AEF")]
	public uint[] map_ids
	{
		[Token(Token = "0x600850A")]
		[Address(RVA = "0x33EA9D0", Offset = "0x33EA9D0", VA = "0x33EA9D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600850B")]
		[Address(RVA = "0x33EA9D8", Offset = "0x33EA9D8", VA = "0x33EA9D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AF0")]
	public uint game_mode
	{
		[Token(Token = "0x600850C")]
		[Address(RVA = "0x33EA9E0", Offset = "0x33EA9E0", VA = "0x33EA9E0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600850D")]
		[Address(RVA = "0x33EA9E8", Offset = "0x33EA9E8", VA = "0x33EA9E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AF1")]
	public uint group_mode
	{
		[Token(Token = "0x600850E")]
		[Address(RVA = "0x33EA9F0", Offset = "0x33EA9F0", VA = "0x33EA9F0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600850F")]
		[Address(RVA = "0x33EA9F8", Offset = "0x33EA9F8", VA = "0x33EA9F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AF2")]
	public uint match_mode
	{
		[Token(Token = "0x6008510")]
		[Address(RVA = "0x33EAA00", Offset = "0x33EAA00", VA = "0x33EAA00")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008511")]
		[Address(RVA = "0x33EAA08", Offset = "0x33EAA08", VA = "0x33EAA08")]
		set
		{
		}
	}

	[Token(Token = "0x17000AF3")]
	public string secret_code
	{
		[Token(Token = "0x6008512")]
		[Address(RVA = "0x33EAA10", Offset = "0x33EAA10", VA = "0x33EAA10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008513")]
		[Address(RVA = "0x33EA9A0", Offset = "0x33EA9A0", VA = "0x33EA9A0")]
		set
		{
		}
	}

	[Token(Token = "0x6008505")]
	[Address(RVA = "0x33EA900", Offset = "0x33EA900", VA = "0x33EA900")]
	public GroupInviteNtf()
	{
	}
}
