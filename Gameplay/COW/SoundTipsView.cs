using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D29")]
public class SoundTipsView : MonoBehaviour
{
	[Token(Token = "0x40113D9")]
	[FieldOffset(Offset = "0xC")]
	public UISprite SpriteVehicleSoundTip;

	[Token(Token = "0x40113DA")]
	[FieldOffset(Offset = "0x10")]
	public UISprite SpriteFootStepSoundTip;

	[Token(Token = "0x40113DB")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SpriteFireSoundTip;

	[Token(Token = "0x40113DC")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha SoundTipTween;

	[Token(Token = "0x40113DD")]
	[FieldOffset(Offset = "0x1C")]
	public Color WarningTipColor;

	[Token(Token = "0x40113DE")]
	[FieldOffset(Offset = "0x2C")]
	public Color DangerTipColor;

	[Token(Token = "0x40113DF")]
	[FieldOffset(Offset = "0x3C")]
	private UISprite m_SoundTipSprite;

	[Token(Token = "0x40113E0")]
	[FieldOffset(Offset = "0x40")]
	private Timer m_DelayStopTimer;

	[Token(Token = "0x17001362")]
	public bool IsInDelayStop
	{
		[Token(Token = "0x6012E22")]
		[Address(RVA = "0x20F3F74", Offset = "0x20F3F74", VA = "0x20F3F74")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6012E21")]
	[Address(RVA = "0x20F3F6C", Offset = "0x20F3F6C", VA = "0x20F3F6C")]
	public SoundTipsView()
	{
	}

	[Token(Token = "0x6012E23")]
	[Address(RVA = "0x20F3FD8", Offset = "0x20F3FD8", VA = "0x20F3FD8")]
	public void SoundTipInit(ESoundTipsType type)
	{
	}

	[Token(Token = "0x6012E24")]
	[Address(RVA = "0x20F4264", Offset = "0x20F4264", VA = "0x20F4264")]
	public void StartSoundTip()
	{
	}

	[Token(Token = "0x6012E25")]
	[Address(RVA = "0x20F4338", Offset = "0x20F4338", VA = "0x20F4338")]
	public void DelayStopSoundTip(float waitTime)
	{
	}

	[Token(Token = "0x6012E26")]
	[Address(RVA = "0x20F44C0", Offset = "0x20F44C0", VA = "0x20F44C0")]
	public void SetSoundTipColor(Color _color)
	{
	}

	[Token(Token = "0x6012E27")]
	[Address(RVA = "0x20F4638", Offset = "0x20F4638", VA = "0x20F4638")]
	public void StopSoundTip()
	{
	}

	[Token(Token = "0x6012E28")]
	[Address(RVA = "0x20F46EC", Offset = "0x20F46EC", VA = "0x20F46EC")]
	private void LateUpdate()
	{
	}
}
