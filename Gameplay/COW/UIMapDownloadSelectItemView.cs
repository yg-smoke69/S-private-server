using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200388A")]
public class UIMapDownloadSelectItemView : UIBaseView
{
	[Token(Token = "0x40175AD")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelMapName;

	[Token(Token = "0x40175AE")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnSelect;

	[Token(Token = "0x40175AF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SpriteSelected;

	[Token(Token = "0x40175B0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SpriteNotSelected;

	[Token(Token = "0x40175B1")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelMapSize;

	[Token(Token = "0x6016D49")]
	[Address(RVA = "0x2801414", Offset = "0x2801414", VA = "0x2801414")]
	public UIMapDownloadSelectItemView()
	{
	}

	[Token(Token = "0x6016D4A")]
	[Address(RVA = "0x280141C", Offset = "0x280141C", VA = "0x280141C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D4B")]
	[Address(RVA = "0x280172C", Offset = "0x280172C", VA = "0x280172C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
