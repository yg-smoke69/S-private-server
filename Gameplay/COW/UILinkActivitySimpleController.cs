using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200218C")]
public class UILinkActivitySimpleController<T> : UILinkActivityDetailController where T : UIBaseController, ISetBaseItemInfo
{
	[Token(Token = "0x400D25E")]
	[FieldOffset(Offset = "0x0")]
	protected UILinkActivitySimpleView m_View;

	[Token(Token = "0x400D25F")]
	[FieldOffset(Offset = "0x0")]
	protected List<T> m_DailyAwardControllers;

	[Token(Token = "0x600B200")]
	public UILinkActivitySimpleController()
	{
	}

	[Token(Token = "0x600B201")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B202")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B203")]
	protected override void InitActivityInfo()
	{
	}

	[Token(Token = "0x600B204")]
	protected virtual void InitActivityInfo(LinkActivityData data)
	{
	}

	[Token(Token = "0x600B205")]
	public static void InitCdnTexture(UINetworkTexture tex, string url)
	{
	}

	[Token(Token = "0x600B206")]
	protected void ShowDailyRewardsGot(bool e)
	{
	}
}
