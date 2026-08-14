using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003851")]
public class UILobbyVehicleDisplayItemView : UIBaseView
{
	[Token(Token = "0x4017121")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UILobbyVehicleDisplayItem;

	[Token(Token = "0x4017122")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Quality;

	[Token(Token = "0x4017123")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite QualityBG;

	[Token(Token = "0x4017124")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4017125")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x4017126")]
	[FieldOffset(Offset = "0x28")]
	public GameObject effectBg;

	[Token(Token = "0x4017127")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite VehicleSprite;

	[Token(Token = "0x4017128")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HL;

	[Token(Token = "0x4017129")]
	[FieldOffset(Offset = "0x34")]
	public GameObject TipsGO;

	[Token(Token = "0x401712A")]
	[FieldOffset(Offset = "0x38")]
	public UILabel TagLabel;

	[Token(Token = "0x401712B")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject DownloadRoot;

	[Token(Token = "0x6016C9E")]
	[Address(RVA = "0x1CC091C", Offset = "0x1CC091C", VA = "0x1CC091C")]
	public UILobbyVehicleDisplayItemView()
	{
	}

	[Token(Token = "0x6016C9F")]
	[Address(RVA = "0x1CC0924", Offset = "0x1CC0924", VA = "0x1CC0924", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CA0")]
	[Address(RVA = "0x1CC0E5C", Offset = "0x1CC0E5C", VA = "0x1CC0E5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
