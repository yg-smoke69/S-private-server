using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002222")]
public class UIHudMatchResultClanState : UIHudMatchResultStateBase
{
	[Token(Token = "0x400D521")]
	[FieldOffset(Offset = "0x14")]
	private FakeSubmitRes m_ClanMatchResult;

	[Token(Token = "0x600B8D3")]
	[Address(RVA = "0x19B1BF8", Offset = "0x19B1BF8", VA = "0x19B1BF8")]
	public UIHudMatchResultClanState(UIHudMatchResultStateMachine machine)
	{
	}

	[Token(Token = "0x600B8D4")]
	[Address(RVA = "0x19B1C20", Offset = "0x19B1C20", VA = "0x19B1C20", Slot = "4")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600B8D5")]
	[Address(RVA = "0x19B1D44", Offset = "0x19B1D44", VA = "0x19B1D44", Slot = "5")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600B8D6")]
	[Address(RVA = "0x19B1E24", Offset = "0x19B1E24", VA = "0x19B1E24", Slot = "6")]
	protected override bool OnEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x600B8D7")]
	[Address(RVA = "0x19B1F74", Offset = "0x19B1F74", VA = "0x19B1F74", Slot = "7")]
	protected override void OnFinish()
	{
	}

	[Token(Token = "0x600B8D8")]
	[Address(RVA = "0x19B1FF4", Offset = "0x19B1FF4", VA = "0x19B1FF4", Slot = "8")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x600B8D9")]
	[Address(RVA = "0x19B2050", Offset = "0x19B2050", VA = "0x19B2050")]
	public void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	[Token(Token = "0x600B8DA")]
	[Address(RVA = "0x19B2054", Offset = "0x19B2054", VA = "0x19B2054")]
	public bool _003C_003EiFixBaseProxy_OnCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600B8DB")]
	[Address(RVA = "0x19B2058", Offset = "0x19B2058", VA = "0x19B2058")]
	public bool _003C_003EiFixBaseProxy_OnEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x600B8DC")]
	[Address(RVA = "0x19B205C", Offset = "0x19B205C", VA = "0x19B205C")]
	public void _003C_003EiFixBaseProxy_OnFinish()
	{
	}

	[Token(Token = "0x600B8DD")]
	[Address(RVA = "0x19B2060", Offset = "0x19B2060", VA = "0x19B2060")]
	public void _003C_003EiFixBaseProxy_OnExit()
	{
	}
}
