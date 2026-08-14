using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace COW;

[Token(Token = "0x2002C2F")]
public class VideoPlayController : MonoBehaviour
{
	[Token(Token = "0x4010DBE")]
	[FieldOffset(Offset = "0xC")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4010DBF")]
	[FieldOffset(Offset = "0x10")]
	private AudioSource audioSource;

	[Token(Token = "0x4010DC0")]
	[FieldOffset(Offset = "0x14")]
	private bool m_hardwardSupport;

	[Token(Token = "0x4010DC1")]
	[FieldOffset(Offset = "0x15")]
	private bool m_canplay;

	[Token(Token = "0x60126A5")]
	[Address(RVA = "0x21A0670", Offset = "0x21A0670", VA = "0x21A0670")]
	public VideoPlayController()
	{
	}

	[Token(Token = "0x60126A6")]
	[Address(RVA = "0x21A0680", Offset = "0x21A0680", VA = "0x21A0680")]
	private void Awake()
	{
	}

	[Token(Token = "0x60126A7")]
	[Address(RVA = "0x21A076C", Offset = "0x21A076C", VA = "0x21A076C")]
	private void Start()
	{
	}

	[Token(Token = "0x60126A8")]
	[Address(RVA = "0x21A0D88", Offset = "0x21A0D88", VA = "0x21A0D88")]
	private void SettingPlayOnUrl(string url)
	{
	}

	[Token(Token = "0x60126A9")]
	[Address(RVA = "0x21A0A78", Offset = "0x21A0A78", VA = "0x21A0A78")]
	private void SettingPlayOnClip()
	{
	}

	[Token(Token = "0x60126AA")]
	[Address(RVA = "0x21A111C", Offset = "0x21A111C", VA = "0x21A111C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60126AB")]
	[Address(RVA = "0x21A12FC", Offset = "0x21A12FC", VA = "0x21A12FC")]
	private void OnLocalPlayerEnter(object[] data)
	{
	}
}
