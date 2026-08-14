using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028BD")]
public class UIHudWereWolvesQuickChatScrollController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FAC9")]
	[FieldOffset(Offset = "0x28")]
	private uint m_Select;

	[Token(Token = "0x400FACA")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudWereWolvesQuickChatScrollView m_View;

	[Token(Token = "0x601008E")]
	[Address(RVA = "0x256C018", Offset = "0x256C018", VA = "0x256C018")]
	public UIHudWereWolvesQuickChatScrollController()
	{
	}

	[Token(Token = "0x601008F")]
	[Address(RVA = "0x256C09C", Offset = "0x256C09C", VA = "0x256C09C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010090")]
	[Address(RVA = "0x256C144", Offset = "0x256C144", VA = "0x256C144", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010091")]
	[Address(RVA = "0x256C370", Offset = "0x256C370", VA = "0x256C370", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010092")]
	[Address(RVA = "0x256C4A4", Offset = "0x256C4A4", VA = "0x256C4A4", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010093")]
	[Address(RVA = "0x256C5D4", Offset = "0x256C5D4", VA = "0x256C5D4", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010094")]
	[Address(RVA = "0x256C650", Offset = "0x256C650", VA = "0x256C650")]
	public void SetData(uint playerId)
	{
	}

	[Token(Token = "0x6010095")]
	[Address(RVA = "0x256C838", Offset = "0x256C838", VA = "0x256C838")]
	private void OnSendWereWolvesQuickChat(object[] data)
	{
	}

	[Token(Token = "0x6010096")]
	[Address(RVA = "0x256CCD0", Offset = "0x256CCD0", VA = "0x256CCD0")]
	private void OnBgClick()
	{
	}

	[Token(Token = "0x6010097")]
	[Address(RVA = "0x256CD3C", Offset = "0x256CD3C", VA = "0x256CD3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010098")]
	[Address(RVA = "0x256CD44", Offset = "0x256CD44", VA = "0x256CD44")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
