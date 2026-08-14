using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025EC")]
public class UIElitePassIngameHudRankingController : UIBaseController
{
	[Token(Token = "0x400EA6A")]
	[FieldOffset(Offset = "0x28")]
	private UIElitePassIngameHudRankingView m_View;

	[Token(Token = "0x600DF90")]
	[Address(RVA = "0x2A56EDC", Offset = "0x2A56EDC", VA = "0x2A56EDC")]
	public UIElitePassIngameHudRankingController()
	{
	}

	[Token(Token = "0x600DF91")]
	[Address(RVA = "0x2A56F60", Offset = "0x2A56F60", VA = "0x2A56F60")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DF92")]
	[Address(RVA = "0x2A57008", Offset = "0x2A57008", VA = "0x2A57008", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DF93")]
	[Address(RVA = "0x2A57274", Offset = "0x2A57274", VA = "0x2A57274", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DF94")]
	[Address(RVA = "0x2A573A8", Offset = "0x2A573A8", VA = "0x2A573A8")]
	public void ShowElite(bool flag)
	{
	}

	[Token(Token = "0x600DF95")]
	[Address(RVA = "0x2A57450", Offset = "0x2A57450", VA = "0x2A57450")]
	private void ShowRanking(object[] param)
	{
	}

	[Token(Token = "0x600DF96")]
	[Address(RVA = "0x2A57CDC", Offset = "0x2A57CDC", VA = "0x2A57CDC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DF97")]
	[Address(RVA = "0x2A57CE4", Offset = "0x2A57CE4", VA = "0x2A57CE4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
