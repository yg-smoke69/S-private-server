using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D1B")]
public class EMatchmaking
{
	[Token(Token = "0x2001D1C")]
	public enum Proto
	{
		[Token(Token = "0x400B7AC")]
		Proto_NONE,
		[Token(Token = "0x400B7AD")]
		Proto_START,
		[Token(Token = "0x400B7AE")]
		Proto_CANCEL,
		[Token(Token = "0x400B7AF")]
		Proto_GROUPSTART,
		[Token(Token = "0x400B7B0")]
		Proto_GROUPCANCEL,
		[Token(Token = "0x400B7B1")]
		Proto_MATCHMAKINGSUSS_NTF,
		[Token(Token = "0x400B7B2")]
		Proto_DROPMATCH,
		[Token(Token = "0x400B7B3")]
		Proto_GAMEOPENINGINFO,
		[Token(Token = "0x400B7B4")]
		Proto_CHECKINGAMEPLAYER,
		[Token(Token = "0x400B7B5")]
		Proto_CLEARINGAMEPLAYER,
		[Token(Token = "0x400B7B6")]
		Proto_ANTIADDICTION_NFT,
		[Token(Token = "0x400B7B7")]
		Proto_START_NTF,
		[Token(Token = "0x400B7B8")]
		Proto_MASSGROUPSTART,
		[Token(Token = "0x400B7B9")]
		Proto_MASSGROUPCANCEL,
		[Token(Token = "0x400B7BA")]
		Proto_STOP_NTF,
		[Token(Token = "0x400B7BB")]
		Proto_RANKING_BANNED,
		[Token(Token = "0x400B7BC")]
		Proto_TEAMMATE_RANKING_BANNED
	}

	[Token(Token = "0x2001D1D")]
	public enum ErrCode
	{
		[Token(Token = "0x400B7BE")]
		ErrCode_SUSS = 0,
		[Token(Token = "0x400B7BF")]
		ErrCode_ALREADYINMATCHMAKING = 1,
		[Token(Token = "0x400B7C0")]
		ErrCode_CREATEPLAYERFAIL = 2,
		[Token(Token = "0x400B7C1")]
		ErrCode_JOINSINGLEPOOLFAIL = 3,
		[Token(Token = "0x400B7C2")]
		ErrCode_JOINMULTIPOOLFAIL = 4,
		[Token(Token = "0x400B7C3")]
		ErrCode_NOGAMESERVERAVAILABLE = 5,
		[Token(Token = "0x400B7C4")]
		ErrCode_INITMATCHFAIL = 6,
		[Token(Token = "0x400B7C5")]
		ErrCode_LOGINGAMESERVERTIMEOUT = 7,
		[Token(Token = "0x400B7C6")]
		ErrCode_MMTIMEOUT = 8,
		[Token(Token = "0x400B7C7")]
		ErrCode_NOSUCHPOOL = 9,
		[Token(Token = "0x400B7C8")]
		ErrCode_MAPNOTOPEN = 10,
		[Token(Token = "0x400B7C9")]
		ErrCode_INVALIDRANDOMMAPCONFIG = 11,
		[Token(Token = "0x400B7CA")]
		ErrCode_RANKINGMATCHLEVELLIMIT = 12,
		[Token(Token = "0x400B7CB")]
		ErrCode_NOTQUALIFIEDFORFREEWTA = 13,
		[Token(Token = "0x400B7CC")]
		ErrCode_INVALIDWTACURRENCYTYPE = 14,
		[Token(Token = "0x400B7CD")]
		ErrCode_NOTENOUGHMONEYFORWTA = 15,
		[Token(Token = "0x400B7CE")]
		ErrCode_NEGATIVEGEMS = 16,
		[Token(Token = "0x400B7CF")]
		ErrCode_ANTIADDICTIONBAN = 17,
		[Token(Token = "0x400B7D0")]
		ErrCode_NOTQUALIFIEDFORCHAMP = 18,
		[Token(Token = "0x400B7D1")]
		ErrCode_MAPINVALIDFORSOMEMEMBERS = 20,
		[Token(Token = "0x400B7D2")]
		ErrCode_EMULATORNOTQUALIFIED = 21,
		[Token(Token = "0x400B7D3")]
		ErrCode_EMULATORRECONNNOTQUALIFIED = 22,
		[Token(Token = "0x400B7D4")]
		ErrCode_CSRANKINGBANNED = 23,
		[Token(Token = "0x400B7D5")]
		ErrCode_RANKINGMATCHREGISTERTIMELIMIT = 24,
		[Token(Token = "0x400B7D6")]
		ErrCode_INVALIDMATCHMODE = 25,
		[Token(Token = "0x400B7D7")]
		ErrCode_NOTQUALIFIEDFORCUP = 26,
		[Token(Token = "0x400B7D8")]
		ErrCode_EXISTNOTMAXCLIENT = 28,
		[Token(Token = "0x400B7D9")]
		ErrCode_INVALIDGAMEMODE = 29,
		[Token(Token = "0x400B7DA")]
		ErrCode_PLAYERISNOTCAPTAIN = 30,
		[Token(Token = "0x400B7DB")]
		ErrCode_NOTENOUGHPLAYERFORCLANWAR = 31,
		[Token(Token = "0x400B7DC")]
		ErrCode_MEMBERISALREADYINMATCHMAKING = 32,
		[Token(Token = "0x400B7DD")]
		ErrCode_CREATEMEMBERFAIL = 33,
		[Token(Token = "0x400B7DE")]
		ErrCode_MASSGROUPALREADYINMATCHMAKING = 34,
		[Token(Token = "0x400B7DF")]
		ErrCode_EMULATORMMTIMEOUT = 35,
		[Token(Token = "0x400B7E0")]
		ErrCode_INVALIDWORKSHOPCODE = 36,
		[Token(Token = "0x400B7E1")]
		ErrCode_HACKERRECONNECTNOTQUALIFIED = 37,
		[Token(Token = "0x400B7E2")]
		ErrCode_NOTQUALIFIEDMODELIMITLEVEL = 38,
		[Token(Token = "0x400B7E3")]
		ErrCode_WORKSHOPCODEUPDATED = 39,
		[Token(Token = "0x400B7E4")]
		ErrCode_INVALIDCREDITSCORE = 40,
		[Token(Token = "0x400B7E5")]
		ErrCode_SOMEONEDIDNOTDOWNLOADMAP = 41,
		[Token(Token = "0x400B7E6")]
		ErrCode_WAITINGGSREADYTIMEOUT = 42
	}

	[Token(Token = "0x2001D1E")]
	public enum PlayerState
	{
		[Token(Token = "0x400B7E8")]
		PlayerState_MATCHMAKING,
		[Token(Token = "0x400B7E9")]
		PlayerState_LOADING,
		[Token(Token = "0x400B7EA")]
		PlayerState_INGAME,
		[Token(Token = "0x400B7EB")]
		PlayerState_INGAME_CAN_RECONNECT,
		[Token(Token = "0x400B7EC")]
		PlayerState_WAITING_GS_READY
	}

	[Token(Token = "0x2001D1F")]
	public enum LevelVisualStyle
	{
		[Token(Token = "0x400B7EE")]
		LevelVisualStyle_NORMAL,
		[Token(Token = "0x400B7EF")]
		LevelVisualStyle_NIGHT,
		[Token(Token = "0x400B7F0")]
		LevelVisualStyle_SNOW
	}

	[Token(Token = "0x6008725")]
	[Address(RVA = "0x33E907C", Offset = "0x33E907C", VA = "0x33E907C")]
	public EMatchmaking()
	{
	}
}
