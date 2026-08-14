using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B5D")]
public class PlaySceneTimelinePlayable : PlayableBehaviour
{
	[Token(Token = "0x40060ED")]
	[FieldOffset(Offset = "0x8")]
	public GameObject SceneTimeLineGameObject;

	[Token(Token = "0x40060EE")]
	[FieldOffset(Offset = "0xC")]
	public GameObject SceneTimeLineGameObjectLow;

	[Token(Token = "0x40060EF")]
	[FieldOffset(Offset = "0x10")]
	public double ClipStartTime;

	[Token(Token = "0x600568E")]
	[Address(RVA = "0x20E9C68", Offset = "0x20E9C68", VA = "0x20E9C68")]
	public PlaySceneTimelinePlayable()
	{
	}

	[Token(Token = "0x600568F")]
	[Address(RVA = "0x20E9C70", Offset = "0x20E9C70", VA = "0x20E9C70", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}
}
