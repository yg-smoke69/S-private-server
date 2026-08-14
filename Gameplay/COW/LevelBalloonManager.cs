using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20005DC")]
public class LevelBalloonManager
{
	[Token(Token = "0x400443E")]
	[FieldOffset(Offset = "0x8")]
	private LinkedList<LevelBalloon> levelBalloonsList;

	[Token(Token = "0x400443F")]
	[FieldOffset(Offset = "0xC")]
	private readonly ResourceID[] balloonResourceIDs;

	[Token(Token = "0x4004440")]
	[FieldOffset(Offset = "0x10")]
	private readonly int maxBalloonNum;

	[Token(Token = "0x6002365")]
	[Address(RVA = "0xEBC0C0", Offset = "0xEBC0C0", VA = "0xEBC0C0")]
	public LevelBalloonManager()
	{
	}

	[Token(Token = "0x6002366")]
	[Address(RVA = "0xEBC27C", Offset = "0xEBC27C", VA = "0xEBC27C")]
	public LevelBalloon CreateBalloon(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6002367")]
	[Address(RVA = "0xEBC62C", Offset = "0xEBC62C", VA = "0xEBC62C")]
	public void OnBalloonDestroy(LinkedListNode<LevelBalloon> node)
	{
	}

	[Token(Token = "0x6002368")]
	[Address(RVA = "0xEBC574", Offset = "0xEBC574", VA = "0xEBC574")]
	private ResourceID GetBalloonResource()
	{
		return default(ResourceID);
	}
}
