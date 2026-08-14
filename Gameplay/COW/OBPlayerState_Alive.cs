using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A0C")]
internal class OBPlayerState_Alive : OBPlayerState_Base
{
	[Token(Token = "0x17001276")]
	public override EOBPlayerStateType StateType
	{
		[Token(Token = "0x6010FE7")]
		[Address(RVA = "0x28BB524", Offset = "0x28BB524", VA = "0x28BB524", Slot = "4")]
		get
		{
			return default(EOBPlayerStateType);
		}
	}

	[Token(Token = "0x6010FE6")]
	[Address(RVA = "0x28BB4E4", Offset = "0x28BB4E4", VA = "0x28BB4E4")]
	public OBPlayerState_Alive(UIOBPlayerNamePlateView view)
	{
	}

	[Token(Token = "0x6010FE8")]
	[Address(RVA = "0x28BB57C", Offset = "0x28BB57C", VA = "0x28BB57C", Slot = "5")]
	public override void EnterState(EOBPlayerStateType next_state_type)
	{
	}

	[Token(Token = "0x6010FE9")]
	[Address(RVA = "0x28BB6A4", Offset = "0x28BB6A4", VA = "0x28BB6A4", Slot = "6")]
	public override bool ExitState(EOBPlayerStateType next_state_type)
	{
		return default(bool);
	}

	[Token(Token = "0x6010FEA")]
	[Address(RVA = "0x28BB7B8", Offset = "0x28BB7B8", VA = "0x28BB7B8", Slot = "7")]
	public override void IsShowTeamIcon(bool show)
	{
	}

	[Token(Token = "0x6010FEB")]
	[Address(RVA = "0x28BB94C", Offset = "0x28BB94C", VA = "0x28BB94C")]
	public EOBPlayerStateType _003C_003EiFixBaseProxy_get_StateType()
	{
		return default(EOBPlayerStateType);
	}

	[Token(Token = "0x6010FEC")]
	[Address(RVA = "0x28BB9A8", Offset = "0x28BB9A8", VA = "0x28BB9A8")]
	public void _003C_003EiFixBaseProxy_EnterState(EOBPlayerStateType P0)
	{
	}

	[Token(Token = "0x6010FED")]
	[Address(RVA = "0x28BBA08", Offset = "0x28BBA08", VA = "0x28BBA08")]
	public bool _003C_003EiFixBaseProxy_ExitState(EOBPlayerStateType P0)
	{
		return default(bool);
	}

	[Token(Token = "0x6010FEE")]
	[Address(RVA = "0x28BBA70", Offset = "0x28BBA70", VA = "0x28BBA70")]
	public void _003C_003EiFixBaseProxy_IsShowTeamIcon(bool P0)
	{
	}
}
