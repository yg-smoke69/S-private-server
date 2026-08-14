using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FBE")]
public class LobbyAvatarClothEffectComponent : MonoBehaviour
{
	[Token(Token = "0x400C71B")]
	[FieldOffset(Offset = "0xC")]
	private IUmaAvatar m_Avatar;

	[Token(Token = "0x400C71C")]
	[FieldOffset(Offset = "0x10")]
	private List<GameObject> m_AnimEffects;

	[Token(Token = "0x400C71D")]
	[FieldOffset(Offset = "0x14")]
	private List<EffectObject> m_EventEffects;

	[Token(Token = "0x6009EB3")]
	[Address(RVA = "0xECB0E4", Offset = "0xECB0E4", VA = "0xECB0E4")]
	public LobbyAvatarClothEffectComponent()
	{
	}

	[Token(Token = "0x6009EB4")]
	[Address(RVA = "0xECB1A4", Offset = "0xECB1A4", VA = "0xECB1A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6009EB5")]
	[Address(RVA = "0xECB274", Offset = "0xECB274", VA = "0xECB274")]
	public void PlayLobbyAnimEffect(GameObject prefab, EffectObject eObject)
	{
	}

	[Token(Token = "0x6009EB6")]
	[Address(RVA = "0xECB624", Offset = "0xECB624", VA = "0xECB624")]
	private void ProcessBoneNameRefs(GameObject go, EffectObject eObject)
	{
	}

	[Token(Token = "0x6009EB7")]
	[Address(RVA = "0xECC194", Offset = "0xECC194", VA = "0xECC194")]
	public void SetEventEffectsVisibility(bool isVisible, bool allEventEffects = true)
	{
	}

	[Token(Token = "0x6009EB8")]
	[Address(RVA = "0xECBFF4", Offset = "0xECBFF4", VA = "0xECBFF4")]
	private static bool ScaleInLocalSpace(GameObject o)
	{
		return default(bool);
	}

	[Token(Token = "0x6009EB9")]
	[Address(RVA = "0xECC400", Offset = "0xECC400", VA = "0xECC400")]
	public void StopAnimEfects()
	{
	}
}
