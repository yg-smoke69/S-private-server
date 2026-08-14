using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035BF")]
public class UIHeroicStarTipView : UIBaseView
{
	[Token(Token = "0x401582C")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Label0;

	[Token(Token = "0x401582D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label1;

	[Token(Token = "0x401582E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Label2;

	[Token(Token = "0x401582F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Label3;

	[Token(Token = "0x4015830")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Label4;

	[Token(Token = "0x4015831")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HeroicSprite;

	[Token(Token = "0x4015832")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject MasterSprite;

	[Token(Token = "0x4015833")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelKey;

	[Token(Token = "0x60164EB")]
	[Address(RVA = "0x162D2C4", Offset = "0x162D2C4", VA = "0x162D2C4")]
	public UIHeroicStarTipView()
	{
	}

	[Token(Token = "0x60164EC")]
	[Address(RVA = "0x162D2CC", Offset = "0x162D2CC", VA = "0x162D2CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164ED")]
	[Address(RVA = "0x162D6FC", Offset = "0x162D6FC", VA = "0x162D6FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
