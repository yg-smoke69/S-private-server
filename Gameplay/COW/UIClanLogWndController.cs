using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200254B")]
public class UIClanLogWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E70D")]
	[FieldOffset(Offset = "0x48")]
	private UIClanLogWndView m_View;

	[Token(Token = "0x400E70E")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIClanLogWndItemController> m_Items;

	[Token(Token = "0x400E70F")]
	[FieldOffset(Offset = "0x50")]
	private Queue<UIClanLogWndItemController> m_ItemPool;

	[Token(Token = "0x600D921")]
	[Address(RVA = "0x2B33BB0", Offset = "0x2B33BB0", VA = "0x2B33BB0")]
	public UIClanLogWndController()
	{
	}

	[Token(Token = "0x600D922")]
	[Address(RVA = "0x2B33C70", Offset = "0x2B33C70", VA = "0x2B33C70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D923")]
	[Address(RVA = "0x2B33D14", Offset = "0x2B33D14", VA = "0x2B33D14", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D924")]
	[Address(RVA = "0x2B33DA8", Offset = "0x2B33DA8", VA = "0x2B33DA8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D925")]
	[Address(RVA = "0x2B3443C", Offset = "0x2B3443C", VA = "0x2B3443C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D926")]
	[Address(RVA = "0x2B34620", Offset = "0x2B34620", VA = "0x2B34620", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D927")]
	[Address(RVA = "0x2B34750", Offset = "0x2B34750", VA = "0x2B34750")]
	public UIClanLogWndItemController GetItem()
	{
		return null;
	}

	[Token(Token = "0x600D928")]
	[Address(RVA = "0x2B34A3C", Offset = "0x2B34A3C", VA = "0x2B34A3C")]
	public void PushItem(UIClanLogWndItemController item)
	{
	}

	[Token(Token = "0x600D929")]
	[Address(RVA = "0x2B33E60", Offset = "0x2B33E60", VA = "0x2B33E60")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600D92A")]
	[Address(RVA = "0x2B34D54", Offset = "0x2B34D54", VA = "0x2B34D54")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D92B")]
	[Address(RVA = "0x2B34D5C", Offset = "0x2B34D5C", VA = "0x2B34D5C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
