using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B57")]
public class NotifyPlayerChangeActiveAsset : PlayableAsset
{
	[Token(Token = "0x40060E1")]
	[FieldOffset(Offset = "0xC")]
	public bool active;

	[Token(Token = "0x6005684")]
	[Address(RVA = "0x20E8A9C", Offset = "0x20E8A9C", VA = "0x20E8A9C")]
	public NotifyPlayerChangeActiveAsset()
	{
	}

	[Token(Token = "0x6005685")]
	[Address(RVA = "0x20E8AA4", Offset = "0x20E8AA4", VA = "0x20E8AA4", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
