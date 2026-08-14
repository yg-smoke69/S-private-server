using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D64")]
public class RoomSetReadyNtf
{
	[Token(Token = "0x400B98E")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B98F")]
	[FieldOffset(Offset = "0x10")]
	private List<RoomPlayerInfo> _003Cplayers_003Ek__BackingField;

	[Token(Token = "0x17000CCE")]
	public ulong room_id
	{
		[Token(Token = "0x6008938")]
		[Address(RVA = "0x435ECA8", Offset = "0x435ECA8", VA = "0x435ECA8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008939")]
		[Address(RVA = "0x435ECB0", Offset = "0x435ECB0", VA = "0x435ECB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000CCF")]
	public List<RoomPlayerInfo> players
	{
		[Token(Token = "0x600893A")]
		[Address(RVA = "0x435ECC0", Offset = "0x435ECC0", VA = "0x435ECC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600893B")]
		[Address(RVA = "0x435ECA0", Offset = "0x435ECA0", VA = "0x435ECA0")]
		private set
		{
		}
	}

	[Token(Token = "0x6008937")]
	[Address(RVA = "0x435EC14", Offset = "0x435EC14", VA = "0x435EC14")]
	public RoomSetReadyNtf()
	{
	}
}
