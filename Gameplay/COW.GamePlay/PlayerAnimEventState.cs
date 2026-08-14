using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200098C")]
public class PlayerAnimEventState : StateMachineBehaviour
{
	[Token(Token = "0x40058B1")]
	[FieldOffset(Offset = "0xC")]
	public float triggerTime;

	[Token(Token = "0x40058B2")]
	[FieldOffset(Offset = "0x10")]
	public OHHHJLJHCKI animEvent;

	[Token(Token = "0x40058B3")]
	[FieldOffset(Offset = "0x14")]
	public bool localPlayerOnly;

	[Token(Token = "0x40058B4")]
	[FieldOffset(Offset = "0x18")]
	private Player m_OwnerPlayer;

	[Token(Token = "0x40058B5")]
	[FieldOffset(Offset = "0x1C")]
	private float m_PrevTime;

	[Token(Token = "0x40058B6")]
	[FieldOffset(Offset = "0x20")]
	private int m_Currentloop;

	[Token(Token = "0x40058B7")]
	[FieldOffset(Offset = "0x24")]
	private uint uniqueIndex;

	[Token(Token = "0x40058B8")]
	[FieldOffset(Offset = "0x28")]
	private AnimationID id;

	[Token(Token = "0x60048D3")]
	[Address(RVA = "0x25E71DC", Offset = "0x25E71DC", VA = "0x25E71DC")]
	public PlayerAnimEventState()
	{
	}

	[Token(Token = "0x60048D4")]
	[Address(RVA = "0x25E71E4", Offset = "0x25E71E4", VA = "0x25E71E4", Slot = "4")]
	public override void OnStateEnter(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60048D5")]
	[Address(RVA = "0x25E76F4", Offset = "0x25E76F4", VA = "0x25E76F4", Slot = "5")]
	public override void OnStateUpdate(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60048D6")]
	[Address(RVA = "0x25E7D7C", Offset = "0x25E7D7C", VA = "0x25E7D7C", Slot = "6")]
	public override void OnStateExit(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60048D7")]
	[Address(RVA = "0x25E85AC", Offset = "0x25E85AC", VA = "0x25E85AC")]
	public void _003C_003EiFixBaseProxy_OnStateEnter(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x60048D8")]
	[Address(RVA = "0x25E85FC", Offset = "0x25E85FC", VA = "0x25E85FC")]
	public void _003C_003EiFixBaseProxy_OnStateUpdate(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x60048D9")]
	[Address(RVA = "0x25E864C", Offset = "0x25E864C", VA = "0x25E864C")]
	public void _003C_003EiFixBaseProxy_OnStateExit(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}
}
