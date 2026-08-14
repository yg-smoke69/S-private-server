using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A25")]
public class PreviewAvatarEffectEx : MonoBehaviour
{
	[Token(Token = "0x4005B0B")]
	[FieldOffset(Offset = "0xC")]
	public List<Animator> m_PlayerAnimatorList;

	[Token(Token = "0x6004F35")]
	[Address(RVA = "0x1C131B0", Offset = "0x1C131B0", VA = "0x1C131B0")]
	public PreviewAvatarEffectEx()
	{
	}
}
