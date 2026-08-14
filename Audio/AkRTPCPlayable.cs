using System;
using System.Runtime.InteropServices;
using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
[Token(Token = "0x2003E33")]
public class AkRTPCPlayable : PlayableAsset, _Attribute
{
	[Token(Token = "0x401A55E")]
	[FieldOffset(Offset = "0xC")]
	public bool overrideTrackObject;

	[Token(Token = "0x401A55F")]
	[FieldOffset(Offset = "0x10")]
	public ExposedReference<GameObject> RTPCObject;

	[Token(Token = "0x401A560")]
	[FieldOffset(Offset = "0x18")]
	public bool setRTPCGlobally;

	[Token(Token = "0x401A561")]
	[FieldOffset(Offset = "0x1C")]
	public AkRTPCPlayableBehaviour template;

	[Token(Token = "0x401A562")]
	[FieldOffset(Offset = "0x20")]
	private RTPC _003CParameter_003Ek__BackingField;

	[Token(Token = "0x401A563")]
	[FieldOffset(Offset = "0x24")]
	private TimelineClip _003COwningClip_003Ek__BackingField;

	[Token(Token = "0x17001B92")]
	private ClipCaps UnityEngine_002ETimeline_002EITimelineClipAsset_002EclipCaps
	{
		[Token(Token = "0x601949C")]
		[Address(RVA = "0x36C3BE0", Offset = "0x36C3BE0", VA = "0x36C3BE0", Slot = "9")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x17001B93")]
	public RTPC Parameter
	{
		[Token(Token = "0x6019498")]
		[Address(RVA = "0x36C3BC0", Offset = "0x36C3BC0", VA = "0x36C3BC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019499")]
		[Address(RVA = "0x36C3BC8", Offset = "0x36C3BC8", VA = "0x36C3BC8")]
		set
		{
		}
	}

	[Token(Token = "0x17001B94")]
	public TimelineClip OwningClip
	{
		[Token(Token = "0x601949A")]
		[Address(RVA = "0x36C3BD0", Offset = "0x36C3BD0", VA = "0x36C3BD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x601949B")]
		[Address(RVA = "0x36C3BD8", Offset = "0x36C3BD8", VA = "0x36C3BD8")]
		set
		{
		}
	}

	[Token(Token = "0x6019497")]
	[Address(RVA = "0x36C3B3C", Offset = "0x36C3B3C", VA = "0x36C3B3C")]
	public AkRTPCPlayable()
	{
	}

	[Token(Token = "0x601949D")]
	[Address(RVA = "0x36C3BE8", Offset = "0x36C3BE8", VA = "0x36C3BE8", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
