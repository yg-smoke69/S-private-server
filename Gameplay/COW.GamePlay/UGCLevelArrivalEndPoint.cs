using System.Runtime.InteropServices;
using COW.Gameplay.LevelObject;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000728")]
public class UGCLevelArrivalEndPoint : LevelUGCCustomizeTrigger, _Attribute
{
	[Token(Token = "0x4004C45")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject EndIconPrefeb;

	[Token(Token = "0x4004C46")]
	[FieldOffset(Offset = "0x80")]
	private GameObject CJNJKCKEOKG;

	[Token(Token = "0x6002D21")]
	[Address(RVA = "0x1385020", Offset = "0x1385020", VA = "0x1385020")]
	public UGCLevelArrivalEndPoint()
	{
	}

	[Token(Token = "0x6002D22")]
	[Address(RVA = "0x1385028", Offset = "0x1385028", VA = "0x1385028", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002D23")]
	[Address(RVA = "0x13850CC", Offset = "0x13850CC", VA = "0x13850CC", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002D24")]
	[Address(RVA = "0x13851D4", Offset = "0x13851D4", VA = "0x13851D4")]
	public void UpdataIcon()
	{
	}

	[Token(Token = "0x6002D25")]
	[Address(RVA = "0x138544C", Offset = "0x138544C", VA = "0x138544C", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002D26")]
	[Address(RVA = "0x1385574", Offset = "0x1385574", VA = "0x1385574")]
	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002D27")]
	[Address(RVA = "0x138557C", Offset = "0x138557C", VA = "0x138557C")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002D28")]
	[Address(RVA = "0x1385584", Offset = "0x1385584", VA = "0x1385584")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
