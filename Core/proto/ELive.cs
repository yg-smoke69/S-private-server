using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200141B")]
public class ELive
{
	[Token(Token = "0x200141C")]
	public enum FollowerType
	{
		[Token(Token = "0x4008C43")]
		FollowerType_NONE,
		[Token(Token = "0x4008C44")]
		FollowerType_YES,
		[Token(Token = "0x4008C45")]
		FollowerType_NO
	}

	[Token(Token = "0x200141D")]
	public enum VideoType
	{
		[Token(Token = "0x4008C47")]
		VideoType_NONE = 0,
		[Token(Token = "0x4008C48")]
		VideoType_HOTEST = 1,
		[Token(Token = "0x4008C49")]
		VideoType_LIVE_NOW = 2,
		[Token(Token = "0x4008C4A")]
		VideoType_EXPLORE = 3,
		[Token(Token = "0x4008C4B")]
		VideoType_TUTORIAL = 4,
		[Token(Token = "0x4008C4C")]
		VideoType_ALL = 100,
		[Token(Token = "0x4008C4D")]
		VideoType_NEWEST = 101,
		[Token(Token = "0x4008C4E")]
		VideoType_POPULAR = 102,
		[Token(Token = "0x4008C4F")]
		VideoType_OTHER = 103
	}

	[Token(Token = "0x6007AE0")]
	[Address(RVA = "0x309F320", Offset = "0x309F320", VA = "0x309F320")]
	public ELive()
	{
	}
}
