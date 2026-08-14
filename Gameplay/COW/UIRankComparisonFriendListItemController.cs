using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AB0")]
public class UIRankComparisonFriendListItemController : UIBaseController
{
	[Token(Token = "0x401067F")]
	[FieldOffset(Offset = "0x28")]
	private UIRankComparisonFriendListItemView m_View;

	[Token(Token = "0x4010680")]
	[FieldOffset(Offset = "0x2C")]
	private UILadderMatchLeaderboardItemController ctrl;

	[Token(Token = "0x601178F")]
	[Address(RVA = "0x1AC741C", Offset = "0x1AC741C", VA = "0x1AC741C")]
	public UIRankComparisonFriendListItemController()
	{
	}

	[Token(Token = "0x6011790")]
	[Address(RVA = "0x1AC74A0", Offset = "0x1AC74A0", VA = "0x1AC74A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011791")]
	[Address(RVA = "0x1AC7544", Offset = "0x1AC7544", VA = "0x1AC7544", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011792")]
	[Address(RVA = "0x1AC6B1C", Offset = "0x1AC6B1C", VA = "0x1AC6B1C")]
	public void SetViewData(object data, bool show)
	{
	}

	[Token(Token = "0x6011793")]
	[Address(RVA = "0x1AC7698", Offset = "0x1AC7698", VA = "0x1AC7698", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011794")]
	[Address(RVA = "0x1AC76FC", Offset = "0x1AC76FC", VA = "0x1AC76FC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011795")]
	[Address(RVA = "0x1AC7704", Offset = "0x1AC7704", VA = "0x1AC7704")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
