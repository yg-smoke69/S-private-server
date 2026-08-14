using System;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x200329E")]
public struct EndConditionCheckList
{
	[Token(Token = "0x4013460")]
	[FieldOffset(Offset = "0x0")]
	public bool TimeUpEnabled;

	[Token(Token = "0x4013461")]
	[FieldOffset(Offset = "0x1")]
	public bool ScoreEnabled;

	[Token(Token = "0x4013462")]
	[FieldOffset(Offset = "0x2")]
	public bool CSRoundsEnabled;
}
