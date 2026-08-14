using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003721")]
public class UIHudSceneEditActionListView : UIBaseView
{
	[Token(Token = "0x4016493")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition TweenPos;

	[Token(Token = "0x4016494")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollViewTypes;

	[Token(Token = "0x4016495")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid ItemTypeGrid;

	[Token(Token = "0x4016496")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ScrollViewActions;

	[Token(Token = "0x4016497")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid ItemListGrid;

	[Token(Token = "0x4016498")]
	[FieldOffset(Offset = "0x28")]
	public UIButton ToggleBtn;

	[Token(Token = "0x4016499")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ToggleBtnReverse;

	[Token(Token = "0x401649A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject AttributeUIContainer;

	[Token(Token = "0x401649B")]
	[FieldOffset(Offset = "0x34")]
	public Transform AttributeUIAnchorLeft;

	[Token(Token = "0x601690E")]
	[Address(RVA = "0x1C52260", Offset = "0x1C52260", VA = "0x1C52260")]
	public UIHudSceneEditActionListView()
	{
	}

	[Token(Token = "0x601690F")]
	[Address(RVA = "0x1C52268", Offset = "0x1C52268", VA = "0x1C52268", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016910")]
	[Address(RVA = "0x1C526DC", Offset = "0x1C526DC", VA = "0x1C526DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
