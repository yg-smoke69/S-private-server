using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A74")]
public class PlayerSoundAndEffectTrigger : MonoBehaviour
{
	[Token(Token = "0x4005C40")]
	[FieldOffset(Offset = "0xC")]
	public string SoundResID;

	[Token(Token = "0x4005C41")]
	[FieldOffset(Offset = "0x10")]
	public string EffectResID;

	[Token(Token = "0x4005C42")]
	[FieldOffset(Offset = "0x14")]
	public bool OnlyLocalPlayer;

	[Token(Token = "0x4005C43")]
	[FieldOffset(Offset = "0x18")]
	private ResourceID m_SoundResID;

	[Token(Token = "0x4005C44")]
	[FieldOffset(Offset = "0x1C")]
	private ResourceID m_EffectResID;

	[Token(Token = "0x60050A1")]
	[Address(RVA = "0x1E23054", Offset = "0x1E23054", VA = "0x1E23054")]
	public PlayerSoundAndEffectTrigger()
	{
	}

	[Token(Token = "0x60050A2")]
	[Address(RVA = "0x1E23108", Offset = "0x1E23108", VA = "0x1E23108")]
	private void Start()
	{
	}

	[Token(Token = "0x60050A3")]
	[Address(RVA = "0x1E2336C", Offset = "0x1E2336C", VA = "0x1E2336C")]
	private void OnTriggerEnter(Collider other)
	{
	}
}
