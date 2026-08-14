using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021F4")]
public class UIMallRecommendItemController : UIMallItemBaseController
{
	[Token(Token = "0x400D49F")]
	[FieldOffset(Offset = "0x12C")]
	private UIMallRecommendItemView m_View;

	[Token(Token = "0x400D4A0")]
	[FieldOffset(Offset = "0x130")]
	private StoreDesc m_storeDesc;

	[Token(Token = "0x600B6EB")]
	[Address(RVA = "0x2269954", Offset = "0x2269954", VA = "0x2269954")]
	public UIMallRecommendItemController()
	{
	}

	[Token(Token = "0x600B6EC")]
	[Address(RVA = "0x2269970", Offset = "0x2269970", VA = "0x2269970")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B6ED")]
	[Address(RVA = "0x2269A14", Offset = "0x2269A14", VA = "0x2269A14", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B6EE")]
	[Address(RVA = "0x2269C50", Offset = "0x2269C50", VA = "0x2269C50", Slot = "33")]
	public override void OnItemBtnClick2()
	{
	}

	[Token(Token = "0x600B6EF")]
	[Address(RVA = "0x2269E34", Offset = "0x2269E34", VA = "0x2269E34", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600B6F0")]
	[Address(RVA = "0x2269F5C", Offset = "0x2269F5C", VA = "0x2269F5C", Slot = "37")]
	protected override void SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B6F1")]
	[Address(RVA = "0x226A1A8", Offset = "0x226A1A8", VA = "0x226A1A8", Slot = "39")]
	protected override void OnClothItemClick()
	{
	}

	[Token(Token = "0x600B6F2")]
	[Address(RVA = "0x226A30C", Offset = "0x226A30C", VA = "0x226A30C", Slot = "40")]
	public override void SetHighLightBGState(bool show)
	{
	}

	[Token(Token = "0x600B6F3")]
	[Address(RVA = "0x226A3A4", Offset = "0x226A3A4", VA = "0x226A3A4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B6F4")]
	[Address(RVA = "0x226A514", Offset = "0x226A514", VA = "0x226A514")]
	public void RefreshData(StoreDesc info, int data_index)
	{
	}

	[Token(Token = "0x600B6F5")]
	[Address(RVA = "0x226A934", Offset = "0x226A934", VA = "0x226A934")]
	private void ShowDiscountTag()
	{
	}

	[Token(Token = "0x600B6F6")]
	[Address(RVA = "0x226AB8C", Offset = "0x226AB8C", VA = "0x226AB8C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B6F7")]
	[Address(RVA = "0x226AB90", Offset = "0x226AB90", VA = "0x226AB90")]
	public new void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}

	[Token(Token = "0x600B6F8")]
	[Address(RVA = "0x226AB94", Offset = "0x226AB94", VA = "0x226AB94")]
	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600B6F9")]
	[Address(RVA = "0x226AB98", Offset = "0x226AB98", VA = "0x226AB98")]
	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B6FA")]
	[Address(RVA = "0x226AB9C", Offset = "0x226AB9C", VA = "0x226AB9C")]
	public void _003C_003EiFixBaseProxy_OnClothItemClick()
	{
	}

	[Token(Token = "0x600B6FB")]
	[Address(RVA = "0x226ABA0", Offset = "0x226ABA0", VA = "0x226ABA0")]
	public void _003C_003EiFixBaseProxy_SetHighLightBGState(bool P0)
	{
	}

	[Token(Token = "0x600B6FC")]
	[Address(RVA = "0x226ABA4", Offset = "0x226ABA4", VA = "0x226ABA4")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
