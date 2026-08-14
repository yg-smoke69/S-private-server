using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002677")]
public class UIGachaTabItemController : UIBaseController
{
	[Token(Token = "0x400ED71")]
	[FieldOffset(Offset = "0x28")]
	public ulong startTime;

	[Token(Token = "0x400ED72")]
	[FieldOffset(Offset = "0x30")]
	public int pageDetentionTime;

	[Token(Token = "0x400ED73")]
	[FieldOffset(Offset = "0x34")]
	private UIGachaTabItemView m_View;

	[Token(Token = "0x400ED74")]
	[FieldOffset(Offset = "0x38")]
	private int m_Idx;

	[Token(Token = "0x400ED75")]
	[FieldOffset(Offset = "0x3C")]
	private GachaDesc m_Desc;

	[Token(Token = "0x400ED76")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsSelected;

	[Token(Token = "0x400ED77")]
	[FieldOffset(Offset = "0x44")]
	private AnimationState[] scaleStateList;

	[Token(Token = "0x400ED78")]
	private const string m_IconPrefix = "FF_Lottery_Tab0";

	[Token(Token = "0x600E67A")]
	[Address(RVA = "0x2A2DB9C", Offset = "0x2A2DB9C", VA = "0x2A2DB9C")]
	public UIGachaTabItemController()
	{
	}

	[Token(Token = "0x600E67B")]
	[Address(RVA = "0x2A2DC20", Offset = "0x2A2DC20", VA = "0x2A2DC20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E67C")]
	[Address(RVA = "0x2A2DCC8", Offset = "0x2A2DCC8", VA = "0x2A2DCC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E67D")]
	[Address(RVA = "0x2A2E2D8", Offset = "0x2A2E2D8", VA = "0x2A2E2D8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E67E")]
	[Address(RVA = "0x2A2E710", Offset = "0x2A2E710", VA = "0x2A2E710", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E67F")]
	[Address(RVA = "0x2A2E7A8", Offset = "0x2A2E7A8", VA = "0x2A2E7A8")]
	public void OnUIGachaShow()
	{
	}

	[Token(Token = "0x600E680")]
	[Address(RVA = "0x2A2E880", Offset = "0x2A2E880", VA = "0x2A2E880")]
	public void OnUIGachaHide()
	{
	}

	[Token(Token = "0x600E681")]
	[Address(RVA = "0x2A2E9C8", Offset = "0x2A2E9C8", VA = "0x2A2E9C8")]
	public void SetViewData(int curGachaIdx)
	{
	}

	[Token(Token = "0x600E682")]
	[Address(RVA = "0x2A2F074", Offset = "0x2A2F074", VA = "0x2A2F074")]
	public void RefreshUI(bool isSelected)
	{
	}

	[Token(Token = "0x600E683")]
	[Address(RVA = "0x2A2F260", Offset = "0x2A2F260", VA = "0x2A2F260")]
	private void InitBGSprite()
	{
	}

	[Token(Token = "0x600E684")]
	[Address(RVA = "0x2A2F3AC", Offset = "0x2A2F3AC", VA = "0x2A2F3AC")]
	private void OnGachaTabItemBtnClick()
	{
	}

	[Token(Token = "0x600E685")]
	[Address(RVA = "0x2A2F5B4", Offset = "0x2A2F5B4", VA = "0x2A2F5B4")]
	public void SetSelecetState(bool isSelected)
	{
	}

	[Token(Token = "0x600E686")]
	[Address(RVA = "0x2A2DE34", Offset = "0x2A2DE34", VA = "0x2A2DE34")]
	private void InitAnimState()
	{
	}

	[Token(Token = "0x600E687")]
	[Address(RVA = "0x2A2EB08", Offset = "0x2A2EB08", VA = "0x2A2EB08")]
	private void InitCDNTex()
	{
	}

	[Token(Token = "0x600E688")]
	[Address(RVA = "0x2A2F964", Offset = "0x2A2F964", VA = "0x2A2F964")]
	private void HideDefaultSprite()
	{
	}

	[Token(Token = "0x600E689")]
	[Address(RVA = "0x2A2F0DC", Offset = "0x2A2F0DC", VA = "0x2A2F0DC")]
	private void RefreshNewTip()
	{
	}

	[Token(Token = "0x600E68A")]
	[Address(RVA = "0x2A2FA14", Offset = "0x2A2FA14", VA = "0x2A2FA14")]
	public void EnableTabVFX()
	{
	}

	[Token(Token = "0x600E68B")]
	[Address(RVA = "0x2A2FAA4", Offset = "0x2A2FAA4", VA = "0x2A2FAA4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E68C")]
	[Address(RVA = "0x2A2FAAC", Offset = "0x2A2FAAC", VA = "0x2A2FAAC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E68D")]
	[Address(RVA = "0x2A2FAB4", Offset = "0x2A2FAB4", VA = "0x2A2FAB4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
