using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200147E")]
public class EMiniGame
{
	[Token(Token = "0x200147F")]
	public enum MiniGame
	{
		[Token(Token = "0x4008E39")]
		MiniGame_NONE,
		[Token(Token = "0x4008E3A")]
		MiniGame_BOOYAH_CHESS,
		[Token(Token = "0x4008E3B")]
		MiniGame_MONOPOLY,
		[Token(Token = "0x4008E3C")]
		MiniGame_BOOYAHGO,
		[Token(Token = "0x4008E3D")]
		MiniGame_WinterFestStrategy,
		[Token(Token = "0x4008E3E")]
		MiniGame_FFWSMANAGER,
		[Token(Token = "0x4008E3F")]
		MiniGame_RAMPAGE4B
	}

	[Token(Token = "0x2001480")]
	public enum HexagonStatus
	{
		[Token(Token = "0x4008E41")]
		HexagonStatus_NONE,
		[Token(Token = "0x4008E42")]
		HexagonStatus_PLAYER,
		[Token(Token = "0x4008E43")]
		HexagonStatus_ENEMY,
		[Token(Token = "0x4008E44")]
		HexagonStatus_CHEST,
		[Token(Token = "0x4008E45")]
		HexagonStatus_BOOYAH
	}

	[Token(Token = "0x2001481")]
	public enum GameStatus
	{
		[Token(Token = "0x4008E47")]
		GameStatus_NONE,
		[Token(Token = "0x4008E48")]
		GameStatus_INGAME
	}

	[Token(Token = "0x2001482")]
	public enum MonopolyNodeType
	{
		[Token(Token = "0x4008E4A")]
		MonopolyNodeType_NONE,
		[Token(Token = "0x4008E4B")]
		MonopolyNodeType_BOX,
		[Token(Token = "0x4008E4C")]
		MonopolyNodeType_DICE,
		[Token(Token = "0x4008E4D")]
		MonopolyNodeType_FORWWARD,
		[Token(Token = "0x4008E4E")]
		MonopolyNodeType_BACKWARD,
		[Token(Token = "0x4008E4F")]
		MonopolyNodeType_BUFF,
		[Token(Token = "0x4008E50")]
		MonopolyNodeType_TOKEN,
		[Token(Token = "0x4008E51")]
		MonopolyNodeType_EVENT,
		[Token(Token = "0x4008E52")]
		MonopolyNodeType_START
	}

	[Token(Token = "0x2001483")]
	public enum MonopolyEventResultType
	{
		[Token(Token = "0x4008E54")]
		MonopolyEventResultType_NONE,
		[Token(Token = "0x4008E55")]
		MonopolyEventResultType_TOKEN,
		[Token(Token = "0x4008E56")]
		MonopolyEventResultType_ACTIVITY
	}

	[Token(Token = "0x2001484")]
	public enum MonopolyPlayerStatus
	{
		[Token(Token = "0x4008E58")]
		MonopolyPlayerStatus_NONE,
		[Token(Token = "0x4008E59")]
		MonopolyPlayerStatus_WAITINGEVENT
	}

	[Token(Token = "0x2001485")]
	public enum BooyahgoNodeType
	{
		[Token(Token = "0x4008E5B")]
		BooyahgoNodeType_NONE,
		[Token(Token = "0x4008E5C")]
		BooyahgoNodeType_BOX,
		[Token(Token = "0x4008E5D")]
		BooyahgoNodeType_DICE,
		[Token(Token = "0x4008E5E")]
		BooyahgoNodeType_FORWARD,
		[Token(Token = "0x4008E5F")]
		BooyahgoNodeType_TRAP,
		[Token(Token = "0x4008E60")]
		BooyahgoNodeType_BUFF,
		[Token(Token = "0x4008E61")]
		BooyahgoNodeType_TOKEN,
		[Token(Token = "0x4008E62")]
		BooyahgoNodeType_START,
		[Token(Token = "0x4008E63")]
		BooyahgoNodeType_SKULLKING,
		[Token(Token = "0x4008E64")]
		BooyahgoNodeType_END
	}

	[Token(Token = "0x2001486")]
	public enum BuildingType
	{
		[Token(Token = "0x4008E66")]
		BuildingType_NONE,
		[Token(Token = "0x4008E67")]
		BuildingType_ALLOY,
		[Token(Token = "0x4008E68")]
		BuildingType_BATTERY,
		[Token(Token = "0x4008E69")]
		BuildingType_CRYSTAL,
		[Token(Token = "0x4008E6A")]
		BuildingType_PLASTIC,
		[Token(Token = "0x4008E6B")]
		BuildingType_MAIN
	}

	[Token(Token = "0x2001487")]
	public enum FFWS03ManagerStageType
	{
		[Token(Token = "0x4008E6D")]
		FFWS03ManagerStageType_NONE,
		[Token(Token = "0x4008E6E")]
		FFWS03ManagerStageType_HIGHEST_LEVEL_COUNT,
		[Token(Token = "0x4008E6F")]
		FFWS03ManagerStageType_MATCH_SCORE,
		[Token(Token = "0x4008E70")]
		FFWS03ManagerStageType_TEAM_KILL_COUNT,
		[Token(Token = "0x4008E71")]
		FFWS03ManagerStageType_BOOYAH_COUNT
	}

	[Token(Token = "0x2001488")]
	public enum FFWS03ManagerMatchID
	{
		[Token(Token = "0x4008E73")]
		FFWS03ManagerMatchID_NONE,
		[Token(Token = "0x4008E74")]
		FFWS03ManagerMatchID_AUDITION,
		[Token(Token = "0x4008E75")]
		FFWS03ManagerMatchID_QUALIFIER,
		[Token(Token = "0x4008E76")]
		FFWS03ManagerMatchID_UNLIMITED,
		[Token(Token = "0x4008E77")]
		FFWS03ManagerMatchID_FINAL,
		[Token(Token = "0x4008E78")]
		FFWS03ManagerMatchID_TEAM_TRAINING
	}

	[Token(Token = "0x2001489")]
	public enum FFWS03ManagerMatchType
	{
		[Token(Token = "0x4008E7A")]
		FFWS03ManagerMatchType_NONE,
		[Token(Token = "0x4008E7B")]
		FFWS03ManagerMatchType_SWORD,
		[Token(Token = "0x4008E7C")]
		FFWS03ManagerMatchType_POLICY
	}

	[Token(Token = "0x6007B08")]
	[Address(RVA = "0x309F358", Offset = "0x309F358", VA = "0x309F358")]
	public EMiniGame()
	{
	}
}
