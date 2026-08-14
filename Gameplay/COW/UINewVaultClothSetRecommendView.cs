using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038C9")]
public class UINewVaultClothSetRecommendView : UIBaseView
{
	[Token(Token = "0x4017873")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UINewVaultClothSetRecommend;

	[Token(Token = "0x4017874")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid ClothSetList;

	[Token(Token = "0x4017875")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Cloth;

	[Token(Token = "0x4017876")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Descargar;

	[Token(Token = "0x4017877")]
	[FieldOffset(Offset = "0x24")]
	public UIButton DressUp;

	[Token(Token = "0x4017878")]
	[FieldOffset(Offset = "0x28")]
	public UISprite BG;

	[Token(Token = "0x6016E04")]
	[Address(RVA = "0x2C016F4", Offset = "0x2C016F4", VA = "0x2C016F4")]
	public UINewVaultClothSetRecommendView()
	{
	}

	[Token(Token = "0x6016E05")]
	[Address(RVA = "0x2C016FC", Offset = "0x2C016FC", VA = "0x2C016FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E06")]
	[Address(RVA = "0x2C01A6C", Offset = "0x2C01A6C", VA = "0x2C01A6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
