using Il2CppDummyDll;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B5B")]
public class PlayBGMPlayable : PlayableBehaviour
{
	[Token(Token = "0x40060EA")]
	[FieldOffset(Offset = "0x8")]
	public string BGMPrefabResIDStr;

	[Token(Token = "0x40060EB")]
	[FieldOffset(Offset = "0x10")]
	public double ClipStartTime;

	[Token(Token = "0x600568A")]
	[Address(RVA = "0x20E978C", Offset = "0x20E978C", VA = "0x20E978C")]
	public PlayBGMPlayable()
	{
	}

	[Token(Token = "0x600568B")]
	[Address(RVA = "0x20E9794", Offset = "0x20E9794", VA = "0x20E9794", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}
}
