using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BA2")]
internal class UIUGCCSaveFileSelectController : UIPopupWindowController
{
	[Token(Token = "0x4010AED")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCCSaveFileSelectView m_View;

	[Token(Token = "0x4010AEE")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_SelecetedSlot;

	[Token(Token = "0x4010AEF")]
	[FieldOffset(Offset = "0x50")]
	private bool m_SelectedLocal;

	[Token(Token = "0x4010AF0")]
	[FieldOffset(Offset = "0x54")]
	private Action<bool> m_OnApplyCallBack;

	[Token(Token = "0x4010AF1")]
	[FieldOffset(Offset = "0x58")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x601207F")]
	[Address(RVA = "0x2B7FA3C", Offset = "0x2B7FA3C", VA = "0x2B7FA3C")]
	public UIUGCCSaveFileSelectController()
	{
	}

	[Token(Token = "0x6012080")]
	[Address(RVA = "0x2B7FA44", Offset = "0x2B7FA44", VA = "0x2B7FA44")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012081")]
	[Address(RVA = "0x2B7FAEC", Offset = "0x2B7FAEC", VA = "0x2B7FAEC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012082")]
	[Address(RVA = "0x2B7FE64", Offset = "0x2B7FE64", VA = "0x2B7FE64", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012083")]
	[Address(RVA = "0x2B7FED0", Offset = "0x2B7FED0", VA = "0x2B7FED0")]
	public void SetSelect(uint selected, Action<bool> action)
	{
	}

	[Token(Token = "0x6012084")]
	[Address(RVA = "0x2B804A0", Offset = "0x2B804A0", VA = "0x2B804A0")]
	private void OnCloseUI(object[] data)
	{
	}

	[Token(Token = "0x6012085")]
	[Address(RVA = "0x2B8050C", Offset = "0x2B8050C", VA = "0x2B8050C")]
	private void OnBtnApplyClick()
	{
	}

	[Token(Token = "0x6012086")]
	[Address(RVA = "0x2B805C4", Offset = "0x2B805C4", VA = "0x2B805C4")]
	private void OnBtnPublishedClick()
	{
	}

	[Token(Token = "0x6012087")]
	[Address(RVA = "0x2B80694", Offset = "0x2B80694", VA = "0x2B80694")]
	private void OnBtnLocalClick()
	{
	}

	[Token(Token = "0x6012088")]
	[Address(RVA = "0x2B80764", Offset = "0x2B80764", VA = "0x2B80764")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012089")]
	[Address(RVA = "0x2B8076C", Offset = "0x2B8076C", VA = "0x2B8076C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
