using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Serializable]
[Token(Token = "0x2000B62")]
public class RecordStartTimePlayableAsset : PlayableAsset
{
	[Token(Token = "0x40060F5")]
	[FieldOffset(Offset = "0x10")]
	public double ClipStartTime;

	[Token(Token = "0x6005698")]
	[Address(RVA = "0x20E9B24", Offset = "0x20E9B24", VA = "0x20E9B24")]
	public RecordStartTimePlayableAsset()
	{
	}

	[Token(Token = "0x6005699")]
	[Address(RVA = "0x20EAABC", Offset = "0x20EAABC", VA = "0x20EAABC", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
