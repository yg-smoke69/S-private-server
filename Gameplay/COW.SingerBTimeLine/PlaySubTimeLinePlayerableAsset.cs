using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Serializable]
[Token(Token = "0x2000B60")]
public class PlaySubTimeLinePlayerableAsset : RecordStartTimePlayableAsset
{
	[Token(Token = "0x40060F4")]
	[FieldOffset(Offset = "0x18")]
	public string TimeLineResouceIDName;

	[Token(Token = "0x6005694")]
	[Address(RVA = "0x20EA520", Offset = "0x20EA520", VA = "0x20EA520")]
	public PlaySubTimeLinePlayerableAsset()
	{
	}

	[Token(Token = "0x6005695")]
	[Address(RVA = "0x20EA528", Offset = "0x20EA528", VA = "0x20EA528", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
