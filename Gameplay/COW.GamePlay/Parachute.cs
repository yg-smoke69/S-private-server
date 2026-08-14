using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20007EB")]
internal class Parachute : MonoBehaviour
{
	[Token(Token = "0x4005009")]
	[FieldOffset(Offset = "0xC")]
	public Transform PlayerAnchor;

	[Token(Token = "0x400500A")]
	[FieldOffset(Offset = "0x10")]
	public Transform MeshTF;

	[Token(Token = "0x400500B")]
	[FieldOffset(Offset = "0x14")]
	public Transform MeshHolder;

	[Token(Token = "0x400500C")]
	[FieldOffset(Offset = "0x18")]
	private SkinnedMeshRenderer FIHAIGEKNBI;

	[Token(Token = "0x400500D")]
	[FieldOffset(Offset = "0x1C")]
	private Animator KFGPIOMOLHI;

	[Token(Token = "0x600320E")]
	[Address(RVA = "0xBC442C", Offset = "0xBC442C", VA = "0xBC442C")]
	public Parachute()
	{
	}

	[Token(Token = "0x600320F")]
	[Address(RVA = "0xBC4434", Offset = "0xBC4434", VA = "0xBC4434")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003210")]
	[Address(RVA = "0xBC4534", Offset = "0xBC4534", VA = "0xBC4534")]
	public void SetAnimationBlendFactor(float LGBDNJEHFMB, float INEJHIDOPDE)
	{
	}

	[Token(Token = "0x6003211")]
	[Address(RVA = "0xBC469C", Offset = "0xBC469C", VA = "0xBC469C")]
	public void SetTexture(Texture2D FDECBPKGFKA)
	{
	}
}
