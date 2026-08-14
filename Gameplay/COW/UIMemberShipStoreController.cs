using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029C5")]
public class UIMemberShipStoreController : UIBaseController, _Attribute
{
	[Token(Token = "0x40100F8")]
	[FieldOffset(Offset = "0x28")]
	private List<UIMemberShipStoreItemController> m_ItemList;

	[Token(Token = "0x40100F9")]
	[FieldOffset(Offset = "0x2C")]
	private UIMemberShipStoreView m_View;

	[Token(Token = "0x40100FA")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMemberShip m_Model;

	[Token(Token = "0x6010CBD")]
	[Address(RVA = "0x1302D78", Offset = "0x1302D78", VA = "0x1302D78")]
	public UIMemberShipStoreController()
	{
	}

	[Token(Token = "0x6010CBE")]
	[Address(RVA = "0x1302E30", Offset = "0x1302E30", VA = "0x1302E30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010CBF")]
	[Address(RVA = "0x1302ED4", Offset = "0x1302ED4", VA = "0x1302ED4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010CC0")]
	[Address(RVA = "0x130304C", Offset = "0x130304C", VA = "0x130304C")]
	private void InitItemList()
	{
	}

	[Token(Token = "0x6010CC1")]
	[Address(RVA = "0x13031F4", Offset = "0x13031F4", VA = "0x13031F4")]
	public void RefreshViewData()
	{
	}

	[Token(Token = "0x6010CC2")]
	[Address(RVA = "0x1303EBC", Offset = "0x1303EBC", VA = "0x1303EBC")]
	private void InitStoreItem()
	{
	}

	[Token(Token = "0x6010CC3")]
	[Address(RVA = "0x1304040", Offset = "0x1304040", VA = "0x1304040", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010CC4")]
	[Address(RVA = "0x13040C8", Offset = "0x13040C8", VA = "0x13040C8", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010CC5")]
	[Address(RVA = "0x13041AC", Offset = "0x13041AC", VA = "0x13041AC", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010CC6")]
	[Address(RVA = "0x1304240", Offset = "0x1304240", VA = "0x1304240")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010CC7")]
	[Address(RVA = "0x1304248", Offset = "0x1304248", VA = "0x1304248")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
