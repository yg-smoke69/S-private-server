using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200098A")]
public class PlayerAliveState : StateMachineBehaviour
{
	[Token(Token = "0x40058A2")]
	[FieldOffset(Offset = "0xC")]
	public float triggerTime1;

	[Token(Token = "0x40058A3")]
	[FieldOffset(Offset = "0x10")]
	public float triggerTime2;

	[Token(Token = "0x40058A4")]
	[FieldOffset(Offset = "0x14")]
	private PlayerAudioComponent m_PlayerAudio;

	[Token(Token = "0x40058A5")]
	[FieldOffset(Offset = "0x18")]
	private float m_PrevTime;

	[Token(Token = "0x40058A6")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_exit;

	[Token(Token = "0x60048CC")]
	[Address(RVA = "0x1C07518", Offset = "0x1C07518", VA = "0x1C07518")]
	public PlayerAliveState()
	{
	}

	[Token(Token = "0x60048CD")]
	[Address(RVA = "0x1C07520", Offset = "0x1C07520", VA = "0x1C07520", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x60048CE")]
	[Address(RVA = "0x1C07650", Offset = "0x1C07650", VA = "0x1C07650", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x60048CF")]
	[Address(RVA = "0x1C07934", Offset = "0x1C07934", VA = "0x1C07934", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x60048D0")]
	[Address(RVA = "0x1C07A04", Offset = "0x1C07A04", VA = "0x1C07A04")]
	public void _003C_003EiFixBaseProxy_OnStateEnter(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x60048D1")]
	[Address(RVA = "0x1C07A54", Offset = "0x1C07A54", VA = "0x1C07A54")]
	public void _003C_003EiFixBaseProxy_OnStateUpdate(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x60048D2")]
	[Address(RVA = "0x1C07AA4", Offset = "0x1C07AA4", VA = "0x1C07AA4")]
	public void _003C_003EiFixBaseProxy_OnStateExit(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}
}
