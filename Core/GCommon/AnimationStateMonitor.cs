using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003ED3")]
public class AnimationStateMonitor : StateMachineBehaviour
{
	[Token(Token = "0x401A870")]
	[FieldOffset(Offset = "0xC")]
	public string AnimIDString;

	[Token(Token = "0x401A871")]
	[FieldOffset(Offset = "0x10")]
	public float EndCutTime;

	[Token(Token = "0x401A872")]
	[FieldOffset(Offset = "0x14")]
	public bool AutoTransitionToDefaultState;

	[Token(Token = "0x401A873")]
	[FieldOffset(Offset = "0x18")]
	protected AnimationID m_AnimID;

	[Token(Token = "0x401A874")]
	[FieldOffset(Offset = "0x1C")]
	protected AnimationSystemComponent m_AnimSystem;

	[Token(Token = "0x401A875")]
	[FieldOffset(Offset = "0x20")]
	protected float m_LastTime;

	[Token(Token = "0x601992E")]
	[Address(RVA = "0x26B5F24", Offset = "0x26B5F24", VA = "0x26B5F24")]
	public AnimationStateMonitor()
	{
	}

	[Token(Token = "0x601992F")]
	[Address(RVA = "0x26B5F40", Offset = "0x26B5F40", VA = "0x26B5F40", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6019930")]
	[Address(RVA = "0x26B60F8", Offset = "0x26B60F8", VA = "0x26B60F8", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}
