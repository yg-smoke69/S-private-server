using Il2CppDummyDll;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B58")]
public class NotifyPlayerChangePhyStatePb : PlayableBehaviour
{
	[Token(Token = "0x40060E2")]
	[FieldOffset(Offset = "0x8")]
	public ESingerBPhyChange ChangePhyState;

	[Token(Token = "0x6005686")]
	[Address(RVA = "0x20E8BB8", Offset = "0x20E8BB8", VA = "0x20E8BB8")]
	public NotifyPlayerChangePhyStatePb()
	{
	}

	[Token(Token = "0x6005687")]
	[Address(RVA = "0x20E8BC0", Offset = "0x20E8BC0", VA = "0x20E8BC0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}
}
