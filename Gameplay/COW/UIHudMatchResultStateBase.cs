using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200222C")]
public class UIHudMatchResultStateBase
{
	[Token(Token = "0x400D532")]
	[FieldOffset(Offset = "0x8")]
	private EUIHudMatchResultState m_State;

	[Token(Token = "0x400D533")]
	[FieldOffset(Offset = "0xC")]
	private UIHudMatchResultStateMachine m_StateMachine;

	[Token(Token = "0x400D534")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsInit;

	[Token(Token = "0x17001039")]
	public EUIHudMatchResultState State
	{
		[Token(Token = "0x600B930")]
		[Address(RVA = "0x19C0108", Offset = "0x19C0108", VA = "0x19C0108")]
		get
		{
			return default(EUIHudMatchResultState);
		}
	}

	[Token(Token = "0x1700103A")]
	public UIHudMatchResultStateMachine StateMachine
	{
		[Token(Token = "0x600B931")]
		[Address(RVA = "0x19B11E8", Offset = "0x19B11E8", VA = "0x19B11E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B92F")]
	[Address(RVA = "0x19B1060", Offset = "0x19B1060", VA = "0x19B1060")]
	public UIHudMatchResultStateBase(UIHudMatchResultStateMachine machine, EUIHudMatchResultState state)
	{
	}

	[Token(Token = "0x600B932")]
	[Address(RVA = "0x19C0160", Offset = "0x19C0160", VA = "0x19C0160")]
	public void Enter()
	{
	}

	[Token(Token = "0x600B933")]
	[Address(RVA = "0x19C028C", Offset = "0x19C028C", VA = "0x19C028C")]
	public void Exit()
	{
	}

	[Token(Token = "0x600B934")]
	[Address(RVA = "0x19C0220", Offset = "0x19C0220", VA = "0x19C0220")]
	public void Finish()
	{
	}

	[Token(Token = "0x600B935")]
	[Address(RVA = "0x19B1194", Offset = "0x19B1194", VA = "0x19B1194", Slot = "4")]
	protected virtual void OnInit()
	{
	}

	[Token(Token = "0x600B936")]
	[Address(RVA = "0x19B16F4", Offset = "0x19B16F4", VA = "0x19B16F4", Slot = "5")]
	protected virtual bool OnCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600B937")]
	[Address(RVA = "0x19B1750", Offset = "0x19B1750", VA = "0x19B1750", Slot = "6")]
	protected virtual bool OnEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x600B938")]
	[Address(RVA = "0x19B17AC", Offset = "0x19B17AC", VA = "0x19B17AC", Slot = "7")]
	protected virtual void OnFinish()
	{
	}

	[Token(Token = "0x600B939")]
	[Address(RVA = "0x19B1698", Offset = "0x19B1698", VA = "0x19B1698", Slot = "8")]
	protected virtual void OnExit()
	{
	}
}
