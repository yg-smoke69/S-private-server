using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200099C")]
public class PlayerCrossOverState : StateMachineBehaviour
{
	[Token(Token = "0x400595A")]
	[FieldOffset(Offset = "0xC")]
	public float CrossJumpTimeTotal;

	[Token(Token = "0x400595B")]
	[FieldOffset(Offset = "0x10")]
	public float CrossFallTimeTotal;

	[Token(Token = "0x400595C")]
	[FieldOffset(Offset = "0x14")]
	private Player m_OwnerPlayer;

	[Token(Token = "0x600498D")]
	[Address(RVA = "0x14E230C", Offset = "0x14E230C", VA = "0x14E230C")]
	public PlayerCrossOverState()
	{
	}

	[Token(Token = "0x600498E")]
	[Address(RVA = "0x14E2314", Offset = "0x14E2314", VA = "0x14E2314", Slot = "4")]
	public override void OnStateEnter(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x600498F")]
	[Address(RVA = "0x14E2530", Offset = "0x14E2530", VA = "0x14E2530", Slot = "6")]
	public override void OnStateExit(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x6004990")]
	[Address(RVA = "0x14E2648", Offset = "0x14E2648", VA = "0x14E2648")]
	public void _003C_003EiFixBaseProxy_OnStateEnter(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x6004991")]
	[Address(RVA = "0x14E2698", Offset = "0x14E2698", VA = "0x14E2698")]
	public void _003C_003EiFixBaseProxy_OnStateExit(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}
}
