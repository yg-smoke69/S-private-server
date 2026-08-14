using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001ED3")]
internal class UIDigitaluniverseBLobbyEntranceController : UIBigEventLobbyEntranceBaseController
{
	[Token(Token = "0x400C215")]
	[FieldOffset(Offset = "0x58")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C216")]
	[FieldOffset(Offset = "0x60")]
	private ulong m_AccountId;

	[Token(Token = "0x6009600")]
	[Address(RVA = "0x2F68E8C", Offset = "0x2F68E8C", VA = "0x2F68E8C")]
	public UIDigitaluniverseBLobbyEntranceController()
	{
	}

	[Token(Token = "0x6009601")]
	[Address(RVA = "0x2F68FB8", Offset = "0x2F68FB8", VA = "0x2F68FB8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009602")]
	[Address(RVA = "0x2F69030", Offset = "0x2F69030", VA = "0x2F69030")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009603")]
	[Address(RVA = "0x2F690D8", Offset = "0x2F690D8", VA = "0x2F690D8", Slot = "31")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009604")]
	[Address(RVA = "0x2F69130", Offset = "0x2F69130", VA = "0x2F69130", Slot = "32")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009605")]
	[Address(RVA = "0x2F69188", Offset = "0x2F69188", VA = "0x2F69188", Slot = "33")]
	public override uint GetTipTypeValue()
	{
		return default(uint);
	}

	[Token(Token = "0x6009606")]
	[Address(RVA = "0x2F691E0", Offset = "0x2F691E0", VA = "0x2F691E0", Slot = "43")]
	public override bool IsShowRedPointTip()
	{
		return default(bool);
	}

	[Token(Token = "0x6009607")]
	[Address(RVA = "0x2F69244", Offset = "0x2F69244", VA = "0x2F69244", Slot = "37")]
	public override bool NeedShowShowBigEventIntro()
	{
		return default(bool);
	}

	[Token(Token = "0x6009608")]
	[Address(RVA = "0x2F69650", Offset = "0x2F69650", VA = "0x2F69650", Slot = "44")]
	public override void ResetBubble()
	{
	}

	[Token(Token = "0x6009609")]
	[Address(RVA = "0x2F69730", Offset = "0x2F69730", VA = "0x2F69730", Slot = "38")]
	public override void OnBtnEntranceClick()
	{
	}

	[Token(Token = "0x600960A")]
	[Address(RVA = "0x2F69D8C", Offset = "0x2F69D8C", VA = "0x2F69D8C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600960B")]
	[Address(RVA = "0x2F69D94", Offset = "0x2F69D94", VA = "0x2F69D94")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x600960C")]
	[Address(RVA = "0x2F69D9C", Offset = "0x2F69D9C", VA = "0x2F69D9C")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x600960D")]
	[Address(RVA = "0x2F69DA4", Offset = "0x2F69DA4", VA = "0x2F69DA4")]
	public uint _003C_003EiFixBaseProxy_GetTipTypeValue()
	{
		return default(uint);
	}

	[Token(Token = "0x600960E")]
	[Address(RVA = "0x2F69DAC", Offset = "0x2F69DAC", VA = "0x2F69DAC")]
	public bool _003C_003EiFixBaseProxy_IsShowRedPointTip()
	{
		return default(bool);
	}

	[Token(Token = "0x600960F")]
	[Address(RVA = "0x2F69DB4", Offset = "0x2F69DB4", VA = "0x2F69DB4")]
	public bool _003C_003EiFixBaseProxy_NeedShowShowBigEventIntro()
	{
		return default(bool);
	}

	[Token(Token = "0x6009610")]
	[Address(RVA = "0x2F69DBC", Offset = "0x2F69DBC", VA = "0x2F69DBC")]
	public void _003C_003EiFixBaseProxy_ResetBubble()
	{
	}

	[Token(Token = "0x6009611")]
	[Address(RVA = "0x2F69DC4", Offset = "0x2F69DC4", VA = "0x2F69DC4")]
	public void _003C_003EiFixBaseProxy_OnBtnEntranceClick()
	{
	}
}
