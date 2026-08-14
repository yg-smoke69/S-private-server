using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002619")]
public class UIForgePurchaseController : UIMallPurchaseBaseController
{
	[Token(Token = "0x400EB37")]
	[FieldOffset(Offset = "0x70")]
	private ChestSpecialExchangeDesc m_ExchangeDesc;

	[Token(Token = "0x400EB38")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<int, UISprite> m_ExchangeMaterial;

	[Token(Token = "0x400EB39")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<int, UILabel> m_ExchangeMaterialCount;

	[Token(Token = "0x600E1B3")]
	[Address(RVA = "0x1B6A11C", Offset = "0x1B6A11C", VA = "0x1B6A11C")]
	public UIForgePurchaseController()
	{
	}

	[Token(Token = "0x600E1B4")]
	[Address(RVA = "0x1B6A124", Offset = "0x1B6A124", VA = "0x1B6A124")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E1B5")]
	[Address(RVA = "0x1B6A1C8", Offset = "0x1B6A1C8", VA = "0x1B6A1C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E1B6")]
	[Address(RVA = "0x1B6A5A0", Offset = "0x1B6A5A0", VA = "0x1B6A5A0")]
	private void OnExchangeBtnClick()
	{
	}

	[Token(Token = "0x600E1B7")]
	[Address(RVA = "0x1B6A384", Offset = "0x1B6A384", VA = "0x1B6A384")]
	private void InitMaterialDict()
	{
	}

	[Token(Token = "0x600E1B8")]
	[Address(RVA = "0x1B62870", Offset = "0x1B62870", VA = "0x1B62870")]
	public void RefreshData(ChestSpecialExchangeDesc exchangeDesc)
	{
	}

	[Token(Token = "0x600E1B9")]
	[Address(RVA = "0x1B6A6D8", Offset = "0x1B6A6D8", VA = "0x1B6A6D8")]
	protected void SetExchangeIcon(UISprite sprite, uint itemID)
	{
	}

	[Token(Token = "0x600E1BA")]
	[Address(RVA = "0x1B6A844", Offset = "0x1B6A844", VA = "0x1B6A844")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
