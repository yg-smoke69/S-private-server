using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B5C")]
public class PlayBGMPlayableAsset : RecordStartTimePlayableAsset
{
	[Token(Token = "0x40060EC")]
	[FieldOffset(Offset = "0x18")]
	public string BGMPrefabResIDStr;

	[Token(Token = "0x600568C")]
	[Address(RVA = "0x20E9B1C", Offset = "0x20E9B1C", VA = "0x20E9B1C")]
	public PlayBGMPlayableAsset()
	{
	}

	[Token(Token = "0x600568D")]
	[Address(RVA = "0x20E9B2C", Offset = "0x20E9B2C", VA = "0x20E9B2C", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
