using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F86")]
public class UIBigEventLobbyEntranceBaseController : UIBaseController
{
	[Token(Token = "0x400C5DB")]
	[FieldOffset(Offset = "0x28")]
	private UIBigEventLobbyEntranceBaseView m_View;

	[Token(Token = "0x400C5DC")]
	[FieldOffset(Offset = "0x2C")]
	protected ELimitedEvent.EventID m_EventId;

	[Token(Token = "0x400C5DD")]
	[FieldOffset(Offset = "0x30")]
	protected EActivity.SubType m_ActivitySubType;

	[Token(Token = "0x400C5DE")]
	[FieldOffset(Offset = "0x34")]
	private uint m_TipTypeValue;

	[Token(Token = "0x400C5DF")]
	[FieldOffset(Offset = "0x38")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x400C5E0")]
	[FieldOffset(Offset = "0x3C")]
	protected UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C5E1")]
	[FieldOffset(Offset = "0x40")]
	protected UIModelLobbyEventBubble m_UIModelLobbyEventBubble;

	[Token(Token = "0x400C5E2")]
	[FieldOffset(Offset = "0x44")]
	protected uint m_WaitOpenTime;

	[Token(Token = "0x400C5E3")]
	[FieldOffset(Offset = "0x48")]
	private EBigEventIntroTiming m_IntroTimingState;

	[Token(Token = "0x400C5E4")]
	[FieldOffset(Offset = "0x4C")]
	private UINewDownloadInfoController m_DownloadCtrl;

	[Token(Token = "0x400C5E5")]
	[FieldOffset(Offset = "0x50")]
	private float m_NextCheckTime;

	[Token(Token = "0x400C5E6")]
	[FieldOffset(Offset = "0x54")]
	private UIModelOptionalDownload m_ModelDownload;

	[Token(Token = "0x17000F98")]
	public UIBigEventLobbyEntranceBaseView BaseView
	{
		[Token(Token = "0x6009CB6")]
		[Address(RVA = "0x300F180", Offset = "0x300F180", VA = "0x300F180")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009CB7")]
		[Address(RVA = "0x300F27C", Offset = "0x300F27C", VA = "0x300F27C")]
		set
		{
		}
	}

	[Token(Token = "0x6009CAF")]
	[Address(RVA = "0x300EDEC", Offset = "0x300EDEC", VA = "0x300EDEC")]
	public UIBigEventLobbyEntranceBaseController()
	{
	}

	[Token(Token = "0x6009CB0")]
	[Address(RVA = "0x300EE78", Offset = "0x300EE78", VA = "0x300EE78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009CB1")]
	[Address(RVA = "0x300EF48", Offset = "0x300EF48", VA = "0x300EF48", Slot = "31")]
	public virtual ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009CB2")]
	[Address(RVA = "0x300EFA0", Offset = "0x300EFA0", VA = "0x300EFA0", Slot = "32")]
	public virtual EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009CB3")]
	[Address(RVA = "0x300EFF8", Offset = "0x300EFF8", VA = "0x300EFF8", Slot = "33")]
	public virtual uint GetTipTypeValue()
	{
		return default(uint);
	}

	[Token(Token = "0x6009CB4")]
	[Address(RVA = "0x300F050", Offset = "0x300F050", VA = "0x300F050", Slot = "34")]
	public virtual bool IsNoWarmUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6009CB5")]
	[Address(RVA = "0x300F0A8", Offset = "0x300F0A8", VA = "0x300F0A8", Slot = "35")]
	public virtual string GetClickSoundId()
	{
		return null;
	}

	[Token(Token = "0x6009CB8")]
	[Address(RVA = "0x300F2DC", Offset = "0x300F2DC", VA = "0x300F2DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009CB9")]
	[Address(RVA = "0x300F69C", Offset = "0x300F69C", VA = "0x300F69C", Slot = "36")]
	public virtual EV2NavigationPageType GetPageType()
	{
		return default(EV2NavigationPageType);
	}

	[Token(Token = "0x6009CBA")]
	[Address(RVA = "0x300F6F4", Offset = "0x300F6F4", VA = "0x300F6F4", Slot = "37")]
	public virtual bool NeedShowShowBigEventIntro()
	{
		return default(bool);
	}

	[Token(Token = "0x6009CBB")]
	[Address(RVA = "0x300F7EC", Offset = "0x300F7EC", VA = "0x300F7EC")]
	protected bool ShowBigEventIntroIfNeed(EBigEventIntroTiming timing)
	{
		return default(bool);
	}

	[Token(Token = "0x6009CBC")]
	[Address(RVA = "0x300FAEC", Offset = "0x300FAEC", VA = "0x300FAEC", Slot = "38")]
	public virtual void OnBtnEntranceClick()
	{
	}

	[Token(Token = "0x6009CBD")]
	[Address(RVA = "0x3010210", Offset = "0x3010210", VA = "0x3010210")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6009CBE")]
	[Address(RVA = "0x30103A4", Offset = "0x30103A4", VA = "0x30103A4")]
	public uint GetNoWarmUpEntranceOpenTime()
	{
		return default(uint);
	}

	[Token(Token = "0x6009CBF")]
	[Address(RVA = "0x30103FC", Offset = "0x30103FC", VA = "0x30103FC")]
	private void SetBigEventCountDown(ELimitedEvent.EventState eventState)
	{
	}

	[Token(Token = "0x6009CC0")]
	[Address(RVA = "0x30107E0", Offset = "0x30107E0", VA = "0x30107E0", Slot = "39")]
	public virtual ELimitedEvent.EventState RefreshBigEventEntranceState()
	{
		return default(ELimitedEvent.EventState);
	}

	[Token(Token = "0x6009CC1")]
	[Address(RVA = "0x3010E18", Offset = "0x3010E18", VA = "0x3010E18", Slot = "40")]
	public virtual void OnEnterWarmUpState()
	{
	}

	[Token(Token = "0x6009CC2")]
	[Address(RVA = "0x3010EAC", Offset = "0x3010EAC", VA = "0x3010EAC", Slot = "41")]
	public virtual void OnEnterProcessState()
	{
	}

	[Token(Token = "0x6009CC3")]
	[Address(RVA = "0x3010F40", Offset = "0x3010F40", VA = "0x3010F40", Slot = "42")]
	public virtual void OnEnterSettleState()
	{
	}

	[Token(Token = "0x6009CC4")]
	[Address(RVA = "0x3010FC8", Offset = "0x3010FC8", VA = "0x3010FC8", Slot = "43")]
	public virtual bool IsShowRedPointTip()
	{
		return default(bool);
	}

	[Token(Token = "0x6009CC5")]
	[Address(RVA = "0x3010A50", Offset = "0x3010A50", VA = "0x3010A50")]
	private void RefreshDownloadState()
	{
	}

	[Token(Token = "0x6009CC6")]
	[Address(RVA = "0x301118C", Offset = "0x301118C", VA = "0x301118C", Slot = "44")]
	public virtual void ResetBubble()
	{
	}

	[Token(Token = "0x6009CC7")]
	[Address(RVA = "0x3011224", Offset = "0x3011224", VA = "0x3011224")]
	private void _003COnBtnEntranceClick_003Em__0()
	{
	}

	[Token(Token = "0x6009CC8")]
	[Address(RVA = "0x3011390", Offset = "0x3011390", VA = "0x3011390")]
	private void _003CSetBigEventCountDown_003Em__1()
	{
	}

	[Token(Token = "0x6009CC9")]
	[Address(RVA = "0x3011428", Offset = "0x3011428", VA = "0x3011428")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
