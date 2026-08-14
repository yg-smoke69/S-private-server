using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20009A4")]
public class PlayerMoveEmoteStateLobby : StateMachineBehaviour
{
	[Token(Token = "0x4005973")]
	[FieldOffset(Offset = "0xC")]
	private UIMaleAvatar m_OwnerPlayer;

	[Token(Token = "0x4005974")]
	[FieldOffset(Offset = "0x10")]
	private float m_PrevTime;

	[Token(Token = "0x4005975")]
	[FieldOffset(Offset = "0x14")]
	private uint m_EmoteID;

	[Token(Token = "0x4005976")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsMoveEmote;

	[Token(Token = "0x4005977")]
	[FieldOffset(Offset = "0x1C")]
	private float[] m_MoveEmoteFootStepTriggerTime;

	[Token(Token = "0x4005978")]
	[FieldOffset(Offset = "0x20")]
	private ResourceID m_FootStepRes;

	[Token(Token = "0x60049DF")]
	[Address(RVA = "0x14E7DA0", Offset = "0x14E7DA0", VA = "0x14E7DA0")]
	public PlayerMoveEmoteStateLobby()
	{
	}

	[Token(Token = "0x60049E0")]
	[Address(RVA = "0x14E7DA8", Offset = "0x14E7DA8", VA = "0x14E7DA8", Slot = "4")]
	public override void OnStateEnter(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60049E1")]
	[Address(RVA = "0x14E8038", Offset = "0x14E8038", VA = "0x14E8038", Slot = "5")]
	public override void OnStateUpdate(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60049E2")]
	[Address(RVA = "0x14E8374", Offset = "0x14E8374", VA = "0x14E8374", Slot = "6")]
	public override void OnStateExit(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60049E3")]
	[Address(RVA = "0x14E8444", Offset = "0x14E8444", VA = "0x14E8444")]
	public void _003C_003EiFixBaseProxy_OnStateEnter(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x60049E4")]
	[Address(RVA = "0x14E8494", Offset = "0x14E8494", VA = "0x14E8494")]
	public void _003C_003EiFixBaseProxy_OnStateUpdate(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x60049E5")]
	[Address(RVA = "0x14E84E4", Offset = "0x14E84E4", VA = "0x14E84E4")]
	public void _003C_003EiFixBaseProxy_OnStateExit(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}
}
