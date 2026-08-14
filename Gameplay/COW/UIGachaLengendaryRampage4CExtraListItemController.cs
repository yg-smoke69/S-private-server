using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002115")]
internal class UIGachaLengendaryRampage4CExtraListItemController : UIBaseController
{
	[Token(Token = "0x400CF4F")]
	[FieldOffset(Offset = "0x28")]
	private ExtraRewardDesc m_ItemDesc;

	[Token(Token = "0x400CF50")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Indx;

	[Token(Token = "0x400CF51")]
	[FieldOffset(Offset = "0x30")]
	private uint m_GachaID;

	[Token(Token = "0x400CF52")]
	[FieldOffset(Offset = "0x34")]
	private uint m_ItemDelayCall;

	[Token(Token = "0x400CF53")]
	[FieldOffset(Offset = "0x38")]
	private RareRewardState m_RareRewardState;

	[Token(Token = "0x400CF54")]
	[FieldOffset(Offset = "0x3C")]
	private BaseItemInfo m_BaseItemInfo;

	[Token(Token = "0x400CF55")]
	[FieldOffset(Offset = "0x40")]
	private ExtraAwardItemState m_State;

	[Token(Token = "0x400CF56")]
	[FieldOffset(Offset = "0x44")]
	private UIGachaLengendaryRampage4CExtraListItemView m_View;

	[Token(Token = "0x600AD14")]
	[Address(RVA = "0x2E73E48", Offset = "0x2E73E48", VA = "0x2E73E48")]
	public UIGachaLengendaryRampage4CExtraListItemController()
	{
	}

	[Token(Token = "0x600AD15")]
	[Address(RVA = "0x2E73ED4", Offset = "0x2E73ED4", VA = "0x2E73ED4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AD16")]
	[Address(RVA = "0x2E73F7C", Offset = "0x2E73F7C", VA = "0x2E73F7C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AD17")]
	[Address(RVA = "0x2E740D8", Offset = "0x2E740D8", VA = "0x2E740D8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AD18")]
	[Address(RVA = "0x2E741E0", Offset = "0x2E741E0", VA = "0x2E741E0")]
	public void SetViewData(ExtraRewardDesc data, int data_index, uint chestID)
	{
	}

	[Token(Token = "0x600AD19")]
	[Address(RVA = "0x2E74284", Offset = "0x2E74284", VA = "0x2E74284")]
	public void UpdateItemState()
	{
	}

	[Token(Token = "0x600AD1A")]
	[Address(RVA = "0x2E74460", Offset = "0x2E74460", VA = "0x2E74460")]
	private void RefreshExtraAwardItemView(uint chestID)
	{
	}

	[Token(Token = "0x600AD1B")]
	[Address(RVA = "0x2E75120", Offset = "0x2E75120", VA = "0x2E75120")]
	private void SetQualityBG(int Quality, UISprite QualityBG)
	{
	}

	[Token(Token = "0x600AD1C")]
	[Address(RVA = "0x2E75470", Offset = "0x2E75470", VA = "0x2E75470")]
	private void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600AD1D")]
	[Address(RVA = "0x2E75A7C", Offset = "0x2E75A7C", VA = "0x2E75A7C")]
	private void ReOpenBtnClick()
	{
	}

	[Token(Token = "0x600AD1E")]
	[Address(RVA = "0x2E75B14", Offset = "0x2E75B14", VA = "0x2E75B14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AD1F")]
	[Address(RVA = "0x2E75B1C", Offset = "0x2E75B1C", VA = "0x2E75B1C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
