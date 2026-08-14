using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200145B")]
public class ELimitedEvent
{
	[Token(Token = "0x200145C")]
	public enum StoreType
	{
		[Token(Token = "0x4008D62")]
		StoreType_NONE,
		[Token(Token = "0x4008D63")]
		StoreType_BRINGER,
		[Token(Token = "0x4008D64")]
		StoreType_LIBERI,
		[Token(Token = "0x4008D65")]
		StoreType_ANNIVERSARY,
		[Token(Token = "0x4008D66")]
		StoreType_BOOYAHDAY,
		[Token(Token = "0x4008D67")]
		StoreType_MVP,
		[Token(Token = "0x4008D68")]
		StoreType_GOLIATH,
		[Token(Token = "0x4008D69")]
		StoreType_FFWS,
		[Token(Token = "0x4008D6A")]
		StoreType_FOURSYMBOLS,
		[Token(Token = "0x4008D6B")]
		StoreType_MOCOMONTH,
		[Token(Token = "0x4008D6C")]
		StoreType_BOOYAHDAY21,
		[Token(Token = "0x4008D6D")]
		StoreType_FFWS03,
		[Token(Token = "0x4008D6E")]
		StoreType_WinterFest21B,
		[Token(Token = "0x4008D6F")]
		StoreType_DigitaluniverseB
	}

	[Token(Token = "0x200145D")]
	public enum EventID
	{
		[Token(Token = "0x4008D71")]
		EventID_NONE,
		[Token(Token = "0x4008D72")]
		EventID_RAMPAGE,
		[Token(Token = "0x4008D73")]
		EventID_ANNIVERSARY,
		[Token(Token = "0x4008D74")]
		EventID_MONEYHEIST,
		[Token(Token = "0x4008D75")]
		EventID_BOOYAHDAY,
		[Token(Token = "0x4008D76")]
		EventID_BOUNTY,
		[Token(Token = "0x4008D77")]
		EventID_BERMUDA,
		[Token(Token = "0x4008D78")]
		EventID_MEGAPUNCH,
		[Token(Token = "0x4008D79")]
		EventID_MVP,
		[Token(Token = "0x4008D7A")]
		EventID_GOLIATH,
		[Token(Token = "0x4008D7B")]
		EventID_FFWS,
		[Token(Token = "0x4008D7C")]
		EventID_SUPERFIGHTER,
		[Token(Token = "0x4008D7D")]
		EventID_SUPERCAR,
		[Token(Token = "0x4008D7E")]
		EventID_SUTORITO,
		[Token(Token = "0x4008D7F")]
		EventID_FOURSYMBOLS,
		[Token(Token = "0x4008D80")]
		EventID_MUSICFEST,
		[Token(Token = "0x4008D81")]
		EventID_MOCOMONTH,
		[Token(Token = "0x4008D82")]
		EventID_FFWS03,
		[Token(Token = "0x4008D83")]
		EventID_BOOYAHDAY21,
		[Token(Token = "0x4008D84")]
		EventID_WinterFest21B,
		[Token(Token = "0x4008D85")]
		EventID_JUMPSUIT,
		[Token(Token = "0x4008D86")]
		EventID_HOODEDKILLERB,
		[Token(Token = "0x4008D87")]
		EventID_HURRICANEB,
		[Token(Token = "0x4008D88")]
		EventID_BOYBANDB,
		[Token(Token = "0x4008D89")]
		EventID_RAMPAGE4B,
		[Token(Token = "0x4008D8A")]
		EventID_DIGITALUNIVERSEB
	}

	[Token(Token = "0x200145E")]
	public enum EventState
	{
		[Token(Token = "0x4008D8C")]
		EventState_NONE,
		[Token(Token = "0x4008D8D")]
		EventState_WARMUP,
		[Token(Token = "0x4008D8E")]
		EventState_PROCESS,
		[Token(Token = "0x4008D8F")]
		EventState_SETTLE,
		[Token(Token = "0x4008D90")]
		EventState_SPAN
	}

	[Token(Token = "0x200145F")]
	public enum ProcessType
	{
		[Token(Token = "0x4008D92")]
		ProcessType_NONE,
		[Token(Token = "0x4008D93")]
		ProcessType_BRINGER,
		[Token(Token = "0x4008D94")]
		ProcessType_LIBERI,
		[Token(Token = "0x4008D95")]
		ProcessType_NODE,
		[Token(Token = "0x4008D96")]
		ProcessType_BOUNTY_WARMUP,
		[Token(Token = "0x4008D97")]
		ProcessType_BOUNTY_POPULARITY,
		[Token(Token = "0x4008D98")]
		ProcessType_BOUNTY_MAIN_PERCENT,
		[Token(Token = "0x4008D99")]
		ProcessType_JUMPSUIT_STAGE,
		[Token(Token = "0x4008D9A")]
		ProcessType_JUMPSUIT_CIRCLE
	}

