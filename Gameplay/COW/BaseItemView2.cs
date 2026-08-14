using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D05")]
public class BaseItemView2 : MonoBehaviour
{
	[Token(Token = "0x401129E")]
	[FieldOffset(Offset = "0xC")]
	public bool m_IsItemMini;

	[Token(Token = "0x401129F")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_ItemNameLabel;

	[Token(Token = "0x40112A0")]
	[FieldOffset(Offset = "0x14")]
	public UISprite m_ItemIconSprite;

	[Token(Token = "0x40112A1")]
	[FieldOffset(Offset = "0x18")]
	public UILabel m_QuantityLabel;

	[Token(Token = "0x40112A2")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel m_VoucherLabel;

	[Token(Token = "0x40112A3")]
	[FieldOffset(Offset = "0x20")]
	public bool m_QuantityIgnoreOne;

	[Token(Token = "0x40112A4")]
	[FieldOffset(Offset = "0x24")]
	public UILabel m_QuantityLimitLabel;

	[Token(Token = "0x40112A5")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget[] m_QualityPerformances;

	[Token(Token = "0x40112A6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject m_FlowLight;

	[Token(Token = "0x40112A7")]
	[FieldOffset(Offset = "0x30")]
	public List<UISprite> m_ShadowSpriteList;

	[Token(Token = "0x40112A8")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 m_DefaultSize;

	[Token(Token = "0x40112A9")]
	[FieldOffset(Offset = "0x3C")]
	private BaseItemInfo m_Data;

	[Token(Token = "0x40112AA")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_SpecificWeaponRotation;

	[Token(Token = "0x40112AB")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 m_SpecificWeaponSize;

	[Token(Token = "0x40112AC")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_SpecificWeaponPosition;

	[Token(Token = "0x17001353")]
	public BaseItemInfo Data
	{
		[Token(Token = "0x6012D22")]
		[Address(RVA = "0x2E5F554", Offset = "0x2E5F554", VA = "0x2E5F554")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6012D21")]
	[Address(RVA = "0x2E5F44C", Offset = "0x2E5F44C", VA = "0x2E5F44C")]
	public BaseItemView2()
	{
	}

	[Token(Token = "0x6012D23")]
	[Address(RVA = "0x2E5F5AC", Offset = "0x2E5F5AC", VA = "0x2E5F5AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012D24")]
	[Address(RVA = "0x2E5F648", Offset = "0x2E5F648", VA = "0x2E5F648")]
	public void SetSpecificWeaponRotation(float x, float y, float z)
	{
	}

	[Token(Token = "0x6012D25")]
	[Address(RVA = "0x2E5F6E4", Offset = "0x2E5F6E4", VA = "0x2E5F6E4")]
	public void SetSpecificWeaponSize(int width, int height)
	{
	}

	[Token(Token = "0x6012D26")]
	[Address(RVA = "0x2E5F774", Offset = "0x2E5F774", VA = "0x2E5F774")]
	public void SetSpecificWeaponPosition(float x, float y, float z)
	{
	}

	[Token(Token = "0x6012D27")]
	[Address(RVA = "0x2E5F810", Offset = "0x2E5F810", VA = "0x2E5F810")]
	public void RefreshViewData()
	{
	}

	[Token(Token = "0x6012D28")]
	[Address(RVA = "0x2E5F888", Offset = "0x2E5F888", VA = "0x2E5F888")]
	public void DisableDiscoloration()
	{
	}

	[Token(Token = "0x6012D29")]
	[Address(RVA = "0x2E5FA64", Offset = "0x2E5FA64", VA = "0x2E5FA64")]
	public bool SetDiscolorationParent(Transform parent)
	{
		return default(bool);
	}

	[Token(Token = "0x6012D2A")]
	[Address(RVA = "0x2E5FC5C", Offset = "0x2E5FC5C", VA = "0x2E5FC5C", Slot = "4")]
	public virtual void SetViewData(BaseItemInfo data)
	{
	}

	[Token(Token = "0x6012D2B")]
	[Address(RVA = "0x2E61B94", Offset = "0x2E61B94", VA = "0x2E61B94")]
	public UISprite GetItemSprite()
	{
		return null;
	}

	[Token(Token = "0x6012D2C")]
	[Address(RVA = "0x2E61BEC", Offset = "0x2E61BEC", VA = "0x2E61BEC")]
	public void SetSpriteSize(int width, int height)
	{
	}

	[Token(Token = "0x6012D2D")]
	[Address(RVA = "0x2E61D34", Offset = "0x2E61D34", VA = "0x2E61D34")]
	public void SetFlowLightEnable(bool b)
	{
	}

	[Token(Token = "0x6012D2E")]
	[Address(RVA = "0x2E618A8", Offset = "0x2E618A8", VA = "0x2E618A8")]
	public void AdjustShadowPic(UISprite spr)
	{
	}

	[Token(Token = "0x6012D2F")]
	[Address(RVA = "0x2E61020", Offset = "0x2E61020", VA = "0x2E61020")]
	public void SetSpriteSize(CSSharedItemData itemData)
	{
	}
}
