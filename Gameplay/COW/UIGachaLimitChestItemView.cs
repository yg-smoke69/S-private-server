using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003587")]
public class UIGachaLimitChestItemView : UIBaseView
{
	[Token(Token = "0x4015479")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIGachaLimitChestItem;

	[Token(Token = "0x401547A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GameObjectItemContainer;

	[Token(Token = "0x401547B")]
	[FieldOffset(Offset = "0x1C")]
	public BaseItemView BaseItemViewItemContainer;

	[Token(Token = "0x401547C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SelectedBG;

	[Token(Token = "0x401547D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ItemContainer;

	[Token(Token = "0x401547E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ObtainedSprite;

	[Token(Token = "0x401547F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LimitTimeLabel;

	[Token(Token = "0x4015480")]
	[FieldOffset(Offset = "0x30")]
	public UILabel DropUpLabel;

	[Token(Token = "0x4015481")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AlreadyOwnSprite;

	[Token(Token = "0x4015482")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnTip;

	[Token(Token = "0x4015483")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject QualityBG01;

	[Token(Token = "0x4015484")]
	[FieldOffset(Offset = "0x40")]
	public GameObject QualityBG02;

	[Token(Token = "0x4015485")]
	[FieldOffset(Offset = "0x44")]
	public GameObject QualityBG03;

	[Token(Token = "0x4015486")]
	[FieldOffset(Offset = "0x48")]
	public GameObject QualityBG04;

	[Token(Token = "0x4015487")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject QualityBG05;

	[Token(Token = "0x4015488")]
	[FieldOffset(Offset = "0x50")]
	public GameObject QualityBG06;

	[Token(Token = "0x4015489")]
	[FieldOffset(Offset = "0x54")]
	public UISprite SpritePurplePlus;

	[Token(Token = "0x401548A")]
	[FieldOffset(Offset = "0x58")]
	public UISprite SpriteOrangePlus;

	[Token(Token = "0x401548B")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject FlickerEffect;

	[Token(Token = "0x401548C")]
	[FieldOffset(Offset = "0x60")]
	public GameObject SecondVFX;

	[Token(Token = "0x401548D")]
	[FieldOffset(Offset = "0x64")]
	public GameObject FirstVFX;

	[Token(Token = "0x401548E")]
	[FieldOffset(Offset = "0x68")]
	public GameObject ThirdVFX;

	[Token(Token = "0x401548F")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject OwnedNode;

	[Token(Token = "0x4015490")]
	[FieldOffset(Offset = "0x70")]
	public GameObject PurchasedNode;

	[Token(Token = "0x4015491")]
	[FieldOffset(Offset = "0x74")]
	public GameObject Status1Effect;

	[Token(Token = "0x4015492")]
	[FieldOffset(Offset = "0x78")]
	public GameObject Status2Effect;

	[Token(Token = "0x4015493")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject Status3Effect;

	[Token(Token = "0x4015494")]
	[FieldOffset(Offset = "0x80")]
	public GameObject Status4Effect;

	[Token(Token = "0x4015495")]
	[FieldOffset(Offset = "0x84")]
	public GameObject Status5Effect;

	[Token(Token = "0x4015496")]
	[FieldOffset(Offset = "0x88")]
	public GameObject VFX_QualityRed;

	[Token(Token = "0x4015497")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject VFX_QualityOrangePlus;

	[Token(Token = "0x6016445")]
	[Address(RVA = "0x2E84B90", Offset = "0x2E84B90", VA = "0x2E84B90")]
	public UIGachaLimitChestItemView()
	{
	}

	[Token(Token = "0x6016446")]
	[Address(RVA = "0x2E84B98", Offset = "0x2E84B98", VA = "0x2E84B98", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016447")]
	[Address(RVA = "0x2E85754", Offset = "0x2E85754", VA = "0x2E85754")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
