using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AC4")]
internal class UIRelationshipFriendInfoItemContoller : UIEasyListItemController
{
	[Token(Token = "0x40106CF")]
	[FieldOffset(Offset = "0x38")]
	private UIBaseProfileInfoController uIBaseProfileInfo;

	[Token(Token = "0x40106D0")]
	[FieldOffset(Offset = "0x3C")]
	private UIRelationshipFriendInfoItemView m_View;

	[Token(Token = "0x40106D1")]
	[FieldOffset(Offset = "0x40")]
	private FriendAccountInfo m_friendInfo;

	[Token(Token = "0x601184E")]
	[Address(RVA = "0x1E48D48", Offset = "0x1E48D48", VA = "0x1E48D48")]
	public UIRelationshipFriendInfoItemContoller()
	{
	}

	[Token(Token = "0x601184F")]
	[Address(RVA = "0x1E48D50", Offset = "0x1E48D50", VA = "0x1E48D50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011850")]
	[Address(RVA = "0x1E48DF4", Offset = "0x1E48DF4", VA = "0x1E48DF4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011851")]
	[Address(RVA = "0x1E48F50", Offset = "0x1E48F50", VA = "0x1E48F50")]
	private void OnChooseItemClick()
	{
	}

	[Token(Token = "0x6011852")]
	[Address(RVA = "0x1E490EC", Offset = "0x1E490EC", VA = "0x1E490EC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011853")]
	[Address(RVA = "0x1E49328", Offset = "0x1E49328", VA = "0x1E49328")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
