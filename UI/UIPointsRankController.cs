using System;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002A64")]
public class UIPointsRankController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x4010478")]
	[FieldOffset(Offset = "0x48")]
	public LeaderBoardInfo m_SelectedInfo;

	[Token(Token = "0x4010479")]
	[FieldOffset(Offset = "0x4C")]
	private UIPointsRankView m_View;

	[Token(Token = "0x401047A")]
	[FieldOffset(Offset = "0x50")]
	private UIModelLeaderBoard m_ModelLeaderBoard;

	[Token(Token = "0x401047B")]
	[FieldOffset(Offset = "0x54")]
	private UIPointsRankItemController m_SelfRankUI;

	[Token(Token = "0x401047C")]
	public const uint PropID = 131104u;

	[Token(Token = "0x60113F0")]
	[Address(RVA = "0x223FF68", Offset = "0x223FF68", VA = "0x223FF68")]
	public UIPointsRankController()
	{
	}

	[Token(Token = "0x60113F1")]
	[Address(RVA = "0x223FF70", Offset = "0x223FF70", VA = "0x223FF70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60113F2")]
	[Address(RVA = "0x223FFD4", Offset = "0x223FFD4", VA = "0x223FFD4", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60113F3")]
	[Address(RVA = "0x2240018", Offset = "0x2240018", VA = "0x2240018", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60113F4")]
	[Address(RVA = "0x22404DC", Offset = "0x22404DC", VA = "0x22404DC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60113F5")]
	[Address(RVA = "0x224051C", Offset = "0x224051C", VA = "0x224051C")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x60113F6")]
	[Address(RVA = "0x2240524", Offset = "0x2240524", VA = "0x2240524", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60113F7")]
	[Address(RVA = "0x2240838", Offset = "0x2240838", VA = "0x2240838", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60113F8")]
	[Address(RVA = "0x22408E0", Offset = "0x22408E0", VA = "0x22408E0", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}
}
