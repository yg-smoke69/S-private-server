using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F3F")]
public class UIFFWS03PeakDayWndController : UIBigEventPeakDayWndBaseController
{
	[Token(Token = "0x6009A41")]
	[Address(RVA = "0x1DB0298", Offset = "0x1DB0298", VA = "0x1DB0298")]
	public UIFFWS03PeakDayWndController()
	{
	}

	[Token(Token = "0x6009A42")]
	[Address(RVA = "0x1DB02A0", Offset = "0x1DB02A0", VA = "0x1DB02A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009A43")]
	[Address(RVA = "0x1DB0348", Offset = "0x1DB0348", VA = "0x1DB0348", Slot = "49")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009A44")]
	[Address(RVA = "0x1DB03A0", Offset = "0x1DB03A0", VA = "0x1DB03A0", Slot = "48")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009A45")]
	[Address(RVA = "0x1DB03F8", Offset = "0x1DB03F8", VA = "0x1DB03F8", Slot = "52")]
	public override string GetPeakDayExpiredKey()
	{
		return null;
	}

	[Token(Token = "0x6009A46")]
	[Address(RVA = "0x1DB049C", Offset = "0x1DB049C", VA = "0x1DB049C", Slot = "51")]
	public override string GetPeakDayLoginKey()
	{
		return null;
	}

	[Token(Token = "0x6009A47")]
	[Address(RVA = "0x1DB0540", Offset = "0x1DB0540", VA = "0x1DB0540", Slot = "53")]
	public override UICommonRewardWndController.WndStyleEnum GetRewandWndStyle()
	{
		return default(UICommonRewardWndController.WndStyleEnum);
	}

	[Token(Token = "0x6009A48")]
	[Address(RVA = "0x1DB05A4", Offset = "0x1DB05A4", VA = "0x1DB05A4")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009A49")]
	[Address(RVA = "0x1DB05AC", Offset = "0x1DB05AC", VA = "0x1DB05AC")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009A4A")]
	[Address(RVA = "0x1DB05B4", Offset = "0x1DB05B4", VA = "0x1DB05B4")]
	public string _003C_003EiFixBaseProxy_GetPeakDayExpiredKey()
	{
		return null;
	}

	[Token(Token = "0x6009A4B")]
	[Address(RVA = "0x1DB05BC", Offset = "0x1DB05BC", VA = "0x1DB05BC")]
	public string _003C_003EiFixBaseProxy_GetPeakDayLoginKey()
	{
		return null;
	}

	[Token(Token = "0x6009A4C")]
	[Address(RVA = "0x1DB05C4", Offset = "0x1DB05C4", VA = "0x1DB05C4")]
	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_GetRewandWndStyle()
	{
		return default(UICommonRewardWndController.WndStyleEnum);
	}
}
