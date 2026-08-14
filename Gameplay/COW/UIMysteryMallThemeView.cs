using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002D4F")]
public class UIMysteryMallThemeView : MonoBehaviour
{
	[Token(Token = "0x401162B")]
	[FieldOffset(Offset = "0xC")]
	public EThemeType ThemeType;

	[Token(Token = "0x401162C")]
	[FieldOffset(Offset = "0x10")]
	public UIProgressBar BarCostProgress;

	[Token(Token = "0x401162D")]
	[FieldOffset(Offset = "0x14")]
	public Transform BarPoint;

	[Token(Token = "0x401162E")]
	[FieldOffset(Offset = "0x18")]
	public MeshRenderer BarUV1;

	[Token(Token = "0x401162F")]
	[FieldOffset(Offset = "0x1C")]
	public MeshRenderer BarUV2;

	[Token(Token = "0x4011630")]
	[FieldOffset(Offset = "0x20")]
	public Transform Bar;

	[Token(Token = "0x4011631")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelLuckNum;

	[Token(Token = "0x4011632")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelSuperRewardDiscount;

	[Token(Token = "0x4011633")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelSuperRewardItemName;

	[Token(Token = "0x4011634")]
	[FieldOffset(Offset = "0x30")]
	public MeshRenderer VFXLuckNum;

	[Token(Token = "0x4011635")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ContainerEffect;

	[Token(Token = "0x4011636")]
	[FieldOffset(Offset = "0x38")]
	public GameObject TabSelectEffect;

	[Token(Token = "0x4011637")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SpriteShare;

	[Token(Token = "0x4011638")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SpriteSwitch;

	[Token(Token = "0x4011639")]
	[FieldOffset(Offset = "0x44")]
	public UISprite SpritePurchase;

	[Token(Token = "0x401163A")]
	[FieldOffset(Offset = "0x48")]
	public GameObject MainObject;

	[Token(Token = "0x401163B")]
	[FieldOffset(Offset = "0x4C")]
	public List<uint> ShopIdList;

	[Token(Token = "0x6012F60")]
	[Address(RVA = "0x1B2D3C8", Offset = "0x1B2D3C8", VA = "0x1B2D3C8")]
	public UIMysteryMallThemeView()
	{
	}

	[Token(Token = "0x6012F61")]
	[Address(RVA = "0x1B2D454", Offset = "0x1B2D454", VA = "0x1B2D454")]
	public void SetThemeActive(bool isCurrentTheme)
	{
	}

	[Token(Token = "0x6012F62")]
	[Address(RVA = "0x1B2D64C", Offset = "0x1B2D64C", VA = "0x1B2D64C")]
	public void SetViewData(ClientMysteryShopSwitchDesc curPoolDesc)
	{
	}

	[Token(Token = "0x6012F63")]
	[Address(RVA = "0x1B2DE20", Offset = "0x1B2DE20", VA = "0x1B2DE20")]
	public static void SetSuperDiscountPriceTheme(UILabel label)
	{
	}

	[Token(Token = "0x6012F64")]
	[Address(RVA = "0x1B2DCD8", Offset = "0x1B2DCD8", VA = "0x1B2DCD8")]
	public void RefreshBar()
	{
	}

	[Token(Token = "0x6012F65")]
	[Address(RVA = "0x1B2E554", Offset = "0x1B2E554", VA = "0x1B2E554")]
	public void SetTabSelectEffect(UIStandardTopTabItemController itemCtrl)
	{
	}

	[Token(Token = "0x6012F66")]
	[Address(RVA = "0x1B2E760", Offset = "0x1B2E760", VA = "0x1B2E760")]
	public static void SetItemSuperContainerTransform(Transform transform)
	{
	}

	[Token(Token = "0x6012F67")]
	[Address(RVA = "0x1B2DFEC", Offset = "0x1B2DFEC", VA = "0x1B2DFEC")]
	private void RefreshBarUVMaterial(MeshRenderer barUV01, MeshRenderer barUV02)
	{
	}

	[Token(Token = "0x6012F68")]
	[Address(RVA = "0x1B2E34C", Offset = "0x1B2E34C", VA = "0x1B2E34C")]
	private void RefreshBarLength(Transform bar, float barValue, float maxPosX, float maxScaleX)
	{
	}

	[Token(Token = "0x6012F69")]
	[Address(RVA = "0x1B2E8F0", Offset = "0x1B2E8F0", VA = "0x1B2E8F0")]
	public static void SetCostNumTheme(UILabel LabelCostNum)
	{
	}

	[Token(Token = "0x6012F6A")]
	[Address(RVA = "0x1B2EAF8", Offset = "0x1B2EAF8", VA = "0x1B2EAF8")]
	public static void SetPriceTipTheme(UILabel label)
	{
	}

	[Token(Token = "0x6012F6B")]
	[Address(RVA = "0x1B2EC3C", Offset = "0x1B2EC3C", VA = "0x1B2EC3C")]
	public static void SetCountDownTheme(UICountDownController ctrl)
	{
	}
}
