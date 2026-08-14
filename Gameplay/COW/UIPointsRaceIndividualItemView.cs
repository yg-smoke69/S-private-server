using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200390B")]
public class UIPointsRaceIndividualItemView : UIBaseView
{
	[Token(Token = "0x4017BA9")]
	[FieldOffset(Offset = "0x14")]
	public GameObject LargeGreyMask;

	[Token(Token = "0x4017BAA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GreyMask;

	[Token(Token = "0x4017BAB")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GreyNumberText;

	[Token(Token = "0x4017BAC")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TitleText;

	[Token(Token = "0x4017BAD")]
	[FieldOffset(Offset = "0x24")]
	public UIButton TipsBtn;

	[Token(Token = "0x4017BAE")]
	[FieldOffset(Offset = "0x28")]
	public BaseItemView Item;

	[Token(Token = "0x4017BAF")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite QualityBG;

	[Token(Token = "0x4017BB0")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4017BB1")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Quality;

	[Token(Token = "0x4017BB2")]
	[FieldOffset(Offset = "0x38")]
	public UIButton ClaimBtn;

	[Token(Token = "0x4017BB3")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ClaimedObj;

	[Token(Token = "0x4017BB4")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x4017BB5")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BGTokenNotEnough;

	[Token(Token = "0x4017BB6")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BGTokenEnough;

	[Token(Token = "0x6016ECA")]
	[Address(RVA = "0x2C53C34", Offset = "0x2C53C34", VA = "0x2C53C34")]
	public UIPointsRaceIndividualItemView()
	{
	}

	[Token(Token = "0x6016ECB")]
	[Address(RVA = "0x2C53C3C", Offset = "0x2C53C3C", VA = "0x2C53C3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016ECC")]
	[Address(RVA = "0x2C54288", Offset = "0x2C54288", VA = "0x2C54288")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
