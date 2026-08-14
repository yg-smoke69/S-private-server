using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A3E")]
public class UIPaymentSubscriptionItemController : UIPaymentSubscriptionBaseController, _Attribute
{
	[Token(Token = "0x40103C0")]
	[FieldOffset(Offset = "0x3C")]
	private UIPaymentSubscriptionItemView m_View;

	[Token(Token = "0x170012AB")]
	protected override UILabel PriceLabel
	{
		[Token(Token = "0x601120E")]
		[Address(RVA = "0x29EA6A8", Offset = "0x29EA6A8", VA = "0x29EA6A8", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012AC")]
	protected override UILabel PeriodLabel
	{
		[Token(Token = "0x601120F")]
		[Address(RVA = "0x29EA718", Offset = "0x29EA718", VA = "0x29EA718", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012AD")]
	protected override UITable PricingTable
	{
		[Token(Token = "0x6011210")]
		[Address(RVA = "0x29EA788", Offset = "0x29EA788", VA = "0x29EA788", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012AE")]
	protected override UILabel SubscribeButtonLabel
	{
		[Token(Token = "0x6011211")]
		[Address(RVA = "0x29EA7E0", Offset = "0x29EA7E0", VA = "0x29EA7E0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012AF")]
	protected override UINetworkTextureExt NetworkTexture
	{
		[Token(Token = "0x6011212")]
		[Address(RVA = "0x29EA838", Offset = "0x29EA838", VA = "0x29EA838", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B0")]
	protected override string NetworkTextureUrl
	{
		[Token(Token = "0x6011213")]
		[Address(RVA = "0x29EA8A8", Offset = "0x29EA8A8", VA = "0x29EA8A8", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B1")]
	protected override GameObject BonusGameObject
	{
		[Token(Token = "0x6011214")]
		[Address(RVA = "0x29EA918", Offset = "0x29EA918", VA = "0x29EA918", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B2")]
	protected override bool BonusAvailable
	{
		[Token(Token = "0x6011215")]
		[Address(RVA = "0x29EA970", Offset = "0x29EA970", VA = "0x29EA970", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170012B3")]
	protected override UILabel BonusLabel
	{
		[Token(Token = "0x6011216")]
		[Address(RVA = "0x29EA9C8", Offset = "0x29EA9C8", VA = "0x29EA9C8", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B4")]
	protected override UIButton FixOnHoldButton
	{
		[Token(Token = "0x6011217")]
		[Address(RVA = "0x29EAA20", Offset = "0x29EAA20", VA = "0x29EAA20", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B5")]
	protected override int BonusAmount
	{
		[Token(Token = "0x6011218")]
		[Address(RVA = "0x29EAA78", Offset = "0x29EAA78", VA = "0x29EAA78", Slot = "42")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6011208")]
	[Address(RVA = "0x29E9FCC", Offset = "0x29E9FCC", VA = "0x29E9FCC")]
	public UIPaymentSubscriptionItemController()
	{
	}

	[Token(Token = "0x6011209")]
	[Address(RVA = "0x29E9FD0", Offset = "0x29E9FD0", VA = "0x29E9FD0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601120A")]
	[Address(RVA = "0x29EA078", Offset = "0x29EA078", VA = "0x29EA078", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601120B")]
	[Address(RVA = "0x29EA268", Offset = "0x29EA268", VA = "0x29EA268", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601120C")]
	[Address(RVA = "0x29EA428", Offset = "0x29EA428", VA = "0x29EA428", Slot = "58")]
	private void COW_002EITipsDelegate_002EOnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x601120D")]
	[Address(RVA = "0x29E9770", Offset = "0x29E9770", VA = "0x29E9770")]
	public void SetDragScrollView(UIScrollView scrollView)
	{
	}

	[Token(Token = "0x6011219")]
	[Address(RVA = "0x29EAAD0", Offset = "0x29EAAD0", VA = "0x29EAAD0", Slot = "44")]
	protected override GameObject GameObjectForStatus(bool subscribing)
	{
		return null;
	}

	[Token(Token = "0x601121A")]
	[Address(RVA = "0x29EAB74", Offset = "0x29EAB74", VA = "0x29EAB74", Slot = "45")]
	protected override GameObject GameObjectForGracePeriod(bool inGracePeriod)
	{
		return null;
	}

	[Token(Token = "0x601121B")]
	[Address(RVA = "0x29EABD8", Offset = "0x29EABD8", VA = "0x29EABD8", Slot = "46")]
	protected override GameObject GameObjectForOnHold(bool isOnHold)
	{
		return null;
	}

	[Token(Token = "0x601121C")]
	[Address(RVA = "0x29EAC3C", Offset = "0x29EAC3C", VA = "0x29EAC3C", Slot = "49")]
	protected override void UpdateSubscriptionUI()
	{
	}

	[Token(Token = "0x601121D")]
	[Address(RVA = "0x29EA4B4", Offset = "0x29EA4B4", VA = "0x29EA4B4")]
	private void UpdateRedDot()
	{
	}

	[Token(Token = "0x601121E")]
	[Address(RVA = "0x29E9A48", Offset = "0x29E9A48", VA = "0x29E9A48")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x601121F")]
	[Address(RVA = "0x29EACA4", Offset = "0x29EACA4", VA = "0x29EACA4")]
	private void OnButtonClick()
	{
	}

	[Token(Token = "0x6011220")]
	[Address(RVA = "0x29EAE50", Offset = "0x29EAE50", VA = "0x29EAE50")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011221")]
	[Address(RVA = "0x29EAE54", Offset = "0x29EAE54", VA = "0x29EAE54")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011222")]
	[Address(RVA = "0x29EAE5C", Offset = "0x29EAE5C", VA = "0x29EAE5C")]
	public void _003C_003EiFixBaseProxy_UpdateSubscriptionUI()
	{
	}
}
