using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B67")]
public class SingerBMainTimeLinePlayer : MonoBehaviour
{
	[Token(Token = "0x4006100")]
	[FieldOffset(Offset = "0xC")]
	public PlayableDirector m_PlayabelDirector;

	[Token(Token = "0x4006101")]
	[FieldOffset(Offset = "0x10")]
	private float m_BeginRealTime;

	[Token(Token = "0x4006102")]
	[FieldOffset(Offset = "0x14")]
	private bool m_IsFinishPlay;

	[Token(Token = "0x60056A4")]
	[Address(RVA = "0x20EAB40", Offset = "0x20EAB40", VA = "0x20EAB40")]
	public SingerBMainTimeLinePlayer()
	{
	}

	[Token(Token = "0x60056A5")]
	[Address(RVA = "0x20EAB48", Offset = "0x20EAB48", VA = "0x20EAB48")]
	private void Awake()
	{
	}

	[Token(Token = "0x60056A6")]
	[Address(RVA = "0x20EABA0", Offset = "0x20EABA0", VA = "0x20EABA0")]
	public void PlayMainTimeLine(float beginRealTime)
	{
	}

	[Token(Token = "0x60056A7")]
	[Address(RVA = "0x20EABA8", Offset = "0x20EABA8", VA = "0x20EABA8")]
	private void Update()
	{
	}
}
