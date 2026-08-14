using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20021EA")]
public class UIMallGiftFriendItemController : UIEasyListItemController
{
	[Token(Token = "0x400D43C")]
	[FieldOffset(Offset = "0x38")]
	private UIMallGiftFriendItemView m_View;

	[Token(Token = "0x400D43D")]
	[FieldOffset(Offset = "0x3C")]
	private FriendInfo m_Info;

	[Token(Token = "0x600B663")]
	[Address(RVA = "0x225A9DC", Offset = "0x225A9DC", VA = "0x225A9DC")]
	public UIMallGiftFriendItemController()
	{
	}

	[Token(Token = "0x600B664")]
	[Address(RVA = "0x225A9E4", Offset = "0x225A9E4", VA = "0x225A9E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B665")]
	[Address(RVA = "0x225AA88", Offset = "0x225AA88", VA = "0x225AA88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B666")]
	[Address(RVA = "0x225ABDC", Offset = "0x225ABDC", VA = "0x225ABDC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B667")]
	[Address(RVA = "0x225AD28", Offset = "0x225AD28", VA = "0x225AD28")]
	private void RefreshData(FriendInfo data)
	{
	}

	[Token(Token = "0x600B668")]
	[Address(RVA = "0x225B7A0", Offset = "0x225B7A0", VA = "0x225B7A0", Slot = "32")]
	public override void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600B669")]
	[Address(RVA = "0x225B5F8", Offset = "0x225B5F8", VA = "0x225B5F8")]
	public void UpdateBanner(uint bannerId)
	{
	}

	[Token(Token = "0x600B66A")]
	[Address(RVA = "0x225BA70", Offset = "0x225BA70", VA = "0x225BA70")]
	public void UpdateBanner(BannerData bannerData)
	{
	}

	[Token(Token = "0x600B66B")]
	[Address(RVA = "0x225B450", Offset = "0x225B450", VA = "0x225B450")]
	public void UpdateHeadPic(uint iid)
	{
	}

	[Token(Token = "0x600B66C")]
	[Address(RVA = "0x225BCF0", Offset = "0x225BCF0", VA = "0x225BCF0")]
	public void UpdateHeadPic(HeadPicData data)
	{
	}

	[Token(Token = "0x600B66D")]
	[Address(RVA = "0x225BE74", Offset = "0x225BE74", VA = "0x225BE74")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B66E")]
	[Address(RVA = "0x225BE7C", Offset = "0x225BE7C", VA = "0x225BE7C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
