using Il2CppDummyDll;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B5F")]
public class PlaySubTimeLinePlayerable : PlayableBehaviour
{
	[Token(Token = "0x40060F2")]
	[FieldOffset(Offset = "0x8")]
	public string TimeLineResouceIDName;

	[Token(Token = "0x40060F3")]
	[FieldOffset(Offset = "0x10")]
	public double ClipStartTime;

	[Token(Token = "0x6005692")]
	[Address(RVA = "0x20EA204", Offset = "0x20EA204", VA = "0x20EA204")]
	public PlaySubTimeLinePlayerable()
	{
	}

	[Token(Token = "0x6005693")]
	[Address(RVA = "0x20EA20C", Offset = "0x20EA20C", VA = "0x20EA20C", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}
}
