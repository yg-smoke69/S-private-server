using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002904")]
public class UILegendClothVaultFeatureItemController : UIBaseController
{
	[Token(Token = "0x400FC98")]
	[FieldOffset(Offset = "0x28")]
	private UILegendClothVaultFeatureItemView m_View;

	[Token(Token = "0x400FC99")]
	[FieldOffset(Offset = "0x2C")]
	private LegendClothVaultFeature m_FeatureType;

	[Token(Token = "0x400FC9A")]
	[FieldOffset(Offset = "0x30")]
	private object m_Data;

	[Token(Token = "0x400FC9B")]
	[FieldOffset(Offset = "0x34")]
	private uint m_LegendId;

	[Token(Token = "0x60103EE")]
	[Address(RVA = "0x253CE84", Offset = "0x253CE84", VA = "0x253CE84")]
	public UILegendClothVaultFeatureItemController()
	{
	}

	[Token(Token = "0x60103EF")]
	[Address(RVA = "0x253CF08", Offset = "0x253CF08", VA = "0x253CF08")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60103F0")]
	[Address(RVA = "0x253CFAC", Offset = "0x253CFAC", VA = "0x253CFAC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60103F1")]
	[Address(RVA = "0x253D1F4", Offset = "0x253D1F4", VA = "0x253D1F4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60103F2")]
	[Address(RVA = "0x253D328", Offset = "0x253D328", VA = "0x253D328")]
	public void SetData(LegendClothVaultFeature featureType, ResourceID resId, object data, uint legendId)
	{
	}

	[Token(Token = "0x60103F3")]
	[Address(RVA = "0x253E5AC", Offset = "0x253E5AC", VA = "0x253E5AC")]
	private void OnBtnFeatureClick()
	{
	}

	[Token(Token = "0x60103F4")]
	[Address(RVA = "0x253EA10", Offset = "0x253EA10", VA = "0x253EA10")]
	private void OnFeatureShow(object[] data)
	{
	}

	[Token(Token = "0x60103F5")]
	[Address(RVA = "0x253EB44", Offset = "0x253EB44", VA = "0x253EB44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60103F6")]
	[Address(RVA = "0x253EB4C", Offset = "0x253EB4C", VA = "0x253EB4C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
