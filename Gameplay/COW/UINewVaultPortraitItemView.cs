using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038D4")]
public class UINewVaultPortraitItemView : UIBaseView
{
	[Token(Token = "0x40178CD")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x40178CE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject gray;

	[Token(Token = "0x40178CF")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite validSprite;

	[Token(Token = "0x40178D0")]
	[FieldOffset(Offset = "0x20")]
	public UILabel valid;

	[Token(Token = "0x40178D1")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HL;

	[Token(Token = "0x40178D2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TipsGO;

	[Token(Token = "0x40178D3")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TagLabel;

	[Token(Token = "0x40178D4")]
	[FieldOffset(Offset = "0x30")]
	public GameObject WL;

	[Token(Token = "0x40178D5")]
	[FieldOffset(Offset = "0x34")]
	public GameObject FakeSprite;

	[Token(Token = "0x40178D6")]
	[FieldOffset(Offset = "0x38")]
	public UIEffectSprite iconSprite;

	[Token(Token = "0x40178D7")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite RankIcon;

	[Token(Token = "0x40178D8")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Descargar;

	[Token(Token = "0x6016E25")]
	[Address(RVA = "0x26CBD98", Offset = "0x26CBD98", VA = "0x26CBD98")]
	public UINewVaultPortraitItemView()
	{
	}

	[Token(Token = "0x6016E26")]
	[Address(RVA = "0x26CBDA0", Offset = "0x26CBDA0", VA = "0x26CBDA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E27")]
	[Address(RVA = "0x26CC320", Offset = "0x26CC320", VA = "0x26CC320")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
