using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200254A")]
public class UIClanLogController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E70A")]
	[FieldOffset(Offset = "0x28")]
	private UIClanLogView m_View;

	[Token(Token = "0x400E70B")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIClanLogItemView> m_Items;

	[Token(Token = "0x400E70C")]
	[FieldOffset(Offset = "0x30")]
	private Queue<UIClanLogItemView> m_ItemPool;

	[Token(Token = "0x600D915")]
	[Address(RVA = "0x2B323C0", Offset = "0x2B323C0", VA = "0x2B323C0")]
	public UIClanLogController()
	{
	}

	[Token(Token = "0x600D916")]
	[Address(RVA = "0x2B324AC", Offset = "0x2B324AC", VA = "0x2B324AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D917")]
	[Address(RVA = "0x2B32550", Offset = "0x2B32550", VA = "0x2B32550", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D918")]
	[Address(RVA = "0x2B325E4", Offset = "0x2B325E4", VA = "0x2B325E4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D919")]
	[Address(RVA = "0x2B32C78", Offset = "0x2B32C78", VA = "0x2B32C78", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D91A")]
	[Address(RVA = "0x2B3319C", Offset = "0x2B3319C", VA = "0x2B3319C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D91B")]
	[Address(RVA = "0x2B32E64", Offset = "0x2B32E64", VA = "0x2B32E64")]
	private void PrepareItems()
	{
	}

	[Token(Token = "0x600D91C")]
	[Address(RVA = "0x2B332CC", Offset = "0x2B332CC", VA = "0x2B332CC")]
	public UIClanLogItemView GetItem()
	{
		return null;
	}

	[Token(Token = "0x600D91D")]
	[Address(RVA = "0x2B33604", Offset = "0x2B33604", VA = "0x2B33604")]
	public void PushItem(UIClanLogItemView item)
	{
	}

	[Token(Token = "0x600D91E")]
	[Address(RVA = "0x2B3269C", Offset = "0x2B3269C", VA = "0x2B3269C")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600D91F")]
	[Address(RVA = "0x2B338CC", Offset = "0x2B338CC", VA = "0x2B338CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D920")]
	[Address(RVA = "0x2B338D4", Offset = "0x2B338D4", VA = "0x2B338D4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
