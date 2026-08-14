using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037FC")]
public class UIIntegerateRewardPoolItemView : UIBaseView
{
	[Token(Token = "0x4016BEE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ItemPos;

	[Token(Token = "0x4016BEF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CountLabel;

	[Token(Token = "0x6016B9F")]
	[Address(RVA = "0x12813F4", Offset = "0x12813F4", VA = "0x12813F4")]
	public UIIntegerateRewardPoolItemView()
	{
	}

	[Token(Token = "0x6016BA0")]
	[Address(RVA = "0x12813FC", Offset = "0x12813FC", VA = "0x12813FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BA1")]
	[Address(RVA = "0x1281564", Offset = "0x1281564", VA = "0x1281564")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
