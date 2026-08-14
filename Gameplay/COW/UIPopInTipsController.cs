using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A68")]
internal class UIPopInTipsController : UIPopupWindowController
{
	[Token(Token = "0x4010491")]
	[FieldOffset(Offset = "0x48")]
	private UIPopInTipsView m_View;

	[Token(Token = "0x4010492")]
	private const int AUTO_SHOW_DETAIL_COUNTDOWN = 10;

	[Token(Token = "0x4010493")]
	[FieldOffset(Offset = "0x50")]
	private ulong m_UserID;

	[Token(Token = "0x4010494")]
	[FieldOffset(Offset = "0x58")]
	private float m_CountDownTime;

	[Token(Token = "0x6011411")]
	[Address(RVA = "0x2C56074", Offset = "0x2C56074", VA = "0x2C56074")]
	public UIPopInTipsController()
	{
	}

	[Token(Token = "0x6011412")]
	[Address(RVA = "0x2C5607C", Offset = "0x2C5607C", VA = "0x2C5607C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011413")]
	[Address(RVA = "0x2C56258", Offset = "0x2C56258", VA = "0x2C56258")]
	public void Update()
	{
	}

	[Token(Token = "0x6011414")]
	[Address(RVA = "0x2C5646C", Offset = "0x2C5646C", VA = "0x2C5646C")]
	private void OnClickRejectBtn()
	{
	}

	[Token(Token = "0x6011415")]
	[Address(RVA = "0x2C56554", Offset = "0x2C56554", VA = "0x2C56554")]
	private void OnClickConfirmBtn()
	{
	}

	[Token(Token = "0x6011416")]
	[Address(RVA = "0x2C563EC", Offset = "0x2C563EC", VA = "0x2C563EC")]
	private bool CanUpdateCountDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6011417")]
	[Address(RVA = "0x2C56824", Offset = "0x2C56824", VA = "0x2C56824")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011418")]
	[Address(RVA = "0x2C568CC", Offset = "0x2C568CC", VA = "0x2C568CC")]
	public void SetData(ulong userId, string nickname)
	{
	}

	[Token(Token = "0x6011419")]
	[Address(RVA = "0x2C56CA0", Offset = "0x2C56CA0", VA = "0x2C56CA0", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x601141A")]
	[Address(RVA = "0x2C56D0C", Offset = "0x2C56D0C", VA = "0x2C56D0C", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x601141B")]
	[Address(RVA = "0x2C56D78", Offset = "0x2C56D78", VA = "0x2C56D78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601141C")]
	[Address(RVA = "0x2C56D80", Offset = "0x2C56D80", VA = "0x2C56D80")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x601141D")]
	[Address(RVA = "0x2C56D88", Offset = "0x2C56D88", VA = "0x2C56D88")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
