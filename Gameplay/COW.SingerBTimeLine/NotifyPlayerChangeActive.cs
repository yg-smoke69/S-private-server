using Il2CppDummyDll;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B56")]
public class NotifyPlayerChangeActive : PlayableBehaviour
{
	[Token(Token = "0x40060E0")]
	[FieldOffset(Offset = "0x8")]
	public bool active;

	[Token(Token = "0x6005682")]
	[Address(RVA = "0x20E87B4", Offset = "0x20E87B4", VA = "0x20E87B4")]
	public NotifyPlayerChangeActive()
	{
	}

	[Token(Token = "0x6005683")]
	[Address(RVA = "0x20E87BC", Offset = "0x20E87BC", VA = "0x20E87BC", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}
}
