using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B5A")]
public class NotifyPlayerChangePhyStatePbAsset : PlayableAsset
{
	[Token(Token = "0x40060E9")]
	[FieldOffset(Offset = "0xC")]
	public ESingerBPhyChange ChangePhyState;

	[Token(Token = "0x6005688")]
	[Address(RVA = "0x20E9670", Offset = "0x20E9670", VA = "0x20E9670")]
	public NotifyPlayerChangePhyStatePbAsset()
	{
	}

	[Token(Token = "0x6005689")]
	[Address(RVA = "0x20E9678", Offset = "0x20E9678", VA = "0x20E9678", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
