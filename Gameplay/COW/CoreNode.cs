using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001F12")]
public class CoreNode
{
	[Token(Token = "0x400C36E")]
	[FieldOffset(Offset = "0x8")]
	public CSDigitalUniverseBStarCraftInfoRes.PlayerInfo playerData;

	[Token(Token = "0x400C36F")]
	[FieldOffset(Offset = "0x10")]
	public ulong accountId;

	[Token(Token = "0x400C370")]
	[FieldOffset(Offset = "0x18")]
	public int trackIndex;

	[Token(Token = "0x400C371")]
	[FieldOffset(Offset = "0x1C")]
	public int groupIndex;

	[Token(Token = "0x400C372")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 point;

	[Token(Token = "0x400C373")]
	[FieldOffset(Offset = "0x28")]
	public bool isNewPlayer;

	[Token(Token = "0x600985F")]
	[Address(RVA = "0x1C80400", Offset = "0x1C80400", VA = "0x1C80400")]
	public CoreNode()
	{
	}

	[Token(Token = "0x6009860")]
	[Address(RVA = "0x1C804E4", Offset = "0x1C804E4", VA = "0x1C804E4")]
	public CoreNode(CoreNode node)
	{
	}
}
