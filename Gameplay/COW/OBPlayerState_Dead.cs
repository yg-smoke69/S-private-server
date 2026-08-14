using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A0E")]
internal class OBPlayerState_Dead : OBPlayerState_Base
{
	[Token(Token = "0x17001278")]
	public override EOBPlayerStateType StateType
	{
		[Token(Token = "0x6010FF7")]
		[Address(RVA = "0x28BBA94", Offset = "0x28BBA94", VA = "0x28BBA94", Slot = "4")]
		get
		{
			return default(EOBPlayerStateType);
		}
	}

	[Token(Token = "0x6010FF6")]
	[Address(RVA = "0x28BBA74", Offset = "0x28BBA74", VA = "0x28BBA74")]
	public OBPlayerState_Dead(UIOBPlayerNamePlateView view)
	{
	}

	[Token(Token = "0x6010FF8")]
	[Address(RVA = "0x28BBAEC", Offset = "0x28BBAEC", VA = "0x28BBAEC", Slot = "5")]
	public override void EnterState(EOBPlayerStateType next_state_type)
	{
	}

	[Token(Token = "0x6010FF9")]
	[Address(RVA = "0x28BBBA4", Offset = "0x28BBBA4", VA = "0x28BBBA4", Slot = "6")]
	public override bool ExitState(EOBPlayerStateType next_state)
	{
		return default(bool);
	}

	[Token(Token = "0x6010FFA")]
	[Address(RVA = "0x28BBC70", Offset = "0x28BBC70", VA = "0x28BBC70")]
	public EOBPlayerStateType _003C_003EiFixBaseProxy_get_StateType()
	{
		return default(EOBPlayerStateType);
	}

	[Token(Token = "0x6010FFB")]
	[Address(RVA = "0x28BBC74", Offset = "0x28BBC74", VA = "0x28BBC74")]
	public void _003C_003EiFixBaseProxy_EnterState(EOBPlayerStateType P0)
	{
	}

	[Token(Token = "0x6010FFC")]
	[Address(RVA = "0x28BBC78", Offset = "0x28BBC78", VA = "0x28BBC78")]
	public bool _003C_003EiFixBaseProxy_ExitState(EOBPlayerStateType P0)
	{
		return default(bool);
	}
}
