using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20009A3")]
public class PlayerMoveEmoteState : StateMachineBehaviour
{
	[Token(Token = "0x400596C")]
	[FieldOffset(Offset = "0xC")]
	private Player m_OwnerPlayer;

	[Token(Token = "0x400596D")]
	[FieldOffset(Offset = "0x10")]
	private float m_PrevTime;

	[Token(Token = "0x400596E")]
	[FieldOffset(Offset = "0x14")]
	private uint m_EmoteID;

	[Token(Token = "0x400596F")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsMoveEmote;

	[Token(Token = "0x4005970")]
	[FieldOffset(Offset = "0x1C")]
	private float[] m_MoveEmoteFootStepTriggerTime;

	[Token(Token = "0x4005971")]
	[FieldOffset(Offset = "0x20")]
	private ResourceID m_FootStepRes;

	[Token(Token = "0x4005972")]
	[FieldOffset(Offset = "0x24")]
	private GameObject m_FootStepAudio;

	[Token(Token = "0x60049D8")]
	[Address(RVA = "0x14E71DC", Offset = "0x14E71DC", VA = "0x14E71DC")]
	public PlayerMoveEmoteState()
	{
	}

	[Token(Token = "0x60049D9")]
	[Address(RVA = "0x14E71E4", Offset = "0x14E71E4", VA = "0x14E71E4", Slot = "4")]
	public override void OnStateEnter(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60049DA")]
	[Address(RVA = "0x14E7564", Offset = "0x14E7564", VA = "0x14E7564", Slot = "5")]
	public override void OnStateUpdate(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60049DB")]
	[Address(RVA = "0x14E7A18", Offset = "0x14E7A18", VA = "0x14E7A18", Slot = "6")]
	public override void OnStateExit(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60049DC")]
	[Address(RVA = "0x14E7CB0", Offset = "0x14E7CB0", VA = "0x14E7CB0")]
	public void _003C_003EiFixBaseProxy_OnStateEnter(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x60049DD")]
	[Address(RVA = "0x14E7D00", Offset = "0x14E7D00", VA = "0x14E7D00")]
	public void _003C_003EiFixBaseProxy_OnStateUpdate(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x60049DE")]
	[Address(RVA = "0x14E7D50", Offset = "0x14E7D50", VA = "0x14E7D50")]
	public void _003C_003EiFixBaseProxy_OnStateExit(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}
}
