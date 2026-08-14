using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200349B")]
public class UICupMatchProfileItemView : UIBaseView
{
	[Token(Token = "0x401484F")]
	[FieldOffset(Offset = "0x14")]
	public UISprite LeaderIcon;

	[Token(Token = "0x4014850")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelName;

	[Token(Token = "0x4014851")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Right;

	[Token(Token = "0x4014852")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture HeadTextureRight;

	[Token(Token = "0x4014853")]
	[FieldOffset(Offset = "0x24")]
	public UISprite HeadIconRight;

	[Token(Token = "0x4014854")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Left;

	[Token(Token = "0x4014855")]
	[FieldOffset(Offset = "0x2C")]
	public UINetworkTexture HeadTextureLeft;

	[Token(Token = "0x4014856")]
	[FieldOffset(Offset = "0x30")]
	public UISprite HeadIconLeft;

	[Token(Token = "0x6016185")]
	[Address(RVA = "0x2AAA498", Offset = "0x2AAA498", VA = "0x2AAA498")]
	public UICupMatchProfileItemView()
	{
	}

	[Token(Token = "0x6016186")]
	[Address(RVA = "0x2AAA4A0", Offset = "0x2AAA4A0", VA = "0x2AAA4A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016187")]
	[Address(RVA = "0x2AAA8D0", Offset = "0x2AAA8D0", VA = "0x2AAA8D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
