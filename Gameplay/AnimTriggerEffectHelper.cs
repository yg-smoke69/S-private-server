using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005A5")]
public class AnimTriggerEffectHelper : MonoBehaviour
{
	[Token(Token = "0x4004359")]
	[FieldOffset(Offset = "0xC")]
	public List<ParticleSystem> m_EffectsList;

	[Token(Token = "0x6002259")]
	[Address(RVA = "0x2ECB308", Offset = "0x2ECB308", VA = "0x2ECB308")]
	public AnimTriggerEffectHelper()
	{
	}

	[Token(Token = "0x600225A")]
	[Address(RVA = "0x2ECB310", Offset = "0x2ECB310", VA = "0x2ECB310")]
	public void TriggerEffect(int effectIndex)
	{
	}

	[Token(Token = "0x600225B")]
	[Address(RVA = "0x2ECB484", Offset = "0x2ECB484", VA = "0x2ECB484")]
	public void CloseEffect(int effectIndex)
	{
	}
}