	[Token(Token = "0x2001460")]
	public enum RampageFaction
	{
		[Token(Token = "0x4008D9C")]
		RampageFaction_NONE,
		[Token(Token = "0x4008D9D")]
		RampageFaction_BRINGER,
		[Token(Token = "0x4008D9E")]
		RampageFaction_LIBERI
	}

	[Token(Token = "0x2001461")]
	public enum NodeStatus
	{
		[Token(Token = "0x4008DA0")]
		NodeStatus_NONE,
		[Token(Token = "0x4008DA1")]
		NodeStatus_LOCKED,
		[Token(Token = "0x4008DA2")]
		NodeStatus_UNLOCKED,
		[Token(Token = "0x4008DA3")]
		NodeStatus_CLAIMED
	}

	[Token(Token = "0x2001462")]
	public enum NodeType
	{
		[Token(Token = "0x4008DA5")]
		NodeTYPE_NONE,
		[Token(Token = "0x4008DA6")]
		NodeType_NORMAL,
		[Token(Token = "0x4008DA7")]
		NodeType_ANNIVERSARY
	}

	[Token(Token = "0x2001463")]
	public enum MoenyHeistHelp
	{
		[Token(Token = "0x4008DA9")]
		MoenyHeistHelp_NONE,
		[Token(Token = "0x4008DAA")]
		MoenyHeistHelp_FOR_OTHER,
		[Token(Token = "0x4008DAB")]
		MoenyHeistHelp_FOR_SELF
	}

	[Token(Token = "0x2001464")]
	public enum MoneyHeistAwardType
	{
		[Token(Token = "0x4008DAD")]
		MoneyHeistAwardType_NONE,
		[Token(Token = "0x4008DAE")]
		MoneyHeistAwardType_NORMAL,
		[Token(Token = "0x4008DAF")]
		MoneyHeistAwardType_BIG
	}

	[Token(Token = "0x2001465")]
	public enum MoneyHesitSpeedChangeType
	{
		[Token(Token = "0x4008DB1")]
		MoneyHeistSpeedChangeType_NONE,
		[Token(Token = "0x4008DB2")]
		MoneyHeistSpeedChangeType_TASK,
		[Token(Token = "0x4008DB3")]
		MoneyHeistSpeedChangeType_TOKEN,
		[Token(Token = "0x4008DB4")]
		MoneyHeistSpeedChangeType_FRIEND
	}

	[Token(Token = "0x2001466")]
	public enum LeaderboardType
	{
		[Token(Token = "0x4008DB6")]
		LeaderboardType_NONE,
		[Token(Token = "0x4008DB7")]
		LeaderboardType_BOOYAH_GAME,
		[Token(Token = "0x4008DB8")]
		LeaderboardType_BOOYAH_CHESS
	}

	[Token(Token = "0x2001467")]
	public enum BooyahAwardStatus
	{
		[Token(Token = "0x4008DBA")]
		BooyahAwardStats_INIT,
		[Token(Token = "0x4008DBB")]
		BooyahAwardStats_AWARDED
	}

	[Token(Token = "0x2001468")]
	public enum GoliathGroupJoinSource
	{
		[Token(Token = "0x4008DBD")]
		GoliathGroupJoinSource_NONE,
		[Token(Token = "0x4008DBE")]
		GoliathGroupJoinSource_FRIEND,
		[Token(Token = "0x4008DBF")]
		GoliathGroupJoinSource_SEARCH,
		[Token(Token = "0x4008DC0")]
		GoliathGroupJoinSource_WORLD,
		[Token(Token = "0x4008DC1")]
		GoliathGroupJoinSource_SHARE,
		[Token(Token = "0x4008DC2")]
		GoliathGroupJoinSource_ClAN
	}

	[Token(Token = "0x2001469")]
	public enum SuperFighterManner
	{
		[Token(Token = "0x4008DC4")]
		SuperFighterManner_NONE,
		[Token(Token = "0x4008DC5")]
		SuperFighterManner_LIGHT,
		[Token(Token = "0x4008DC6")]
		SuperFighterManner_HEAVY,
		[Token(Token = "0x4008DC7")]
		SuperFighterManner_UNIQUE
	}

	[Token(Token = "0x200146A")]
	public enum SuperFighterResult
	{
		[Token(Token = "0x4008DC9")]
		SuperFighterResult_NONE,
		[Token(Token = "0x4008DCA")]
		SuperFighterResult_WIN,
		[Token(Token = "0x4008DCB")]
		SuperFighterResult_LOSE
	}

	[Token(Token = "0x200146B")]
	public enum FFWSGuessingAwardStatus
	{
		[Token(Token = "0x4008DCD")]
		FFWSGuessingAwardStats_INIT,
		[Token(Token = "0x4008DCE")]
		FFWSGuessingAwardStats_AWARDED
	}

