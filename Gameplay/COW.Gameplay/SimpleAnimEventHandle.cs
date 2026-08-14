using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay;

[Token(Token = "0x2000A1B")]
internal class SimpleAnimEventHandle : MonoBehaviour
{
	[Token(Token = "0x4005AE7")]
	[FieldOffset(Offset = "0xC")]
	private Transform m_CacheTransform;

	[Token(Token = "0x4005AE8")]
	[FieldOffset(Offset = "0x10")]
	private ActionSkillPawn ownerSkillPawn;

	[Token(Token = "0x6004EFA")]
	[Address(RVA = "0x24AD888", Offset = "0x24AD888", VA = "0x24AD888")]
	public SimpleAnimEventHandle()
	{
	}

	[Token(Token = "0x6004EFB")]
	[Address(RVA = "0x24AD890", Offset = "0x24AD890", VA = "0x24AD890")]
	private void Start()
	{
	}

	[Token(Token = "0x6004EFC")]
	[Address(RVA = "0x24AD908", Offset = "0x24AD908", VA = "0x24AD908")]
	private void OnTransformParentChanged()
	{
	}

	[Token(Token = "0x6004EFD")]
	[Address(RVA = "0x24AD970", Offset = "0x24AD970", VA = "0x24AD970")]
	private void PlayEventEffect(AnimationEvent evt)
	{
	}

	[Token(Token = "0x6004EFE")]
	[Address(RVA = "0x24ADF08", Offset = "0x24ADF08", VA = "0x24ADF08")]
	private void PlayEventSound(AnimationEvent evt)
	{
	}

	[Token(Token = "0x6004EFF")]
	[Address(RVA = "0x24AE3F4", Offset = "0x24AE3F4", VA = "0x24AE3F4")]
	public void PlayShakeCamera(AnimationEvent evt)
	{
	}
}
