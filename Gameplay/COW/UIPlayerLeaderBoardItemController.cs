using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028F2")]
public class UIPlayerLeaderBoardItemController : UIEasyListItemController
{
	[Token(Token = "0x400FBCB")]
	[FieldOffset(Offset = "0x38")]
	private UILeaderBoardItemView m_View;

	[Token(Token = "0x400FBCC")]
	[FieldOffset(Offset = "0x3C")]
	private LeaderBoardInfo m_info;

	[Token(Token = "0x400FBCD")]
	private const string ODD_BG_SPRITENAME = "leaderboard_list_BG_G";

	[Token(Token = "0x400FBCE")]
	private const string EVEN_BG_SPRITENAME = "leaderboard_list_BG_GH";

	[Token(Token = "0x400FBCF")]
	private const string ODD_TOP3_BG_SPRITENAME = "leaderboard_list_BG_B";

	[Token(Token = "0x400FBD0")]
	private const string EVEN_TOP3_BG_SPRITENAME = "leaderboard_list_BG_BH";

	[Token(Token = "0x400FBD1")]
	private const string CUP_NO1_SPRITENAME = "UI_Icon_Cup_01";

	[Token(Token = "0x400FBD2")]
	private const string CUP_NO2_SPRITENAME = "UI_Icon_Cup_02";

	[Token(Token = "0x400FBD3")]
	private const string CUP_NO3_SPRITENAME = "UI_Icon_Cup_03";

	[Token(Token = "0x60102E9")]
	[Address(RVA = "0x2C52B48", Offset = "0x2C52B48", VA = "0x2C52B48")]
	public UIPlayerLeaderBoardItemController()
	{
	}

	[Token(Token = "0x60102EA")]
	[Address(RVA = "0x2C52B50", Offset = "0x2C52B50", VA = "0x2C52B50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60102EB")]
	[Address(RVA = "0x2C52BF4", Offset = "0x2C52BF4", VA = "0x2C52BF4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60102EC")]
	[Address(RVA = "0x2C52DF8", Offset = "0x2C52DF8", VA = "0x2C52DF8")]
	private void OnItemLeaderBoardClick()
	{
	}

	[Token(Token = "0x60102ED")]
	[Address(RVA = "0x2C52EE8", Offset = "0x2C52EE8", VA = "0x2C52EE8")]
	public void SetItemData(LeaderBoardInfo info)
	{
	}

	[Token(Token = "0x60102EE")]
	[Address(RVA = "0x2C53618", Offset = "0x2C53618", VA = "0x2C53618")]
	public void SetCompareToLastRank(int compare)
	{
	}

	[Token(Token = "0x60102EF")]
	[Address(RVA = "0x2C53700", Offset = "0x2C53700", VA = "0x2C53700", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60102F0")]
	[Address(RVA = "0x2C53804", Offset = "0x2C53804", VA = "0x2C53804")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
