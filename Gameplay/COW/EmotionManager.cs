using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20002D5")]
internal class EmotionManager
{
	[Token(Token = "0x4003321")]
	[FieldOffset(Offset = "0x8")]
	private Animator m_Animator;

	[Token(Token = "0x14000001")]
	public event Action<AnimationClip> OnOverrideClip
	{
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x2533E5C", Offset = "0x2533E5C", VA = "0x2533E5C")]
		add
		{
		}
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x2533FB8", Offset = "0x2533FB8", VA = "0x2533FB8")]
		remove
		{
		}
	}

	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0x2533E3C", Offset = "0x2533E3C", VA = "0x2533E3C")]
	public EmotionManager(Animator animator)
	{
	}

	[Token(Token = "0x6000DA3")]
	[Address(RVA = "0x2534114", Offset = "0x2534114", VA = "0x2534114")]
	public void PlayEmotionAnimation(uint emotionID, bool isFemale)
	{
	}

	[Token(Token = "0x6000DA4")]
	[Address(RVA = "0x2534798", Offset = "0x2534798", VA = "0x2534798")]
	public void PlayFreezeEmotionAnimation(uint emotionID, bool isFemale)
	{
	}

	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x25349AC", Offset = "0x25349AC", VA = "0x25349AC")]
	public void PlayAnimClip(ResourceID animResId)
	{
	}

	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x2534AE4", Offset = "0x2534AE4", VA = "0x2534AE4")]
	public static float GetEmotionAnimLength(EmoteData data, bool isFemale)
	{
		return default(float);
	}

	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x2534C14", Offset = "0x2534C14", VA = "0x2534C14")]
	public void StopEmotionAnimation()
	{
	}

	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x25344B4", Offset = "0x25344B4", VA = "0x25344B4")]
	private void SetOverrideAnim(AnimationClip clip, string clipName)
	{
	}

	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x2534D50", Offset = "0x2534D50", VA = "0x2534D50")]
	private AnimationClip GetAnimClip(RuntimeAnimatorController controller, bool baseClip, string clipName)
	{
		return null;
	}

	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x25342E4", Offset = "0x25342E4", VA = "0x25342E4")]
	private static AnimationClip LoadAnimClip(ResourceID id)
	{
		return null;
	}
}
