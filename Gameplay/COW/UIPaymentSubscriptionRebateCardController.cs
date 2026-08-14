using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A3F")]
public class UIPaymentSubscriptionRebateCardController : UIPaymentSubscriptionBaseController, _Attribute
{
	[Token(Token = "0x40103C1")]
	[FieldOffset(Offset = "0x3C")]
	private UIPaymentSubscriptionRebateCardView m_View;

	[Token(Token = "0x40103C2")]
	[FieldOffset(Offset = "0x40")]
	private UIModelMemberShip m_ModelMembership;

	[Token(Token = "0x40103C3")]
	[FieldOffset(Offset = "0x44")]
	private RebateCardType? m_RebateCardType;

	[Token(Token = "0x170012B6")]
	protected override UILabel PriceLabel
	{
		[Token(Token = "0x6011227")]
		[Address(RVA = "0x29EB944", Offset = "0x29EB944", VA = "0x29EB944", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B7")]
	protected override UILabel PeriodLabel
	{
		[Token(Token = "0x6011228")]
		[Address(RVA = "0x29EB9B4", Offset = "0x29EB9B4", VA = "0x29EB9B4", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B8")]
	protected override UITable PricingTable
	{
		[Token(Token = "0x6011229")]
		[Address(RVA = "0x29EBA24", Offset = "0x29EBA24", VA = "0x29EBA24", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B9")]
	protected override UILabel SubscribeButtonLabel
	{
		[Token(Token = "0x601122A")]
		[Address(RVA = "0x29EBA94", Offset = "0x29EBA94", VA = "0x29EBA94", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012BA")]
	protected override UINetworkTextureExt NetworkTexture
	{
		[Token(Token = "0x601122B")]
		[Address(RVA = "0x29EBB04", Offset = "0x29EBB04", VA = "0x29EBB04", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012BB")]
	protected override string NetworkTextureUrl
	{
		[Token(Token = "0x601122C")]
		[Address(RVA = "0x29EBB74", Offset = "0x29EBB74", VA = "0x29EBB74", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012BC")]
	protected override GameObject BonusGameObject
	{
		[Token(Token = "0x601122D")]
		[Address(RVA = "0x29EBBE4", Offset = "0x29EBBE4", VA = "0x29EBBE4", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012BD")]
	protected override bool BonusAvailable
	{
		[Token(Token = "0x601122E")]
		[Address(RVA = "0x29EBC70", Offset = "0x29EBC70", VA = "0x29EBC70", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170012BE")]
	protected override UILabel BonusLabel
	{
		[Token(Token = "0x601122F")]
		[Address(RVA = "0x29EBD74", Offset = "0x29EBD74", VA = "0x29EBD74", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012BF")]
	protected override int BonusAmount
	{
		[Token(Token = "0x6011230")]
		[Address(RVA = "0x29EBDE4", Offset = "0x29EBDE4", VA = "0x29EBDE4", Slot = "42")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170012C0")]
	protected override UIButton FixOnHoldButton
	{
		[Token(Token = "0x6011231")]
		[Address(RVA = "0x29EBF04", Offset = "0x29EBF04", VA = "0x29EBF04", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6011223")]
	[Address(RVA = "0x29EB378", Offset = "0x29EB378", VA = "0x29EB378")]
	public UIPaymentSubscriptionRebateCardController()
	{
	}

	[Token(Token = "0x6011224")]
	[Address(RVA = "0x29EB37C", Offset = "0x29EB37C", VA = "0x29EB37C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011225")]
	[Address(RVA = "0x29EB424", Offset = "0x29EB424", VA = "0x29EB424", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011226")]
	[Address(RVA = "0x29EB6F8", Offset = "0x29EB6F8", VA = "0x29EB6F8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011232")]
	[Address(RVA = "0x29EBF74", Offset = "0x29EBF74", VA = "0x29EBF74", Slot = "44")]
	protected override GameObject GameObjectForStatus(bool subscribing)
	{
		return null;
	}

	[Token(Token = "0x6011233")]
	[Address(RVA = "0x29EC018", Offset = "0x29EC018", VA = "0x29EC018", Slot = "45")]
	protected override GameObject GameObjectForGracePeriod(bool inGracePeriod)
	{
		return null;
	}

	[Token(Token = "0x6011234")]
	[Address(RVA = "0x29EC0BC", Offset = "0x29EC0BC", VA = "0x29EC0BC", Slot = "46")]
	protected override GameObject GameObjectForOnHold(bool isOnHold)
	{
		return null;
	}

	[Token(Token = "0x6011235")]
	[Address(RVA = "0x29EC144", Offset = "0x29EC144", VA = "0x29EC144", Slot = "49")]
	protected override void UpdateSubscriptionUI()
	{
	}

	[Token(Token = "0x6011236")]
	[Address(RVA = "0x29EC2A4", Offset = "0x29EC2A4", VA = "0x29EC2A4")]
	private void UpdateMembershipUI(ClientMemberShipCardData data)
	{
	}

	[Token(Token = "0x6011237")]
	[Address(RVA = "0x29EC50C", Offset = "0x29EC50C", VA = "0x29EC50C")]
	private void UpdateMemberShipDescriptions(ClientMemberShipCardData data)
	{
	}

	[Token(Token = "0x6011238")]
	[Address(RVA = "0x29EC61C", Offset = "0x29EC61C", VA = "0x29EC61C")]
	private void OnSubscribeButtonClick()
	{
	}

	[Token(Token = "0x6011239")]
	[Address(RVA = "0x29EC9C8", Offset = "0x29EC9C8", VA = "0x29EC9C8")]
	private void OnInfoButtonClick()
	{
	}

	[Token(Token = "0x601123A")]
	[Address(RVA = "0x29ECB3C", Offset = "0x29ECB3C", VA = "0x29ECB3C")]
	private void OnGracePeriodButtonClick()
	{
	}

	[Token(Token = "0x601123B")]
	[Address(RVA = "0x29ECC40", Offset = "0x29ECC40", VA = "0x29ECC40", Slot = "47")]
	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601123C")]
	[Address(RVA = "0x29ECD08", Offset = "0x29ECD08", VA = "0x29ECD08", Slot = "48")]
	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601123D")]
	[Address(RVA = "0x29ED1A8", Offset = "0x29ED1A8", VA = "0x29ED1A8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601123E")]
	[Address(RVA = "0x29ED1AC", Offset = "0x29ED1AC", VA = "0x29ED1AC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601123F")]
	[Address(RVA = "0x29ED1B4", Offset = "0x29ED1B4", VA = "0x29ED1B4")]
	public void _003C_003EiFixBaseProxy_UpdateSubscriptionUI()
	{
	}

	[Token(Token = "0x6011240")]
	[Address(RVA = "0x29ED1B8", Offset = "0x29ED1B8", VA = "0x29ED1B8")]
	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return default(uint);
	}

	[Token(Token = "0x6011241")]
	[Address(RVA = "0x29ED1BC", Offset = "0x29ED1BC", VA = "0x29ED1BC")]
	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}
}
