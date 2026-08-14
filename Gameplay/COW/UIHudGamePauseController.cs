using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200275C")]
internal class UIHudGamePauseController : UIBaseController
{
	[Token(Token = "0x400F310")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGamePauseView m_View;

	[Token(Token = "0x400F311")]
	[FieldOffset(Offset = "0x2C")]
	private float m_CountDownTime;

	[Token(Token = "0x600F07D")]
	[Address(RVA = "0x188A73C", Offset = "0x188A73C", VA = "0x188A73C")]
	public UIHudGamePauseController()
	{
	}

	[Token(Token = "0x600F07E")]
	[Address(RVA = "0x188A7C0", Offset = "0x188A7C0", VA = "0x188A7C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F07F")]
	[Address(RVA = "0x188A868", Offset = "0x188A868", VA = "0x188A868", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F080")]
	[Address(RVA = "0x188AB10", Offset = "0x188AB10", VA = "0x188AB10")]
	private void OnRequestGameResumeConfirm(object[] param)
	{
	}

	[Token(Token = "0x600F081")]
	[Address(RVA = "0x188ABA8", Offset = "0x188ABA8", VA = "0x188ABA8")]
	private void OnPauseCheck(object[] param)
	{
	}

	[Token(Token = "0x600F082")]
	[Address(RVA = "0x188AC40", Offset = "0x188AC40", VA = "0x188AC40", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600F083")]
	[Address(RVA = "0x188ADD0", Offset = "0x188ADD0", VA = "0x188ADD0")]
	public void CSTutorialPause()
	{
	}

	[Token(Token = "0x600F084")]
	[Address(RVA = "0x188AE98", Offset = "0x188AE98", VA = "0x188AE98")]
	public void Pause()
	{
	}

	[Token(Token = "0x600F085")]
	[Address(RVA = "0x188B1C8", Offset = "0x188B1C8", VA = "0x188B1C8")]
	public void PreResume(byte time)
	{
	}

	[Token(Token = "0x600F086")]
	[Address(RVA = "0x188B540", Offset = "0x188B540", VA = "0x188B540")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x600F087")]
	[Address(RVA = "0x188B728", Offset = "0x188B728", VA = "0x188B728")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F088")]
	[Address(RVA = "0x188B730", Offset = "0x188B730", VA = "0x188B730")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
