using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029C1")]
public class UIMemberShipReissueItemController : UIEasyListItemController
{
	[Token(Token = "0x40100EC")]
	private const string TIMEFORMAT = "{0}.{1}";

	[Token(Token = "0x40100ED")]
	[FieldOffset(Offset = "0x38")]
	private UIMemberShipReissueItemView m_View;

	[Token(Token = "0x40100EE")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelMemberShip m_ModelMembership;

	[Token(Token = "0x40100EF")]
	[FieldOffset(Offset = "0x40")]
	private ClientReissueItemData m_Data;

	[Token(Token = "0x40100F0")]
	[FieldOffset(Offset = "0x44")]
	private List<UIMemberShipReissueMiniItemController> m_ItemList;

	[Token(Token = "0x6010CA8")]
	[Address(RVA = "0x12FD9C4", Offset = "0x12FD9C4", VA = "0x12FD9C4")]
	public UIMemberShipReissueItemController()
	{
	}

	[Token(Token = "0x6010CA9")]
	[Address(RVA = "0x12FDA50", Offset = "0x12FDA50", VA = "0x12FDA50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010CAA")]
	[Address(RVA = "0x12FDAF4", Offset = "0x12FDAF4", VA = "0x12FDAF4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010CAB")]
	[Address(RVA = "0x12FDCC0", Offset = "0x12FDCC0", VA = "0x12FDCC0")]
	private void OnReissueBtnClick()
	{
	}

	[Token(Token = "0x6010CAC")]
	[Address(RVA = "0x12FDF88", Offset = "0x12FDF88", VA = "0x12FDF88", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6010CAD")]
	[Address(RVA = "0x12FEC6C", Offset = "0x12FEC6C", VA = "0x12FEC6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
