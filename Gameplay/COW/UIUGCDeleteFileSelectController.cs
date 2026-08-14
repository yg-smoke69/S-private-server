using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BA3")]
internal class UIUGCDeleteFileSelectController : UIPopupWindowController
{
	[Token(Token = "0x4010AF2")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCDeleteFileSelectView m_View;

	[Token(Token = "0x4010AF3")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_SelectedLocal;

	[Token(Token = "0x4010AF4")]
	[FieldOffset(Offset = "0x50")]
	private uint m_SelecetedSlot;

	[Token(Token = "0x4010AF5")]
	[FieldOffset(Offset = "0x54")]
	private Action<bool> m_OnApplyCallBack;

	[Token(Token = "0x601208A")]
	[Address(RVA = "0x2B957A8", Offset = "0x2B957A8", VA = "0x2B957A8")]
	public UIUGCDeleteFileSelectController()
	{
	}

	[Token(Token = "0x601208B")]
	[Address(RVA = "0x2B957B0", Offset = "0x2B957B0", VA = "0x2B957B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601208C")]
	[Address(RVA = "0x2B95858", Offset = "0x2B95858", VA = "0x2B95858", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601208D")]
	[Address(RVA = "0x2B95BDC", Offset = "0x2B95BDC", VA = "0x2B95BDC")]
	public void SetUIData(uint selected, Action<bool> action)
	{
	}

	[Token(Token = "0x601208E")]
	[Address(RVA = "0x2B95F44", Offset = "0x2B95F44", VA = "0x2B95F44")]
	private void OnBtnApplyClick()
	{
	}

	[Token(Token = "0x601208F")]
	[Address(RVA = "0x2B95FFC", Offset = "0x2B95FFC", VA = "0x2B95FFC")]
	private void OnBtnPublishedClick()
	{
	}

	[Token(Token = "0x6012090")]
	[Address(RVA = "0x2B960E4", Offset = "0x2B960E4", VA = "0x2B960E4")]
	private void OnBtnLocalClick()
	{
	}

	[Token(Token = "0x6012091")]
	[Address(RVA = "0x2B961CC", Offset = "0x2B961CC", VA = "0x2B961CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
