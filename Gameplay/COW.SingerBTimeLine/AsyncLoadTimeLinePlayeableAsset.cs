using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Serializable]
[Token(Token = "0x2000B4F")]
public class AsyncLoadTimeLinePlayeableAsset : PlayableAsset
{
	[Token(Token = "0x40060D7")]
	[FieldOffset(Offset = "0xC")]
	public string TimeLineResouceIDName;

	[Token(Token = "0x6005674")]
	[Address(RVA = "0x20E7AF8", Offset = "0x20E7AF8", VA = "0x20E7AF8")]
	public AsyncLoadTimeLinePlayeableAsset()
	{
	}

	[Token(Token = "0x6005675")]
	[Address(RVA = "0x20E7B00", Offset = "0x20E7B00", VA = "0x20E7B00", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
