using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B69")]
public class SingerBSubTimeLinePlayer : MonoBehaviour
{
	[Token(Token = "0x4006103")]
	[FieldOffset(Offset = "0xC")]
	private PlayableDirector m_PlayabelDirector;

	[Token(Token = "0x4006104")]
	[FieldOffset(Offset = "0x10")]
	private double m_ClipStartTime;

	[Token(Token = "0x60056B0")]
	[Address(RVA = "0x20EAF38", Offset = "0x20EAF38", VA = "0x20EAF38")]
	public SingerBSubTimeLinePlayer()
	{
	}

	[Token(Token = "0x60056B1")]
	[Address(RVA = "0x20EAF40", Offset = "0x20EAF40", VA = "0x20EAF40")]
	private void Awake()
	{
	}

	[Token(Token = "0x60056B2")]
	[Address(RVA = "0x20EAFF0", Offset = "0x20EAFF0", VA = "0x20EAFF0")]
	public void PlaySubTimeLine(double clipStartTime)
	{
	}

	[Token(Token = "0x60056B3")]
	[Address(RVA = "0x20EB000", Offset = "0x20EB000", VA = "0x20EB000")]
	private void LateUpdate()
	{
	}
}
