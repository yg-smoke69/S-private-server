using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000D9D")]
public enum DAHEMOKAHIN : uint
{
	[Token(Token = "0x400711C")]
	EWWMatchPhase_Waiting,
	[Token(Token = "0x400711D")]
	EWWMatchPhase_Prepare,
	[Token(Token = "0x400711E")]
	EWWMatchPhase_Task,
	[Token(Token = "0x400711F")]
	EWWMatchPhase_Vote,
	[Token(Token = "0x4007120")]
	EWWMatchPhase_VoteResultShow,
	[Token(Token = "0x4007121")]
	EWWMatchPhase_FinalShow,
	[Token(Token = "0x4007122")]
	EWWMatchPhase_GameEndShow,
	[Token(Token = "0x4007123")]
	EWWMatchPhase_GameEndCommunication
}
