using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A37")]
public class UIPaymentSubscriptionBundleController : UIPaymentSubscriptionBaseController
{
	[Token(Token = "0x40103A1")]
	[FieldOffset(Offset = "0x3C")]
	private UIPaymentSubscriptionBundleView m_View;

	[Token(Token = "0x40103A2")]
	[FieldOffset(Offset = "0x40")]
	private bool m_ShowFirstTime;

	[Token(Token = "0x40103A3")]
	[FieldOffset(Offset = "0x44")]
	private uint m_DelayCall;

	[Token(Token = "0x40103A4")]
	[FieldOffset(Offset = "0x48")]
	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x40103A5")]
	[FieldOffset(Offset = "0x4C")]
	private FrontendPreviewType m_PreviewUIType;

	[Token(Token = "0x40103A6")]
	[FieldOffset(Offset = "0x50")]
	private FrontEndPreviewConfigData m_FrontEndPreviewData;

	[Token(Token = "0x40103A7")]
	[FieldOffset(Offset = "0x54")]
	private UIWidget m_FrontEndPreviewBorder;

	[Token(Token = "0x17001286")]
	protected override UILabel PriceLabel
	{
		[Token(Token = "0x6011183")]
		[Address(RVA = "0x29E27D0", Offset = "0x29E27D0", VA = "0x29E27D0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001287")]
	protected override UILabel PeriodLabel
	{
		[Token(Token = "0x6011184")]
		[Address(RVA = "0x29E2840", Offset = "0x29E2840", VA = "0x29E2840", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001288")]
	protected override UITable PricingTable
	{
		[Token(Token = "0x6011185")]
		[Address(RVA = "0x29E28B0", Offset = "0x29E28B0", VA = "0x29E28B0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001289")]
	protected override UILabel SubscribeButtonLabel
	{
		[Token(Token = "0x6011186")]
		[Address(RVA = "0x29E2920", Offset = "0x29E2920", VA = "0x29E2920", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700128A")]
	protected override UINetworkTextureExt NetworkTexture
	{
		[Token(Token = "0x6011187")]
		[Address(RVA = "0x29E2990", Offset = "0x29E2990", VA = "0x29E2990", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700128B")]
	protected override string NetworkTextureUrl
	{
		[Token(Token = "0x6011188")]
		[Address(RVA = "0x29E29E8", Offset = "0x29E29E8", VA = "0x29E29E8", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700128C")]
	protected override GameObject BonusGameObject
	{
		[Token(Token = "0x6011189")]
		[Address(RVA = "0x29E2AC0", Offset = "0x29E2AC0", VA = "0x29E2AC0", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700128D")]
	protected override bool BonusAvailable
	{
		[Token(Token = "0x601118A")]
		[Address(RVA = "0x29E2B4C", Offset = "0x29E2B4C", VA = "0x29E2B4C", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700128E")]
	protected override UILabel BonusLabel
	{
		[Token(Token = "0x601118B")]
		[Address(RVA = "0x29E2BE4", Offset = "0x29E2BE4", VA = "0x29E2BE4", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700128F")]
	protected override int BonusAmount
	{
		[Token(Token = "0x601118C")]
		[Address(RVA = "0x29E2C54", Offset = "0x29E2C54", VA = "0x29E2C54", Slot = "42")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001290")]
	protected override UIButton FixOnHoldButton
	{
		[Token(Token = "0x601118D")]
		[Address(RVA = "0x29E2D04", Offset = "0x29E2D04", VA = "0x29E2D04", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601117C")]
	[Address(RVA = "0x29E1978", Offset = "0x29E1978", VA = "0x29E1978")]
	public UIPaymentSubscriptionBundleController()
	{
	}

	[Token(Token = "0x601117D")]
	[Address(RVA = "0x29E197C", Offset = "0x29E197C", VA = "0x29E197C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601117E")]
	[Address(RVA = "0x29E1A24", Offset = "0x29E1A24", VA = "0x29E1A24", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601117F")]
	[Address(RVA = "0x29E1FC4", Offset = "0x29E1FC4", VA = "0x29E1FC4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011180")]
	[Address(RVA = "0x29E24C4", Offset = "0x29E24C4", VA = "0x29E24C4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6011181")]
	[Address(RVA = "0x29E26D0", Offset = "0x29E26D0", VA = "0x29E26D0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011182")]
	[Address(RVA = "0x29E273C", Offset = "0x29E273C", VA = "0x29E273C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x601118E")]
	[Address(RVA = "0x29E2D74", Offset = "0x29E2D74", VA = "0x29E2D74", Slot = "44")]
	protected override GameObject GameObjectForStatus(bool subscribing)
	{
		return null;
	}

	[Token(Token = "0x601118F")]
	[Address(RVA = "0x29E2E34", Offset = "0x29E2E34", VA = "0x29E2E34", Slot = "45")]
	protected override GameObject GameObjectForGracePeriod(bool inGracePeriod)
	{
		return null;
	}

	[Token(Token = "0x6011190")]
	[Address(RVA = "0x29E2ED8", Offset = "0x29E2ED8", VA = "0x29E2ED8", Slot = "46")]
	protected override GameObject GameObjectForOnHold(bool isOnHold)
	{
		return null;
	}

	[Token(Token = "0x6011191")]
	[Address(RVA = "0x29E2F60", Offset = "0x29E2F60", VA = "0x29E2F60", Slot = "49")]
	protected override void UpdateSubscriptionUI()
	{
	}

	[Token(Token = "0x6011192")]
	[Address(RVA = "0x29E2FD0", Offset = "0x29E2FD0", VA = "0x29E2FD0")]
	private void UpdateClaimButton()
	{
	}

	[Token(Token = "0x6011193")]
	[Address(RVA = "0x29E3428", Offset = "0x29E3428", VA = "0x29E3428")]
	private void UpdateAsJustClaimed()
	{
	}

	[Token(Token = "0x6011194")]
	[Address(RVA = "0x29E2530", Offset = "0x29E2530", VA = "0x29E2530")]
	private void _EnterPreview()
	{
	}

	[Token(Token = "0x6011195")]
	[Address(RVA = "0x29E3644", Offset = "0x29E3644", VA = "0x29E3644")]
	private void OpenPreview()
	{
	}

	[Token(Token = "0x6011196")]
	[Address(RVA = "0x29E34D8", Offset = "0x29E34D8", VA = "0x29E34D8")]
	private FrontEndPreviewConfigData GetFrontEndPreviewData()
	{
		return null;
	}

	[Token(Token = "0x6011197")]
	[Address(RVA = "0x29E3228", Offset = "0x29E3228", VA = "0x29E3228")]
	private void UpdatePreview()
	{
	}

	[Token(Token = "0x6011198")]
	[Address(RVA = "0x29E2354", Offset = "0x29E2354", VA = "0x29E2354")]
	private void _ExitPreview()
	{
	}

	[Token(Token = "0x6011199")]
	[Address(RVA = "0x29E3A20", Offset = "0x29E3A20", VA = "0x29E3A20")]
	private void OnSubscribeButtonClick()
	{
	}

	[Token(Token = "0x601119A")]
	[Address(RVA = "0x29E3D94", Offset = "0x29E3D94", VA = "0x29E3D94")]
	private void OnClaimButtonClick()
	{
	}

	[Token(Token = "0x601119B")]
	[Address(RVA = "0x29E403C", Offset = "0x29E403C", VA = "0x29E403C")]
	private void OnInfoButtonClick()
	{
	}

	[Token(Token = "0x601119C")]
	[Address(RVA = "0x29E4144", Offset = "0x29E4144", VA = "0x29E4144")]
	private void OnGracePeriodButtonClick()
	{
	}

	[Token(Token = "0x601119D")]
	[Address(RVA = "0x29E4248", Offset = "0x29E4248", VA = "0x29E4248", Slot = "47")]
	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601119E")]
	[Address(RVA = "0x29E4340", Offset = "0x29E4340", VA = "0x29E4340", Slot = "48")]
	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601119F")]
	[Address(RVA = "0x29E445C", Offset = "0x29E445C", VA = "0x29E445C", Slot = "50")]
	protected override void TryPlayAnim()
	{
	}

	[Token(Token = "0x60111A0")]
	[Address(RVA = "0x29E457C", Offset = "0x29E457C", VA = "0x29E457C")]
	private void _003CUpdatePreview_003Em__0()
	{
	}

	[Token(Token = "0x60111A1")]
	[Address(RVA = "0x29E4608", Offset = "0x29E4608", VA = "0x29E4608")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60111A2")]
	[Address(RVA = "0x29E460C", Offset = "0x29E460C", VA = "0x29E460C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60111A3")]
	[Address(RVA = "0x29E4614", Offset = "0x29E4614", VA = "0x29E4614")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x60111A4")]
	[Address(RVA = "0x29E461C", Offset = "0x29E461C", VA = "0x29E461C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60111A5")]
	[Address(RVA = "0x29E4624", Offset = "0x29E4624", VA = "0x29E4624")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60111A6")]
	[Address(RVA = "0x29E462C", Offset = "0x29E462C", VA = "0x29E462C")]
	public void _003C_003EiFixBaseProxy_UpdateSubscriptionUI()
	{
	}

	[Token(Token = "0x60111A7")]
	[Address(RVA = "0x29E4630", Offset = "0x29E4630", VA = "0x29E4630")]
	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return default(uint);
	}

	[Token(Token = "0x60111A8")]
	[Address(RVA = "0x29E4634", Offset = "0x29E4634", VA = "0x29E4634")]
	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	[Token(Token = "0x60111A9")]
	[Address(RVA = "0x29E464C", Offset = "0x29E464C", VA = "0x29E464C")]
	public void _003C_003EiFixBaseProxy_TryPlayAnim()
	{
	}
}
