using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D4E")]
public class RoomListReq
{
	[Token(Token = "0x400B911")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B912")]
	[FieldOffset(Offset = "0x10")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x400B913")]
	[FieldOffset(Offset = "0x14")]
	private List<EMatch.GameMode> _003Cgame_modes_003Ek__BackingField;

	[Token(Token = "0x400B914")]
	[FieldOffset(Offset = "0x18")]
	private ERoom.TabType _003Croom_tab_type_003Ek__BackingField;

	[Token(Token = "0x17000C51")]
	public ulong room_id
	{
		[Token(Token = "0x6008828")]
		[Address(RVA = "0x435E8D0", Offset = "0x435E8D0", VA = "0x435E8D0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008829")]
		[Address(RVA = "0x435E8D8", Offset = "0x435E8D8", VA = "0x435E8D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000C52")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x600882A")]
		[Address(RVA = "0x435E8E8", Offset = "0x435E8E8", VA = "0x435E8E8")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x600882B")]
		[Address(RVA = "0x435E8F0", Offset = "0x435E8F0", VA = "0x435E8F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C53")]
	public List<EMatch.GameMode> game_modes
	{
		[Token(Token = "0x600882C")]
		[Address(RVA = "0x435E8F8", Offset = "0x435E8F8", VA = "0x435E8F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600882D")]
		[Address(RVA = "0x435E8C8", Offset = "0x435E8C8", VA = "0x435E8C8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C54")]
	public ERoom.TabType room_tab_type
	{
		[Token(Token = "0x600882E")]
		[Address(RVA = "0x435E900", Offset = "0x435E900", VA = "0x435E900")]
		get
		{
			return default(ERoom.TabType);
		}
		[Token(Token = "0x600882F")]
		[Address(RVA = "0x435E908", Offset = "0x435E908", VA = "0x435E908")]
		set
		{
		}
	}

	[Token(Token = "0x6008827")]
	[Address(RVA = "0x435E83C", Offset = "0x435E83C", VA = "0x435E83C")]
	public RoomListReq()
	{
	}
}
