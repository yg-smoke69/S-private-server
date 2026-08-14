using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A32")]
public class UIPaymentMemberShipController : UIPaymentController.PaymentTabContentController, _Attribute
{
	[Token(Token = "0x2002A33")]
	public enum UIPaymentMemberShipPageType
	{
		[Token(Token = "0x4010389")]
		None,
		[Token(Token = "0x401038A")]
		Membership,
		[Token(Token = "0x401038B")]
		CheckIn
	}

	[Token(Token = "0x4010382")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentMemberShipView m_View;

	[Token(Token = "0x4010383")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMemberShip m_ModelMemberShip;

	[Token(Token = "0x4010384")]
	[FieldOffset(Offset = "0x30")]
	private UIMemberShipItemController m_MonthCardController;

	[Token(Token = "0x4010385")]
	[FieldOffset(Offset = "0x34")]
	private UIMemberShipItemController m_WeekCardController;

	[Token(Token = "0x4010386")]
	[FieldOffset(Offset = "0x38")]
	private UIMemberShipCheckInController m_CheckInController;

	[Token(Token = "0x4010387")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_FirstRefreshContent;

	[Token(Token = "0x6011142")]
	[Address(RVA = "0x29D8A94", Offset = "0x29D8A94", VA = "0x29D8A94")]
	public UIPaymentMemberShipController()
	{
	}

	[Token(Token = "0x6011143")]
	[Address(RVA = "0x29D8AA4", Offset = "0x29D8AA4", VA = "0x29D8AA4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011144")]
	[Address(RVA = "0x29D8B48", Offset = "0x29D8B48", VA = "0x29D8B48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011145")]
	[Address(RVA = "0x29D9018", Offset = "0x29D9018", VA = "0x29D9018", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011146")]
	[Address(RVA = "0x29D919C", Offset = "0x29D919C", VA = "0x29D919C", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x6011147")]
	[Address(RVA = "0x29D98C4", Offset = "0x29D98C4", VA = "0x29D98C4")]
	private void InitView()
	{
	}

	[Token(Token = "0x6011148")]
	[Address(RVA = "0x29D93C0", Offset = "0x29D93C0", VA = "0x29D93C0")]
	private void UpdateRebateCardItem()
	{
	}

	[Token(Token = "0x6011149")]
	[Address(RVA = "0x29D9670", Offset = "0x29D9670", VA = "0x29D9670")]
	private void OnCheckInBtnClick()
	{
	}

	[Token(Token = "0x601114A")]
	[Address(RVA = "0x29D9954", Offset = "0x29D9954", VA = "0x29D9954")]
	private void OnMemberShipBtnClick()
	{
	}

	[Token(Token = "0x601114B")]
	[Address(RVA = "0x29D9B18", Offset = "0x29D9B18", VA = "0x29D9B18")]
	private void OnSVIPClick()
	{
	}

	[Token(Token = "0x601114C")]
	[Address(RVA = "0x29D9D68", Offset = "0x29D9D68", VA = "0x29D9D68")]
	private void OnRuleBtnClick()
	{
	}

	[Token(Token = "0x601114D")]
	[Address(RVA = "0x29D9E78", Offset = "0x29D9E78", VA = "0x29D9E78")]
	private void GotoPurchasePage(object[] obj)
	{
	}

	[Token(Token = "0x601114E")]
	[Address(RVA = "0x29D9F74", Offset = "0x29D9F74", VA = "0x29D9F74", Slot = "35")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601114F")]
	[Address(RVA = "0x29DA008", Offset = "0x29DA008", VA = "0x29DA008", Slot = "34")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011150")]
	[Address(RVA = "0x29DA0C8", Offset = "0x29DA0C8", VA = "0x29DA0C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011151")]
	[Address(RVA = "0x29DA0D0", Offset = "0x29DA0D0", VA = "0x29DA0D0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6011152")]
	[Address(RVA = "0x29DA0D8", Offset = "0x29DA0D8", VA = "0x29DA0D8")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
