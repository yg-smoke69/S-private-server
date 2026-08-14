using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002A3D")]
public abstract class UIPaymentSubscriptionBaseController : UIBaseController, _Attribute
{
	[Token(Token = "0x40103BC")]
	[FieldOffset(Offset = "0x28")]
	private UIModelPayment _003CPayment_003Ek__BackingField;

	[Token(Token = "0x40103BD")]
	[FieldOffset(Offset = "0x2C")]
	private UIPaymentSubscriptionHubController.DisplayInfo m_DisplayInfo;

	[Token(Token = "0x40103BE")]
	[FieldOffset(Offset = "0x34")]
	private SubscribeStoreDesc _003CSubscriptionDescription_003Ek__BackingField;

	[Token(Token = "0x40103BF")]
	[FieldOffset(Offset = "0x38")]
	private AccountSubscription _003CSubscriptionStatus_003Ek__BackingField;

	[Token(Token = "0x1700129C")]
	protected UIModelPayment Payment
	{
		[Token(Token = "0x60111E2")]
		[Address(RVA = "0x29DFDA0", Offset = "0x29DFDA0", VA = "0x29DFDA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60111E3")]
		[Address(RVA = "0x29DFDA8", Offset = "0x29DFDA8", VA = "0x29DFDA8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700129D")]
	public UIPaymentSubscriptionHubController.DisplayInfo DisplayInfo
	{
		[Token(Token = "0x60111E4")]
		[Address(RVA = "0x29DFDB0", Offset = "0x29DFDB0", VA = "0x29DFDB0")]
		get
		{
			return default(UIPaymentSubscriptionHubController.DisplayInfo);
		}
		[Token(Token = "0x60111E5")]
		[Address(RVA = "0x29DFE1C", Offset = "0x29DFE1C", VA = "0x29DFE1C")]
		set
		{
		}
	}

	[Token(Token = "0x1700129E")]
	protected SubscribeStoreDesc SubscriptionDescription
	{
		[Token(Token = "0x60111E6")]
		[Address(RVA = "0x29DFF28", Offset = "0x29DFF28", VA = "0x29DFF28")]
		get
		{
			return null;
		}
		[Token(Token = "0x60111E7")]
		[Address(RVA = "0x29DFF18", Offset = "0x29DFF18", VA = "0x29DFF18")]
		private set
		{
		}
	}

	[Token(Token = "0x1700129F")]
	protected AccountSubscription SubscriptionStatus
	{
		[Token(Token = "0x60111E8")]
		[Address(RVA = "0x29DFF30", Offset = "0x29DFF30", VA = "0x29DFF30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60111E9")]
		[Address(RVA = "0x29DFF20", Offset = "0x29DFF20", VA = "0x29DFF20")]
		private set
		{
		}
	}

	[Token(Token = "0x170012A0")]
	protected abstract UILabel PriceLabel
	{
		[Token(Token = "0x60111EA")]
		get;
	}

	[Token(Token = "0x170012A1")]
	protected abstract UILabel PeriodLabel
	{
		[Token(Token = "0x60111EB")]
		get;
	}

	[Token(Token = "0x170012A2")]
	protected abstract UITable PricingTable
	{
		[Token(Token = "0x60111EC")]
		get;
	}

	[Token(Token = "0x170012A3")]
	protected abstract UILabel SubscribeButtonLabel
	{
		[Token(Token = "0x60111ED")]
		get;
	}

	[Token(Token = "0x170012A4")]
	protected abstract UINetworkTextureExt NetworkTexture
	{
		[Token(Token = "0x60111EE")]
		get;
	}

	[Token(Token = "0x170012A5")]
	protected abstract string NetworkTextureUrl
	{
		[Token(Token = "0x60111EF")]
		get;
	}

	[Token(Token = "0x170012A6")]
	protected abstract GameObject BonusGameObject
	{
		[Token(Token = "0x60111F0")]
		get;
	}

	[Token(Token = "0x170012A7")]
	protected abstract bool BonusAvailable
	{
		[Token(Token = "0x60111F1")]
		get;
	}

	[Token(Token = "0x170012A8")]
	protected abstract UILabel BonusLabel
	{
		[Token(Token = "0x60111F2")]
		get;
	}

	[Token(Token = "0x170012A9")]
	protected abstract int BonusAmount
	{
		[Token(Token = "0x60111F3")]
		get;
	}

	[Token(Token = "0x170012AA")]
	protected abstract UIButton FixOnHoldButton
	{
		[Token(Token = "0x60111F4")]
		get;
	}

	[Token(Token = "0x60111E1")]
	[Address(RVA = "0x29DFD1C", Offset = "0x29DFD1C", VA = "0x29DFD1C")]
	protected UIPaymentSubscriptionBaseController()
	{
	}

	[Token(Token = "0x60111F5")]
	protected abstract GameObject GameObjectForStatus(bool subscribing);

	[Token(Token = "0x60111F6")]
	protected abstract GameObject GameObjectForGracePeriod(bool inGracePeriod);

	[Token(Token = "0x60111F7")]
	protected abstract GameObject GameObjectForOnHold(bool isOnHold);

	[Token(Token = "0x60111F8")]
	[Address(RVA = "0x29DFF38", Offset = "0x29DFF38", VA = "0x29DFF38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60111F9")]
	[Address(RVA = "0x29E008C", Offset = "0x29E008C", VA = "0x29E008C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60111FA")]
	[Address(RVA = "0x29E0110", Offset = "0x29E0110", VA = "0x29E0110", Slot = "47")]
	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60111FB")]
	[Address(RVA = "0x29E01C8", Offset = "0x29E01C8", VA = "0x29E01C8", Slot = "48")]
	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60111FC")]
	[Address(RVA = "0x29E0314", Offset = "0x29E0314", VA = "0x29E0314", Slot = "49")]
	protected virtual void UpdateSubscriptionUI()
	{
	}

	[Token(Token = "0x60111FD")]
	[Address(RVA = "0x29E0570", Offset = "0x29E0570", VA = "0x29E0570", Slot = "50")]
	protected virtual void TryPlayAnim()
	{
	}

	[Token(Token = "0x60111FE")]
	[Address(RVA = "0x29E05C4", Offset = "0x29E05C4", VA = "0x29E05C4", Slot = "51")]
	protected virtual void UpdateSubscriptionPrice(PayItemData csv, PayItemData sdk)
	{
	}

	[Token(Token = "0x60111FF")]
	[Address(RVA = "0x29E0878", Offset = "0x29E0878", VA = "0x29E0878", Slot = "52")]
	protected virtual void UpdateSubscriptionPeriod(PayItemData csv, PayItemData sdk)
	{
	}

	[Token(Token = "0x6011200")]
	[Address(RVA = "0x29E0AB8", Offset = "0x29E0AB8", VA = "0x29E0AB8", Slot = "53")]
	protected virtual void UpdateSubscriptionNetworkTexture()
	{
	}

	[Token(Token = "0x6011201")]
	[Address(RVA = "0x29E0C00", Offset = "0x29E0C00", VA = "0x29E0C00", Slot = "54")]
	protected virtual void UpdateSubscriptionBonus()
	{
	}

	[Token(Token = "0x6011202")]
	[Address(RVA = "0x29E0E0C", Offset = "0x29E0E0C", VA = "0x29E0E0C", Slot = "55")]
	protected virtual void UpdateSubscriptionStatus(PayItemData csv, PayItemData sdk)
	{
	}

	[Token(Token = "0x6011203")]
	[Address(RVA = "0x29E11D4", Offset = "0x29E11D4", VA = "0x29E11D4", Slot = "56")]
	protected virtual void UpdateSubscriptionGracePeriod(PayItemData csv, PayItemData sdk)
	{
	}

	[Token(Token = "0x6011204")]
	[Address(RVA = "0x29E1488", Offset = "0x29E1488", VA = "0x29E1488", Slot = "57")]
	protected virtual void UpdateSubscriptionOnHold(PayItemData csv, PayItemData sdk)
	{
	}

	[Token(Token = "0x6011205")]
	[Address(RVA = "0x29E1864", Offset = "0x29E1864", VA = "0x29E1864")]
	private void OnFixOnHoldButtonClick()
	{
	}

	[Token(Token = "0x6011206")]
	[Address(RVA = "0x29E1968", Offset = "0x29E1968", VA = "0x29E1968")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011207")]
	[Address(RVA = "0x29E1970", Offset = "0x29E1970", VA = "0x29E1970")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
