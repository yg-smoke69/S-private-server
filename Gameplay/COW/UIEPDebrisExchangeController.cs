using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020D2")]
public class UIEPDebrisExchangeController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400CD73")]
	[FieldOffset(Offset = "0x48")]
	private UIEPDebrisExchangeView m_View;

	[Token(Token = "0x400CD74")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelElitePass m_Model;

	[Token(Token = "0x600A9CE")]
	[Address(RVA = "0x2BA9C70", Offset = "0x2BA9C70", VA = "0x2BA9C70")]
	public UIEPDebrisExchangeController()
	{
	}

	[Token(Token = "0x600A9CF")]
	[Address(RVA = "0x2BA9C78", Offset = "0x2BA9C78", VA = "0x2BA9C78", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A9D0")]
	[Address(RVA = "0x2BA9E88", Offset = "0x2BA9E88", VA = "0x2BA9E88")]
	private void InitData()
	{
	}

	[Token(Token = "0x600A9D1")]
	[Address(RVA = "0x2BAA030", Offset = "0x2BAA030", VA = "0x2BAA030")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A9D2")]
	[Address(RVA = "0x2BAA0D4", Offset = "0x2BAA0D4", VA = "0x2BAA0D4")]
	private void OnClaimClick()
	{
	}

	[Token(Token = "0x600A9D3")]
	[Address(RVA = "0x2BAA158", Offset = "0x2BAA158", VA = "0x2BAA158")]
	public void SetData(int badgeFrom, int badgeTo)
	{
	}

	[Token(Token = "0x600A9D4")]
	[Address(RVA = "0x2BAA278", Offset = "0x2BAA278", VA = "0x2BAA278")]
	private void ShowReward(int badgeFrom, int badgeTo)
	{
	}

	[Token(Token = "0x600A9D5")]
	[Address(RVA = "0x2BAA7E0", Offset = "0x2BAA7E0", VA = "0x2BAA7E0", Slot = "46")]
	private UIEasyListItemController GCommon_002EIEasyList_002EOpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600A9D6")]
	[Address(RVA = "0x2BAA910", Offset = "0x2BAA910", VA = "0x2BAA910", Slot = "47")]
	private void GCommon_002EIEasyList_002ECloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600A9D7")]
	[Address(RVA = "0x2BAA98C", Offset = "0x2BAA98C", VA = "0x2BAA98C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
