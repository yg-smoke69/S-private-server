using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E1A")]
public class RoomBlockManager : SingletonModule<RoomBlockManager>
{
	[Token(Token = "0x4011A54")]
	private const string BLOCKED_ROOM_ID = "BLOCKED_ROOM_ID";

	[Token(Token = "0x4011A55")]
	private const string BLOCKED_ROOM_TIME = "BLOCKED_ROOM_TIME";

	[Token(Token = "0x4011A56")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<ulong, Dictionary<ulong, ulong>> m_AccountIdToRoomId;

	[Token(Token = "0x60134CB")]
	[Address(RVA = "0x240DE44", Offset = "0x240DE44", VA = "0x240DE44")]
	public RoomBlockManager()
	{
	}

	[Token(Token = "0x60134CC")]
	[Address(RVA = "0x240DF08", Offset = "0x240DF08", VA = "0x240DF08", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60134CD")]
	[Address(RVA = "0x240DF5C", Offset = "0x240DF5C", VA = "0x240DF5C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60134CE")]
	[Address(RVA = "0x240DFB0", Offset = "0x240DFB0", VA = "0x240DFB0")]
	public void OnTicked(ulong roomid)
	{
	}

	[Token(Token = "0x60134CF")]
	[Address(RVA = "0x240E2F8", Offset = "0x240E2F8", VA = "0x240E2F8")]
	public bool CheckIsBlocked(ulong roomid)
	{
		return default(bool);
	}
}
