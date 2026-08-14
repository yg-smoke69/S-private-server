using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003684")]
public class UIHudItemMarkShowItemView : UIBaseView
{
	[Token(Token = "0x4015EC8")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ItemSprite;

	[Token(Token = "0x4015EC9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CountLabel;

	[Token(Token = "0x4015ECA")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ItemName;

	[Token(Token = "0x4015ECB")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnClick;

	[Token(Token = "0x6016739")]
	[Address(RVA = "0x20AC37C", Offset = "0x20AC37C", VA = "0x20AC37C")]
	public UIHudItemMarkShowItemView()
	{
	}

	[Token(Token = "0x601673A")]
	[Address(RVA = "0x20AC384", Offset = "0x20AC384", VA = "0x20AC384", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601673B")]
	[Address(RVA = "0x20AC64C", Offset = "0x20AC64C", VA = "0x20AC64C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
