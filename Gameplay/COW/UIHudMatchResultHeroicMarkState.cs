using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002225")]
public class UIHudMatchResultHeroicMarkState : UIHudMatchResultStateBase
{
	[Token(Token = "0x400D523")]
	[FieldOffset(Offset = "0x14")]
	private EHeroicMarkType m_HeroicType;

	[Token(Token = "0x400D524")]
	[FieldOffset(Offset = "0x18")]
	private uint m_HeroicBefore;

	[Token(Token = "0x400D525")]
	[FieldOffset(Offset = "0x1C")]
	private uint m_HeroicAfter;

	[Token(Token = "0x400D526")]
	[FieldOffset(Offset = "0x20")]
	private uint m_RankBefore;

	[Token(Token = "0x400D527")]
	[FieldOffset(Offset = "0x24")]
	private uint m_RankAfter;

	[Token(Token = "0x400D528")]
	[FieldOffset(Offset = "0x28")]
	private bool isFirstMaster;

	[Token(Token = "0x600B8F0")]
	[Address(RVA = "0x19B2064", Offset = "0x19B2064", VA = "0x19B2064")]
	public UIHudMatchResultHeroicMarkState(UIHudMatchResultStateMachine machine)
	{
	}

	[Token(Token = "0x600B8F1")]
	[Address(RVA = "0x19B2098", Offset = "0x19B2098", VA = "0x19B2098", Slot = "5")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600B8F2")]
	[Address(RVA = "0x19B2EFC", Offset = "0x19B2EFC", VA = "0x19B2EFC", Slot = "6")]
	protected override bool OnEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x600B8F3")]
	[Address(RVA = "0x19B30DC", Offset = "0x19B30DC", VA = "0x19B30DC", Slot = "7")]
	protected override void OnFinish()
	{
	}

	[Token(Token = "0x600B8F4")]
	[Address(RVA = "0x19B3240", Offset = "0x19B3240", VA = "0x19B3240")]
	public bool _003C_003EiFixBaseProxy_OnCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600B8F5")]
	[Address(RVA = "0x19B3244", Offset = "0x19B3244", VA = "0x19B3244")]
	public bool _003C_003EiFixBaseProxy_OnEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x600B8F6")]
	[Address(RVA = "0x19B3248", Offset = "0x19B3248", VA = "0x19B3248")]
	public void _003C_003EiFixBaseProxy_OnFinish()
	{
	}
}
