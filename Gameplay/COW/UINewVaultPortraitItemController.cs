using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A06")]
public class UINewVaultPortraitItemController : UIEasyListItemController
{
	[Token(Token = "0x40102A7")]
	[FieldOffset(Offset = "0x38")]
	private UINewVaultPortraitItemView m_View;

	[Token(Token = "0x40102A8")]
	[FieldOffset(Offset = "0x3C")]
	private UINewVaultItemViewData m_data;

	[Token(Token = "0x6010FB1")]
	[Address(RVA = "0x26CABB8", Offset = "0x26CABB8", VA = "0x26CABB8")]
	public UINewVaultPortraitItemController()
	{
	}

	[Token(Token = "0x6010FB2")]
	[Address(RVA = "0x26CABC0", Offset = "0x26CABC0", VA = "0x26CABC0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010FB3")]
	[Address(RVA = "0x26CAC68", Offset = "0x26CAC68", VA = "0x26CAC68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010FB4")]
	[Address(RVA = "0x26CAE60", Offset = "0x26CAE60", VA = "0x26CAE60", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010FB5")]
	[Address(RVA = "0x26CAFBC", Offset = "0x26CAFBC", VA = "0x26CAFBC", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6010FB6")]
	[Address(RVA = "0x26CB058", Offset = "0x26CB058", VA = "0x26CB058", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6010FB7")]
	[Address(RVA = "0x26CBAA8", Offset = "0x26CBAA8", VA = "0x26CBAA8")]
	public void RefreshABReady()
	{
	}

	[Token(Token = "0x6010FB8")]
	[Address(RVA = "0x26CB6B8", Offset = "0x26CB6B8", VA = "0x26CB6B8")]
	private void SetRankingItemIcon()
	{
	}

	[Token(Token = "0x6010FB9")]
	[Address(RVA = "0x26CB9F8", Offset = "0x26CB9F8", VA = "0x26CB9F8")]
	public void RefreshEquipState()
	{
	}

	[Token(Token = "0x6010FBA")]
	[Address(RVA = "0x26CBC08", Offset = "0x26CBC08", VA = "0x26CBC08")]
	public void RefreshNewGetState()
	{
	}

	[Token(Token = "0x6010FBB")]
	[Address(RVA = "0x26CBD80", Offset = "0x26CBD80", VA = "0x26CBD80")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010FBC")]
	[Address(RVA = "0x26CBD88", Offset = "0x26CBD88", VA = "0x26CBD88")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010FBD")]
	[Address(RVA = "0x26CBD90", Offset = "0x26CBD90", VA = "0x26CBD90")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
