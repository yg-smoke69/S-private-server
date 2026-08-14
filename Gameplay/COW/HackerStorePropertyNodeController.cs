using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002119")]
public class HackerStorePropertyNodeController : UIBaseController
{
	[Token(Token = "0x200211A")]
	public class VehicleInfo
	{
		[Token(Token = "0x400CF60")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x400CF61")]
		[FieldOffset(Offset = "0xC")]
		public int Value;

		[Token(Token = "0x600AD50")]
		[Address(RVA = "0x190B034", Offset = "0x190B034", VA = "0x190B034")]
		public VehicleInfo()
		{
		}
	}

	[Token(Token = "0x400CF5A")]
	[FieldOffset(Offset = "0x28")]
	private HackerStorePropertyNodeView m_View;

	[Token(Token = "0x400CF5B")]
	[FieldOffset(Offset = "0x2C")]
	private List<UICollectionScoreItemByHackerStoreController> m_WeaponSkinScoreItemList;

	[Token(Token = "0x400CF5C")]
	[FieldOffset(Offset = "0x30")]
	private List<UICollectionVehicleSkinScoreItemByHackerStoreController> m_VehicleSkinScoreItemList;

	[Token(Token = "0x400CF5D")]
	[FieldOffset(Offset = "0x34")]
	private uint m_Itemid;

	[Token(Token = "0x400CF5E")]
	[FieldOffset(Offset = "0x38")]
	private int m_nFrameCount;

	[Token(Token = "0x400CF5F")]
	[FieldOffset(Offset = "0x3C")]
	private int m_nFrameMaxCount;

	[Token(Token = "0x600AD45")]
	[Address(RVA = "0x190A02C", Offset = "0x190A02C", VA = "0x190A02C")]
	public HackerStorePropertyNodeController()
	{
	}

	[Token(Token = "0x600AD46")]
	[Address(RVA = "0x190A120", Offset = "0x190A120", VA = "0x190A120")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AD47")]
	[Address(RVA = "0x190A1C8", Offset = "0x190A1C8", VA = "0x190A1C8")]
	public void SetVehicleSkinPropertyScore(VehicleSkinPropertyScoreData vehicleData)
	{
	}

	[Token(Token = "0x600AD48")]
	[Address(RVA = "0x190B03C", Offset = "0x190B03C", VA = "0x190B03C")]
	public void SetWeaponProperty(WeaponSkinData data)
	{
	}

	[Token(Token = "0x600AD49")]
	[Address(RVA = "0x190B5B0", Offset = "0x190B5B0", VA = "0x190B5B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AD4A")]
	[Address(RVA = "0x190BA60", Offset = "0x190BA60", VA = "0x190BA60")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600AD4B")]
	[Address(RVA = "0x190BAFC", Offset = "0x190BAFC", VA = "0x190BAFC")]
	private void Update()
	{
	}

	[Token(Token = "0x600AD4C")]
	[Address(RVA = "0x190BBA8", Offset = "0x190BBA8", VA = "0x190BBA8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600AD4D")]
	[Address(RVA = "0x190B708", Offset = "0x190B708", VA = "0x190B708")]
	private void LoadWeaponScoreItemRenderers()
	{
	}

	[Token(Token = "0x600AD4E")]
	[Address(RVA = "0x190BC04", Offset = "0x190BC04", VA = "0x190BC04")]
	private void OnWeaponskillbtnClick()
	{
	}

	[Token(Token = "0x600AD4F")]
	[Address(RVA = "0x190BF34", Offset = "0x190BF34", VA = "0x190BF34")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
