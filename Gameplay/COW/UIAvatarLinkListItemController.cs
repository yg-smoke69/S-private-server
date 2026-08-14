using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024B4")]
public class UIAvatarLinkListItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400E39D")]
	[FieldOffset(Offset = "0x38")]
	private UIAvatarLinkListItemView m_View;

	[Token(Token = "0x400E39E")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_LinkAvatarID;

	[Token(Token = "0x600D279")]
	[Address(RVA = "0x2A97CB4", Offset = "0x2A97CB4", VA = "0x2A97CB4")]
	public UIAvatarLinkListItemController()
	{
	}

	[Token(Token = "0x600D27A")]
	[Address(RVA = "0x2A97CBC", Offset = "0x2A97CBC", VA = "0x2A97CBC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D27B")]
	[Address(RVA = "0x2A97D64", Offset = "0x2A97D64", VA = "0x2A97D64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D27C")]
	[Address(RVA = "0x2A97FDC", Offset = "0x2A97FDC", VA = "0x2A97FDC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D27D")]
	[Address(RVA = "0x2A98CBC", Offset = "0x2A98CBC", VA = "0x2A98CBC", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D27E")]
	[Address(RVA = "0x2A98EC0", Offset = "0x2A98EC0", VA = "0x2A98EC0", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600D27F")]
	[Address(RVA = "0x2A98FB8", Offset = "0x2A98FB8", VA = "0x2A98FB8", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D280")]
	[Address(RVA = "0x2A99250", Offset = "0x2A99250", VA = "0x2A99250", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D281")]
	[Address(RVA = "0x2A98100", Offset = "0x2A98100", VA = "0x2A98100")]
	private void LoadStaticContent()
	{
	}

	[Token(Token = "0x600D282")]
	[Address(RVA = "0x2A986AC", Offset = "0x2A986AC", VA = "0x2A986AC")]
	private void RefreshDynamicContent()
	{
	}

	[Token(Token = "0x600D283")]
	[Address(RVA = "0x2A97EA8", Offset = "0x2A97EA8", VA = "0x2A97EA8")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x600D284")]
	[Address(RVA = "0x2A992E4", Offset = "0x2A992E4", VA = "0x2A992E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D285")]
	[Address(RVA = "0x2A992EC", Offset = "0x2A992EC", VA = "0x2A992EC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D286")]
	[Address(RVA = "0x2A992F4", Offset = "0x2A992F4", VA = "0x2A992F4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
