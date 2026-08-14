using Il2CppDummyDll;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B52")]
public class NotifyArtModelActive : PlayableBehaviour
{
	[Token(Token = "0x40060DE")]
	[FieldOffset(Offset = "0x8")]
	public bool active;

	[Token(Token = "0x600567A")]
	[Address(RVA = "0x20E816C", Offset = "0x20E816C", VA = "0x20E816C")]
	public NotifyArtModelActive()
	{
	}

	[Token(Token = "0x600567B")]
	[Address(RVA = "0x20E8174", Offset = "0x20E8174", VA = "0x20E8174", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}
}
