using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002ADF")]
public class UIRoomCardListController : UIBaseController
{
	[Token(Token = "0x4010752")]
	[FieldOffset(Offset = "0x28")]
	private UIRoomCardListView m_View;

	[Token(Token = "0x4010753")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, UIRoomCardView> m_CardViewDic;

	[Token(Token = "0x4010754")]
	private const string GUIDE_KEY = "KEY_CUSTOMROOM_ADCS_CARD";

	[Token(Token = "0x601194A")]
	[Address(RVA = "0x23B8038", Offset = "0x23B8038", VA = "0x23B8038")]
	public UIRoomCardListController()
	{
	}

	[Token(Token = "0x601194B")]
	[Address(RVA = "0x23B80F0", Offset = "0x23B80F0", VA = "0x23B80F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601194C")]
	[Address(RVA = "0x23B8194", Offset = "0x23B8194", VA = "0x23B8194", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601194D")]
	[Address(RVA = "0x23B8300", Offset = "0x23B8300", VA = "0x23B8300")]
	public void RefreshCard(object[] data)
	{
	}

	[Token(Token = "0x601194E")]
	[Address(RVA = "0x23B9418", Offset = "0x23B9418", VA = "0x23B9418")]
	public UIRoomCardView GetCardViewByType(EInventory.ItemSubType type)
	{
		return null;
	}

	[Token(Token = "0x601194F")]
	[Address(RVA = "0x23B94FC", Offset = "0x23B94FC", VA = "0x23B94FC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
