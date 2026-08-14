using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200252F")]
public class UIClanBannerItemController : UIEasyListItemController
{
	[Token(Token = "0x400E678")]
	[FieldOffset(Offset = "0x38")]
	private UIClanBannerItemView m_View;

	[Token(Token = "0x400E679")]
	[FieldOffset(Offset = "0x3C")]
	private BannerBaseInfo m_ClanBannerInfo;

	[Token(Token = "0x600D849")]
	[Address(RVA = "0x2F23574", Offset = "0x2F23574", VA = "0x2F23574")]
	public UIClanBannerItemController()
	{
	}

	[Token(Token = "0x600D84A")]
	[Address(RVA = "0x2F2357C", Offset = "0x2F2357C", VA = "0x2F2357C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D84B")]
	[Address(RVA = "0x2F23624", Offset = "0x2F23624", VA = "0x2F23624", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D84C")]
	[Address(RVA = "0x2F23780", Offset = "0x2F23780", VA = "0x2F23780", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D84D")]
	[Address(RVA = "0x2F23AFC", Offset = "0x2F23AFC", VA = "0x2F23AFC")]
	private void SelectBanner()
	{
	}

	[Token(Token = "0x600D84E")]
	[Address(RVA = "0x2F23C78", Offset = "0x2F23C78", VA = "0x2F23C78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
