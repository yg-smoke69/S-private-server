using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002286")]
public class MVPShowCutscene : MonoBehaviour
{
	[Token(Token = "0x400D81E")]
	[FieldOffset(Offset = "0xC")]
	public GameObject Scene;

	[Token(Token = "0x400D81F")]
	[FieldOffset(Offset = "0x10")]
	public GameObject MaleCam;

	[Token(Token = "0x400D820")]
	[FieldOffset(Offset = "0x14")]
	public Animator MaleCamAnim;

	[Token(Token = "0x400D821")]
	[FieldOffset(Offset = "0x18")]
	public Transform MaleCamPos;

	[Token(Token = "0x400D822")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject FemaleCam;

	[Token(Token = "0x400D823")]
	[FieldOffset(Offset = "0x20")]
	public Animator FemaleCamAnim;

	[Token(Token = "0x400D824")]
	[FieldOffset(Offset = "0x24")]
	public Transform FemaleCamPos;

	[Token(Token = "0x400D825")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MVPFemaleEffect;

	[Token(Token = "0x400D826")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject MVPMaleEffect;

	[Token(Token = "0x400D827")]
	[FieldOffset(Offset = "0x30")]
	public Transform MVPAvatar;

	[Token(Token = "0x400D828")]
	[FieldOffset(Offset = "0x34")]
	public Transform Teammate1Avatar;

	[Token(Token = "0x400D829")]
	[FieldOffset(Offset = "0x38")]
	public Transform Teammate2Avatar;

	[Token(Token = "0x400D82A")]
	[FieldOffset(Offset = "0x3C")]
	public Transform Teammate3Avatar;

	[Token(Token = "0x600BD56")]
	[Address(RVA = "0x15320FC", Offset = "0x15320FC", VA = "0x15320FC")]
	public MVPShowCutscene()
	{
	}

	[Token(Token = "0x600BD57")]
	[Address(RVA = "0x1532104", Offset = "0x1532104", VA = "0x1532104")]
	public Transform[] GetAvatarTrans()
	{
		return null;
	}
}
