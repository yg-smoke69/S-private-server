using Il2CppDummyDll;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B63")]
public class SingersBNotifyPb : PlayableBehaviour
{
	[Token(Token = "0x40060F6")]
	[FieldOffset(Offset = "0x8")]
	public ESingerBNotifyType NotifyType;

	[Token(Token = "0x600569A")]
	[Address(RVA = "0x20EB7E0", Offset = "0x20EB7E0", VA = "0x20EB7E0")]
	public SingersBNotifyPb()
	{
	}

	[Token(Token = "0x600569B")]
	[Address(RVA = "0x20EB7E8", Offset = "0x20EB7E8", VA = "0x20EB7E8", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}
}
