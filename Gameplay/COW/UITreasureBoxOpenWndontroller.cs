using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B82")]
public class UITreasureBoxOpenWndontroller : UIPopupWindowController
{
	[Token(Token = "0x4010A79")]
	[FieldOffset(Offset = "0x48")]
	private UITreasureBoxOpenWndView m_View;

	[Token(Token = "0x4010A7A")]
	[FieldOffset(Offset = "0x4C")]
	private Item m_Item;

	[Token(Token = "0x4010A7B")]
	[FieldOffset(Offset = "0x50")]
	private int maxOpenCnt;

	[Token(Token = "0x4010A7C")]
	[FieldOffset(Offset = "0x54")]
	private UIStandardItemMAXBController m_ItemCtrl;

	[Token(Token = "0x4010A7D")]
	[FieldOffset(Offset = "0x58")]
	private uint m_SelectCnt;

	[Token(Token = "0x4010A7E")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsSliderChange;

	[Token(Token = "0x170012F0")]
	private uint SelectCnt
	{
		[Token(Token = "0x6011F9F")]
		[Address(RVA = "0x1C2E080", Offset = "0x1C2E080", VA = "0x1C2E080")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6011F9E")]
		[Address(RVA = "0x1C2DCC0", Offset = "0x1C2DCC0", VA = "0x1C2DCC0")]
		set
		{
		}
	}

	[Token(Token = "0x6011F9D")]
	[Address(RVA = "0x1C2DCB8", Offset = "0x1C2DCB8", VA = "0x1C2DCB8")]
	public UITreasureBoxOpenWndontroller()
	{
	}

	[Token(Token = "0x6011FA0")]
	[Address(RVA = "0x1C2E0D8", Offset = "0x1C2E0D8", VA = "0x1C2E0D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011FA1")]
	[Address(RVA = "0x1C2E180", Offset = "0x1C2E180", VA = "0x1C2E180", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011FA2")]
	[Address(RVA = "0x1C2E4B0", Offset = "0x1C2E4B0", VA = "0x1C2E4B0")]
	public void RefreshView(uint itemID)
	{
	}

	[Token(Token = "0x6011FA3")]
	[Address(RVA = "0x1C2E810", Offset = "0x1C2E810", VA = "0x1C2E810")]
	private void OnOpenBtnClick()
	{
	}

	[Token(Token = "0x6011FA4")]
	[Address(RVA = "0x1C2E98C", Offset = "0x1C2E98C", VA = "0x1C2E98C")]
	private void OnPlusBtnClick()
	{
	}

	[Token(Token = "0x6011FA5")]
	[Address(RVA = "0x1C2EA14", Offset = "0x1C2EA14", VA = "0x1C2EA14")]
	private void OnMinsBtnClick()
	{
	}

	[Token(Token = "0x6011FA6")]
	[Address(RVA = "0x1C2EA90", Offset = "0x1C2EA90", VA = "0x1C2EA90")]
	private void OnSliderValueChange()
	{
	}

	[Token(Token = "0x6011FA7")]
	[Address(RVA = "0x1C2DD38", Offset = "0x1C2DD38", VA = "0x1C2DD38")]
	private void OnSelectCntChange()
	{
	}

	[Token(Token = "0x6011FA8")]
	[Address(RVA = "0x1C2EC84", Offset = "0x1C2EC84", VA = "0x1C2EC84")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
