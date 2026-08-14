using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A0D")]
internal class OBPlayerState_KnockDown : OBPlayerState_Base
{
	[Token(Token = "0x17001277")]
	public override EOBPlayerStateType StateType
	{
		[Token(Token = "0x6010FF0")]
		[Address(RVA = "0x28BBC9C", Offset = "0x28BBC9C", VA = "0x28BBC9C", Slot = "4")]
		get
		{
			return default(EOBPlayerStateType);
		}
	}

	[Token(Token = "0x6010FEF")]
	[Address(RVA = "0x28BBC7C", Offset = "0x28BBC7C", VA = "0x28BBC7C")]
	public OBPlayerState_KnockDown(UIOBPlayerNamePlateView view)
	{
	}

	[Token(Token = "0x6010FF1")]
	[Address(RVA = "0x28BBCF4", Offset = "0x28BBCF4", VA = "0x28BBCF4", Slot = "5")]
	public override void EnterState(EOBPlayerStateType next_state_type)
	{
	}

	[Token(Token = "0x6010FF2")]
	[Address(RVA = "0x28BBDAC", Offset = "0x28BBDAC", VA = "0x28BBDAC", Slot = "6")]
	public override bool ExitState(EOBPlayerStateType next_state_type)
	{
		return default(bool);
	}

	[Token(Token = "0x6010FF3")]
	[Address(RVA = "0x28BBE68", Offset = "0x28BBE68", VA = "0x28BBE68")]
	public EOBPlayerStateType _003C_003EiFixBaseProxy_get_StateType()
	{
		return default(EOBPlayerStateType);
	}

	[Token(Token = "0x6010FF4")]
	[Address(RVA = "0x28BBE6C", Offset = "0x28BBE6C", VA = "0x28BBE6C")]
	public void _003C_003EiFixBaseProxy_EnterState(EOBPlayerStateType P0)
	{
	}

	[Token(Token = "0x6010FF5")]
	[Address(RVA = "0x28BBE70", Offset = "0x28BBE70", VA = "0x28BBE70")]
	public bool _003C_003EiFixBaseProxy_ExitState(EOBPlayerStateType P0)
	{
		return default(bool);
	}
}
