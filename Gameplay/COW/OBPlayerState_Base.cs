using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A0B")]
internal class OBPlayerState_Base
{
	[Token(Token = "0x40102B3")]
	[FieldOffset(Offset = "0x8")]
	protected UIOBPlayerNamePlateView m_OwnedView;

	[Token(Token = "0x40102B4")]
	[FieldOffset(Offset = "0xC")]
	public bool m_IsShowTeamIcon;

	[Token(Token = "0x17001275")]
	public virtual EOBPlayerStateType StateType
	{
		[Token(Token = "0x6010FE2")]
		[Address(RVA = "0x28BB950", Offset = "0x28BB950", VA = "0x28BB950", Slot = "4")]
		get
		{
			return default(EOBPlayerStateType);
		}
	}

	[Token(Token = "0x6010FE1")]
	[Address(RVA = "0x28BB504", Offset = "0x28BB504", VA = "0x28BB504")]
	public OBPlayerState_Base(UIOBPlayerNamePlateView view)
	{
	}

	[Token(Token = "0x6010FE3")]
	[Address(RVA = "0x28BB9AC", Offset = "0x28BB9AC", VA = "0x28BB9AC", Slot = "5")]
	public virtual void EnterState(EOBPlayerStateType next_state_type)
	{
	}

	[Token(Token = "0x6010FE4")]
	[Address(RVA = "0x28BBA0C", Offset = "0x28BBA0C", VA = "0x28BBA0C", Slot = "6")]
	public virtual bool ExitState(EOBPlayerStateType next_state_type)
	{
		return default(bool);
	}

	[Token(Token = "0x6010FE5")]
	[Address(RVA = "0x28BB8EC", Offset = "0x28BB8EC", VA = "0x28BB8EC", Slot = "7")]
	public virtual void IsShowTeamIcon(bool show)
	{
	}
}
