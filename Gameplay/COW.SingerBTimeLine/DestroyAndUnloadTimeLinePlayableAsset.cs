using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Serializable]
[Token(Token = "0x2000B51")]
public class DestroyAndUnloadTimeLinePlayableAsset : PlayableAsset
{
	[Token(Token = "0x40060DB")]
	[FieldOffset(Offset = "0xC")]
	public string TimeLineResouceIDName;

	[Token(Token = "0x40060DC")]
	[FieldOffset(Offset = "0x10")]
	public ExposedReference<GameObject> TimeLineObject;

	[Token(Token = "0x40060DD")]
	[FieldOffset(Offset = "0x18")]
	public ExposedReference<GameObject> TimeLineObjectLow;

	[Token(Token = "0x6005678")]
	[Address(RVA = "0x20E7FC8", Offset = "0x20E7FC8", VA = "0x20E7FC8")]
	public DestroyAndUnloadTimeLinePlayableAsset()
	{
	}

	[Token(Token = "0x6005679")]
	[Address(RVA = "0x20E7FD0", Offset = "0x20E7FD0", VA = "0x20E7FD0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
