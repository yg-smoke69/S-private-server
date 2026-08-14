using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D4F")]
public class RoomListRes
{
	[Token(Token = "0x400B915")]
	[FieldOffset(Offset = "0x8")]
	private List<RoomBasicInfo> _003Croom_list_003Ek__BackingField;

	[Token(Token = "0x17000C55")]
	public List<RoomBasicInfo> room_list
	{
		[Token(Token = "0x6008831")]
		[Address(RVA = "0x435E9A4", Offset = "0x435E9A4", VA = "0x435E9A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008832")]
		[Address(RVA = "0x435E99C", Offset = "0x435E99C", VA = "0x435E99C")]
		private set
		{
		}
	}

	[Token(Token = "0x6008830")]
	[Address(RVA = "0x435E910", Offset = "0x435E910", VA = "0x435E910")]
	public RoomListRes()
	{
	}
}
