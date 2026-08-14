using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2003DD6")]
public static class AkRoomPortalManager
{
	[Token(Token = "0x401A42C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<AkRoom> m_UpdatedRooms;

	[Token(Token = "0x401A42D")]
	[FieldOffset(Offset = "0x4")]
	private static readonly List<AkRoomPortal> m_Portals;

	[Token(Token = "0x401A42E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly List<AkRoomPortal> m_PortalsToUpdate;

	[Token(Token = "0x60192AA")]
	[Address(RVA = "0x36C91CC", Offset = "0x36C91CC", VA = "0x36C91CC")]
	public static void RegisterPortal(AkRoomPortal portal)
	{
	}

	[Token(Token = "0x60192AB")]
	[Address(RVA = "0x36C94E4", Offset = "0x36C94E4", VA = "0x36C94E4")]
	public static void UnregisterPortal(AkRoomPortal portal)
	{
	}

	[Token(Token = "0x60192AC")]
	[Address(RVA = "0x36C80EC", Offset = "0x36C80EC", VA = "0x36C80EC")]
	public static void RegisterPortalUpdate(AkRoomPortal portal)
	{
	}

	[Token(Token = "0x60192AD")]
	[Address(RVA = "0x36C6B00", Offset = "0x36C6B00", VA = "0x36C6B00")]
	public static void RegisterRoomUpdate(AkRoom room)
	{
	}

	[Token(Token = "0x60192AE")]
	[Address(RVA = "0x36C9CC4", Offset = "0x36C9CC4", VA = "0x36C9CC4")]
	public static void UpdatePortals()
	{
	}
}
