using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031AA")]
internal interface OnlineMatch
{
	[Token(Token = "0x6014E16")]
	OnlineMatchEntranceState GetEntranceBtnState();

	[Token(Token = "0x6014E17")]
	void SetEntranceWarmUpState();

	[Token(Token = "0x6014E18")]
	bool AllProtocalReady();

	[Token(Token = "0x6014E19")]
	bool SetEntranceBtnState();

	[Token(Token = "0x6014E1A")]
	bool CanShowEntranceCountDown();

	[Token(Token = "0x6014E1B")]
	ulong GetCountDownTime();

	[Token(Token = "0x6014E1C")]
	void SetLobbyEntranceWarmUpPlayerPrefs();

	[Token(Token = "0x6014E1D")]
	void SetLobbyEntranceMatchOpenPlayerPrefs();

	[Token(Token = "0x6014E1E")]
	DateTime MatchStartTime();

	[Token(Token = "0x6014E1F")]
	int LobbyEntrancePriority();
}
