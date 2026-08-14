using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D52")]
public class RoomSpectateReq
{
	[Token(Token = "0x400B945")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B946")]
	[FieldOffset(Offset = "0x10")]
	private string _003Ccode_003Ek__BackingField;

	[Token(Token = "0x400B947")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B948")]
	[FieldOffset(Offset = "0x20")]
	private bool _003Cis_solo_003Ek__BackingField;

	[Token(Token = "0x400B949")]
	[FieldOffset(Offset = "0x24")]
	private List<JoinRoomPlayerInfo> _003Cplayers_003Ek__BackingField;

	[Token(Token = "0x400B94A")]
	[FieldOffset(Offset = "0x28")]
	private List<AccountIDCPingInfo> _003Cping_list_003Ek__BackingField;

	[Token(Token = "0x400B94B")]
	[FieldOffset(Offset = "0x2C")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B94C")]
	[FieldOffset(Offset = "0x30")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x17000C85")]
	public ulong room_id
	{
		[Token(Token = "0x6008894")]
		[Address(RVA = "0x435EE10", Offset = "0x435EE10", VA = "0x435EE10")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008895")]
		[Address(RVA = "0x435EE18", Offset = "0x435EE18", VA = "0x435EE18")]
		set
		{
		}
	}

	[Token(Token = "0x17000C86")]
	public string code
	{
		[Token(Token = "0x6008896")]
		[Address(RVA = "0x435EE28", Offset = "0x435EE28", VA = "0x435EE28")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008897")]
		[Address(RVA = "0x435EDF8", Offset = "0x435EDF8", VA = "0x435EDF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000C87")]
	public ulong group_id
	{
		[Token(Token = "0x6008898")]
		[Address(RVA = "0x435EE30", Offset = "0x435EE30", VA = "0x435EE30")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008899")]
		[Address(RVA = "0x435EE38", Offset = "0x435EE38", VA = "0x435EE38")]
		set
		{
		}
	}

	[Token(Token = "0x17000C88")]
	public bool is_solo
	{
		[Token(Token = "0x600889A")]
		[Address(RVA = "0x435EE48", Offset = "0x435EE48", VA = "0x435EE48")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600889B")]
		[Address(RVA = "0x435EE50", Offset = "0x435EE50", VA = "0x435EE50")]
		set
		{
		}
	}

	[Token(Token = "0x17000C89")]
	public List<JoinRoomPlayerInfo> players
	{
		[Token(Token = "0x600889C")]
		[Address(RVA = "0x435EE58", Offset = "0x435EE58", VA = "0x435EE58")]
		get
		{
			return null;
		}
		[Token(Token = "0x600889D")]
		[Address(RVA = "0x435EE00", Offset = "0x435EE00", VA = "0x435EE00")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C8A")]
	public List<AccountIDCPingInfo> ping_list
	{
		[Token(Token = "0x600889E")]
		[Address(RVA = "0x435EE60", Offset = "0x435EE60", VA = "0x435EE60")]
		get
		{
			return null;
		}
		[Token(Token = "0x600889F")]
		[Address(RVA = "0x435EE08", Offset = "0x435EE08", VA = "0x435EE08")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C8B")]
	public uint[] available_maps
	{
		[Token(Token = "0x60088A0")]
		[Address(RVA = "0x435EE68", Offset = "0x435EE68", VA = "0x435EE68")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088A1")]
		[Address(RVA = "0x435EE70", Offset = "0x435EE70", VA = "0x435EE70")]
		set
		{
		}
	}

	[Token(Token = "0x17000C8C")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x60088A2")]
		[Address(RVA = "0x435EE78", Offset = "0x435EE78", VA = "0x435EE78")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x60088A3")]
		[Address(RVA = "0x435EE80", Offset = "0x435EE80", VA = "0x435EE80")]
		set
		{
		}
	}

	[Token(Token = "0x6008893")]
	[Address(RVA = "0x435ECF0", Offset = "0x435ECF0", VA = "0x435ECF0")]
	public RoomSpectateReq()
	{
	}
}
