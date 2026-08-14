using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200347A")]
public class UICommonPopMenuView : UIBaseView
{
	[Token(Token = "0x40146B8")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel UICommonPopMenu;

	[Token(Token = "0x40146B9")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget Container;

	[Token(Token = "0x40146BA")]
	[FieldOffset(Offset = "0x1C")]
	public Transform ProfileContainer;

	[Token(Token = "0x40146BB")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid ItemGrid;

	[Token(Token = "0x40146BC")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BGBorder;

	[Token(Token = "0x40146BD")]
	[FieldOffset(Offset = "0x28")]
	public UISprite BG;

	[Token(Token = "0x6016122")]
	[Address(RVA = "0x2CE52C4", Offset = "0x2CE52C4", VA = "0x2CE52C4")]
	public UICommonPopMenuView()
	{
	}

	[Token(Token = "0x6016123")]
	[Address(RVA = "0x2CE52CC", Offset = "0x2CE52CC", VA = "0x2CE52CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016124")]
	[Address(RVA = "0x2CE562C", Offset = "0x2CE562C", VA = "0x2CE562C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
