using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038CC")]
public class UINewVaultEmoteItemView : UIBaseView
{
	[Token(Token = "0x401788C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x401788D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject DragItem;

	[Token(Token = "0x401788E")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite DragItemIcon;

	[Token(Token = "0x401788F")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BooyahSpr;

	[Token(Token = "0x4017890")]
	[FieldOffset(Offset = "0x24")]
	public GameObject TipsGO;

	[Token(Token = "0x4017891")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SecondVFX;

	[Token(Token = "0x4017892")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite itemSprite;

	[Token(Token = "0x4017893")]
	[FieldOffset(Offset = "0x30")]
	public BaseItemView2 ItemIconView2;

	[Token(Token = "0x4017894")]
	[FieldOffset(Offset = "0x34")]
	public UISprite defaultEmoteSprite;

	[Token(Token = "0x4017895")]
	[FieldOffset(Offset = "0x38")]
	public UISprite stateSprite;

	[Token(Token = "0x4017896")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject HL;

	[Token(Token = "0x4017897")]
	[FieldOffset(Offset = "0x40")]
	public UISprite validSprite;

	[Token(Token = "0x4017898")]
	[FieldOffset(Offset = "0x44")]
	public UILabel valid;

	[Token(Token = "0x4017899")]
	[FieldOffset(Offset = "0x48")]
	public UISprite RankIcon;

	[Token(Token = "0x401789A")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Download;

	[Token(Token = "0x401789B")]
	[FieldOffset(Offset = "0x50")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x401789C")]
	[FieldOffset(Offset = "0x54")]
	public UISprite Quality;

	[Token(Token = "0x401789D")]
	[FieldOffset(Offset = "0x58")]
	public UISprite QualityBG;

	[Token(Token = "0x401789E")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject gray;

	[Token(Token = "0x401789F")]
	[FieldOffset(Offset = "0x60")]
	public UISprite IPTag;

	[Token(Token = "0x40178A0")]
	[FieldOffset(Offset = "0x64")]
	public GameObject Descargar;

	[Token(Token = "0x40178A1")]
	[FieldOffset(Offset = "0x68")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x6016E0D")]
	[Address(RVA = "0x2C213B8", Offset = "0x2C213B8", VA = "0x2C213B8")]
	public UINewVaultEmoteItemView()
	{
	}

	[Token(Token = "0x6016E0E")]
	[Address(RVA = "0x2C213C0", Offset = "0x2C213C0", VA = "0x2C213C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E0F")]
	[Address(RVA = "0x2C21CF4", Offset = "0x2C21CF4", VA = "0x2C21CF4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
