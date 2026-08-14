using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D5C")]
public class AudioCGPlusEvt : MonoBehaviour
{
	[Token(Token = "0x4011663")]
	[FieldOffset(Offset = "0xC")]
	public string voice_resourceid;

	[Token(Token = "0x4011664")]
	[FieldOffset(Offset = "0x10")]
	public string voice_resourceid_last;

	[Token(Token = "0x4011665")]
	[FieldOffset(Offset = "0x14")]
	private GameObject m_curAudioGo;

	[Token(Token = "0x6012F9F")]
	[Address(RVA = "0x14CF148", Offset = "0x14CF148", VA = "0x14CF148")]
	public AudioCGPlusEvt()
	{
	}

	[Token(Token = "0x6012FA0")]
	[Address(RVA = "0x14CF150", Offset = "0x14CF150", VA = "0x14CF150")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012FA1")]
	[Address(RVA = "0x14CF278", Offset = "0x14CF278", VA = "0x14CF278")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6012FA2")]
	[Address(RVA = "0x14CF450", Offset = "0x14CF450", VA = "0x14CF450")]
	private void ProcessCGEvt(object[] data)
	{
	}

	[Token(Token = "0x6012FA3")]
	[Address(RVA = "0x14CF778", Offset = "0x14CF778", VA = "0x14CF778")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6012FA4")]
	[Address(RVA = "0x14CF53C", Offset = "0x14CF53C", VA = "0x14CF53C")]
	private void PlayAnimOneShotEvt(string voice_resourceid)
	{
	}
}
