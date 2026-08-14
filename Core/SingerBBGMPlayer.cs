using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B66")]
public class SingerBBGMPlayer : MonoBehaviour
{
	[Token(Token = "0x40060FE")]
	[FieldOffset(Offset = "0xC")]
	private AudioSource m_BGMAudioSource;

	[Token(Token = "0x40060FF")]
	[FieldOffset(Offset = "0x10")]
	private double m_ClipStartTime;

	[Token(Token = "0x600569E")]
	[Address(RVA = "0x21CE134", Offset = "0x21CE134", VA = "0x21CE134")]
	public SingerBBGMPlayer()
	{
	}

	[Token(Token = "0x600569F")]
	[Address(RVA = "0x21CE13C", Offset = "0x21CE13C", VA = "0x21CE13C")]
	private void Start()
	{
	}

	[Token(Token = "0x60056A0")]
	[Address(RVA = "0x21CE21C", Offset = "0x21CE21C", VA = "0x21CE21C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60056A1")]
	[Address(RVA = "0x21CE2FC", Offset = "0x21CE2FC", VA = "0x21CE2FC")]
	private void OnMusiceVolumeChange(object[] param)
	{
	}

	[Token(Token = "0x60056A2")]
	[Address(RVA = "0x21CE3EC", Offset = "0x21CE3EC", VA = "0x21CE3EC")]
	public void PlayBGM(AudioSource bgmAS, double clipStartTime)
	{
	}

	[Token(Token = "0x60056A3")]
	[Address(RVA = "0x21CE4F4", Offset = "0x21CE4F4", VA = "0x21CE4F4")]
	private void LateUpdate()
	{
	}
}
