using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200407A")]
public enum DisconnectedReason : uint
{
	[Token(Token = "0x401B1D1")]
	Unknown,
	[Token(Token = "0x401B1D2")]
	MultiLogin,
	[Token(Token = "0x401B1D3")]
	InvalidClientVersion,
	[Token(Token = "0x401B1D4")]
	InBlackList,
	[Token(Token = "0x401B1D5")]
	LevelUp,
	[Token(Token = "0x401B1D6")]
	RoleChange,
	[Token(Token = "0x401B1D7")]
	AccountDelete,
	[Token(Token = "0x401B1D8")]
	ReachMaxResendCount
}
