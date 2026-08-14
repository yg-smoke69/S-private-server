using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002ABA")]
public class UIRebateCardItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002ABB")]
	private class DescLabelInfo
	{
		[Token(Token = "0x40106A4")]
		[FieldOffset(Offset = "0x8")]
		public string Text;

		[Token(Token = "0x40106A5")]
		[FieldOffset(Offset = "0xC")]
		public Callback OnClick;

		[Token(Token = "0x6011802")]
		[Address(RVA = "0x1E3FF34", Offset = "0x1E3FF34", VA = "0x1E3FF34")]
		public DescLabelInfo()
		{
		}
	}

	[Token(Token = "0x401069C")]
	[FieldOffset(Offset = "0x28")]
	private UIRebateCardItemView m_View;

	[Token(Token = "0x401069D")]
	[FieldOffset(Offset = "0x2C")]
	private RebateCardType m_RebateCardType;

	[Token(Token = "0x401069E")]
	[FieldOffset(Offset = "0x30")]
	private RebateCardInfo m_RebateCardInfo;

	[Token(Token = "0x401069F")]
	[FieldOffset(Offset = "0x34")]
	private UIModelRebateCard m_Model;

	[Token(Token = "0x40106A0")]
	private const string REBATE_CARD_SPRITE_NAME_SUFFIX = "_RebateCardTint";

	[Token(Token = "0x40106A1")]
	[FieldOffset(Offset = "0x38")]
	private bool m_PreferSubscription;

	[Token(Token = "0x40106A2")]
	private const string PRICE_TEMPLATE = "US${0}";

	[Token(Token = "0x40106A3")]
	[FieldOffset(Offset = "0x0")]
	private static Action<PayUtility.SubscriptionGracePeriodReminderInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170012D3")]
	private UILabel RedeemAmountLabel
	{
		[Token(Token = "0x60117EF")]
		[Address(RVA = "0x1AD69A4", Offset = "0x1AD69A4", VA = "0x1AD69A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012D4")]
	private UILabel TotalAmountLabel
	{
		[Token(Token = "0x60117F0")]
		[Address(RVA = "0x1AD6A14", Offset = "0x1AD6A14", VA = "0x1AD6A14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012D5")]
	private UIButton BtnRedeem
	{
		[Token(Token = "0x60117F1")]
		[Address(RVA = "0x1AD6A84", Offset = "0x1AD6A84", VA = "0x1AD6A84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60117DC")]
	[Address(RVA = "0x1AD2488", Offset = "0x1AD2488", VA = "0x1AD2488")]
	public UIRebateCardItemController()
	{
	}

	[Token(Token = "0x60117DD")]
	[Address(RVA = "0x1AD2514", Offset = "0x1AD2514", VA = "0x1AD2514")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60117DE")]
	[Address(RVA = "0x1AD25B8", Offset = "0x1AD25B8", VA = "0x1AD25B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60117DF")]
	[Address(RVA = "0x1AD2B08", Offset = "0x1AD2B08", VA = "0x1AD2B08")]
	private void SetSpriteColorByRebateCardType()
	{
	}

	[Token(Token = "0x60117E0")]
	[Address(RVA = "0x1AD2E58", Offset = "0x1AD2E58", VA = "0x1AD2E58", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60117E1")]
	[Address(RVA = "0x1AD2EE8", Offset = "0x1AD2EE8", VA = "0x1AD2EE8")]
	private void OnBtnRedeemClick()
	{
	}

	[Token(Token = "0x60117E2")]
	[Address(RVA = "0x1AD3698", Offset = "0x1AD3698", VA = "0x1AD3698")]
	private void OnBtnPurchaseClick()
	{
	}

	[Token(Token = "0x60117E3")]
	[Address(RVA = "0x1AD3EAC", Offset = "0x1AD3EAC", VA = "0x1AD3EAC")]
	private void GotoSubscription()
	{
	}

	[Token(Token = "0x60117E4")]
	[Address(RVA = "0x1AD4068", Offset = "0x1AD4068", VA = "0x1AD4068")]
	private void SetStaticData_Descriptions(RebateCardData rebateCardData)
	{
	}

	[Token(Token = "0x60117E5")]
	[Address(RVA = "0x1AD52E8", Offset = "0x1AD52E8", VA = "0x1AD52E8")]
	private void ToggleByExtraReward(RebateCardData rebateCardData)
	{
	}

	[Token(Token = "0x60117E6")]
	[Address(RVA = "0x1AD5344", Offset = "0x1AD5344", VA = "0x1AD5344")]
	private void OnExtraRewardClick()
	{
	}

	[Token(Token = "0x60117E7")]
	[Address(RVA = "0x1AD5660", Offset = "0x1AD5660", VA = "0x1AD5660")]
	private void OnSubscriptionToggleBoxClick()
	{
	}

	[Token(Token = "0x60117E8")]
	[Address(RVA = "0x1AD2A4C", Offset = "0x1AD2A4C", VA = "0x1AD2A4C")]
	private void SyncSubscriptionToggleStatus()
	{
	}

	[Token(Token = "0x60117E9")]
	[Address(RVA = "0x1AD5AE4", Offset = "0x1AD5AE4", VA = "0x1AD5AE4")]
	private void OnSubscriptionHintButtonClick()
	{
	}

	[Token(Token = "0x60117EA")]
	[Address(RVA = "0x1AD5DC4", Offset = "0x1AD5DC4", VA = "0x1AD5DC4")]
	private void OnGracePeriodButtonClick()
	{
	}

	[Token(Token = "0x60117EB")]
	[Address(RVA = "0x1AD5EC8", Offset = "0x1AD5EC8", VA = "0x1AD5EC8")]
	private void OnFixOnHoldButtonClick()
	{
	}

	[Token(Token = "0x60117EC")]
	[Address(RVA = "0x1AD5FCC", Offset = "0x1AD5FCC", VA = "0x1AD5FCC")]
	private string GetSKinWeaponPropDesc(uint _rewardId)
	{
		return null;
	}

	[Token(Token = "0x60117ED")]
	[Address(RVA = "0x1AD64F0", Offset = "0x1AD64F0", VA = "0x1AD64F0")]
	private string GetPropMark(int num)
	{
		return null;
	}

	[Token(Token = "0x60117EE")]
	[Address(RVA = "0x1AD66B4", Offset = "0x1AD66B4", VA = "0x1AD66B4")]
	private void OnHelpBtnClick()
	{
	}

	[Token(Token = "0x60117F2")]
	[Address(RVA = "0x1AD6AF4", Offset = "0x1AD6AF4", VA = "0x1AD6AF4")]
	private UISprite RebateCardSprite(RebateCardType rebateCardType)
	{
		return null;
	}

	[Token(Token = "0x60117F3")]
	[Address(RVA = "0x1AD6BA0", Offset = "0x1AD6BA0", VA = "0x1AD6BA0")]
	private void SetStaticData(RebateCardData rebateCardData)
	{
	}

	[Token(Token = "0x60117F4")]
	[Address(RVA = "0x1AD7104", Offset = "0x1AD7104", VA = "0x1AD7104")]
	public void SetDynamicData(RebateCardType rebateCardType)
	{
	}

	[Token(Token = "0x60117F5")]
	[Address(RVA = "0x1AD709C", Offset = "0x1AD709C", VA = "0x1AD709C")]
	private void UpdatePrice(RebateCardData data)
	{
	}

	[Token(Token = "0x60117F6")]
	[Address(RVA = "0x1AD7868", Offset = "0x1AD7868", VA = "0x1AD7868")]
	private void UpdateSubscription(RebateCardData data)
	{
	}

	[Token(Token = "0x60117F7")]
	[Address(RVA = "0x1AD3D34", Offset = "0x1AD3D34", VA = "0x1AD3D34")]
	private bool IsInGracePeriod()
	{
		return default(bool);
	}

	[Token(Token = "0x60117F8")]
	[Address(RVA = "0x1AD8448", Offset = "0x1AD8448", VA = "0x1AD8448")]
	private bool OnHold()
	{
		return default(bool);
	}

	[Token(Token = "0x60117F9")]
	[Address(RVA = "0x1AD82E0", Offset = "0x1AD82E0", VA = "0x1AD82E0")]
	private void UpdateSubscriptionBonus()
	{
	}

	[Token(Token = "0x60117FA")]
	[Address(RVA = "0x1AD56D4", Offset = "0x1AD56D4", VA = "0x1AD56D4")]
	private void UpdatePriceLabel()
	{
	}

	[Token(Token = "0x60117FB")]
	[Address(RVA = "0x1AD8118", Offset = "0x1AD8118", VA = "0x1AD8118")]
	private void UpdatePurchaseButton()
	{
	}

	[Token(Token = "0x60117FC")]
	[Address(RVA = "0x1AD85C0", Offset = "0x1AD85C0", VA = "0x1AD85C0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60117FD")]
	[Address(RVA = "0x1AD8654", Offset = "0x1AD8654", VA = "0x1AD8654", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60117FE")]
	[Address(RVA = "0x1AD87D8", Offset = "0x1AD87D8", VA = "0x1AD87D8")]
	private static void _003COnBtnRedeemClick_003Em__0(PayUtility.SubscriptionGracePeriodReminderInfo info)
	{
	}

	[Token(Token = "0x60117FF")]
	[Address(RVA = "0x1AD8890", Offset = "0x1AD8890", VA = "0x1AD8890")]
	private void _003COnBtnRedeemClick_003Em__1(PayUtility.SubscriptionGracePeriodReminderInfo info)
	{
	}

	[Token(Token = "0x6011800")]
	[Address(RVA = "0x1AD88EC", Offset = "0x1AD88EC", VA = "0x1AD88EC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011801")]
	[Address(RVA = "0x1AD88F4", Offset = "0x1AD88F4", VA = "0x1AD88F4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
