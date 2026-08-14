using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CC2")]
public class EGroup
{
	[Token(Token = "0x2001CC3")]
	public enum Proto
	{
		[Token(Token = "0x400B5CD")]
		Proto_NONE,
		[Token(Token = "0x400B5CE")]
		Proto_CREATE,
		[Token(Token = "0x400B5CF")]
		Proto_INVITE,
		[Token(Token = "0x400B5D0")]
		Proto_INVITE_NTF,
		[Token(Token = "0x400B5D1")]
		Proto_ACCEPT,
		[Token(Token = "0x400B5D2")]
		Proto_REFUSE,
		[Token(Token = "0x400B5D3")]
		Proto_JOIN_NTF,
		[Token(Token = "0x400B5D4")]
		Proto_LEAVE,
		[Token(Token = "0x400B5D5")]
		Proto_LEAVE_NTF,
		[Token(Token = "0x400B5D6")]
		Proto_START,
		[Token(Token = "0x400B5D7")]
		Proto_START_NTF,
		[Token(Token = "0x400B5D8")]
		Proto_STOP,
		[Token(Token = "0x400B5D9")]
		Proto_STOP_NTF,
		[Token(Token = "0x400B5DA")]
		Proto_DISMISS_NTF,
		[Token(Token = "0x400B5DB")]
		Proto_GROUPINFO,
		[Token(Token = "0x400B5DC")]
		Proto_READY,
		[Token(Token = "0x400B5DD")]
		Proto_READY_NTF,
		[Token(Token = "0x400B5DE")]
		Proto_CHANGE,
		[Token(Token = "0x400B5DF")]
		Proto_CHANGE_NTF,
		[Token(Token = "0x400B5E0")]
		Proto_JOINROOM,
		[Token(Token = "0x400B5E1")]
		Proto_SPECTATEROOM,
		[Token(Token = "0x400B5E2")]
		Proto_SHOWEMOTE,
		[Token(Token = "0x400B5E3")]
		Proto_SHOWEMOTE_NTF,
		[Token(Token = "0x400B5E4")]
		Proto_SHOWPETACTION,
		[Token(Token = "0x400B5E5")]
		Proto_SHOWPETACTION_NTF,
		[Token(Token = "0x400B5E6")]
		Proto_CHECKPLAYER,
		[Token(Token = "0x400B5E7")]
		Proto_ANTIADDICTION_NFT,
		[Token(Token = "0x400B5E8")]
		proto_TEAMMATEHEATING_NFT,
		[Token(Token = "0x400B5E9")]
		Proto_CHANGEMAP_NTF,
		[Token(Token = "0x400B5EA")]
		Proto_CHANGEAVAILABLEMAPS,
		[Token(Token = "0x400B5EB")]
		Proto_CHANGEAVAILABLEMAPS_NTF,
		[Token(Token = "0x400B5EC")]
		Proto_GETGROUPCODE,
		[Token(Token = "0x400B5ED")]
		Proto_GETGROUPCODE_NTF,
		[Token(Token = "0x400B5EE")]
		Proto_JOIN,
		[Token(Token = "0x400B5EF")]
		Proto_JOINREQUEST_NTF,
		[Token(Token = "0x400B5F0")]
		Proto_KICKOUT,
		[Token(Token = "0x400B5F1")]
		Proto_CHANGEPUBPVT,
		[Token(Token = "0x400B5F2")]
		Proto_CHANGEPUBPVT_NTF,
		[Token(Token = "0x400B5F3")]
		Proto_ACCEPTJOIN,
		[Token(Token = "0x400B5F4")]
		Proto_CSRANKINGBAN_NTF,
		[Token(Token = "0x400B5F5")]
		Proto_GROUPBAN_NTF,
		[Token(Token = "0x400B5F6")]
		Proto_RANKINGBAN_NTF,
		[Token(Token = "0x400B5F7")]
		Proto_SYNCPATCHOPTIONALRESSTATUS,
		[Token(Token = "0x400B5F8")]
		Proto_SYNCPATCHOPTIONALRESSTATUS_NTF,
		[Token(Token = "0x400B5F9")]
		Proto_ACCEPTJOIN_NTF
	}

