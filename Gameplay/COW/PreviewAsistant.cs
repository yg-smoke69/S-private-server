using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A22")]
public class PreviewAsistant : MonoBehaviour
{
	[Token(Token = "0x4005B02")]
	[FieldOffset(Offset = "0xC")]
	public string vfxid;

	[Token(Token = "0x4005B03")]
	[FieldOffset(Offset = "0x10")]
	public List<Animator> m_PlayerAnimatorList;

	[Token(Token = "0x4005B04")]
	[FieldOffset(Offset = "0x14")]
	public List<Animator> m_PlayerIdleAnimatorList;

	[Token(Token = "0x4005B05")]
	[FieldOffset(Offset = "0x18")]
	public AnimationClip IdleAnim;

	[Token(Token = "0x4005B06")]
	[FieldOffset(Offset = "0x1C")]
	private float ActionTime;

	[Token(Token = "0x4005B07")]
	[FieldOffset(Offset = "0x20")]
	private float RealTime;

	[Token(Token = "0x4005B08")]
	[FieldOffset(Offset = "0x24")]
	private bool StartIdle;

	[Token(Token = "0x6004F1F")]
	[Address(RVA = "0x1C116E0", Offset = "0x1C116E0", VA = "0x1C116E0")]
	public PreviewAsistant()
	{
	}

	[Token(Token = "0x6004F20")]
	[Address(RVA = "0x1C116E8", Offset = "0x1C116E8", VA = "0x1C116E8")]
	public void PlayAnimAudioBackGroundEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x6004F21")]
	[Address(RVA = "0x1C11920", Offset = "0x1C11920", VA = "0x1C11920")]
	public void PlayAnimAudioLoopBackGroundEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x6004F22")]
	[Address(RVA = "0x1C11B58", Offset = "0x1C11B58", VA = "0x1C11B58")]
	public void PlayAnimOneShotEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x6004F23")]
	[Address(RVA = "0x1C11D90", Offset = "0x1C11D90", VA = "0x1C11D90")]
	public void ResumeAudioVolume()
	{
	}

	[Token(Token = "0x6004F24")]
	[Address(RVA = "0x1C11EB4", Offset = "0x1C11EB4", VA = "0x1C11EB4")]
	public void ReduceAudioVolume(float volumerate)
	{
	}

	[Token(Token = "0x6004F25")]
	[Address(RVA = "0x1C1200C", Offset = "0x1C1200C", VA = "0x1C1200C")]
	public void AnimCGFinish()
	{
	}

	[Token(Token = "0x6004F26")]
	[Address(RVA = "0x1C12118", Offset = "0x1C12118", VA = "0x1C12118")]
	public void WeaponCGFinish()
	{
	}

	[Token(Token = "0x6004F27")]
	[Address(RVA = "0x1C12224", Offset = "0x1C12224", VA = "0x1C12224")]
	public void WeaponCgStart()
	{
	}

	[Token(Token = "0x6004F28")]
	[Address(RVA = "0x1C12330", Offset = "0x1C12330", VA = "0x1C12330")]
	public void AnimationOver()
	{
	}

	[Token(Token = "0x6004F29")]
	[Address(RVA = "0x1C1243C", Offset = "0x1C1243C", VA = "0x1C1243C")]
	public void SetAnimRotateEnable()
	{
	}

	[Token(Token = "0x6004F2A")]
	[Address(RVA = "0x1C12490", Offset = "0x1C12490", VA = "0x1C12490")]
	public void AutoDestoryCg()
	{
	}

	[Token(Token = "0x6004F2B")]
	[Address(RVA = "0x1C124E4", Offset = "0x1C124E4", VA = "0x1C124E4")]
	public void PlayVfxEffect(string vfxid)
	{
	}

	[Token(Token = "0x6004F2C")]
	[Address(RVA = "0x1C1283C", Offset = "0x1C1283C", VA = "0x1C1283C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004F2D")]
	[Address(RVA = "0x1C12944", Offset = "0x1C12944", VA = "0x1C12944")]
	private void Update()
	{
	}

	[Token(Token = "0x6004F2E")]
	[Address(RVA = "0x1C12BE0", Offset = "0x1C12BE0", VA = "0x1C12BE0")]
	public void StartRecordIdle()
	{
	}

	[Token(Token = "0x6004F2F")]
	[Address(RVA = "0x1C12C48", Offset = "0x1C12C48", VA = "0x1C12C48")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6004F30")]
	[Address(RVA = "0x1C12C9C", Offset = "0x1C12C9C", VA = "0x1C12C9C")]
	public void ResetRecord()
	{
	}

	[Token(Token = "0x6004F31")]
	[Address(RVA = "0x1C129F8", Offset = "0x1C129F8", VA = "0x1C129F8")]
	private void UpdatePlayerAnimator()
	{
	}
}
