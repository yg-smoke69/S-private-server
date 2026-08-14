using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200400A")]
public class TimelineSpeedController : MonoBehaviour
{
	[Token(Token = "0x401AEFC")]
	[FieldOffset(Offset = "0xC")]
	public float speed;

	[Token(Token = "0x401AEFD")]
	[FieldOffset(Offset = "0x10")]
	private PlayableDirector m_playableDirector;

	[Token(Token = "0x401AEFE")]
	[FieldOffset(Offset = "0x14")]
	private double[] m_playableSpeeds;

	[Token(Token = "0x401AEFF")]
	[FieldOffset(Offset = "0x18")]
	private TrailRenderer[] m_trailRenderers;

	[Token(Token = "0x401AF00")]
	[FieldOffset(Offset = "0x1C")]
	private float[] m_trailRendererTimes;

	[Token(Token = "0x601A141")]
	[Address(RVA = "0x2639504", Offset = "0x2639504", VA = "0x2639504")]
	public TimelineSpeedController()
	{
	}

	[Token(Token = "0x601A142")]
	[Address(RVA = "0x2639518", Offset = "0x2639518", VA = "0x2639518")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x601A143")]
	[Address(RVA = "0x26395CC", Offset = "0x26395CC", VA = "0x26395CC")]
	private void Start()
	{
	}

	[Token(Token = "0x601A144")]
	[Address(RVA = "0x2639938", Offset = "0x2639938", VA = "0x2639938")]
	private void Update()
	{
	}
}
