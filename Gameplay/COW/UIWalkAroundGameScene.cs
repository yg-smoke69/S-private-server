using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2004194")]
internal class UIWalkAroundGameScene : UIInGameScene
{
	[Token(Token = "0x401B7CF")]
	[FieldOffset(Offset = "0x2C8")]
	private WalkAroundGame m_CurrentGame;

	[Token(Token = "0x601AC93")]
	[Address(RVA = "0x101C848", Offset = "0x101C848", VA = "0x101C848")]
	public UIWalkAroundGameScene()
	{
	}

	[Token(Token = "0x601AC94")]
	[Address(RVA = "0x101C8CC", Offset = "0x101C8CC", VA = "0x101C8CC", Slot = "17")]
	public override void OpenHud()
	{
	}

	[Token(Token = "0x601AC95")]
	[Address(RVA = "0x101C94C", Offset = "0x101C94C", VA = "0x101C94C", Slot = "11")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601AC96")]
	[Address(RVA = "0x101CB74", Offset = "0x101CB74", VA = "0x101CB74", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x601AC97")]
	[Address(RVA = "0x101CBD8", Offset = "0x101CBD8", VA = "0x101CBD8", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x601AC98")]
	[Address(RVA = "0x101CC3C", Offset = "0x101CC3C", VA = "0x101CC3C", Slot = "14")]
	protected override bool OnCheckInviteNtf()
	{
		return default(bool);
	}

	[Token(Token = "0x601AC99")]
	[Address(RVA = "0x101CC94", Offset = "0x101CC94", VA = "0x101CC94")]
	public void _003C_003EiFixBaseProxy_OpenHud()
	{
	}

	[Token(Token = "0x601AC9A")]
	[Address(RVA = "0x101CC9C", Offset = "0x101CC9C", VA = "0x101CC9C")]
	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	[Token(Token = "0x601AC9B")]
	[Address(RVA = "0x101CCA4", Offset = "0x101CCA4", VA = "0x101CCA4")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x601AC9C")]
	[Address(RVA = "0x101CCAC", Offset = "0x101CCAC", VA = "0x101CCAC")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x601AC9D")]
	[Address(RVA = "0x101CCB4", Offset = "0x101CCB4", VA = "0x101CCB4")]
	public bool _003C_003EiFixBaseProxy_OnCheckInviteNtf()
	{
		return default(bool);
	}
}
