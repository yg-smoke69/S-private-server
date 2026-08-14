using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D56")]
public class RoomJoinNtf
{
	[Token(Token = "0x400B955")]
	[FieldOffset(Offset = "0x8")]
	private List<RoomPlayerInfo> _003Cjoin_player_list_003Ek__BackingField;

	[Token(Token = "0x400B956")]
	[FieldOffset(Offset = "0xC")]
	private RoomInfo _003Croom_info_003Ek__BackingField;

	[Token(Token = "0x17000C95")]
	public List<RoomPlayerInfo> join_player_list
	{
		[Token(Token = "0x60088B8")]
		[Address(RVA = "0x435E550", Offset = "0x435E550", VA = "0x435E550")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088B9")]
		[Address(RVA = "0x435E548", Offset = "0x435E548", VA = "0x435E548")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C96")]
	public RoomInfo room_info
	{
		[Token(Token = "0x60088BA")]
		[Address(RVA = "0x435E558", Offset = "0x435E558", VA = "0x435E558")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088BB")]
		[Address(RVA = "0x435E560", Offset = "0x435E560", VA = "0x435E560")]
		set
		{
		}
	}

	[Token(Token = "0x60088B7")]
	[Address(RVA = "0x435E4BC", Offset = "0x435E4BC", VA = "0x435E4BC")]
	public RoomJoinNtf()
	{
	}
}