	[Token(Token = "0x2001CC4")]
	public enum ErrCode
	{
		[Token(Token = "0x400B5FB")]
		ErrCode_SUSS = 0,
		[Token(Token = "0x400B5FC")]
		ErrCode_GROUPEXISTED = 1,
		[Token(Token = "0x400B5FD")]
		ErrCode_NOGROUP = 2,
		[Token(Token = "0x400B5FE")]
		ErrCode_ALREADYINVITED = 3,
		[Token(Token = "0x400B5FF")]
		ErrCode_NOTINVITED = 4,
		[Token(Token = "0x400B600")]
		ErrCode_REACHMAXINVITEE = 5,
		[Token(Token = "0x400B601")]
		ErrCode_ALREADYINGROUP = 6,
		[Token(Token = "0x400B602")]
		ErrCode_NOTINGROUP = 7,
		[Token(Token = "0x400B603")]
		ErrCode_REACHMAXMEMBER = 8,
		[Token(Token = "0x400B604")]
		ErrCode_GROUPINGAME = 9,
		[Token(Token = "0x400B605")]
		ErrCode_GROUPNOTINGAME = 10,
		[Token(Token = "0x400B606")]
		ErrCode_CANNOTINVITESELF = 11,
		[Token(Token = "0x400B607")]
		ErrCode_CANNOTINVITEOTHERREGION = 12,
		[Token(Token = "0x400B608")]
		ErrCode_GROUPNOTREADY = 13,
		[Token(Token = "0x400B609")]
		ErrCode_INVALIDGROUPMODE = 14,
		[Token(Token = "0x400B60A")]
		ErrCode_AUTOGROUPTIMEOUT = 15,
		[Token(Token = "0x400B60B")]
		ErrCode_NOSUCHPOOL = 16,
		[Token(Token = "0x400B60C")]
		ErrCode_CREATEGROUPFAIL = 17,
		[Token(Token = "0x400B60D")]
		ErrCode_INVALIDRANDOMMAPCONFIG = 18,
		[Token(Token = "0x400B60E")]
		ErrCode_INVITEEALREADYINGROUP = 19,
		[Token(Token = "0x400B60F")]
		ErrCode_INVITEEALREADYINROOM = 20,
		[Token(Token = "0x400B610")]
		ErrCode_INVITEEALREADYINGAME = 21,
		[Token(Token = "0x400B611")]
		ErrCode_INVITEEALREADYOFFLINE = 22,
		[Token(Token = "0x400B612")]
		ErrCode_INVALIDEMOTE = 23,
		[Token(Token = "0x400B613")]
		ErrCode_RANKINGMATCHLEVELLIMIT = 24,
		[Token(Token = "0x400B614")]
		ErrCode_NEGATIVEGEMS = 25,
		[Token(Token = "0x400B615")]
		ErrCode_ANTIADDICTIONBAN = 26,
		[Token(Token = "0x400B616")]
		ErrCode_NOTCHAMPIONTEAMMEMBER = 27,
		[Token(Token = "0x400B617")]
		ErrCode_INVITERNOTINGROUP = 28,
		[Token(Token = "0x400B618")]
		ErrCode_INVALIDCHAMPIONTEAM = 29,
		[Token(Token = "0x400B619")]
		ErrCode_NOTQUALIFIEDFORCHAMP = 30,
		[Token(Token = "0x400B61A")]
		ErrCode_INVITEEALREADYINTRAINING = 31,
		[Token(Token = "0x400B61B")]
		ErrCode_NOTQUALIFIEDFORTRAIN = 32,
		[Token(Token = "0x400B61C")]
		ErrCode_MAPINVALIDFORSOMEMEMBERS = 33,
		[Token(Token = "0x400B61D")]
		ErrCode_NOTQUALIFIEDFORGENGROUPCODE = 34,
		[Token(Token = "0x400B61E")]
		ErrCode_NOTQUALIFIEDFORUSEGROUPCODE = 35,
		[Token(Token = "0x400B61F")]
		ErrCode_NOAVAILABLEGROUPCODE = 36,
		[Token(Token = "0x400B620")]
		ErrCode_NOTGROUPCAPTAIN = 37,
		[Token(Token = "0x400B621")]
		ErrCode_DIFFERENTGROUPS = 38,
		[Token(Token = "0x400B622")]
		ErrCode_ALREADYINMATCHMAKING = 39,
		[Token(Token = "0x400B623")]
		ErrCode_CANNOTJOINSELF = 40,
		[Token(Token = "0x400B624")]
		ErrCode_CANNOTJOINOTHERREGION = 41,
		[Token(Token = "0x400B625")]
		ErrCode_JOINNONEXISTENTGROUP = 42,
		[Token(Token = "0x400B626")]
		ErrCode_PRIVATEGROUP = 43,
		[Token(Token = "0x400B627")]
		ErrCode_CANNOTKICKSELF = 44,
		[Token(Token = "0x400B628")]
		ErrCode_CREATEPLAYERFAIL = 45,
		[Token(Token = "0x400B629")]
		ErrCode_SELFNOTREADY = 46,
		[Token(Token = "0x400B62A")]
		ErrCode_JOINERALREADYINGROUP = 47,
		[Token(Token = "0x400B62B")]
		ErrCode_CSRANKINGBANNED = 48,
		[Token(Token = "0x400B62C")]
		ErrCode_RANKINGMATCHREGISTERTIMELIMIT = 49,
		[Token(Token = "0x400B62D")]
		ErrCode_GROUPSECRETCODENOTMATCH = 50,
		[Token(Token = "0x400B62E")]
		ErrCode_GROUPNOTIDLEFORBIDCHANGEMODE = 51,
		[Token(Token = "0x400B62F")]
		ErrCode_NOTQUALIFIEDFORCUP = 52,
		[Token(Token = "0x400B630")]
		ErrCode_INVALIDCUPTEAM = 53,
		[Token(Token = "0x400B631")]
		ErrCode_NOTCUPTEAMMEMBER = 54,
		[Token(Token = "0x400B632")]
		ErrCode_INVALIDWORKSHOPCODE = 56,
		[Token(Token = "0x400B633")]
		ErrCode_INVALIDCREDITSCORE = 57,
		[Token(Token = "0x400B634")]
		ErrCode_SOMEONEDIDNOTDOWNLOADMAP = 58,
		[Token(Token = "0x400B635")]
		ErrCode_PLAYERMAPINVALID = 59,
		[Token(Token = "0x400B636")]
		ErrCode_KICKEDPLAYER = 60,
		[Token(Token = "0x400B637")]
		ErrCode_INVALIDINVITE = 61
	}

