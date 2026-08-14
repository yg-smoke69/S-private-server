using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200387D")]
public class UIManualGrownItemView : UIBaseView
{
	[Token(Token = "0x401743C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x401743D")]
	[FieldOffset(Offset = "0x18")]
	public BaseItemView RewardItem;

	[Token(Token = "0x401743E")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject IconGroup;

	[Token(Token = "0x401743F")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Sprite_Debris;

	[Token(Token = "0x4017440")]
	[FieldOffset(Offset = "0x24")]
	public UISprite VoucherIcon;

	[Token(Token = "0x4017441")]
	[FieldOffset(Offset = "0x28")]
	public UISprite DisableMask;

	[Token(Token = "0x4017442")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject EnableBG;

	[Token(Token = "0x6016D22")]
	[Address(RVA = "0x2C27B40", Offset = "0x2C27B40", VA = "0x2C27B40")]
	public UIManualGrownItemView()
	{
	}

	[Token(Token = "0x6016D23")]
	[Address(RVA = "0x2C27B48", Offset = "0x2C27B48", VA = "0x2C27B48", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D24")]
	[Address(RVA = "0x2C27F18", Offset = "0x2C27F18", VA = "0x2C27F18")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
