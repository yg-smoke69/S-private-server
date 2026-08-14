using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace COW.TimelineEvents;

[Serializable]
[Token(Token = "0x2000A4F")]
public class TimelineEventClip : PlayableAsset, _Attribute
{
	[Token(Token = "0x4005BA6")]
	[FieldOffset(Offset = "0xC")]
	public TimelineEventBehaviour template;

	[Token(Token = "0x4005BA7")]
	[FieldOffset(Offset = "0x10")]
	private GameObject _003CTrackTargetObject_003Ek__BackingField;

	[Token(Token = "0x17000632")]
	public GameObject TrackTargetObject
	{
		[Token(Token = "0x600500D")]
		[Address(RVA = "0x28A8F00", Offset = "0x28A8F00", VA = "0x28A8F00")]
		get
		{
			return null;
		}
		[Token(Token = "0x600500E")]
		[Address(RVA = "0x28A8F08", Offset = "0x28A8F08", VA = "0x28A8F08")]
		set
		{
		}
	}

	[Token(Token = "0x17000633")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600500F")]
		[Address(RVA = "0x28A8F10", Offset = "0x28A8F10", VA = "0x28A8F10", Slot = "9")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600500C")]
	[Address(RVA = "0x28A8E84", Offset = "0x28A8E84", VA = "0x28A8E84")]
	public TimelineEventClip()
	{
	}

	[Token(Token = "0x6005010")]
	[Address(RVA = "0x28A8F18", Offset = "0x28A8F18", VA = "0x28A8F18", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
