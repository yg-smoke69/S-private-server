using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F0F")]
internal class UIDigitaluniverseBWarmUpController : UIBigEventNaviPopBaseController
{
	[Token(Token = "0x400C367")]
	[FieldOffset(Offset = "0x70")]
	private UIDigitaluniverseBWarmUpView m_View;

	[Token(Token = "0x400C368")]
	[FieldOffset(Offset = "0x74")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C369")]
	[FieldOffset(Offset = "0x78")]
	private UIDigitaluniverseBTopBtnController m_TopBtnCtrl;

	[Token(Token = "0x6009846")]
	[Address(RVA = "0x275A508", Offset = "0x275A508", VA = "0x275A508")]
	public UIDigitaluniverseBWarmUpController()
	{
	}

	[Token(Token = "0x6009847")]
	[Address(RVA = "0x275A510", Offset = "0x275A510", VA = "0x275A510")]
	public static UIDigitaluniverseBWarmUpController Push()
	{
		return null;
	}

	[Token(Token = "0x6009848")]
	[Address(RVA = "0x275A6B4", Offset = "0x275A6B4", VA = "0x275A6B4", Slot = "38")]
	public override EFrontendBGMType GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x6009849")]
	[Address(RVA = "0x275A70C", Offset = "0x275A70C", VA = "0x275A70C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600984A")]
	[Address(RVA = "0x275A7B4", Offset = "0x275A7B4", VA = "0x275A7B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600984B")]
	[Address(RVA = "0x275AB30", Offset = "0x275AB30", VA = "0x275AB30", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600984C")]
	[Address(RVA = "0x275AB94", Offset = "0x275AB94", VA = "0x275AB94", Slot = "43")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x600984D")]
	[Address(RVA = "0x275ABEC", Offset = "0x275ABEC", VA = "0x275ABEC", Slot = "45")]
	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x600984E")]
	[Address(RVA = "0x275AC44", Offset = "0x275AC44", VA = "0x275AC44", Slot = "44")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x600984F")]
	[Address(RVA = "0x275AC9C", Offset = "0x275AC9C", VA = "0x275AC9C")]
	public new EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x6009850")]
	[Address(RVA = "0x275ACA4", Offset = "0x275ACA4", VA = "0x275ACA4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009851")]
	[Address(RVA = "0x275ACAC", Offset = "0x275ACAC", VA = "0x275ACAC")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6009852")]
	[Address(RVA = "0x275ACB4", Offset = "0x275ACB4", VA = "0x275ACB4")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009853")]
	[Address(RVA = "0x275ACBC", Offset = "0x275ACBC", VA = "0x275ACBC")]
	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x6009854")]
	[Address(RVA = "0x275ACC4", Offset = "0x275ACC4", VA = "0x275ACC4")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}
}
