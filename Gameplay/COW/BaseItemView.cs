using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D04")]
public class BaseItemView : MonoBehaviour
{
	[Token(Token = "0x401127C")]
	[FieldOffset(Offset = "0xC")]
	private UIUtils.SpriteScaleType m_SpriteFixedType;

	[Token(Token = "0x401127D")]
	[FieldOffset(Offset = "0x10")]
	public bool m_ItemUsePerfect;

	[Token(Token = "0x401127E")]
	[FieldOffset(Offset = "0x14")]
	public UILabel m_ItemNameLabel;

	[Token(Token = "0x401127F")]
	[FieldOffset(Offset = "0x18")]
	public UISprite m_ItemIconSprite;

	[Token(Token = "0x4011280")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite m_ItemBigIconSprite;

	[Token(Token = "0x4011281")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_QuantityLabel;

	[Token(Token = "0x4011282")]
	[FieldOffset(Offset = "0x24")]
	public UILabel m_VoucherLabel;

	[Token(Token = "0x4011283")]
	[FieldOffset(Offset = "0x28")]
	public bool m_QuantityIgnoreOne;

	[Token(Token = "0x4011284")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel m_QuantityLimitLabel;

	[Token(Token = "0x4011285")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget[] m_QualityPerformances;

	[Token(Token = "0x4011286")]
	[FieldOffset(Offset = "0x34")]
	public UISprite m_TreasureBoxSprite;

	[Token(Token = "0x4011287")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_BackpackSprite;

	[Token(Token = "0x4011288")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite m_ParachuteSprite;

	[Token(Token = "0x4011289")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_HeadPicSprite;

	[Token(Token = "0x401128A")]
	[FieldOffset(Offset = "0x44")]
	public UISprite m_CallSignSprite;

	[Token(Token = "0x401128B")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_BundleSprite;

	[Token(Token = "0x401128C")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite m_ClothesSprite;

	[Token(Token = "0x401128D")]
	[FieldOffset(Offset = "0x50")]
	public UISprite m_SurfboardSprite;

	[Token(Token = "0x401128E")]
	[FieldOffset(Offset = "0x54")]
	public UISprite m_GrowthCardSprite;

	[Token(Token = "0x401128F")]
	[FieldOffset(Offset = "0x58")]
	public UISprite m_DebrisSprite;

	[Token(Token = "0x4011290")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite m_VirtualSprite;

	[Token(Token = "0x4011291")]
	[FieldOffset(Offset = "0x60")]
	public UISprite m_WeaponSprite;

	[Token(Token = "0x4011292")]
	[FieldOffset(Offset = "0x64")]
	public UISprite m_SuitWeaponSprite;

	[Token(Token = "0x4011293")]
	[FieldOffset(Offset = "0x68")]
	public UISprite m_VehicleSprite;

	[Token(Token = "0x4011294")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite m_AvatarSprite;

	[Token(Token = "0x4011295")]
	[FieldOffset(Offset = "0x70")]
	public UISprite m_EmoteSprite;

	[Token(Token = "0x4011296")]
	[FieldOffset(Offset = "0x74")]
	public UISprite m_PetAnimSprite;

	[Token(Token = "0x4011297")]
	[FieldOffset(Offset = "0x78")]
	public UISprite m_VoucherSprite;

	[Token(Token = "0x4011298")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite m_RedEnvelopeSprite;

	[Token(Token = "0x4011299")]
	[FieldOffset(Offset = "0x80")]
	public UISprite m_FlightSprite;

	[Token(Token = "0x401129A")]
	[FieldOffset(Offset = "0x84")]
	public GameObject m_FlowLight;

	[Token(Token = "0x401129B")]
	[FieldOffset(Offset = "0x88")]
	public bool m_UseBigIcon;

	[Token(Token = "0x401129C")]
	[FieldOffset(Offset = "0x8C")]
	private UISprite itemSprite;

	[Token(Token = "0x401129D")]
	[FieldOffset(Offset = "0x90")]
	public List<UISprite> m_ShadowSpriteList;

	[Token(Token = "0x6012D1A")]
	[Address(RVA = "0x2E5C5D8", Offset = "0x2E5C5D8", VA = "0x2E5C5D8")]
	public BaseItemView()
	{
	}

	[Token(Token = "0x6012D1B")]
	[Address(RVA = "0x2E5C5EC", Offset = "0x2E5C5EC", VA = "0x2E5C5EC")]
	public void DisableDiscoloration(UISprite spr)
	{
	}

	[Token(Token = "0x6012D1C")]
	[Address(RVA = "0x2E5C7C8", Offset = "0x2E5C7C8", VA = "0x2E5C7C8", Slot = "4")]
	public virtual void SetViewData(BaseItemInfo m_Data)
	{
	}

	[Token(Token = "0x6012D1D")]
	[Address(RVA = "0x2E5F184", Offset = "0x2E5F184", VA = "0x2E5F184")]
	public UISprite GetItemSprite()
	{
		return null;
	}

	[Token(Token = "0x6012D1E")]
	[Address(RVA = "0x2E5F1DC", Offset = "0x2E5F1DC", VA = "0x2E5F1DC")]
	public void SetSpriteSize(int width, int height)
	{
	}

	[Token(Token = "0x6012D1F")]
	[Address(RVA = "0x2E5F324", Offset = "0x2E5F324", VA = "0x2E5F324")]
	public void SetFlowLightEnable(bool b)
	{
	}

	[Token(Token = "0x6012D20")]
	[Address(RVA = "0x2E5EE98", Offset = "0x2E5EE98", VA = "0x2E5EE98")]
	public void AdjustShadowPic(UISprite spr)
	{
	}
}
