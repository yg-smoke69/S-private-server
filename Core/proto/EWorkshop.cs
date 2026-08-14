using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014A1")]
public class EWorkshop
{
	[Token(Token = "0x20014A2")]
	public enum UnlockSlotCostType
	{
		[Token(Token = "0x4008F18")]
		ConsumeType_NONE,
		[Token(Token = "0x4008F19")]
		ConsumeType_ITEMS,
		[Token(Token = "0x4008F1A")]
		ConsumeType_COINS,
		[Token(Token = "0x4008F1B")]
		ConsumeType_GEMS
	}

	[Token(Token = "0x20014A3")]
	public enum SlotType
	{
		[Token(Token = "0x4008F1D")]
		SlotType_ALL,
		[Token(Token = "0x4008F1E")]
		SlotType_EDIT,
		[Token(Token = "0x4008F1F")]
		SlotType_SHARE,
		[Token(Token = "0x4008F20")]
		SlotType_SUBSCRIPTION,
		[Token(Token = "0x4008F21")]
		SlotType_CLASSIC,
		[Token(Token = "0x4008F22")]
		SlotType_AUTHOR
	}

	[Token(Token = "0x20014A4")]
	public enum SlotState
	{
		[Token(Token = "0x4008F24")]
		SlotState_EMPTY,
		[Token(Token = "0x4008F25")]
		SlotState_NORMAL,
		[Token(Token = "0x4008F26")]
		SlotState_LOCK,
		[Token(Token = "0x4008F27")]
		SlotState_UPDATABLE,
		[Token(Token = "0x4008F28")]
		SlotState_DELETED,
		[Token(Token = "0x4008F29")]
		SlotState_EXPIRED,
		[Token(Token = "0x4008F2A")]
		SlotState_BAN,
		[Token(Token = "0x4008F2B")]
		SlotState_PUBLISHED,
		[Token(Token = "0x4008F2C")]
		SlotState_WARNING
	}

	[Token(Token = "0x20014A5")]
	public enum ExpireType
	{
		[Token(Token = "0x4008F2E")]
		ExpireType_NONE,
		[Token(Token = "0x4008F2F")]
		ExpireType_WORKSHOP_CODE,
		[Token(Token = "0x4008F30")]
		ExpireType_WORKSHOP_CODE_BANNED,
		[Token(Token = "0x4008F31")]
		ExpireType_ACCOUNT_BANNED,
		[Token(Token = "0x4008F32")]
		ExpireType_WORKSHOP_CODE_PROTECT,
		[Token(Token = "0x4008F33")]
		ExpireType_ACCOUNT_PROTECT,
		[Token(Token = "0x4008F34")]
		ExpireType_WARNING_STATE
	}

	[Token(Token = "0x20014A6")]
	public enum TaskType
	{
		[Token(Token = "0x4008F36")]
		TaskType_NONE,
		[Token(Token = "0x4008F37")]
		TaskType_DAILY_PLAY,
		[Token(Token = "0x4008F38")]
		TaskType_CREATE_ROOM,
		[Token(Token = "0x4008F39")]
		TaskType_LIKED,
		[Token(Token = "0x4008F3A")]
		TaskType_WSCODE_USED
	}

	[Token(Token = "0x20014A7")]
	public enum MatchPoolType
	{
		[Token(Token = "0x4008F3C")]
		MatchPoolType_RECOMMEND = 0,
		[Token(Token = "0x4008F3D")]
		MatchPoolType_SENIOR = 1,
		[Token(Token = "0x4008F3E")]
		MatchPoolType_MIDDLE = 2,
		[Token(Token = "0x4008F3F")]
		MatchPoolType_JUNIOR = 3,
		[Token(Token = "0x4008F40")]
		MatchPoolType_ALL = 99
	}

	[Token(Token = "0x20014A8")]
	public enum DataAPIType
	{
		[Token(Token = "0x4008F42")]
		DataAPIType_NONE,
		[Token(Token = "0x4008F43")]
		DataAPIType_RECOMMEND,
		[Token(Token = "0x4008F44")]
		DataAPIType_MATCH_POOL,
		[Token(Token = "0x4008F45")]
		DataAPIType_HOT_MAP
	}

	[Token(Token = "0x20014A9")]
	public enum SwitchType
	{
		[Token(Token = "0x4008F47")]
		SwitchType_NONE,
		[Token(Token = "0x4008F48")]
		SwitchType_DATA_API_RECOMMEND,
		[Token(Token = "0x4008F49")]
		SwitchType_DATA_API_MATCH_POOL,
		[Token(Token = "0x4008F4A")]
		SwitchType_DATA_API_HOT_MAP,
		[Token(Token = "0x4008F4B")]
		SwitchType_EDITOR_CHOICE
	}

	[Token(Token = "0x20014AA")]
	public enum LikeType
	{
		[Token(Token = "0x4008F4D")]
		LikeType_Like,
		[Token(Token = "0x4008F4E")]
		LikeType_Dislike
	}

	[Token(Token = "0x20014AB")]
	public enum WordFilterType
	{
		[Token(Token = "0x4008F50")]
		WordFilterType_NONE,
		[Token(Token = "0x4008F51")]
		WordFilterType_HUD,
		[Token(Token = "0x4008F52")]
		WordFilterType_GRAPH,
		[Token(Token = "0x4008F53")]
		WordFilterType_NAME,
		[Token(Token = "0x4008F54")]
		WordFilterType_DESC
	}

	[Token(Token = "0x20014AC")]
	public enum BanType
	{
		[Token(Token = "0x4008F56")]
		BanType_UNBAN,
		[Token(Token = "0x4008F57")]
		BanType_BAN,
		[Token(Token = "0x4008F58")]
		BanType_WARNING
	}

	[Token(Token = "0x20014AD")]
	public enum RecommendMode
	{
		[Token(Token = "0x4008F5A")]
		RecommendMode_NONE,
		[Token(Token = "0x4008F5B")]
		RecommendMode_ALGORITHM,
		[Token(Token = "0x4008F5C")]
		RecommendMode_OPERATE
	}

	[Token(Token = "0x20014AE")]
	public enum RecommendPosition
	{
		[Token(Token = "0x4008F5E")]
		RecommendPosition_NONE,
		[Token(Token = "0x4008F5F")]
		RecommendPosition_HOTMAP,
		[Token(Token = "0x4008F60")]
		RecommendPosition_WEEKLIST
	}

	[Token(Token = "0x20014AF")]
	public enum EditorType
	{
		[Token(Token = "0x4008F62")]
		EditorType_CRAFTLAND,
		[Token(Token = "0x4008F63")]
		EditorType_FIREDITOR
	}

	[Token(Token = "0x20014B0")]
	public enum EditorChoiceType
	{
		[Token(Token = "0x4008F65")]
		EditorChoiceType_NONE,
		[Token(Token = "0x4008F66")]
		EditorChoiceType_PRIMARY,
		[Token(Token = "0x4008F67")]
		EditorChoiceType_SECONDARY
	}

	[Token(Token = "0x6007B11")]
	[Address(RVA = "0x309F924", Offset = "0x309F924", VA = "0x309F924")]
	public EWorkshop()
	{
	}
}
