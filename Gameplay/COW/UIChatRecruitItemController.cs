using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002512")]
public class UIChatRecruitItemController : UIEasyListItemController
{
	[Token(Token = "0x400E603")]
	[FieldOffset(Offset = "0x38")]
	private UIChatRecruitItemView m_View;

	[Token(Token = "0x400E604")]
	[FieldOffset(Offset = "0x3C")]
	private MessageInfo m_InfoData;

	[Token(Token = "0x400E605")]
	[FieldOffset(Offset = "0x40")]
	private FastGroupInvite m_GroupRecruit;

	[Token(Token = "0x400E606")]
	private const string LADDER_BG = "SG_UI_chatbg_01";

	[Token(Token = "0x400E607")]
	private const string NORMAL_BG = "SG_UI_chatbg_02";

	[Token(Token = "0x400E608")]
	private const string CLANWARRECRUIT_BG = "SG_UI_chatbg_02";

	[Token(Token = "0x400E609")]
	[FieldOffset(Offset = "0x44")]
	private UIBaseProfileInfoController m_BaseProfileCtrl;

	[Token(Token = "0x600D72F")]
	[Address(RVA = "0x20763EC", Offset = "0x20763EC", VA = "0x20763EC")]
	public UIChatRecruitItemController()
	{
	}

	[Token(Token = "0x600D730")]
	[Address(RVA = "0x20763F4", Offset = "0x20763F4", VA = "0x20763F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D731")]
	[Address(RVA = "0x2076688", Offset = "0x2076688", VA = "0x2076688")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D732")]
	[Address(RVA = "0x207672C", Offset = "0x207672C", VA = "0x207672C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D733")]
	[Address(RVA = "0x2077C98", Offset = "0x2077C98", VA = "0x2077C98")]
	private void OnProfileClick()
	{
	}

	[Token(Token = "0x600D734")]
	[Address(RVA = "0x20780F0", Offset = "0x20780F0", VA = "0x20780F0", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D735")]
	[Address(RVA = "0x207826C", Offset = "0x207826C", VA = "0x207826C")]
	private bool _003COnProfileClick_003Em__0(ClanMember temp)
	{
		return default(bool);
	}

	[Token(Token = "0x600D736")]
	[Address(RVA = "0x20782D4", Offset = "0x20782D4", VA = "0x20782D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D737")]
	[Address(RVA = "0x20782DC", Offset = "0x20782DC", VA = "0x20782DC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
