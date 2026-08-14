using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B50")]
public class DestroyAndUnloadTimeLinePlayable : PlayableBehaviour
{
	[Token(Token = "0x40060D8")]
	[FieldOffset(Offset = "0x8")]
	public string m_TimeLineResouceIDName;

	[Token(Token = "0x40060D9")]
	[FieldOffset(Offset = "0xC")]
	public GameObject TimeLineObject;

	[Token(Token = "0x40060DA")]
	[FieldOffset(Offset = "0x10")]
	public GameObject TimeLineObjectLow;

	[Token(Token = "0x6005676")]
	[Address(RVA = "0x20E7C14", Offset = "0x20E7C14", VA = "0x20E7C14")]
	public DestroyAndUnloadTimeLinePlayable()
	{
	}

	[Token(Token = "0x6005677")]
	[Address(RVA = "0x20E7C1C", Offset = "0x20E7C1C", VA = "0x20E7C1C", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}
}
