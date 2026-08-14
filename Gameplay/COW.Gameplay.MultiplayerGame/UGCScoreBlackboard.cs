using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.Gameplay.MultiplayerGame;

[Token(Token = "0x2000867")]
public class UGCScoreBlackboard
{
	[Token(Token = "0x4005287")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, Dictionary<uint, Dictionary<uint, int>>> _playerScores;

	[Token(Token = "0x4005288")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, Dictionary<uint, Dictionary<uint, int>>> _teamScores;

	[Token(Token = "0x6003ACF")]
	[Address(RVA = "0x24A3C30", Offset = "0x24A3C30", VA = "0x24A3C30")]
	public UGCScoreBlackboard()
	{
	}

	[Token(Token = "0x6003AD0")]
	[Address(RVA = "0x24A3CD4", Offset = "0x24A3CD4", VA = "0x24A3CD4")]
	public void OnPlayerSyncScore(int roundIndex, uint playerID, uint scoreType, int score)
	{
	}

	[Token(Token = "0x6003AD1")]
	[Address(RVA = "0x24A4120", Offset = "0x24A4120", VA = "0x24A4120")]
	public void OnTeamSyncScore(int roundIndex, uint teamIndex, uint scoreType, int score)
	{
	}

	[Token(Token = "0x6003AD2")]
	[Address(RVA = "0x24A456C", Offset = "0x24A456C", VA = "0x24A456C")]
	public int GetPlayerScore(uint playerID, uint scoreType)
	{
		return default(int);
	}

	[Token(Token = "0x6003AD3")]
	[Address(RVA = "0x24A49A4", Offset = "0x24A49A4", VA = "0x24A49A4")]
	public int GetPlayerRoundScore(int roundIndex, uint playerID, uint scoreType)
	{
		return default(int);
	}

	[Token(Token = "0x6003AD4")]
	[Address(RVA = "0x24A4AD0", Offset = "0x24A4AD0", VA = "0x24A4AD0")]
	public int GetTeamScore(uint teamID, uint scoreType)
	{
		return default(int);
	}

	[Token(Token = "0x6003AD5")]
	[Address(RVA = "0x24A4F08", Offset = "0x24A4F08", VA = "0x24A4F08")]
	public int GetTeamRoundScore(int roundIndex, uint teamIndex, uint scoreType)
	{
		return default(int);
	}
}