	[Token(Token = "0x2001CC5")]
	public enum LeaveReason
	{
		[Token(Token = "0x400B639")]
		LeaveReason_NORMAL,
		[Token(Token = "0x400B63A")]
		LeaveReason_OFFLINE,
		[Token(Token = "0x400B63B")]
		LeaveReason_DROPMATCH,
		[Token(Token = "0x400B63C")]
		LeaveReason_ALLJOINROOM,
		[Token(Token = "0x400B63D")]
		LeaveReason_SOLOJOINROOM,
		[Token(Token = "0x400B63E")]
		LeaveReason_KICKOUT
	}

	[Token(Token = "0x2001CC6")]
	public enum PlayerState
	{
		[Token(Token = "0x400B640")]
		PlayerState_IDLE,
		[Token(Token = "0x400B641")]
		PlayerState_MATCHMAKING,
		[Token(Token = "0x400B642")]
		PlayerState_INGAME,
		[Token(Token = "0x400B643")]
		PlayerState_AUTOGROUP
	}

	[Token(Token = "0x2001CC7")]
	public enum State
	{
		[Token(Token = "0x400B645")]
		State_IDLE,
		[Token(Token = "0x400B646")]
		State_MATCHMAKING,
		[Token(Token = "0x400B647")]
		State_INGAME,
		[Token(Token = "0x400B648")]
		State_AUTOGROUP
	}

