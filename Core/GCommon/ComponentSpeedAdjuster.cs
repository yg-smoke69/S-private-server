using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F27")]
public class ComponentSpeedAdjuster : MonoBehaviour
{
	[Token(Token = "0x401AA19")]
	[FieldOffset(Offset = "0xC")]
	public float m_speed;

	[Token(Token = "0x401AA1A")]
	[FieldOffset(Offset = "0x10")]
	private ParticleSystem[] m_particleSystemArray;

	[Token(Token = "0x401AA1B")]
	[FieldOffset(Offset = "0x14")]
	private float[] m_particleSystemSpeed;

	[Token(Token = "0x401AA1C")]
	[FieldOffset(Offset = "0x18")]
	private Animator[] m_animatorArray;

	[Token(Token = "0x401AA1D")]
	[FieldOffset(Offset = "0x1C")]
	private float[] m_animatorSpeed;

	[Token(Token = "0x401AA1E")]
	[FieldOffset(Offset = "0x20")]
	private Animation[] m_animationArray;

	[Token(Token = "0x401AA1F")]
	[FieldOffset(Offset = "0x24")]
	private float[] m_animationSpeed;

	[Token(Token = "0x401AA20")]
	[FieldOffset(Offset = "0x28")]
	private List<List<AnimationState>> m_animationSateList;

	[Token(Token = "0x401AA21")]
	[FieldOffset(Offset = "0x2C")]
	private TrailRenderer[] m_trailRendererArray;

	[Token(Token = "0x401AA22")]
	[FieldOffset(Offset = "0x30")]
	private float[] m_trailRendererSpeed;

	[Token(Token = "0x401AA23")]
	[FieldOffset(Offset = "0x34")]
	private float m_currentSpeedScale;

	[Token(Token = "0x401AA24")]
	[FieldOffset(Offset = "0x38")]
	private float m_lastSpeedScale;

	[Token(Token = "0x6019B55")]
	[Address(RVA = "0x30874B4", Offset = "0x30874B4", VA = "0x30874B4")]
	public ComponentSpeedAdjuster()
	{
	}

	[Token(Token = "0x6019B56")]
	[Address(RVA = "0x30874D4", Offset = "0x30874D4", VA = "0x30874D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6019B57")]
	[Address(RVA = "0x3087F9C", Offset = "0x3087F9C", VA = "0x3087F9C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6019B58")]
	[Address(RVA = "0x3088688", Offset = "0x3088688", VA = "0x3088688")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6019B59")]
	[Address(RVA = "0x308769C", Offset = "0x308769C", VA = "0x308769C")]
	private void GetComponentsSpeed()
	{
	}

	[Token(Token = "0x6019B5A")]
	[Address(RVA = "0x3087FCC", Offset = "0x3087FCC", VA = "0x3087FCC")]
	private void SetComponentsSpeed()
	{
	}
}
