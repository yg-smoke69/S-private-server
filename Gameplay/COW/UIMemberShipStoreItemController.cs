using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20029C6")]
public class UIMemberShipStoreItemController : UIBaseController
{
	[Token(Token = "0x40100FB")]
	[FieldOffset(Offset = "0x28")]
	private UIMemberShipStoreItemView m_View;

	[Token(Token = "0x40100FC")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMemberShip m_Model;

	[Token(Token = "0x40100FD")]
	[FieldOffset(Offset = "0x30")]
	private VipCardStoreInfo m_Info;

	[Token(Token = "0x40100FE")]
	[FieldOffset(Offset = "0x34")]
	private UIStandardItemMAXBController m_StandardItemCtrl;

	[Token(Token = "0x6010CC8")]
	[Address(RVA = "0x1304250", Offset = "0x1304250", VA = "0x1304250")]
	public UIMemberShipStoreItemController()
	{
	}

	[Token(Token = "0x6010CC9")]
	[Address(RVA = "0x13042D4", Offset = "0x13042D4", VA = "0x13042D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010CCA")]
	[Address(RVA = "0x1304378", Offset = "0x1304378", VA = "0x1304378", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010CCB")]
	[Address(RVA = "0x13045DC", Offset = "0x13045DC", VA = "0x13045DC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010CCC")]
	[Address(RVA = "0x1303578", Offset = "0x1303578", VA = "0x1303578")]
	public void SetViewData(VipCardStoreInfo data)
	{
	}

	[Token(Token = "0x6010CCD")]
	[Address(RVA = "0x1304640", Offset = "0x1304640", VA = "0x1304640")]
	private void OnBuyBtnClick()
	{
	}

	[Token(Token = "0x6010CCE")]
	[Address(RVA = "0x13048BC", Offset = "0x13048BC", VA = "0x13048BC")]
	private void ShowPurchaseConfirmWindow()
	{
	}

	[Token(Token = "0x6010CCF")]
	[Address(RVA = "0x1304D20", Offset = "0x1304D20", VA = "0x1304D20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010CD0")]
	[Address(RVA = "0x1304D28", Offset = "0x1304D28", VA = "0x1304D28")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
