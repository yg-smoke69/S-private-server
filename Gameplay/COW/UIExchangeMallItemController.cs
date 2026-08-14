using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021B6")]
public class UIExchangeMallItemController : UIMallItemWidgetController
{
	[Token(Token = "0x400D306")]
	[FieldOffset(Offset = "0x130")]
	protected ExchangeStoreItemDesc m_ExchangeItem;

	[Token(Token = "0x600B3CA")]
	[Address(RVA = "0x19DD760", Offset = "0x19DD760", VA = "0x19DD760")]
	public UIExchangeMallItemController()
	{
	}

	[Token(Token = "0x600B3CB")]
	[Address(RVA = "0x19DE780", Offset = "0x19DE780", VA = "0x19DE780", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B3CC")]
	[Address(RVA = "0x19E6268", Offset = "0x19E6268", VA = "0x19E6268")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B3CD")]
	[Address(RVA = "0x19DDE20", Offset = "0x19DDE20", VA = "0x19DDE20", Slot = "42")]
	protected override void RefreshItemView()
	{
	}

	[Token(Token = "0x600B3CE")]
	[Address(RVA = "0x19E63AC", Offset = "0x19E63AC", VA = "0x19E63AC")]
	private void SetExchangeIcon()
	{
	}

	[Token(Token = "0x600B3CF")]
	[Address(RVA = "0x19E6544", Offset = "0x19E6544", VA = "0x19E6544", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B3D0")]
	[Address(RVA = "0x19E66A8", Offset = "0x19E66A8", VA = "0x19E66A8", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600B3D1")]
	[Address(RVA = "0x19DDB7C", Offset = "0x19DDB7C", VA = "0x19DDB7C", Slot = "43")]
	protected override void ResetState()
	{
	}

	[Token(Token = "0x600B3D2")]
	[Address(RVA = "0x19E630C", Offset = "0x19E630C", VA = "0x19E630C")]
	protected void SetExchangePriceLabel()
	{
	}

	[Token(Token = "0x600B3D3")]
	[Address(RVA = "0x19E670C", Offset = "0x19E670C", VA = "0x19E670C", Slot = "37")]
	protected override void SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B3D4")]
	[Address(RVA = "0x19E695C", Offset = "0x19E695C", VA = "0x19E695C", Slot = "38")]
	protected override void SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B3D5")]
	[Address(RVA = "0x19E6BAC", Offset = "0x19E6BAC", VA = "0x19E6BAC")]
	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	[Token(Token = "0x600B3D6")]
	[Address(RVA = "0x19E6BB4", Offset = "0x19E6BB4", VA = "0x19E6BB4")]
	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	[Token(Token = "0x600B3D7")]
	[Address(RVA = "0x19E6BBC", Offset = "0x19E6BBC", VA = "0x19E6BBC")]
	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B3D8")]
	[Address(RVA = "0x19E6BC4", Offset = "0x19E6BC4", VA = "0x19E6BC4")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600B3D9")]
	[Address(RVA = "0x19E6BCC", Offset = "0x19E6BCC", VA = "0x19E6BCC")]
	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600B3DA")]
	[Address(RVA = "0x19E6BD4", Offset = "0x19E6BD4", VA = "0x19E6BD4")]
	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B3DB")]
	[Address(RVA = "0x19E6BDC", Offset = "0x19E6BDC", VA = "0x19E6BDC")]
	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}
}
