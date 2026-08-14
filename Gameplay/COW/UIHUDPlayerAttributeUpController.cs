using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002800")]
internal class UIHUDPlayerAttributeUpController : UIBaseController
{
	[Token(Token = "0x400F6E1")]
	private const int MAX_ITEM_COUNT = 4;

	[Token(Token = "0x400F6E2")]
	[FieldOffset(Offset = "0x28")]
	private float m_ItemDeltaY;

	[Token(Token = "0x400F6E3")]
	[FieldOffset(Offset = "0x2C")]
	private UIHUDPlayerAttributeUpItem m_ItemTemplate;

	[Token(Token = "0x400F6E4")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_TemlateLocPos;

	[Token(Token = "0x400F6E5")]
	[FieldOffset(Offset = "0x3C")]
	private Queue<UIHUDPlayerAttributeUpItem> m_ItemQ;

	[Token(Token = "0x600F8AF")]
	[Address(RVA = "0x1685934", Offset = "0x1685934", VA = "0x1685934")]
	public UIHUDPlayerAttributeUpController()
	{
	}

	[Token(Token = "0x600F8B0")]
	[Address(RVA = "0x16859EC", Offset = "0x16859EC", VA = "0x16859EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F8B1")]
	[Address(RVA = "0x1685A94", Offset = "0x1685A94", VA = "0x1685A94", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F8B2")]
	[Address(RVA = "0x1685C10", Offset = "0x1685C10", VA = "0x1685C10")]
	public void ShowMessage(string msg)
	{
	}

	[Token(Token = "0x600F8B3")]
	[Address(RVA = "0x1685D0C", Offset = "0x1685D0C", VA = "0x1685D0C")]
	public UIHUDPlayerAttributeUpItem DequeueItem()
	{
		return null;
	}

	[Token(Token = "0x600F8B4")]
	[Address(RVA = "0x1685FFC", Offset = "0x1685FFC", VA = "0x1685FFC")]
	public void Reposition()
	{
	}

	[Token(Token = "0x600F8B5")]
	[Address(RVA = "0x168625C", Offset = "0x168625C", VA = "0x168625C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
