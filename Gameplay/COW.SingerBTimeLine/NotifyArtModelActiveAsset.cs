using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B53")]
public class NotifyArtModelActiveAsset : PlayableAsset
{
	[Token(Token = "0x40060DF")]
	[FieldOffset(Offset = "0xC")]
	public bool active;

	[Token(Token = "0x600567C")]
	[Address(RVA = "0x20E83AC", Offset = "0x20E83AC", VA = "0x20E83AC")]
	public NotifyArtModelActiveAsset()
	{
	}

	[Token(Token = "0x600567D")]
	[Address(RVA = "0x20E83B4", Offset = "0x20E83B4", VA = "0x20E83B4", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
