using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001EE7")]
internal class UIDigitaluniverseBPeakDayWndController : UIBigEventPeakDayWndBaseController
{
	[Token(Token = "0x400C29E")]
	[FieldOffset(Offset = "0x5C")]
	private UIDigitaluniverseBPeakDayWndView m_View;

	[Token(Token = "0x60096D7")]
	[Address(RVA = "0x2EFF904", Offset = "0x2EFF904", VA = "0x2EFF904")]
	public UIDigitaluniverseBPeakDayWndController()
	{
	}

	[Token(Token = "0x60096D8")]
	[Address(RVA = "0x2EFF90C", Offset = "0x2EFF90C", VA = "0x2EFF90C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60096D9")]
	[Address(RVA = "0x2EFF9B4", Offset = "0x2EFF9B4", VA = "0x2EFF9B4", Slot = "48")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x60096DA")]
	[Address(RVA = "0x2EFFA0C", Offset = "0x2EFFA0C", VA = "0x2EFFA0C", Slot = "49")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x60096DB")]
	[Address(RVA = "0x2EFFA64", Offset = "0x2EFFA64", VA = "0x2EFFA64", Slot = "52")]
	public override string GetPeakDayExpiredKey()
	{
		return null;
	}

	[Token(Token = "0x60096DC")]
	[Address(RVA = "0x2EFFB08", Offset = "0x2EFFB08", VA = "0x2EFFB08", Slot = "51")]
	public override string GetPeakDayLoginKey()
	{
		return null;
	}

	[Token(Token = "0x60096DD")]
	[Address(RVA = "0x2EFFBAC", Offset = "0x2EFFBAC", VA = "0x2EFFBAC", Slot = "53")]
	public override UICommonRewardWndController.WndStyleEnum GetRewandWndStyle()
	{
		return default(UICommonRewardWndController.WndStyleEnum);
	}

	[Token(Token = "0x60096DE")]
	[Address(RVA = "0x2EFFC04", Offset = "0x2EFFC04", VA = "0x2EFFC04", Slot = "50")]
	public override UIStandardItemMiniController GetItemController()
	{
		return null;
	}

	[Token(Token = "0x60096DF")]
	[Address(RVA = "0x2EFFD54", Offset = "0x2EFFD54", VA = "0x2EFFD54")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x60096E0")]
	[Address(RVA = "0x2EFFD5C", Offset = "0x2EFFD5C", VA = "0x2EFFD5C")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x60096E1")]
	[Address(RVA = "0x2EFFD64", Offset = "0x2EFFD64", VA = "0x2EFFD64")]
	public string _003C_003EiFixBaseProxy_GetPeakDayExpiredKey()
	{
		return null;
	}

	[Token(Token = "0x60096E2")]
	[Address(RVA = "0x2EFFD6C", Offset = "0x2EFFD6C", VA = "0x2EFFD6C")]
	public string _003C_003EiFixBaseProxy_GetPeakDayLoginKey()
	{
		return null;
	}

	[Token(Token = "0x60096E3")]
	[Address(RVA = "0x2EFFD74", Offset = "0x2EFFD74", VA = "0x2EFFD74")]
	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_GetRewandWndStyle()
	{
		return default(UICommonRewardWndController.WndStyleEnum);
	}

	[Token(Token = "0x60096E4")]
	[Address(RVA = "0x2EFFD7C", Offset = "0x2EFFD7C", VA = "0x2EFFD7C")]
	public UIStandardItemMiniController _003C_003EiFixBaseProxy_GetItemController()
	{
		return null;
	}
}
