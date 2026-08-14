using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B5E")]
public class PlaySceneTimelinePlayableAsset : RecordStartTimePlayableAsset
{
	[Token(Token = "0x40060F0")]
	[FieldOffset(Offset = "0x18")]
	public ExposedReference<GameObject> SceneTimeLineGameObject;

	[Token(Token = "0x40060F1")]
	[FieldOffset(Offset = "0x20")]
	public ExposedReference<GameObject> SceneTimeLineGameObjectLow;

	[Token(Token = "0x6005690")]
	[Address(RVA = "0x20EA050", Offset = "0x20EA050", VA = "0x20EA050")]
	public PlaySceneTimelinePlayableAsset()
	{
	}

	[Token(Token = "0x6005691")]
	[Address(RVA = "0x20EA058", Offset = "0x20EA058", VA = "0x20EA058", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
