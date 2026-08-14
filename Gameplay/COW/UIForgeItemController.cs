using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002618")]
public class UIForgeItemController : UIEasyListItemController
{
	[Token(Token = "0x400EB2B")]
	[FieldOffset(Offset = "0x38")]
	private ChestSpecialExchangeDesc m_Info;

	[Token(Token = "0x400EB2C")]
	[FieldOffset(Offset = "0x3C")]
	private UIForgeItemView m_View;

	[Token(Token = "0x400EB2D")]
	[FieldOffset(Offset = "0x40")]
	private CSSharedItemData m_ItemData;

	[Token(Token = "0x400EB2E")]
	[FieldOffset(Offset = "0x44")]
	private uint m_Id;

	[Token(Token = "0x400EB2F")]
	[FieldOffset(Offset = "0x48")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400EB30")]
	[FieldOffset(Offset = "0x4C")]
	private ShowBoostAvatarParams m_ShowBoostAvatarParams;

	[Token(Token = "0x400EB31")]
	[FieldOffset(Offset = "0x50")]
	private List<UISprite> m_Materials;

	[Token(Token = "0x400EB32")]
	[FieldOffset(Offset = "0x54")]
	private List<UILabel> m_MaterialsCnt;

	[Token(Token = "0x400EB33")]
	[FieldOffset(Offset = "0x58")]
	private bool m_ShowAvatar;

	[Token(Token = "0x400EB34")]
	[FieldOffset(Offset = "0x5C")]
	private int PriceBGExtraWidth;

	[Token(Token = "0x400EB35")]
	[FieldOffset(Offset = "0x60")]
	private int PriceBGMinWidth;

	[Token(Token = "0x400EB36")]
	[FieldOffset(Offset = "0x64")]
	private UIForgeController m_ForgeController;

	[Token(Token = "0x600E19F")]
	[Address(RVA = "0x1B677AC", Offset = "0x1B677AC", VA = "0x1B677AC")]
	public UIForgeItemController()
	{
	}

	[Token(Token = "0x600E1A0")]
	[Address(RVA = "0x1B6787C", Offset = "0x1B6787C", VA = "0x1B6787C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E1A1")]
	[Address(RVA = "0x1B67924", Offset = "0x1B67924", VA = "0x1B67924", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E1A2")]
	[Address(RVA = "0x1B67CAC", Offset = "0x1B67CAC", VA = "0x1B67CAC", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E1A3")]
	[Address(RVA = "0x1B68028", Offset = "0x1B68028", VA = "0x1B68028", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600E1A4")]
	[Address(RVA = "0x1B680C4", Offset = "0x1B680C4", VA = "0x1B680C4")]
	private void HideGameObject()
	{
	}

	[Token(Token = "0x600E1A5")]
	[Address(RVA = "0x1B68484", Offset = "0x1B68484", VA = "0x1B68484", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E1A6")]
	[Address(RVA = "0x1B687B8", Offset = "0x1B687B8", VA = "0x1B687B8")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600E1A7")]
	[Address(RVA = "0x1B68844", Offset = "0x1B68844", VA = "0x1B68844")]
	private void RefreshCDNImage()
	{
	}

	[Token(Token = "0x600E1A8")]
	[Address(RVA = "0x1B68B6C", Offset = "0x1B68B6C", VA = "0x1B68B6C")]
	private void RefreshVFX()
	{
	}

	[Token(Token = "0x600E1A9")]
	[Address(RVA = "0x1B68EB4", Offset = "0x1B68EB4", VA = "0x1B68EB4")]
	private void RefreshOwnedTitle()
	{
	}

	[Token(Token = "0x600E1AA")]
	[Address(RVA = "0x1B68FCC", Offset = "0x1B68FCC", VA = "0x1B68FCC")]
	private void RefreshPriceContainer()
	{
	}

	[Token(Token = "0x600E1AB")]
	[Address(RVA = "0x1B6997C", Offset = "0x1B6997C", VA = "0x1B6997C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600E1AC")]
	[Address(RVA = "0x1B697C4", Offset = "0x1B697C4", VA = "0x1B697C4")]
	private void RefreshPriceTable()
	{
	}

	[Token(Token = "0x600E1AD")]
	[Address(RVA = "0x1B69544", Offset = "0x1B69544", VA = "0x1B69544")]
	private void RefreshBigAwardIcon()
	{
	}

	[Token(Token = "0x600E1AE")]
	[Address(RVA = "0x1B67AF8", Offset = "0x1B67AF8", VA = "0x1B67AF8")]
	private void InitMaterial()
	{
	}

	[Token(Token = "0x600E1AF")]
	[Address(RVA = "0x1B68698", Offset = "0x1B68698", VA = "0x1B68698")]
	private void InitItemData(uint itemID, uint id)
	{
	}

	[Token(Token = "0x600E1B0")]
	[Address(RVA = "0x1B699DC", Offset = "0x1B699DC", VA = "0x1B699DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E1B1")]
	[Address(RVA = "0x1B699E4", Offset = "0x1B699E4", VA = "0x1B699E4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E1B2")]
	[Address(RVA = "0x1B699EC", Offset = "0x1B699EC", VA = "0x1B699EC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
