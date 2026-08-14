using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002611")]
public class UIFastSendGiftFriendItemController : UIEasyListItemController
{
	[Token(Token = "0x400EB00")]
	[FieldOffset(Offset = "0x38")]
	private UIFastSendGiftFriendItemView m_View;

	[Token(Token = "0x400EB01")]
	[FieldOffset(Offset = "0x3C")]
	private FriendInfo m_Info;

	[Token(Token = "0x600E139")]
	[Address(RVA = "0x1DB8E60", Offset = "0x1DB8E60", VA = "0x1DB8E60")]
	public UIFastSendGiftFriendItemController()
	{
	}

	[Token(Token = "0x600E13A")]
	[Address(RVA = "0x1DB8E68", Offset = "0x1DB8E68", VA = "0x1DB8E68")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E13B")]
	[Address(RVA = "0x1DB8F10", Offset = "0x1DB8F10", VA = "0x1DB8F10", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E13C")]
	[Address(RVA = "0x1DB9064", Offset = "0x1DB9064", VA = "0x1DB9064", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E13D")]
	[Address(RVA = "0x1DB91B0", Offset = "0x1DB91B0", VA = "0x1DB91B0")]
	private void RefreshData(FriendInfo data)
	{
	}

	[Token(Token = "0x600E13E")]
	[Address(RVA = "0x1DB9A2C", Offset = "0x1DB9A2C", VA = "0x1DB9A2C", Slot = "32")]
	public override void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600E13F")]
	[Address(RVA = "0x1DB9884", Offset = "0x1DB9884", VA = "0x1DB9884")]
	public void UpdateBanner(uint bannerId)
	{
	}

	[Token(Token = "0x600E140")]
	[Address(RVA = "0x1DB9CFC", Offset = "0x1DB9CFC", VA = "0x1DB9CFC")]
	public void UpdateBanner(BannerData bannerData)
	{
	}

	[Token(Token = "0x600E141")]
	[Address(RVA = "0x1DB96DC", Offset = "0x1DB96DC", VA = "0x1DB96DC")]
	public void UpdateHeadPic(uint iid)
	{
	}

	[Token(Token = "0x600E142")]
	[Address(RVA = "0x1DB9F7C", Offset = "0x1DB9F7C", VA = "0x1DB9F7C")]
	public void UpdateHeadPic(HeadPicData data)
	{
	}

	[Token(Token = "0x600E143")]
	[Address(RVA = "0x1DBA100", Offset = "0x1DBA100", VA = "0x1DBA100")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E144")]
	[Address(RVA = "0x1DBA108", Offset = "0x1DBA108", VA = "0x1DBA108")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
