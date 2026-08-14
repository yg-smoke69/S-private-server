using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200098E")]
public class PlayerAnimEventStateLobby : StateMachineBehaviour
{
	[Token(Token = "0x40058C0")]
	[FieldOffset(Offset = "0xC")]
	public float triggerTime;

	[Token(Token = "0x40058C1")]
	[FieldOffset(Offset = "0x10")]
	public PKNONKBDBBK animEvent;

	[Token(Token = "0x40058C2")]
	[FieldOffset(Offset = "0x14")]
	private UIMaleAvatar m_OwnerPlayer;

	[Token(Token = "0x40058C3")]
	[FieldOffset(Offset = "0x18")]
	private float m_PrevTime;

	[Token(Token = "0x60048DA")]
	[Address(RVA = "0x25E869C", Offset = "0x25E869C", VA = "0x25E869C")]
	public PlayerAnimEventStateLobby()
	{
	}

	[Token(Token = "0x60048DB")]
	[Address(RVA = "0x25E86A4", Offset = "0x25E86A4", VA = "0x25E86A4", Slot = "4")]
	public override void OnStateEnter(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60048DC")]
	[Address(RVA = "0x25E88CC", Offset = "0x25E88CC", VA = "0x25E88CC", Slot = "5")]
	public override void OnStateUpdate(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60048DD")]
	[Address(RVA = "0x25E8B1C", Offset = "0x25E8B1C", VA = "0x25E8B1C", Slot = "6")]
	public override void OnStateExit(Animator HLIOOJLOAGA, AnimatorStateInfo OMKEENPMONN, int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60048DE")]
	[Address(RVA = "0x25E8E18", Offset = "0x25E8E18", VA = "0x25E8E18")]
	public void _003C_003EiFixBaseProxy_OnStateEnter(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x60048DF")]
	[Address(RVA = "0x25E8E68", Offset = "0x25E8E68", VA = "0x25E8E68")]
	public void _003C_003EiFixBaseProxy_OnStateUpdate(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x60048E0")]
	[Address(RVA = "0x25E8EB8", Offset = "0x25E8EB8", VA = "0x25E8EB8")]
	public void _003C_003EiFixBaseProxy_OnStateExit(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}
}
