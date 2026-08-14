using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A38")]
public class UIPaymentSubscriptionElitePassController : UIPaymentSubscriptionBaseController
{
	[Token(Token = "0x40103A8")]
	[FieldOffset(Offset = "0x3C")]
	private UIPaymentSubscriptionElitePassView m_View;

	[Token(Token = "0x40103A9")]
	[FieldOffset(Offset = "0x40")]
	private UIModelElitePass ElitePass;

	[Token(Token = "0x40103AA")]
	[FieldOffset(Offset = "0x44")]
	private List<BaseItemInfo> m_RewardItemInfos;

	[Token(Token = "0x40103AB")]
	[FieldOffset(Offset = "0x48")]
	private List<UIStandardItemMiniController> m_ItemControllers;

	[Token(Token = "0x17001291")]
	protected override UILabel PriceLabel
	{
		[Token(Token = "0x60111AE")]
		[Address(RVA = "0x29E5814", Offset = "0x29E5814", VA = "0x29E5814", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001292")]
	protected override UILabel PeriodLabel
	{
		[Token(Token = "0x60111AF")]
		[Address(RVA = "0x29E5884", Offset = "0x29E5884", VA = "0x29E5884", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001293")]
	protected override UITable PricingTable
	{
		[Token(Token = "0x60111B0")]
		[Address(RVA = "0x29E58F4", Offset = "0x29E58F4", VA = "0x29E58F4", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001294")]
	protected override UILabel SubscribeButtonLabel
	{
		[Token(Token = "0x60111B1")]
		[Address(RVA = "0x29E5964", Offset = "0x29E5964", VA = "0x29E5964", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001295")]
	protected override UINetworkTextureExt NetworkTexture
	{
		[Token(Token = "0x60111B2")]
		[Address(RVA = "0x29E59D4", Offset = "0x29E59D4", VA = "0x29E59D4", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001296")]
	protected override string NetworkTextureUrl
	{
		[Token(Token = "0x60111B3")]
		[Address(RVA = "0x29E5A44", Offset = "0x29E5A44", VA = "0x29E5A44", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001297")]
	protected override GameObject BonusGameObject
	{
		[Token(Token = "0x60111B4")]
		[Address(RVA = "0x29E5AB4", Offset = "0x29E5AB4", VA = "0x29E5AB4", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001298")]
	protected override bool BonusAvailable
	{
		[Token(Token = "0x60111B5")]
		[Address(RVA = "0x29E5B40", Offset = "0x29E5B40", VA = "0x29E5B40", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001299")]
	protected override UILabel BonusLabel
	{
		[Token(Token = "0x60111B6")]
		[Address(RVA = "0x29E5C74", Offset = "0x29E5C74", VA = "0x29E5C74", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700129A")]
	protected override int BonusAmount
	{
		[Token(Token = "0x60111B7")]
		[Address(RVA = "0x29E5CE4", Offset = "0x29E5CE4", VA = "0x29E5CE4", Slot = "42")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700129B")]
	protected override UIButton FixOnHoldButton
	{
		[Token(Token = "0x60111B8")]
		[Address(RVA = "0x29E5D6C", Offset = "0x29E5D6C", VA = "0x29E5D6C", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60111AA")]
	[Address(RVA = "0x29E5078", Offset = "0x29E5078", VA = "0x29E5078")]
	public UIPaymentSubscriptionElitePassController()
	{
	}

	[Token(Token = "0x60111AB")]
	[Address(RVA = "0x29E51A4", Offset = "0x29E51A4", VA = "0x29E51A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60111AC")]
	[Address(RVA = "0x29E524C", Offset = "0x29E524C", VA = "0x29E524C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60111AD")]
	[Address(RVA = "0x29E5640", Offset = "0x29E5640", VA = "0x29E5640", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60111B9")]
	[Address(RVA = "0x29E5DDC", Offset = "0x29E5DDC", VA = "0x29E5DDC", Slot = "44")]
	protected override GameObject GameObjectForStatus(bool subscribing)
	{
		return null;
	}

	[Token(Token = "0x60111BA")]
	[Address(RVA = "0x29E5E80", Offset = "0x29E5E80", VA = "0x29E5E80", Slot = "45")]
	protected override GameObject GameObjectForGracePeriod(bool inGracePeriod)
	{
		return null;
	}

	[Token(Token = "0x60111BB")]
	[Address(RVA = "0x29E5F24", Offset = "0x29E5F24", VA = "0x29E5F24", Slot = "46")]
	protected override GameObject GameObjectForOnHold(bool isOnHold)
	{
		return null;
	}

	[Token(Token = "0x60111BC")]
	[Address(RVA = "0x29E54B4", Offset = "0x29E54B4", VA = "0x29E54B4")]
	private void InitItemControllers()
	{
	}

	[Token(Token = "0x60111BD")]
	[Address(RVA = "0x29E5FAC", Offset = "0x29E5FAC", VA = "0x29E5FAC", Slot = "49")]
	protected override void UpdateSubscriptionUI()
	{
	}

	[Token(Token = "0x60111BE")]
	[Address(RVA = "0x29E6260", Offset = "0x29E6260", VA = "0x29E6260")]
	private void UpdateWorth()
	{
	}

	[Token(Token = "0x60111BF")]
	[Address(RVA = "0x29E6314", Offset = "0x29E6314", VA = "0x29E6314")]
	private void UpdateItems()
	{
	}

	[Token(Token = "0x60111C0")]
	[Address(RVA = "0x29E6024", Offset = "0x29E6024", VA = "0x29E6024")]
	private void UpdateCountdown()
	{
	}

	[Token(Token = "0x60111C1")]
	[Address(RVA = "0x29E6A18", Offset = "0x29E6A18", VA = "0x29E6A18")]
	private void OnSubscribeButtonClick()
	{
	}

	[Token(Token = "0x60111C2")]
	[Address(RVA = "0x29E6D58", Offset = "0x29E6D58", VA = "0x29E6D58")]
	private void OnInfoButtonClick()
	{
	}

	[Token(Token = "0x60111C3")]
	[Address(RVA = "0x29E6E3C", Offset = "0x29E6E3C", VA = "0x29E6E3C")]
	private void _003CUpdateCountdown_003Em__0()
	{
	}

	[Token(Token = "0x60111C4")]
	[Address(RVA = "0x29E6EA0", Offset = "0x29E6EA0", VA = "0x29E6EA0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60111C5")]
	[Address(RVA = "0x29E6EA4", Offset = "0x29E6EA4", VA = "0x29E6EA4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60111C6")]
	[Address(RVA = "0x29E6EAC", Offset = "0x29E6EAC", VA = "0x29E6EAC")]
	public void _003C_003EiFixBaseProxy_UpdateSubscriptionUI()
	{
	}
}
