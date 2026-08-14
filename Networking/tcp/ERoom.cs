using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D43")]
public class ERoom
{
	[Token(Token = "0x2001D44")]
	public enum Proto
	{
		[Token(Token = "0x400B881")]
		Proto_NONE,
		[Token(Token = "0x400B882")]
		Proto_ROOMLIST,
		[Token(Token = "0x400B883")]
		Proto_CREATE,
		[Token(Token = "0x400B884")]
		Proto_JOIN,
		[Token(Token = "0x400B885")]
		Proto_SPECTATE,
		[Token(Token = "0x400B886")]
		Proto_JOIN_NTF,
		[Token(Token = "0x400B887")]
		Proto_LEAVE,
		[Token(Token = "0x400B888")]
		Proto_LEAVE_NTF,
		[Token(Token = "0x400B889")]
		Proto_DISMISS_NTF,
		[Token(Token = "0x400B88A")]
		Proto_KICK,
		[Token(Token = "0x400B88B")]
		Proto_KICK_NTF,
		[Token(Token = "0x400B88C")]
		Proto_START,
		[Token(Token = "0x400B88D")]
		Proto_ROOMINFO,
		[Token(Token = "0x400B88E")]
		Proto_CHANGE,
		[Token(Token = "0x400B88F")]
		Proto_CHANGE_NTF,
		[Token(Token = "0x400B890")]
		Proto_DROPOMATCH,
		[Token(Token = "0x400B891")]
		Proto_MATCHMAKINGSUSS_NTF,
		[Token(Token = "0x400B892")]
		Proto_ROOMSTATE_NTF,
		[Token(Token = "0x400B893")]
		Proto_CHECKINGAMEPLAYER,
		[Token(Token = "0x400B894")]
		Proto_CLEARINGAMEPLAYER,
		[Token(Token = "0x400B895")]
		Proto_SWITCHSEAT,
		[Token(Token = "0x400B896")]
		Proto_SWITCHSEAT_NTF,
		[Token(Token = "0x400B897")]
		Proto_INVITE,
		[Token(Token = "0x400B898")]
		Proto_INVITE_NTF,
		[Token(Token = "0x400B899")]
		Proto_SETREADY,
		[Token(Token = "0x400B89A")]
		Proto_SETREADY_NTF,
		[Token(Token = "0x400B89B")]
		Proto_REAL_CREATE,
		[Token(Token = "0x400B89C")]
		Proto_ADMIN_SET_ICON,
		[Token(Token = "0x400B89D")]
		Proto_ADMIN_DISMISS_ROOM,
		[Token(Token = "0x400B89E")]
		Proto_ANTIADDICTION_NFT,
		[Token(Token = "0x400B89F")]
		proto_TEAMMATEHEATING_NFT,
		[Token(Token = "0x400B8A0")]
		Proto_ADMIN_GET_CUSTOMROOM_MATCHSTATS,
		[Token(Token = "0x400B8A1")]
		Proto_ROOM_CREATE_RULE,
		[Token(Token = "0x400B8A2")]
		Proto_CHANGEAVAILABLEMAPS,
		[Token(Token = "0x400B8A3")]
		Proto_CHANGEAVAILABLEMAPS_NTF,
		[Token(Token = "0x400B8A4")]
		Proto_EMULATORCHECK_NTF,
		[Token(Token = "0x400B8A5")]
		proto_OWNERSWITCHGROUP,
		[Token(Token = "0x400B8A6")]
		proto_OWNERSWITCHGROUP_NTF,
		[Token(Token = "0x400B8A7")]
		Proto_ROLECHECK_NTF,
		[Token(Token = "0x400B8A8")]
		Proto_COUNTDOWN,
		[Token(Token = "0x400B8A9")]
		Proto_COUNTDOWN_NTF,
		[Token(Token = "0x400B8AA")]
		Proto_CREDITSCORECHECK_NTF,
		[Token(Token = "0x400B8AB")]
		Proto_SYNCPATCHOPTIONALRESSTATUS,
		[Token(Token = "0x400B8AC")]
		Proto_SYNCPATCHOPTIONALRESSTATUS_NTF,
		[Token(Token = "0x400B8AD")]
		Proto_CHECKAVAILABLEMAPS_NTF,
		[Token(Token = "0x400B8AE")]
		Proto_WORKSHOP_LOADING_TIMEOUT,
		[Token(Token = "0x400B8AF")]
		Proto_ADMIN_SET_ROOM_PRIORITY
	}

