using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200346C")]
public class UIClothPreviewItemView : UIBaseView
{
	[Token(Token = "0x401462D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton clothpreviewbtn;

	[Token(Token = "0x401462E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Normal;

	[Token(Token = "0x401462F")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BG;

	[Token(Token = "0x4014630")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Highlight;

	[Token(Token = "0x4014631")]
	[FieldOffset(Offset = "0x24")]
	public GameObject equip;

	[Token(Token = "0x4014632")]
	[FieldOffset(Offset = "0x28")]
	public UISprite icon;

	[Token(Token = "0x60160F8")]
	[Address(RVA = "0x2CD1774", Offset = "0x2CD1774", VA = "0x2CD1774")]
	public UIClothPreviewItemView()
	{
	}

	[Token(Token = "0x60160F9")]
	[Address(RVA = "0x2CD177C", Offset = "0x2CD177C", VA = "0x2CD177C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160FA")]
	[Address(RVA = "0x2CD1AE0", Offset = "0x2CD1AE0", VA = "0x2CD1AE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
