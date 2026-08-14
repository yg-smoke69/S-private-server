using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B65")]
public class SingersBNotifyPbAsset : PlayableAsset
{
	[Token(Token = "0x40060FD")]
	[FieldOffset(Offset = "0xC")]
	public ESingerBNotifyType NotifyType;

	[Token(Token = "0x600569C")]
	[Address(RVA = "0x20EBF28", Offset = "0x20EBF28", VA = "0x20EBF28")]
	public SingersBNotifyPbAsset()
	{
	}

	[Token(Token = "0x600569D")]
	[Address(RVA = "0x20EBF30", Offset = "0x20EBF30", VA = "0x20EBF30", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}
}