	[Token(Token = "0x2001D45")]
	public enum ErrCode
	{
		[Token(Token = "0x400B8B1")]
		ErrCode_SUSS,
		[Token(Token = "0x400B8B2")]
		ErrCode_NOROOM,
		[Token(Token = "0x400B8B3")]
		ErrCode_REACHMAXMEMBERS,
		[Token(Token = "0x400B8B4")]
		ErrCode_REACHMAXSPECTATORS,
		[Token(Token = "0x400B8B5")]
		ErrCode_ALREADYINROOM,
		[Token(Token = "0x400B8B6")]
		ErrCode_NOTINROOM,
		[Token(Token = "0x400B8B7")]
		ErrCode_ROOMINGAME,
		[Token(Token = "0x400B8B8")]
		ErrCode_ROOMNOTINGAME,
		[Token(Token = "0x400B8B9")]
		ErrCode_CANNOTCREATEROOM,
		[Token(Token = "0x400B8BA")]
		ErrCode_NOGAMESERVERAVAILABLE,
		[Token(Token = "0x400B8BB")]
		ErrCode_INVALIDCODE,
		[Token(Token = "0x400B8BC")]
		ErrCode_CANNOTKICK,
		[Token(Token = "0x400B8BD")]
		ErrCode_NOTOWNER,
		[Token(Token = "0x400B8BE")]
		ErrCode_GENMATCHIDFAIL,
		[Token(Token = "0x400B8BF")]
		ErrCode_LOGINGAMESERVERTIMEOUT,
		[Token(Token = "0x400B8C0")]
		ErrCode_CREATEROOMFAIL,
		[Token(Token = "0x400B8C1")]
		ErrCode_JOININVALIDPLAYERCNT,
		[Token(Token = "0x400B8C2")]
		ErrCode_DIRTYWORD,
		[Token(Token = "0x400B8C3")]
		ErrCode_SEATOCCUPIED,
		[Token(Token = "0x400B8C4")]
		ErrCode_CANNOTSWITCHSEAT,
		[Token(Token = "0x400B8C5")]
		ErrCode_INVALIDMEMBERNUM,
		[Token(Token = "0x400B8C6")]
		ErrCode_NOTENOUGHROOMCARD,
		[Token(Token = "0x400B8C7")]
		ErrCode_INVALIDOPTIONS,
		[Token(Token = "0x400B8C8")]
		ErrCode_CANNOTINVITESELF,
		[Token(Token = "0x400B8C9")]
		ErrCode_INVALIDROOMTYPE,
		[Token(Token = "0x400B8CA")]
		ErrCode_INVITEEALREADYINGROUP,
		[Token(Token = "0x400B8CB")]
		ErrCode_INVITEEALREADYINROOM,
		[Token(Token = "0x400B8CC")]
		ErrCode_INVITEEALREADYINGAME,
		[Token(Token = "0x400B8CD")]
		ErrCode_INVITEEALREADYOFFLINE,
		[Token(Token = "0x400B8CE")]
		ErrCode_NOTENOUGHMEMEBERS,
		[Token(Token = "0x400B8CF")]
		ErrCode_REACHMAXINGAMEROOMNUMLIMIT,
		[Token(Token = "0x400B8D0")]
		ErrCode_NEGATIVEGEMS,
		[Token(Token = "0x400B8D1")]
		ErrCode_ANTIADDICTIONBAN,
		[Token(Token = "0x400B8D2")]
		ErrCode_ROOMCENTERNOTREADY,
		[Token(Token = "0x400B8D3")]
		ErrCode_INVITEEALREADYINTRAINING,
		[Token(Token = "0x400B8D4")]
		ErrCode_MAPINVALIDFORSOMEMEMBERS,
		[Token(Token = "0x400B8D5")]
		ErrCode_REOPENIDNOTEXISTS,
		[Token(Token = "0x400B8D6")]
		ErrCode_EMULATORCHECKFAILED,
		[Token(Token = "0x400B8D7")]
		ErrCode_GROUPOCCUPIED,
		[Token(Token = "0x400B8D8")]
		ErrCode_REACHMAXBATCHROOMNUMLIMIT,
		[Token(Token = "0x400B8D9")]
		ErrCode_NOCREATEROLE,
		[Token(Token = "0x400B8DA")]
		ErrCode_NOJOINROLE,
		[Token(Token = "0x400B8DB")]
		ErrCode_WORKSHOP_UPDATED,
		[Token(Token = "0x400B8DC")]
		ErrCode_PLAYERMAPINVALID,
		[Token(Token = "0x400B8DD")]
		ErrCode_CREDITSCORECHECKFAILED
	}

