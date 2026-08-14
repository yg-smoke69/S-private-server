using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20003F1")]
public class AmbienceAudioComponent : MonoBehaviour
{
	[Token(Token = "0x40039CF")]
	[FieldOffset(Offset = "0xC")]
	public AudioSource AmbienceAudioSource;

	[Token(Token = "0x40039D0")]
	[FieldOffset(Offset = "0x10")]
	public NLNBLOLGPCP AmbienceAudioType;

	[Token(Token = "0x40039D1")]
	[FieldOffset(Offset = "0x14")]
	public SphereCollider AmbienceTrigger;

	[Token(Token = "0x40039D2")]
	[FieldOffset(Offset = "0x18")]
	private ResourceID NDPKFAMOIEN;

	[Token(Token = "0x6001281")]
	[Address(RVA = "0x113F0F0", Offset = "0x113F0F0", VA = "0x113F0F0")]
	public AmbienceAudioComponent()
	{
	}

	[Token(Token = "0x6001282")]
	[Address(RVA = "0x113F190", Offset = "0x113F190", VA = "0x113F190")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001283")]
	[Address(RVA = "0x113F2F4", Offset = "0x113F2F4", VA = "0x113F2F4")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6001284")]
	[Address(RVA = "0x113F458", Offset = "0x113F458", VA = "0x113F458")]
	private void EPBABEJOEIJ(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6001285")]
	[Address(RVA = "0x113F630", Offset = "0x113F630", VA = "0x113F630")]
	public void PlayAmbience()
	{
	}

	[Token(Token = "0x6001286")]
	[Address(RVA = "0x113FB30", Offset = "0x113FB30", VA = "0x113FB30")]
	public void StopAmbience()
	{
	}
}
