using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002A50")]
public class UIPetFeedController : UIPopupWindowController
{
	[Token(Token = "0x401040C")]
	[FieldOffset(Offset = "0x48")]
	protected CSSharedItemData m_ItemData;

	[Token(Token = "0x401040D")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_pet_food_id;

	[Token(Token = "0x401040E")]
	[FieldOffset(Offset = "0x50")]
	private uint m_pet_id;

	[Token(Token = "0x401040F")]
	[FieldOffset(Offset = "0x54")]
	private UIFeedPetView m_View;

	[Token(Token = "0x4010410")]
	[FieldOffset(Offset = "0x58")]
	protected EInventory.CurrencyType m_CurrencyType;

	[Token(Token = "0x4010411")]
	[FieldOffset(Offset = "0x5C")]
	protected uint m_Price;

	[Token(Token = "0x4010412")]
	[FieldOffset(Offset = "0x0")]
	protected static Color GemBgColor;

	[Token(Token = "0x4010413")]
	[FieldOffset(Offset = "0x10")]
	protected static Color GemTextColor;

	[Token(Token = "0x4010414")]
	[FieldOffset(Offset = "0x20")]
	protected static Color CoinBgColor;

	[Token(Token = "0x4010415")]
	[FieldOffset(Offset = "0x30")]
	protected static Color CoinTextColor;

	[Token(Token = "0x4010416")]
	private const uint OUTLINE_BLUE = 192872447u;

	[Token(Token = "0x4010417")]
	[FieldOffset(Offset = "0x60")]
	protected int m_Count;

	[Token(Token = "0x4010418")]
	[FieldOffset(Offset = "0x64")]
	protected int m_MaxCount;

	[Token(Token = "0x4010419")]
	[FieldOffset(Offset = "0x68")]
	protected int m_TotalFeed_Num;

	[Token(Token = "0x170012C2")]
	protected virtual int ItemCount
	{
		[Token(Token = "0x60112F1")]
		[Address(RVA = "0x23F3B98", Offset = "0x23F3B98", VA = "0x23F3B98", Slot = "46")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60112F2")]
		[Address(RVA = "0x23F3BF0", Offset = "0x23F3BF0", VA = "0x23F3BF0", Slot = "47")]
		set
		{
		}
	}

	[Token(Token = "0x60112F0")]
	[Address(RVA = "0x23F3B80", Offset = "0x23F3B80", VA = "0x23F3B80")]
	public UIPetFeedController()
	{
	}

	[Token(Token = "0x60112F3")]
	[Address(RVA = "0x23F3CB0", Offset = "0x23F3CB0", VA = "0x23F3CB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60112F4")]
	[Address(RVA = "0x23F3D58", Offset = "0x23F3D58", VA = "0x23F3D58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60112F5")]
	[Address(RVA = "0x23F419C", Offset = "0x23F419C", VA = "0x23F419C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60112F6")]
	[Address(RVA = "0x23F4200", Offset = "0x23F4200", VA = "0x23F4200")]
	private void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x60112F7")]
	[Address(RVA = "0x23F4368", Offset = "0x23F4368", VA = "0x23F4368")]
	protected void OnPlusBtnClick()
	{
	}

	[Token(Token = "0x60112F8")]
	[Address(RVA = "0x23F45B8", Offset = "0x23F45B8", VA = "0x23F45B8")]
	protected void OnMinsBtnClick()
	{
	}

	[Token(Token = "0x60112F9")]
	[Address(RVA = "0x23F4658", Offset = "0x23F4658", VA = "0x23F4658")]
	protected void OnMaxBtnClick()
	{
	}

	[Token(Token = "0x60112FA")]
	[Address(RVA = "0x23F46C8", Offset = "0x23F46C8", VA = "0x23F46C8")]
	protected void OnCancelClick()
	{
	}

	[Token(Token = "0x60112FB")]
	[Address(RVA = "0x23F472C", Offset = "0x23F472C", VA = "0x23F472C")]
	public void SetUIData(uint pet_feed_id, uint pet_id, uint max_count)
	{
	}

	[Token(Token = "0x60112FC")]
	[Address(RVA = "0x23F4B3C", Offset = "0x23F4B3C", VA = "0x23F4B3C")]
	protected void SetMaxPurchaseCount(uint limited_purchase_times, uint purchase_times)
	{
	}

	[Token(Token = "0x60112FD")]
	[Address(RVA = "0x23F40D4", Offset = "0x23F40D4", VA = "0x23F40D4")]
	private void ShowModifyCountContainer()
	{
	}

	[Token(Token = "0x60112FF")]
	[Address(RVA = "0x23F4DD0", Offset = "0x23F4DD0", VA = "0x23F4DD0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011300")]
	[Address(RVA = "0x23F4DD8", Offset = "0x23F4DD8", VA = "0x23F4DD8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
