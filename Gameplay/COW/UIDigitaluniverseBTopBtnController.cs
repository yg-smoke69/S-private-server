using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F0C")]
internal class UIDigitaluniverseBTopBtnController : UIBigEventTopBtnBaseController
{
	[Token(Token = "0x400C35D")]
	[FieldOffset(Offset = "0x34")]
	private EActivity.SubType m_Type;

	[Token(Token = "0x400C35E")]
	[FieldOffset(Offset = "0x38")]
	private UINavigationUtil.UINavigationFrom m_From;

	[Token(Token = "0x6009826")]
	[Address(RVA = "0x27572BC", Offset = "0x27572BC", VA = "0x27572BC")]
	public UIDigitaluniverseBTopBtnController()
	{
	}

	[Token(Token = "0x6009827")]
	[Address(RVA = "0x27572CC", Offset = "0x27572CC", VA = "0x27572CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009828")]
	[Address(RVA = "0x2757374", Offset = "0x2757374", VA = "0x2757374", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009829")]
	[Address(RVA = "0x2757530", Offset = "0x2757530", VA = "0x2757530")]
	public void ShowGoStoreBtn(bool state = true)
	{
	}

	[Token(Token = "0x600982A")]
	[Address(RVA = "0x2757698", Offset = "0x2757698", VA = "0x2757698")]
	private ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x600982B")]
	[Address(RVA = "0x27576F0", Offset = "0x27576F0", VA = "0x27576F0")]
	public void SetNavigationFrom(UINavigationUtil.UINavigationFrom from)
	{
	}

	[Token(Token = "0x600982C")]
	[Address(RVA = "0x2757750", Offset = "0x2757750", VA = "0x2757750")]
	private void OnStoreBtnClick()
	{
	}

	[Token(Token = "0x600982D")]
	[Address(RVA = "0x2757B3C", Offset = "0x2757B3C", VA = "0x2757B3C")]
	public void GetNavigationFromType(EActivity.SubType type)
	{
	}

	[Token(Token = "0x600982E")]
	[Address(RVA = "0x2757B9C", Offset = "0x2757B9C", VA = "0x2757B9C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
