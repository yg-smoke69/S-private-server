using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200204E")]
internal class UIHudCSShopMysteryBoxOpenController : UIBaseController
{
	[Token(Token = "0x400CA7A")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCSShopMysteryBoxOpenView m_View;

	[Token(Token = "0x400CA7B")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIToggleButton> m_ListToggles;

	[Token(Token = "0x400CA7C")]
	[FieldOffset(Offset = "0x30")]
	private uint m_SelectedBoxItemID;

	[Token(Token = "0x400CA7D")]
	[FieldOffset(Offset = "0x34")]
	private uint m_SelectedBoxUniqueID;

	[Token(Token = "0x400CA7E")]
	[FieldOffset(Offset = "0x38")]
	private UIHudCSMysteryBoxOptionItemView.MysterBoxData m_MysteryBoxData;

	[Token(Token = "0x400CA7F")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIHudCSMysteryBoxOptionItemView.MysterBoxData> m_OptionItemsDataList;

	[Token(Token = "0x400CA80")]
	[FieldOffset(Offset = "0x40")]
	private UIHudCommonlTipsController m_CurrentTips;

	[Token(Token = "0x400CA81")]
	[FieldOffset(Offset = "0x44")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x600A49D")]
	[Address(RVA = "0x2141290", Offset = "0x2141290", VA = "0x2141290")]
	public UIHudCSShopMysteryBoxOpenController()
	{
	}

	[Token(Token = "0x600A49E")]
	[Address(RVA = "0x2141314", Offset = "0x2141314", VA = "0x2141314")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A49F")]
	[Address(RVA = "0x21413BC", Offset = "0x21413BC", VA = "0x21413BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A4A0")]
	[Address(RVA = "0x2141728", Offset = "0x2141728", VA = "0x2141728", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A4A1")]
	[Address(RVA = "0x214185C", Offset = "0x214185C", VA = "0x214185C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600A4A2")]
	[Address(RVA = "0x21419DC", Offset = "0x21419DC", VA = "0x21419DC")]
	private void Update()
	{
	}

	[Token(Token = "0x600A4A3")]
	[Address(RVA = "0x2141B94", Offset = "0x2141B94", VA = "0x2141B94")]
	public void SetUIData(List<JMPFKFLHEDK> data, float duration)
	{
	}

	[Token(Token = "0x600A4A4")]
	[Address(RVA = "0x2142394", Offset = "0x2142394", VA = "0x2142394")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x600A4A5")]
	[Address(RVA = "0x21424B0", Offset = "0x21424B0", VA = "0x21424B0")]
	private void OnOptionItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600A4A6")]
	[Address(RVA = "0x2142654", Offset = "0x2142654", VA = "0x2142654")]
	private void OnHelpBtnClick()
	{
	}

	[Token(Token = "0x600A4A7")]
	[Address(RVA = "0x2141A84", Offset = "0x2141A84", VA = "0x2141A84")]
	private void AutoChooseOption()
	{
	}

	[Token(Token = "0x600A4A8")]
	[Address(RVA = "0x21428D8", Offset = "0x21428D8", VA = "0x21428D8")]
	public void OnTimeUp()
	{
	}

	[Token(Token = "0x600A4A9")]
	[Address(RVA = "0x2142938", Offset = "0x2142938", VA = "0x2142938")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A4AA")]
	[Address(RVA = "0x2142940", Offset = "0x2142940", VA = "0x2142940")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600A4AB")]
	[Address(RVA = "0x2142948", Offset = "0x2142948", VA = "0x2142948")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
