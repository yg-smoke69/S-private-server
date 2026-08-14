using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021BB")]
public class UIExchangeMallRankItemController : UIMallItemWidgetController
{
	[Token(Token = "0x400D315")]
	[FieldOffset(Offset = "0x130")]
	protected ExchangeStoreItemDesc m_ExchangeItem;

	[Token(Token = "0x400D316")]
	[FieldOffset(Offset = "0x134")]
	private Dictionary<int, bool> m_ChildTransformActiveDict;

	[Token(Token = "0x400D317")]
	[FieldOffset(Offset = "0x138")]
	private bool m_isFirstTimeInit;

	[Token(Token = "0x600B40B")]
	[Address(RVA = "0x19E9F88", Offset = "0x19E9F88", VA = "0x19E9F88")]
	public UIExchangeMallRankItemController()
	{
	}

	[Token(Token = "0x600B40C")]
	[Address(RVA = "0x19EA01C", Offset = "0x19EA01C", VA = "0x19EA01C", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B40D")]
	[Address(RVA = "0x19EA078", Offset = "0x19EA078", VA = "0x19EA078")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B40E")]
	[Address(RVA = "0x19EA11C", Offset = "0x19EA11C", VA = "0x19EA11C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B40F")]
	[Address(RVA = "0x19EA46C", Offset = "0x19EA46C", VA = "0x19EA46C")]
	public void SetWidgetIgnoreBound(bool value)
	{
	}

	[Token(Token = "0x600B410")]
	[Address(RVA = "0x19EA2CC", Offset = "0x19EA2CC", VA = "0x19EA2CC")]
	private void ShowObject()
	{
	}

	[Token(Token = "0x600B411")]
	[Address(RVA = "0x19EA39C", Offset = "0x19EA39C", VA = "0x19EA39C")]
	private void HideObject()
	{
	}

	[Token(Token = "0x600B412")]
	[Address(RVA = "0x19EA4F8", Offset = "0x19EA4F8", VA = "0x19EA4F8")]
	private void HideAllChild()
	{
	}

	[Token(Token = "0x600B413")]
	[Address(RVA = "0x19EA6D8", Offset = "0x19EA6D8", VA = "0x19EA6D8")]
	private void InitTransformChildActiveProperty()
	{
	}

	[Token(Token = "0x600B414")]
	[Address(RVA = "0x19EAA28", Offset = "0x19EAA28", VA = "0x19EAA28", Slot = "42")]
	protected override void RefreshItemView()
	{
	}

	[Token(Token = "0x600B415")]
	[Address(RVA = "0x19EB2E0", Offset = "0x19EB2E0", VA = "0x19EB2E0", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600B416")]
	[Address(RVA = "0x19EB468", Offset = "0x19EB468", VA = "0x19EB468", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600B417")]
	[Address(RVA = "0x19EB4CC", Offset = "0x19EB4CC", VA = "0x19EB4CC", Slot = "43")]
	protected override void ResetState()
	{
	}

	[Token(Token = "0x600B418")]
	[Address(RVA = "0x19EAE5C", Offset = "0x19EAE5C", VA = "0x19EAE5C")]
	protected void SetExchangePriceLabel()
	{
	}

	[Token(Token = "0x600B419")]
	[Address(RVA = "0x19EB580", Offset = "0x19EB580", VA = "0x19EB580", Slot = "37")]
	protected override void SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B41A")]
	[Address(RVA = "0x19EAEFC", Offset = "0x19EAEFC", VA = "0x19EAEFC")]
	private void SetExchangeIcon()
	{
	}

	[Token(Token = "0x600B41B")]
	[Address(RVA = "0x19EB094", Offset = "0x19EB094", VA = "0x19EB094")]
	private void SetRankIcon()
	{
	}

	[Token(Token = "0x600B41C")]
	[Address(RVA = "0x19EB5E4", Offset = "0x19EB5E4", VA = "0x19EB5E4", Slot = "38")]
	protected override void SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B41D")]
	[Address(RVA = "0x19EB638", Offset = "0x19EB638", VA = "0x19EB638", Slot = "46")]
	protected override void SetPreviewTitle()
	{
	}

	[Token(Token = "0x600B41E")]
	[Address(RVA = "0x19EB68C", Offset = "0x19EB68C", VA = "0x19EB68C")]
	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B41F")]
	[Address(RVA = "0x19EB694", Offset = "0x19EB694", VA = "0x19EB694")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600B420")]
	[Address(RVA = "0x19EB69C", Offset = "0x19EB69C", VA = "0x19EB69C")]
	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	[Token(Token = "0x600B421")]
	[Address(RVA = "0x19EB6A4", Offset = "0x19EB6A4", VA = "0x19EB6A4")]
	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600B422")]
	[Address(RVA = "0x19EB6AC", Offset = "0x19EB6AC", VA = "0x19EB6AC")]
	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600B423")]
	[Address(RVA = "0x19EB6B4", Offset = "0x19EB6B4", VA = "0x19EB6B4")]
	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	[Token(Token = "0x600B424")]
	[Address(RVA = "0x19EB6BC", Offset = "0x19EB6BC", VA = "0x19EB6BC")]
	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B425")]
	[Address(RVA = "0x19EB6C4", Offset = "0x19EB6C4", VA = "0x19EB6C4")]
	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B426")]
	[Address(RVA = "0x19EB6CC", Offset = "0x19EB6CC", VA = "0x19EB6CC")]
	public void _003C_003EiFixBaseProxy_SetPreviewTitle()
	{
	}
}
