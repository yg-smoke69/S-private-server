using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace COW;

[Token(Token = "0x2002282")]
public class PartyVideoPlayComp : MonoBehaviour
{
	[Token(Token = "0x400D7FC")]
	[FieldOffset(Offset = "0xC")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x400D7FD")]
	[FieldOffset(Offset = "0x10")]
	private AudioSource audioSource;

	[Token(Token = "0x400D7FE")]
	[FieldOffset(Offset = "0x14")]
	private bool m_hardwardSupport;

	[Token(Token = "0x400D7FF")]
	[FieldOffset(Offset = "0x15")]
	private bool m_canplay;

	[Token(Token = "0x600BD3A")]
	[Address(RVA = "0x28D1AA0", Offset = "0x28D1AA0", VA = "0x28D1AA0")]
	public PartyVideoPlayComp()
	{
	}

	[Token(Token = "0x600BD3B")]
	[Address(RVA = "0x28D1AB0", Offset = "0x28D1AB0", VA = "0x28D1AB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BD3C")]
	[Address(RVA = "0x28D1B9C", Offset = "0x28D1B9C", VA = "0x28D1B9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600BD3D")]
	[Address(RVA = "0x28D22B4", Offset = "0x28D22B4", VA = "0x28D22B4")]
	private void SettingPlayOnUrl(string url)
	{
	}

	[Token(Token = "0x600BD3E")]
	[Address(RVA = "0x28D1FA4", Offset = "0x28D1FA4", VA = "0x28D1FA4")]
	private void SettingPlayOnClip()
	{
	}

	[Token(Token = "0x600BD3F")]
	[Address(RVA = "0x28D24F4", Offset = "0x28D24F4", VA = "0x28D24F4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600BD40")]
	[Address(RVA = "0x28D2768", Offset = "0x28D2768", VA = "0x28D2768")]
	private void ForcePlayVideo(object[] data)
	{
	}

	[Token(Token = "0x600BD41")]
	[Address(RVA = "0x28D2888", Offset = "0x28D2888", VA = "0x28D2888")]
	private void OnLocalPlayerEnter(object[] data)
	{
	}
}
