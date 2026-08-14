using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200380E")]
public class UILadderMatchResetMatchRewardItemView : UIBaseView
{
	[Token(Token = "0x4016C9D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel RankLabel;

	[Token(Token = "0x4016C9E")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid RewardGrid;

	[Token(Token = "0x6016BD5")]
	[Address(RVA = "0x22BE704", Offset = "0x22BE704", VA = "0x22BE704")]
	public UILadderMatchResetMatchRewardItemView()
	{
	}

	[Token(Token = "0x6016BD6")]
	[Address(RVA = "0x22BE70C", Offset = "0x22BE70C", VA = "0x22BE70C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BD7")]
	[Address(RVA = "0x22BE914", Offset = "0x22BE914", VA = "0x22BE914")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