	[Token(Token = "0x2001D46")]
	public enum Type
	{
		[Token(Token = "0x400B8DF")]
		Type_NONE = 0,
		[Token(Token = "0x400B8E0")]
		Type_CASUAL = 1,
		[Token(Token = "0x400B8E1")]
		Type_LEAGUE_NORMAL = 2,
		[Token(Token = "0x400B8E2")]
		Type_LEAGUE_BATCH = 6,
		[Token(Token = "0x400B8E3")]
		Type_WEREWOLVES = 7,
		[Token(Token = "0x400B8E4")]
		Type_WORKSHOP = 8,
		[Token(Token = "0x400B8E5")]
		Type_RUSHING_PETS = 9
	}

	[Token(Token = "0x2001D47")]
	public enum TabType
	{
		[Token(Token = "0x400B8E7")]
		TabType_NONE,
		[Token(Token = "0x400B8E8")]
		TabType_NORMAL,
		[Token(Token = "0x400B8E9")]
		TabType_LEAGUE,
		[Token(Token = "0x400B8EA")]
		TabType_WEREWOLVES,
		[Token(Token = "0x400B8EB")]
		TabType_WORKSHOP,
		[Token(Token = "0x400B8EC")]
		TabType_RUSHING_PETS
	}

	[Token(Token = "0x2001D48")]
	public enum PlayerRole
	{
		[Token(Token = "0x400B8EE")]
		PlayerRole_NONE,
		[Token(Token = "0x400B8EF")]
		PlayerRole_MEMBER,
		[Token(Token = "0x400B8F0")]
		PlayerRole_SPECTATOR
	}

	[Token(Token = "0x2001D49")]
	public enum PlayerState
	{
		[Token(Token = "0x400B8F2")]
		PlayerState_IDLE,
		[Token(Token = "0x400B8F3")]
		PlayerState_LOADING,
		[Token(Token = "0x400B8F4")]
		PlayerState_INGAME,
		[Token(Token = "0x400B8F5")]
		PlayerState_INGAME_CAN_RECONNECT
	}

	[Token(Token = "0x2001D4A")]
	public enum PlayerPatchOptionalResStatus
	{
		[Token(Token = "0x400B8F7")]
		PlayerPatchOptionalResStatus_NONE,
		[Token(Token = "0x400B8F8")]
		PlayerPatchOptionalResStatus_LACK,
		[Token(Token = "0x400B8F9")]
		PlayerPatchOptionalResStatus_START
	}

	[Token(Token = "0x2001D4B")]
	public enum State
	{
		[Token(Token = "0x400B8FB")]
		State_IDLE,
		[Token(Token = "0x400B8FC")]
		State_INGAME,
		[Token(Token = "0x400B8FD")]
		State_LOADING
	}

	[Token(Token = "0x2001D4C")]
	public enum DismissReason
	{
		[Token(Token = "0x400B8FF")]
		DismissReason_NONE,
		[Token(Token = "0x400B900")]
		DismissReason_NORMAL,
		[Token(Token = "0x400B901")]
		DismissReason_OFFLINE,
		[Token(Token = "0x400B902")]
		DismissReason_TIMEOUT,
		[Token(Token = "0x400B903")]
		DismissReason_ADMIN,
		[Token(Token = "0x400B904")]
		DismissReason_WORKSHOP_LOADING_TIMEOUT
	}

	[Token(Token = "0x2001D4D")]
	public enum UpdateRoomEvent
	{
		[Token(Token = "0x400B906")]
		UpdateRoomEvent_NONE,
		[Token(Token = "0x400B907")]
		UpdateRoomEvent_INIT,
		[Token(Token = "0x400B908")]
		UpdateRoomEvent_SEND_ALL_ROOMS,
		[Token(Token = "0x400B909")]
		UpdateRoomEvent_STATE,
		[Token(Token = "0x400B90A")]
		UpdateRoomEvent_OPTIONS,
		[Token(Token = "0x400B90B")]
		UpdateRoomEvent_MEMBER_NUM,
		[Token(Token = "0x400B90C")]
		UpdateRoomEvent_DISMISS_ROOM,
		[Token(Token = "0x400B90D")]
		UpdateRoomEvent_CREATE_ROOM,
		[Token(Token = "0x400B90E")]
		UpdateRoomEvent_EMPTY,
		[Token(Token = "0x400B90F")]
		UpdateRoomEvent_ENOUGH_ROOM_CARD,
		[Token(Token = "0x400B910")]
		UpdateRoomEvent_OWNER_ONLINE
	}

	[Token(Token = "0x6008826")]
	[Address(RVA = "0x33E9220", Offset = "0x33E9220", VA = "0x33E9220")]
	public ERoom()
	{
	}
}
