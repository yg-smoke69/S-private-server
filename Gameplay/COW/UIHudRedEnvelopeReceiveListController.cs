using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002826")]
internal class UIHudRedEnvelopeReceiveListController : UIPopupWindowController
{
	[Token(Token = "0x400F7C0")]
	[FieldOffset(Offset = "0x48")]
	private UIHudRedEnvelopeReceiveListView m_View;

	[Token(Token = "0x400F7C1")]
	[FieldOffset(Offset = "0x4C")]
	private List<RedEnvelopeAwardItemView> m_ItemViewList;

	[Token(Token = "0x600FA32")]
	[Address(RVA = "0x13DE370", Offset = "0x13DE370", VA = "0x13DE370")]
	public UIHudRedEnvelopeReceiveListController()
	{
	}

	[Token(Token = "0x600FA33")]
	[Address(RVA = "0x13DE3FC", Offset = "0x13DE3FC", VA = "0x13DE3FC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FA34")]
	[Address(RVA = "0x13DE4A4", Offset = "0x13DE4A4", VA = "0x13DE4A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FA35")]
	[Address(RVA = "0x13DE648", Offset = "0x13DE648", VA = "0x13DE648")]
	private int GetSortOrder(RedEnvelopeAwardDisplayInfo award)
	{
		return default(int);
	}

	[Token(Token = "0x600FA36")]
	[Address(RVA = "0x13DDD14", Offset = "0x13DDD14", VA = "0x13DDD14")]
	public void SetReceiveData(List<RedEnvelopeAwardDisplayInfo> itemList, string ownerName)
	{
	}

	[Token(Token = "0x600FA37")]
	[Address(RVA = "0x13DE6E4", Offset = "0x13DE6E4", VA = "0x13DE6E4")]
	private int _003CSetReceiveData_003Em__0(RedEnvelopeAwardDisplayInfo a, RedEnvelopeAwardDisplayInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600FA38")]
	[Address(RVA = "0x13DE77C", Offset = "0x13DE77C", VA = "0x13DE77C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
