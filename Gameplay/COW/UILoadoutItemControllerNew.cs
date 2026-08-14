using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002914")]
internal class UILoadoutItemControllerNew : UILoadoutItemController
{
	[Token(Token = "0x400FCFB")]
	[FieldOffset(Offset = "0x54")]
	private UILoadOutItemNewView m_View;

	[Token(Token = "0x60104B0")]
	[Address(RVA = "0x2162634", Offset = "0x2162634", VA = "0x2162634")]
	public UILoadoutItemControllerNew()
	{
	}

	[Token(Token = "0x60104B1")]
	[Address(RVA = "0x2162638", Offset = "0x2162638", VA = "0x2162638")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60104B2")]
	[Address(RVA = "0x21626DC", Offset = "0x21626DC", VA = "0x21626DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60104B3")]
	[Address(RVA = "0x2162A28", Offset = "0x2162A28", VA = "0x2162A28", Slot = "31")]
	public override UIWidget GetWidget()
	{
		return null;
	}

	[Token(Token = "0x60104B4")]
	[Address(RVA = "0x2162A98", Offset = "0x2162A98", VA = "0x2162A98")]
	private void OnInfoBtnClicked()
	{
	}

	[Token(Token = "0x60104B5")]
	[Address(RVA = "0x2162D88", Offset = "0x2162D88", VA = "0x2162D88")]
	private void ToggleInfoText()
	{
	}

	[Token(Token = "0x60104B6")]
	[Address(RVA = "0x2162FC4", Offset = "0x2162FC4", VA = "0x2162FC4")]
	private void OnBtnClicked()
	{
	}

	[Token(Token = "0x60104B7")]
	[Address(RVA = "0x21639C4", Offset = "0x21639C4", VA = "0x21639C4")]
	private void OnIncreaseClicked()
	{
	}

	[Token(Token = "0x60104B8")]
	[Address(RVA = "0x2163BE4", Offset = "0x2163BE4", VA = "0x2163BE4")]
	private void OnDecreaseClicked()
	{
	}

	[Token(Token = "0x60104B9")]
	[Address(RVA = "0x2163AA4", Offset = "0x2163AA4", VA = "0x2163AA4")]
	private void RefreshBuyInfo()
	{
	}

	[Token(Token = "0x60104BA")]
	[Address(RVA = "0x2163CC4", Offset = "0x2163CC4", VA = "0x2163CC4")]
	private void OnBuyClick()
	{
	}

	[Token(Token = "0x60104BB")]
	[Address(RVA = "0x2163E2C", Offset = "0x2163E2C", VA = "0x2163E2C")]
	private bool IsItemShow(Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x60104BC")]
	[Address(RVA = "0x2164130", Offset = "0x2164130", VA = "0x2164130")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60104BD")]
	[Address(RVA = "0x2164134", Offset = "0x2164134", VA = "0x2164134")]
	public UIWidget _003C_003EiFixBaseProxy_GetWidget()
	{
		return null;
	}
}
