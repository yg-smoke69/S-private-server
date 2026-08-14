using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013C8")]
public class EFriend
{
	[Token(Token = "0x20013C9")]
	public enum FriendMainType
	{
		[Token(Token = "0x4008B13")]
		FriendMainType_NONE,
		[Token(Token = "0x4008B14")]
		FriendMainType_REGION
	}

	[Token(Token = "0x20013CA")]
	public enum IntimacyType
	{
		[Token(Token = "0x4008B16")]
		IntimacyType_NONE,
		[Token(Token = "0x4008B17")]
		IntimacyType_ENDMATCH,
		[Token(Token = "0x4008B18")]
		IntimacyType_SENDGIFT,
		[Token(Token = "0x4008B19")]
		IntimacyType_CHAT
	}

	[Token(Token = "0x20013CB")]
	public enum RelationType
	{
		[Token(Token = "0x4008B1B")]
		RelationType_NONE,
		[Token(Token = "0x4008B1C")]
		RelationType_CONFIDANT
	}

	[Token(Token = "0x20013CC")]
	public enum IntimacyRankAwardStatus
	{
		[Token(Token = "0x4008B1E")]
		IntimacyRankAwardStatus_INIT,
		[Token(Token = "0x4008B1F")]
		IntimacyRankAwardStatus_AWARDED
	}

	[Token(Token = "0x20013CD")]
	public enum SpecialFriendState
	{
		[Token(Token = "0x4008B21")]
		SpecialFriendState_NONE,
		[Token(Token = "0x4008B22")]
		SpecialFriendState_WAIT_CREATE,
		[Token(Token = "0x4008B23")]
		SpecialFriendState_ALREADY_BE,
		[Token(Token = "0x4008B24")]
		SpecialFriendState_WAIT_DISMISS,
		[Token(Token = "0x4008B25")]
		SpecialFriendState_DECLINED
	}

	[Token(Token = "0x20013CE")]
	public enum SpecialFriendSendApplyResult
	{
		[Token(Token = "0x4008B27")]
		SpecialFriendSendApplyResult_NONE,
		[Token(Token = "0x4008B28")]
		SpecialFriendSendApplyResult_SUCCESS,
		[Token(Token = "0x4008B29")]
		SpecialFriendSendApplyResult_TARGET_APPLY_MAX,
		[Token(Token = "0x4008B2A")]
		SpecialFriendSendApplyResult_TARGET_SPECIAL_FRIEND_MAX
	}

	[Token(Token = "0x20013CF")]
	public enum SpecialFriendReplyResult
	{
		[Token(Token = "0x4008B2C")]
		SpecialFriendReplyResult_REJECT,
		[Token(Token = "0x4008B2D")]
		SpecialFriendReplyResult_AGREE
	}

	[Token(Token = "0x20013D0")]
	public enum FriendAliasAction
	{
		[Token(Token = "0x4008B2F")]
		FriendAliasAction_NONE,
		[Token(Token = "0x4008B30")]
		FriendAliasAction_SET,
		[Token(Token = "0x4008B31")]
		FriendAliasAction_UPDATE,
		[Token(Token = "0x4008B32")]
		FriendAliasAction_REMOVE
	}

	[Token(Token = "0x6007AB3")]
	[Address(RVA = "0x309F2D8", Offset = "0x309F2D8", VA = "0x309F2D8")]
	public EFriend()
	{
	}
}
