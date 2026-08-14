using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002735")]
internal class UIHudEmotionController : UIBaseController
{
	[Token(Token = "0x400F20E")]
	[FieldOffset(Offset = "0x28")]
	protected UIHudEmotionView m_View;

	[Token(Token = "0x400F20F")]
	[FieldOffset(Offset = "0x2C")]
	protected List<UIHudEmotionItem> m_EmotionItems;

	[Token(Token = "0x400F210")]
	[FieldOffset(Offset = "0x30")]
	protected List<GameObject> m_DesgarObjs;

	[Token(Token = "0x600EEDE")]
	[Address(RVA = "0x1CDE278", Offset = "0x1CDE278", VA = "0x1CDE278")]
	public UIHudEmotionController()
	{
	}

	[Token(Token = "0x600EEDF")]
	[Address(RVA = "0x1CDE2FC", Offset = "0x1CDE2FC", VA = "0x1CDE2FC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EEE0")]
	[Address(RVA = "0x1CDE3A4", Offset = "0x1CDE3A4", VA = "0x1CDE3A4", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x600EEE1")]
	[Address(RVA = "0x1CDE764", Offset = "0x1CDE764", VA = "0x1CDE764", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600EEE2")]
	[Address(RVA = "0x1CDE898", Offset = "0x1CDE898", VA = "0x1CDE898", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EEE3")]
	[Address(RVA = "0x1CDF154", Offset = "0x1CDF154", VA = "0x1CDF154")]
	protected void InitTransformer()
	{
	}

	[Token(Token = "0x600EEE4")]
	[Address(RVA = "0x1CDF2D0", Offset = "0x1CDF2D0", VA = "0x1CDF2D0")]
	private void InitDownloadInfo()
	{
	}

	[Token(Token = "0x600EEE5")]
	[Address(RVA = "0x1CDF6C8", Offset = "0x1CDF6C8", VA = "0x1CDF6C8")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x600EEE6")]
	[Address(RVA = "0x1CDF75C", Offset = "0x1CDF75C", VA = "0x1CDF75C")]
	private void OnBtnPaintSprayerClick()
	{
	}

	[Token(Token = "0x600EEE7")]
	[Address(RVA = "0x1CDF9C4", Offset = "0x1CDF9C4", VA = "0x1CDF9C4")]
	protected void InitPaintSprayer(object[] param)
	{
	}

	[Token(Token = "0x600EEE8")]
	[Address(RVA = "0x1CDE4E0", Offset = "0x1CDE4E0", VA = "0x1CDE4E0")]
	private void InitPaintSprayer()
	{
	}

	[Token(Token = "0x600EEE9")]
	[Address(RVA = "0x1CDFA2C", Offset = "0x1CDFA2C", VA = "0x1CDFA2C", Slot = "31")]
	protected virtual void InitEmotions()
	{
	}

	[Token(Token = "0x600EEEA")]
	[Address(RVA = "0x1CDF47C", Offset = "0x1CDF47C", VA = "0x1CDF47C")]
	private void RefreshBtnCustomoAnimVisibility()
	{
	}

	[Token(Token = "0x600EEEB")]
	[Address(RVA = "0x1CE0038", Offset = "0x1CE0038", VA = "0x1CE0038")]
	protected void OnBtnCustomAnimClick()
	{
	}

	[Token(Token = "0x600EEEC")]
	[Address(RVA = "0x1CE0468", Offset = "0x1CE0468", VA = "0x1CE0468")]
	protected void OnBtnMaskClick()
	{
	}

	[Token(Token = "0x600EEED")]
	[Address(RVA = "0x1CE0574", Offset = "0x1CE0574", VA = "0x1CE0574", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EEEE")]
	[Address(RVA = "0x1CE05C8", Offset = "0x1CE05C8", VA = "0x1CE05C8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EEEF")]
	[Address(RVA = "0x1CE0794", Offset = "0x1CE0794", VA = "0x1CE0794")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EEF0")]
	[Address(RVA = "0x1CE079C", Offset = "0x1CE079C", VA = "0x1CE079C")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x600EEF1")]
	[Address(RVA = "0x1CE07A4", Offset = "0x1CE07A4", VA = "0x1CE07A4")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	[Token(Token = "0x600EEF2")]
	[Address(RVA = "0x1CE07AC", Offset = "0x1CE07AC", VA = "0x1CE07AC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EEF3")]
	[Address(RVA = "0x1CE07B4", Offset = "0x1CE07B4", VA = "0x1CE07B4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
