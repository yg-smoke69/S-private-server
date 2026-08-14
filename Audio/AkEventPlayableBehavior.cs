using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2003E1F")]
public class AkEventPlayableBehavior : PlayableBehaviour
{
	[Token(Token = "0x2003E20")]
	private enum Actions
	{
		[Token(Token = "0x401A509")]
		None = 0,
		[Token(Token = "0x401A50A")]
		Playback = 1,
		[Token(Token = "0x401A50B")]
		Retrigger = 2,
		[Token(Token = "0x401A50C")]
		DelayedStop = 4,
		[Token(Token = "0x401A50D")]
		Seek = 8,
		[Token(Token = "0x401A50E")]
		FadeIn = 0x10,
		[Token(Token = "0x401A50F")]
		FadeOut = 0x20
	}

	[Token(Token = "0x401A4F0")]
	[FieldOffset(Offset = "0x8")]
	private float currentDuration;

	[Token(Token = "0x401A4F1")]
	[FieldOffset(Offset = "0xC")]
	private float currentDurationProportion;

	[Token(Token = "0x401A4F2")]
	[FieldOffset(Offset = "0x10")]
	private bool eventIsPlaying;

	[Token(Token = "0x401A4F3")]
	[FieldOffset(Offset = "0x11")]
	private bool fadeinTriggered;

	[Token(Token = "0x401A4F4")]
	[FieldOffset(Offset = "0x12")]
	private bool fadeoutTriggered;

	[Token(Token = "0x401A4F5")]
	[FieldOffset(Offset = "0x14")]
	private float previousEventStartTime;

	[Token(Token = "0x401A4F6")]
	private const uint CallbackFlags = 9u;

	[Token(Token = "0x401A4F7")]
	[FieldOffset(Offset = "0x18")]
	private Actions requiredActions;

	[Token(Token = "0x401A4F8")]
	private const int scrubPlaybackLengthMs = 100;

	[Token(Token = "0x401A4F9")]
	[FieldOffset(Offset = "0x1C")]
	public Event akEvent;

	[Token(Token = "0x401A4FA")]
	[FieldOffset(Offset = "0x20")]
	public float eventDurationMax;

	[Token(Token = "0x401A4FB")]
	[FieldOffset(Offset = "0x24")]
	public float eventDurationMin;

	[Token(Token = "0x401A4FC")]
	[FieldOffset(Offset = "0x28")]
	public float blendInDuration;

	[Token(Token = "0x401A4FD")]
	[FieldOffset(Offset = "0x2C")]
	public float blendOutDuration;

	[Token(Token = "0x401A4FE")]
	[FieldOffset(Offset = "0x30")]
	public float easeInDuration;

	[Token(Token = "0x401A4FF")]
	[FieldOffset(Offset = "0x34")]
	public float easeOutDuration;

	[Token(Token = "0x401A500")]
	[FieldOffset(Offset = "0x38")]
	public AkCurveInterpolation blendInCurve;

	[Token(Token = "0x401A501")]
	[FieldOffset(Offset = "0x3C")]
	public AkCurveInterpolation blendOutCurve;

	[Token(Token = "0x401A502")]
	[FieldOffset(Offset = "0x40")]
	public GameObject eventObject;

	[Token(Token = "0x401A503")]
	[FieldOffset(Offset = "0x44")]
	public bool retriggerEvent;

	[Token(Token = "0x401A504")]
	[FieldOffset(Offset = "0x45")]
	private bool wasScrubbingAndRequiresRetrigger;

	[Token(Token = "0x401A505")]
	[FieldOffset(Offset = "0x46")]
	public bool StopEventAtClipEnd;

	[Token(Token = "0x401A506")]
	[FieldOffset(Offset = "0x47")]
	public bool overrideTrackEmitterObject;

	[Token(Token = "0x401A507")]
	private const float alph = 0.05f;

	[Token(Token = "0x6019411")]
	[Address(RVA = "0x35D69B8", Offset = "0x35D69B8", VA = "0x35D69B8")]
	public AkEventPlayableBehavior()
	{
	}

	[Token(Token = "0x6019412")]
	[Address(RVA = "0x35D69D4", Offset = "0x35D69D4", VA = "0x35D69D4")]
	private void CallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	[Token(Token = "0x6019413")]
	[Address(RVA = "0x35D6B04", Offset = "0x35D6B04", VA = "0x35D6B04")]
	private bool IsScrubbing(FrameData info)
	{
		return default(bool);
	}

	[Token(Token = "0x6019414")]
	[Address(RVA = "0x35D6B94", Offset = "0x35D6B94", VA = "0x35D6B94", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6019415")]
	[Address(RVA = "0x35D7110", Offset = "0x35D7110", VA = "0x35D7110", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6019416")]
	[Address(RVA = "0x35D73F4", Offset = "0x35D73F4", VA = "0x35D73F4", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6019417")]
	[Address(RVA = "0x35D75EC", Offset = "0x35D75EC", VA = "0x35D75EC", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6019418")]
	[Address(RVA = "0x35D6E2C", Offset = "0x35D6E2C", VA = "0x35D6E2C")]
	private bool ShouldPlay(Playable playable)
	{
		return default(bool);
	}

	[Token(Token = "0x6019419")]
	[Address(RVA = "0x35D6F94", Offset = "0x35D6F94", VA = "0x35D6F94")]
	private void CheckForFadeInFadeOut(Playable playable)
	{
	}

	[Token(Token = "0x601941A")]
	[Address(RVA = "0x35D7058", Offset = "0x35D7058", VA = "0x35D7058")]
	private void CheckForFadeOut(Playable playable, double currentClipTime)
	{
	}

	[Token(Token = "0x601941B")]
	[Address(RVA = "0x35D7A88", Offset = "0x35D7A88", VA = "0x35D7A88")]
	private void TriggerFadeIn(Playable playable)
	{
	}

	[Token(Token = "0x601941C")]
	[Address(RVA = "0x35D7BF8", Offset = "0x35D7BF8", VA = "0x35D7BF8")]
	private void TriggerFadeOut(Playable playable)
	{
	}

	[Token(Token = "0x601941D")]
	[Address(RVA = "0x35D7594", Offset = "0x35D7594", VA = "0x35D7594")]
	private void StopEvent(int transition = 0)
	{
	}

	[Token(Token = "0x601941E")]
	[Address(RVA = "0x35D7CF4", Offset = "0x35D7CF4", VA = "0x35D7CF4")]
	private bool PostEvent()
	{
		return default(bool);
	}

	[Token(Token = "0x601941F")]
	[Address(RVA = "0x35D78AC", Offset = "0x35D78AC", VA = "0x35D78AC")]
	private void PlayEvent()
	{
	}

	[Token(Token = "0x6019420")]
	[Address(RVA = "0x35D79D0", Offset = "0x35D79D0", VA = "0x35D79D0")]
	private void RetriggerEvent(Playable playable)
	{
	}

	[Token(Token = "0x6019421")]
	[Address(RVA = "0x35D72E8", Offset = "0x35D72E8", VA = "0x35D72E8")]
	private float GetProportionalTime(Playable playable)
	{
		return default(float);
	}

	[Token(Token = "0x6019422")]
	[Address(RVA = "0x35D78D4", Offset = "0x35D78D4", VA = "0x35D78D4")]
	private float SeekToTime(Playable playable)
	{
		return default(float);
	}
}