	[Token(Token = "0x200146C")]
	public enum FFWSGuessingAwardType
	{
		[Token(Token = "0x4008DD0")]
		FFWSGuessingAwardType_NONE,
		[Token(Token = "0x4008DD1")]
		FFWSGuessingAwardType_WIN,
		[Token(Token = "0x4008DD2")]
		FFWSGuessingAwardType_LOSE
	}

	[Token(Token = "0x200146D")]
	public enum SutoritoManner
	{
		[Token(Token = "0x4008DD4")]
		SutoritoManner_NONE,
		[Token(Token = "0x4008DD5")]
		SutoritoManner_LIGHT,
		[Token(Token = "0x4008DD6")]
		SutoritoManner_HEAVY,
		[Token(Token = "0x4008DD7")]
		SutoritoManner_UNIQUE
	}

	[Token(Token = "0x200146E")]
	public enum SutoritoResult
	{
		[Token(Token = "0x4008DD9")]
		SutoritoResult_NONE,
		[Token(Token = "0x4008DDA")]
		SutoritoResult_WIN,
		[Token(Token = "0x4008DDB")]
		SutoritoResult_LOSE
	}

	[Token(Token = "0x200146F")]
	public enum SutoritoCharacter
	{
		[Token(Token = "0x4008DDD")]
		SutoritoCharacter_NONE,
		[Token(Token = "0x4008DDE")]
		SutoritoCharacter_KELLY,
		[Token(Token = "0x4008DDF")]
		SutoritoCharacter_SHIROU,
		[Token(Token = "0x4008DE0")]
		SutoritoCharacter_RYU,
		[Token(Token = "0x4008DE1")]
		SutoritoCharacter_CHUNLI
	}

	[Token(Token = "0x2001470")]
	public enum FourSymbolsID
	{
		[Token(Token = "0x4008DE3")]
		FourSymbolsID_NONE,
		[Token(Token = "0x4008DE4")]
		FourSymbolsID_AZURE_DRAGON,
		[Token(Token = "0x4008DE5")]
		FourSymbolsID_WHITE_TIGER,
		[Token(Token = "0x4008DE6")]
		FourSymbolsID_BLACK_TORTOISE,
		[Token(Token = "0x4008DE7")]
		FourSymbolsID_VERMILLION_BIRD
	}

	[Token(Token = "0x2001471")]
	public enum FourSymbolsRoadNodeType
	{
		[Token(Token = "0x4008DE9")]
		FourSymbolsRoadNodeType_NONE,
		[Token(Token = "0x4008DEA")]
		FourSymbolsRoadNodeType_NORMAL,
		[Token(Token = "0x4008DEB")]
		FourSymbolsRoadNodeType_AWARD
	}

	[Token(Token = "0x2001472")]
	public enum JumpsuitJoinType
	{
		[Token(Token = "0x4008DED")]
		JumpsuitJoinType_NONE,
		[Token(Token = "0x4008DEE")]
		JumpsuitJoinType_ACTIVE,
		[Token(Token = "0x4008DEF")]
		JumpsuitJoinType_INVITED
	}

	[Token(Token = "0x2001473")]
	public enum HoodedkillerBWeaponType
	{
		[Token(Token = "0x4008DF1")]
		HoodedkillerBWeaponType_NONE,
		[Token(Token = "0x4008DF2")]
		HoodedkillerBWeaponType_SLEEVEARROW,
		[Token(Token = "0x4008DF3")]
		HoodedkillerBWeaponType_SWORD
	}

	[Token(Token = "0x2001474")]
	public enum DigitaluniverseBTimeAttackStatus
	{
		[Token(Token = "0x4008DF5")]
		DigitaluniverseBTimeAttackStatus_NONE,
		[Token(Token = "0x4008DF6")]
		DigitaluniverseBTimeAttackStatus_INPROGRESS,
		[Token(Token = "0x4008DF7")]
		DigitaluniverseBTimeAttackStatus_EXPIRED,
		[Token(Token = "0x4008DF8")]
		DigitaluniverseBTimeAttackStatus_FINISHED
	}

	[Token(Token = "0x2001475")]
	public enum DigitaluniverseBGateType
	{
		[Token(Token = "0x4008DFA")]
		DigitaluniverseBGateType_NONE,
		[Token(Token = "0x4008DFB")]
		DigitaluniverseBGateType_COLLECTION,
		[Token(Token = "0x4008DFC")]
		DigitaluniverseBGateType_CLOTH,
		[Token(Token = "0x4008DFD")]
		DigitaluniverseBGateType_MAP,
		[Token(Token = "0x4008DFE")]
		DigitaluniverseBGateType_CHARACTER,
		[Token(Token = "0x4008DFF")]
		DigitaluniverseBGateType_EVENT
	}

	[Token(Token = "0x6007B02")]
	[Address(RVA = "0x309F310", Offset = "0x309F310", VA = "0x309F310")]
	public ELimitedEvent()
	{
	}
}
