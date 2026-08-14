using Il2CppDummyDll;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B4E")]
public class AsyncLoadTimeLinePlayable : PlayableBehaviour
{
	[Token(Token = "0x40060D6")]
	[FieldOffset(Offset = "0x8")]
	public string m_TimeLineResouceIDName;

	[Token(Token = "0x6005672")]
	[Address(RVA = "0x20E765C", Offset = "0x20E765C", VA = "0x20E765C")]
	public AsyncLoadTimeLinePlayable()
	{
	}

	[Token(Token = "0x6005673")]
	[Address(RVA = "0x20E7664", Offset = "0x20E7664", VA = "0x20E7664", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}
}
