using System;
using System.Runtime.InteropServices;
using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Token(Token = "0x2003E1E")]
public class AkEventPlayable : PlayableAsset, _Attribute
{
	[Token(Token = "0x401A4E6")]
	[FieldOffset(Offset = "0xC")]
	public Event akEvent;

	[Token(Token = "0x401A4E7")]
	[FieldOffset(Offset = "0x10")]
	private AkCurveInterpolation blendInCurve;

	[Token(Token = "0x401A4E8")]
	[FieldOffset(Offset = "0x14")]
	private AkCurveInterpolation blendOutCurve;

	[Token(Token = "0x401A4E9")]
	[FieldOffset(Offset = "0x18")]
	private ExposedReference<GameObject> emitterObjectRef;

	[Token(Token = "0x401A4EA")]
	[FieldOffset(Offset = "0x20")]
	public float eventDurationMax;

	[Token(Token = "0x401A4EB")]
	[FieldOffset(Offset = "0x24")]
	public float eventDurationMin;

	[NonSerialized]
	[Token(Token = "0x401A4EC")]
	[FieldOffset(Offset = "0x28")]
	public TimelineClip owningClip;

	[Token(Token = "0x401A4ED")]
	[FieldOffset(Offset = "0x2C")]
	private bool retriggerEvent;

	[Token(Token = "0x401A4EE")]
	[FieldOffset(Offset = "0x2D")]
	public bool UseWwiseEventDuration;

	[Token(Token = "0x401A4EF")]
	[FieldOffset(Offset = "0x2E")]
	private bool StopEventAtClipEnd;

	[Token(Token = "0x17001B86")]
	private ClipCaps UnityEngine_002ETimeline_002EITimelineClipAsset_002EclipCaps
	{
		[Token(Token = "0x601940F")]
		[Address(RVA = "0x35D6600", Offset = "0x35D6600", VA = "0x35D6600", Slot = "9")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x601940E")]
	[Address(RVA = "0x35D6560", Offset = "0x35D6560", VA = "0x35D6560")]
	public AkEventPlayable()
	{
	}

	[Token(Token = "0x6019410")]
	[Address(RVA = "0x35D6608", Offset = "0x35D6608", VA = "0x35D6608", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
