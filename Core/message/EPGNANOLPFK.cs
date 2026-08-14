using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000DBA")]
public enum EPGNANOLPFK : uint
{
	[Token(Token = "0x40071D1")]
	EBombMatchPhase_Waiting,
	[Token(Token = "0x40071D2")]
	EBombMatchPhase_Prepare,
	[Token(Token = "0x40071D3")]
	EBombMatchPhase_Settle,
	[Token(Token = "0x40071D4")]
	EBombMatchPhase_Explode,
	[Token(Token = "0x40071D5")]
	EBombMatchPhase_Post
}
