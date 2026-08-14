using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace COW.TimelineEvents;

[Token(Token = "0x2000A51")]
public class TimelineEventTrack : TrackAsset
{
	[Token(Token = "0x6005012")]
	[Address(RVA = "0x28A9114", Offset = "0x28A9114", VA = "0x28A9114")]
	public TimelineEventTrack()
	{
	}

	[Token(Token = "0x6005013")]
	[Address(RVA = "0x28A9198", Offset = "0x28A9198", VA = "0x28A9198", Slot = "14")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
