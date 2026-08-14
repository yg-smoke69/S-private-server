using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A3A")]
public class UIPaymentSubscriptionHubController : UIPaymentController.PaymentTabContentController, _Attribute
{
	[Token(Token = "0x2002A3B")]
	public enum DisplayType
	{
		[Token(Token = "0x40103B6")]
		None,
		[Token(Token = "0x40103B7")]
		RebateCard,
		[Token(Token = "0x40103B8")]
		ElitePass,
		[Token(Token = "0x40103B9")]
		Bundle
	}

	[Token(Token = "0x2002A3C")]
	public struct DisplayInfo
	{
		[Token(Token = "0x40103BA")]
		[FieldOffset(Offset = "0x0")]
		public DisplayType Type;

		[Token(Token = "0x40103BB")]
		[FieldOffset(Offset = "0x4")]
		public int BundleID;
	}

	[Token(Token = "0x40103AE")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentSubscriptionHubView m_View;

	[Token(Token = "0x40103AF")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelPayment m_Payment;

	[Token(Token = "0x40103B0")]
	[FieldOffset(Offset = "0x30")]
	private UIModelRebateCard m_RebateCard;

	[Token(Token = "0x40103B1")]
	[FieldOffset(Offset = "0x34")]
	private UIModelElitePass m_ElitePass;

	[Token(Token = "0x40103B2")]
	[FieldOffset(Offset = "0x38")]
	private UIModelMemberShip m_ModelMembership;

	[Token(Token = "0x40103B3")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIPaymentSubscriptionItemController> m_Items;

	[Token(Token = "0x40103B4")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, UIPaymentSubscriptionBaseController> m_Contents;

	[Token(Token = "0x60111CE")]
	[Address(RVA = "0x29E7CE8", Offset = "0x29E7CE8", VA = "0x29E7CE8")]
	public UIPaymentSubscriptionHubController()
	{
	}

	[Token(Token = "0x60111CF")]
	[Address(RVA = "0x29E7DA8", Offset = "0x29E7DA8", VA = "0x29E7DA8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60111D0")]
	[Address(RVA = "0x29E7E50", Offset = "0x29E7E50", VA = "0x29E7E50", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60111D1")]
	[Address(RVA = "0x29E8134", Offset = "0x29E8134", VA = "0x29E8134", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60111D2")]
	[Address(RVA = "0x29E8298", Offset = "0x29E8298", VA = "0x29E8298")]
	private void ClearSubscriptionUIs()
	{
	}

	[Token(Token = "0x60111D3")]
	[Address(RVA = "0x29E869C", Offset = "0x29E869C", VA = "0x29E869C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60111D4")]
	[Address(RVA = "0x29E8724", Offset = "0x29E8724", VA = "0x29E8724", Slot = "35")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60111D5")]
	[Address(RVA = "0x29E880C", Offset = "0x29E880C", VA = "0x29E880C", Slot = "34")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60111D6")]
	[Address(RVA = "0x29E8F88", Offset = "0x29E8F88", VA = "0x29E8F88", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x60111D7")]
	[Address(RVA = "0x29E8FE8", Offset = "0x29E8FE8", VA = "0x29E8FE8", Slot = "31")]
	public override void GotoByParams(UIPaymentController.PaymentGotoParams parameters)
	{
	}

	[Token(Token = "0x60111D8")]
	[Address(RVA = "0x29E8914", Offset = "0x29E8914", VA = "0x29E8914")]
	private void UpdateSubscriptionItems()
	{
	}

	[Token(Token = "0x60111D9")]
	[Address(RVA = "0x29E992C", Offset = "0x29E992C", VA = "0x29E992C")]
	private void OnSubscriptionGoto(object[] parameters)
	{
	}

	[Token(Token = "0x60111DA")]
	[Address(RVA = "0x29E9248", Offset = "0x29E9248", VA = "0x29E9248")]
	private void Goto(DisplayInfo info)
	{
	}

	[Token(Token = "0x60111DB")]
	[Address(RVA = "0x29E9B00", Offset = "0x29E9B00", VA = "0x29E9B00")]
	private UIPaymentSubscriptionBaseController ContentUI(DisplayType displayType)
	{
		return null;
	}

	[Token(Token = "0x60111DC")]
	[Address(RVA = "0x29E9D2C", Offset = "0x29E9D2C", VA = "0x29E9D2C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60111DD")]
	[Address(RVA = "0x29E9D34", Offset = "0x29E9D34", VA = "0x29E9D34")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60111DE")]
	[Address(RVA = "0x29E9D3C", Offset = "0x29E9D3C", VA = "0x29E9D3C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60111DF")]
	[Address(RVA = "0x29E9D44", Offset = "0x29E9D44", VA = "0x29E9D44")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	[Token(Token = "0x60111E0")]
	[Address(RVA = "0x29E9D4C", Offset = "0x29E9D4C", VA = "0x29E9D4C")]
	public void _003C_003EiFixBaseProxy_GotoByParams(UIPaymentController.PaymentGotoParams P0)
	{
	}
}
