using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026F2")]
internal class UIHudBombHintController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F079")]
	[FieldOffset(Offset = "0x28")]
	private UIModelMatch m_MatchModel;

	[Token(Token = "0x400F07A")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudBombHintView m_View;

	[Token(Token = "0x400F07B")]
	[FieldOffset(Offset = "0x30")]
	public Color iconTintWhiteColor;

	[Token(Token = "0x400F07C")]
	[FieldOffset(Offset = "0x40")]
	public Color iconTintYellowColor;

	[Token(Token = "0x400F07D")]
	[FieldOffset(Offset = "0x50")]
	private uint m_DelayCall;

	[Token(Token = "0x400F07E")]
	[FieldOffset(Offset = "0x54")]
	private PJIBHMGGMEL m_BombGame;

	[Token(Token = "0x600EC30")]
	[Address(RVA = "0x1E0B280", Offset = "0x1E0B280", VA = "0x1E0B280")]
	public UIHudBombHintController()
	{
	}

	[Token(Token = "0x600EC31")]
	[Address(RVA = "0x1E0B364", Offset = "0x1E0B364", VA = "0x1E0B364")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EC32")]
	[Address(RVA = "0x1E0B408", Offset = "0x1E0B408", VA = "0x1E0B408", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EC33")]
	[Address(RVA = "0x1E0B5FC", Offset = "0x1E0B5FC", VA = "0x1E0B5FC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EC34")]
	[Address(RVA = "0x1E0B684", Offset = "0x1E0B684", VA = "0x1E0B684", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600EC35")]
	[Address(RVA = "0x1E0B718", Offset = "0x1E0B718", VA = "0x1E0B718", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600EC36")]
	[Address(RVA = "0x1E0BFC8", Offset = "0x1E0BFC8", VA = "0x1E0BFC8")]
	private void UpdateHintInfo(BombModeNotification notification, bool needAutoHide = true)
	{
	}

	[Token(Token = "0x600EC37")]
	[Address(RVA = "0x1E0C700", Offset = "0x1E0C700", VA = "0x1E0C700")]
	private void On3PPreparation(object[] data)
	{
	}

	[Token(Token = "0x600EC38")]
	[Address(RVA = "0x1E0CB94", Offset = "0x1E0CB94", VA = "0x1E0CB94")]
	private void _003CUpdateHintInfo_003Em__0()
	{
	}

	[Token(Token = "0x600EC39")]
	[Address(RVA = "0x1E0CC74", Offset = "0x1E0CC74", VA = "0x1E0CC74")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EC3A")]
	[Address(RVA = "0x1E0CC7C", Offset = "0x1E0CC7C", VA = "0x1E0CC7C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
