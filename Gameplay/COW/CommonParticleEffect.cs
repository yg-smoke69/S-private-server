using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A57")]
internal class CommonParticleEffect : ReusableObject
{
	[Token(Token = "0x4005BBA")]
	[FieldOffset(Offset = "0x15")]
	public bool AutoDestory;

	[Token(Token = "0x4005BBB")]
	[FieldOffset(Offset = "0x18")]
	protected ParticleSystem[] m_Particles;

	[Token(Token = "0x4005BBC")]
	[FieldOffset(Offset = "0x1C")]
	public bool ScaleSizeByDistance;

	[Token(Token = "0x4005BBD")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve ScaleSizeCurve;

	[Token(Token = "0x4005BBE")]
	[FieldOffset(Offset = "0x24")]
	private Transform camTrans;

	[Token(Token = "0x600502B")]
	[Address(RVA = "0x17383B0", Offset = "0x17383B0", VA = "0x17383B0")]
	public CommonParticleEffect()
	{
	}

	[Token(Token = "0x600502C")]
	[Address(RVA = "0x17383B8", Offset = "0x17383B8", VA = "0x17383B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600502D")]
	[Address(RVA = "0x173848C", Offset = "0x173848C", VA = "0x173848C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600502E")]
	[Address(RVA = "0x1738580", Offset = "0x1738580", VA = "0x1738580", Slot = "6")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600502F")]
	[Address(RVA = "0x1738BC4", Offset = "0x1738BC4", VA = "0x1738BC4")]
	public bool IsParticleAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x6005030")]
	[Address(RVA = "0x1738C94", Offset = "0x1738C94", VA = "0x1738C94")]
	public void Play()
	{
	}

	[Token(Token = "0x6005031")]
	[Address(RVA = "0x1738E64", Offset = "0x1738E64", VA = "0x1738E64")]
	public void PlayFromStart()
	{
	}

	[Token(Token = "0x6005032")]
	[Address(RVA = "0x173903C", Offset = "0x173903C", VA = "0x173903C")]
	public void Stop()
	{
	}

	[Token(Token = "0x6005033")]
	[Address(RVA = "0x1738688", Offset = "0x1738688", VA = "0x1738688")]
	public void AdjustScale()
	{
	}
}
