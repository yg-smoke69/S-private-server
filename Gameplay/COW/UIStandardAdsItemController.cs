using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023B3")]
internal class UIStandardAdsItemController : UIBaseController
{
	[Token(Token = "0x400DE47")]
	[FieldOffset(Offset = "0x28")]
	private UIStandardAdsItemView m_View;

	[Token(Token = "0x400DE48")]
	[FieldOffset(Offset = "0x2C")]
	public int AdIndex;

	[Token(Token = "0x600C8D5")]
	[Address(RVA = "0x2061F40", Offset = "0x2061F40", VA = "0x2061F40")]
	public UIStandardAdsItemController()
	{
	}

	[Token(Token = "0x600C8D6")]
	[Address(RVA = "0x2061FC4", Offset = "0x2061FC4", VA = "0x2061FC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C8D7")]
	[Address(RVA = "0x2062068", Offset = "0x2062068", VA = "0x2062068", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C8D8")]
	[Address(RVA = "0x2061180", Offset = "0x2061180", VA = "0x2061180")]
	public void RefreshUIData(UIModelLobbyAds.AdInfo info)
	{
	}

	[Token(Token = "0x600C8D9")]
	[Address(RVA = "0x206217C", Offset = "0x206217C", VA = "0x206217C")]
	public void SetTextureSize(float width, float height)
	{
	}

	[Token(Token = "0x600C8DA")]
	[Address(RVA = "0x206232C", Offset = "0x206232C", VA = "0x206232C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
