using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029BB")]
public class UIMemberShipCheckInController : UIBaseController, _Attribute
{
	[Token(Token = "0x40100CC")]
	[FieldOffset(Offset = "0x28")]
	private UIMemberShipCheckInView m_View;

	[Token(Token = "0x40100CD")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMemberShip m_Model;

	[Token(Token = "0x40100CE")]
	[FieldOffset(Offset = "0x30")]
	private UIMemberShipCheckInItemController m_WeekCardCheckInItem;

	[Token(Token = "0x40100CF")]
	[FieldOffset(Offset = "0x34")]
	private UIMemberShipCheckInItemController m_MonthCardCheckInItem;

	[Token(Token = "0x40100D0")]
	[FieldOffset(Offset = "0x38")]
	private UIMemberShipCheckInItemController m_SVIPCardCheckInItem;

	[Token(Token = "0x40100D1")]
	[FieldOffset(Offset = "0x3C")]
	private UIMemberShipStoreController m_StoreCtrl;

	[Token(Token = "0x6010C58")]
	[Address(RVA = "0x269873C", Offset = "0x269873C", VA = "0x269873C")]
	public UIMemberShipCheckInController()
	{
	}

	[Token(Token = "0x6010C59")]
	[Address(RVA = "0x26987C0", Offset = "0x26987C0", VA = "0x26987C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010C5A")]
	[Address(RVA = "0x2698864", Offset = "0x2698864", VA = "0x2698864", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010C5B")]
	[Address(RVA = "0x269935C", Offset = "0x269935C", VA = "0x269935C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010C5C")]
	[Address(RVA = "0x2698DBC", Offset = "0x2698DBC", VA = "0x2698DBC")]
	public void RefreshViewData()
	{
	}

	[Token(Token = "0x6010C5D")]
	[Address(RVA = "0x269A67C", Offset = "0x269A67C", VA = "0x269A67C")]
	private void OnCountDownUpdate()
	{
	}

	[Token(Token = "0x6010C5E")]
	[Address(RVA = "0x269A710", Offset = "0x269A710", VA = "0x269A710")]
	private void OnCountDownEnd()
	{
	}

	[Token(Token = "0x6010C5F")]
	[Address(RVA = "0x269A824", Offset = "0x269A824", VA = "0x269A824")]
	private void OnReissueBtnClick()
	{
	}

	[Token(Token = "0x6010C60")]
	[Address(RVA = "0x269A934", Offset = "0x269A934", VA = "0x269A934")]
	private void OnCheckInBtnClick()
	{
	}

	[Token(Token = "0x6010C61")]
	[Address(RVA = "0x269A9B4", Offset = "0x269A9B4", VA = "0x269A9B4")]
	private void OnRemainTipBtnClick()
	{
	}

	[Token(Token = "0x6010C62")]
	[Address(RVA = "0x269ABFC", Offset = "0x269ABFC", VA = "0x269ABFC", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010C63")]
	[Address(RVA = "0x269ACB0", Offset = "0x269ACB0", VA = "0x269ACB0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010C64")]
	[Address(RVA = "0x269AD44", Offset = "0x269AD44", VA = "0x269AD44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010C65")]
	[Address(RVA = "0x269AD4C", Offset = "0x269AD4C", VA = "0x269AD4C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
