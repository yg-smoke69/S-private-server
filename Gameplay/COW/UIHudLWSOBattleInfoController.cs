using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200219D")]
public class UIHudLWSOBattleInfoController : UIBaseController
{
	[Token(Token = "0x400D29A")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLWSOBattleInfoView m_View;

	[Token(Token = "0x400D29B")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400D29C")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsOpen;

	[Token(Token = "0x400D29D")]
	[FieldOffset(Offset = "0x34")]
	private List<UIHudLWSOBattleInfoItemController> m_ItemCtrlList;

	[Token(Token = "0x400D29E")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, List<NBJFOKDNNBK>> m_VSTeamInfoDict;

	[Token(Token = "0x600B294")]
	[Address(RVA = "0x1BBDFB4", Offset = "0x1BBDFB4", VA = "0x1BBDFB4")]
	public UIHudLWSOBattleInfoController()
	{
	}

	[Token(Token = "0x600B295")]
	[Address(RVA = "0x1BBE0A8", Offset = "0x1BBE0A8", VA = "0x1BBE0A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B296")]
	[Address(RVA = "0x1BBE150", Offset = "0x1BBE150", VA = "0x1BBE150", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B297")]
	[Address(RVA = "0x1BBE3E4", Offset = "0x1BBE3E4", VA = "0x1BBE3E4")]
	public void RefreshInfo()
	{
	}

	[Token(Token = "0x600B298")]
	[Address(RVA = "0x1BBF348", Offset = "0x1BBF348", VA = "0x1BBF348")]
	public void ArrowOpenOnClick()
	{
	}

	[Token(Token = "0x600B299")]
	[Address(RVA = "0x1BBF4E4", Offset = "0x1BBF4E4", VA = "0x1BBF4E4")]
	public void ArrowCloseOnClick()
	{
	}

	[Token(Token = "0x600B29A")]
	[Address(RVA = "0x1BBF67C", Offset = "0x1BBF67C", VA = "0x1BBF67C")]
	private void OnNewItemOnHand(object[] param)
	{
	}

	[Token(Token = "0x600B29B")]
	[Address(RVA = "0x1BBF90C", Offset = "0x1BBF90C", VA = "0x1BBF90C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