	[Token(Token = "0x2001CC8")]
	public enum PlayerPatchOptionalResStatus
	{
		[Token(Token = "0x400B64A")]
		PlayerPatchOptionalResStatus_NONE,
		[Token(Token = "0x400B64B")]
		PlayerPatchOptionalResStatus_LACK,
		[Token(Token = "0x400B64C")]
		PlayerPatchOptionalResStatus_START
	}

	[Token(Token = "0x2001CC9")]
	public enum CreateFromType
	{
		[Token(Token = "0x400B64E")]
		CreateFromType_NONE,
		[Token(Token = "0x400B64F")]
		CreateFromType_OWNSELF,
		[Token(Token = "0x400B650")]
		CreateFromType_GROUP,
		[Token(Token = "0x400B651")]
		CreateFromType_RESERVATION
	}

	[Token(Token = "0x2001CCA")]
	public enum JoinFromType
	{
		[Token(Token = "0x400B653")]
		JoinFromType_NONE,
		[Token(Token = "0x400B654")]
		JoinFromType_GROUP,
		[Token(Token = "0x400B655")]
		JoinFromType_RESERVATION
	}

	[Token(Token = "0x2001CCB")]
	public enum InviteChannelType
	{
		[Token(Token = "0x400B657")]
		InviteChannelType_PLAYER,
		[Token(Token = "0x400B658")]
		InviteChannelType_WORLD,
		[Token(Token = "0x400B659")]
		InviteChannelType_GUILD,
		[Token(Token = "0x400B65A")]
		InviteChannelType_JOIN
	}

	[Token(Token = "0x2001CCC")]
	public enum InviteeType
	{
		[Token(Token = "0x400B65C")]
		InviteeType_NONE,
		[Token(Token = "0x400B65D")]
		InviteeType_FRIEND,
		[Token(Token = "0x400B65E")]
		InviteeType_GUILD,
		[Token(Token = "0x400B65F")]
		InviteeType_MATCHGROUP,
		[Token(Token = "0x400B660")]
		InviteeType_MATCHKILLER,
		[Token(Token = "0x400B661")]
		InviteeType_MATCHCHICKEN,
		[Token(Token = "0x400B662")]
		InviteeType_CHAMPIONSHIP,
		[Token(Token = "0x400B663")]
		InviteeType_REVENGER,
		[Token(Token = "0x400B664")]
		InviteeType_CUP,
		[Token(Token = "0x400B665")]
		InviteeType_RESERVATION,
		[Token(Token = "0x400B666")]
		InviteeType_MATCHMVP
	}

	[Token(Token = "0x2001CCD")]
	public enum PubPvtStatus
	{
		[Token(Token = "0x400B668")]
		PubPvtStatus_NONE,
		[Token(Token = "0x400B669")]
		PubPvtStatus_PUBLIC,
		[Token(Token = "0x400B66A")]
		PubPvtStatus_PRIVATE
	}

	[Token(Token = "0x2001CCE")]
	public enum RoomType
	{
		[Token(Token = "0x400B66C")]
		Type_NONE,
		[Token(Token = "0x400B66D")]
		Type_CASUAL,
		[Token(Token = "0x400B66E")]
		Type_LEAGUE_NORMAL,
		[Token(Token = "0x400B66F")]
		Type_LEAGUE_OFFICIAL,
		[Token(Token = "0x400B670")]
		Type_CHAMPIONSHIP,
		[Token(Token = "0x400B671")]
		Type_LEAGUE_ULTIMATE,
		[Token(Token = "0x400B672")]
		Type_LEAGUE_BATCH
	}

	[Token(Token = "0x60084DC")]
	[Address(RVA = "0x33E9044", Offset = "0x33E9044", VA = "0x33E9044")]
	public EGroup()
	{
	}
}
