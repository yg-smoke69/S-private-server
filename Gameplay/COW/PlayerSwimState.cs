using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20009D7")]
public class PlayerSwimState : StateMachineBehaviour
{
	[Token(Token = "0x40059FD")]
	[FieldOffset(Offset = "0xC")]
	public float triggerTime1;

	[Token(Token = "0x40059FE")]
	[FieldOffset(Offset = "0x10")]
	public float triggerTime2;

	[Token(Token = "0x40059FF")]
	[FieldOffset(Offset = "0x14")]
	private PlayerAudioComponent m_PlayerAudio;

	[Token(Token = "0x4005A00")]
	[FieldOffset(Offset = "0x18")]
	private float m_PrevTime;

	[Token(Token = "0x6004BD6")]
	[Address(RVA = "0x1C0CA6C", Offset = "0x1C0CA6C", VA = "0x1C0CA6C")]
	public PlayerSwimState()
	{
	}

	[Token(Token = "0x6004BD7")]
	[Address(RVA = "0x1C0CA74", Offset = "0x1C0CA74", VA = "0x1C0CA74", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004BD8")]
	[Address(RVA = "0x1C0CB9C", Offset = "0x1C0CB9C", VA = "0x1C0CB9C", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004BD9")]
	[Address(RVA = "0x1C0CDE4", Offset = "0x1C0CDE4", VA = "0x1C0CDE4", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004BDA")]
	[Address(RVA = "0x1C0CEAC", Offset = "0x1C0CEAC", VA = "0x1C0CEAC")]
	public void _003C_003EiFixBaseProxy_OnStateEnter(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x6004BDB")]
	[Address(RVA = "0x1C0CEFC", Offset = "0x1C0CEFC", VA = "0x1C0CEFC")]
	public void _003C_003EiFixBaseProxy_OnStateUpdate(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x6004BDC")]
	[Address(RVA = "0x1C0CF4C", Offset = "0x1C0CF4C", VA = "0x1C0CF4C")]
	public void _003C_003EiFixBaseProxy_OnStateExit(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}
}
