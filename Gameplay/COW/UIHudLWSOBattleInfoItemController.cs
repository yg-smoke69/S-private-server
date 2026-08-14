using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200219E")]
internal class UIHudLWSOBattleInfoItemController : UIBaseController
{
	[Token(Token = "0x400D29F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLWSOBattleInfoItemView m_View;

	[Token(Token = "0x400D2A0")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x600B29C")]
	[Address(RVA = "0x1BBF914", Offset = "0x1BBF914", VA = "0x1BBF914")]
	public UIHudLWSOBattleInfoItemController()
	{
	}

	[Token(Token = "0x600B29D")]
	[Address(RVA = "0x1BBF998", Offset = "0x1BBF998", VA = "0x1BBF998")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B29E")]
	[Address(RVA = "0x1BBFA40", Offset = "0x1BBFA40", VA = "0x1BBFA40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B29F")]
	[Address(RVA = "0x1BBEA9C", Offset = "0x1BBEA9C", VA = "0x1BBEA9C")]
	public void SetItemInfo(List<NBJFOKDNNBK> list)
	{
	}

	[Token(Token = "0x600B2A0")]
	[Address(RVA = "0x1BBFB6C", Offset = "0x1BBFB6C", VA = "0x1BBFB6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
