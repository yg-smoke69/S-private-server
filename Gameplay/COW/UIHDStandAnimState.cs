using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200212A")]
public class UIHDStandAnimState : StateMachineBehaviour
{
	[Token(Token = "0x200212B")]
	public enum EHDStandAnimEvent
	{
		[Token(Token = "0x400CFB3")]
		GunDoorMove,
		[Token(Token = "0x400CFB4")]
		GunDoorOpend,
		[Token(Token = "0x400CFB5")]
		MoveToGunDoor,
		[Token(Token = "0x400CFB6")]
		MoveFromGunDoor,
		[Token(Token = "0x400CFB7")]
		MoveToCarPlat,
		[Token(Token = "0x400CFB8")]
		MoveFromCarPlat,
		[Token(Token = "0x400CFB9")]
		MoveToIcePlat,
		[Token(Token = "0x400CFBA")]
		MoveFromIcePlat,
		[Token(Token = "0x400CFBB")]
		MoveToSkyboardPlat,
		[Token(Token = "0x400CFBC")]
		MoveFromSkyboardPlat
	}

	[Token(Token = "0x400CFB1")]
	[FieldOffset(Offset = "0xC")]
	public EHDStandAnimEvent animEvent;

	[Token(Token = "0x600ADBB")]
	[Address(RVA = "0x2036244", Offset = "0x2036244", VA = "0x2036244")]
	public UIHDStandAnimState()
	{
	}

	[Token(Token = "0x600ADBC")]
	[Address(RVA = "0x203624C", Offset = "0x203624C", VA = "0x203624C", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600ADBD")]
	[Address(RVA = "0x2036304", Offset = "0x2036304", VA = "0x2036304", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600ADBE")]
	[Address(RVA = "0x2036AF0", Offset = "0x2036AF0", VA = "0x2036AF0")]
	public void _003C_003EiFixBaseProxy_OnStateEnter(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	[Token(Token = "0x600ADBF")]
	[Address(RVA = "0x2036B40", Offset = "0x2036B40", VA = "0x2036B40")]
	public void _003C_003EiFixBaseProxy_OnStateExit(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}
}
