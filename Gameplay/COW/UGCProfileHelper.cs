using System;
using System.Text;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x2000CA6")]
public static class UGCProfileHelper
{
	[Token(Token = "0x2000CA7")]
	private sealed class _003CExtractSelfStats_003Ec__AnonStorey0
	{
		[Token(Token = "0x400674F")]
		[FieldOffset(Offset = "0x8")]
		internal UGCMatchStats stats;

		[Token(Token = "0x6006077")]
		[Address(RVA = "0x29F3FE0", Offset = "0x29F3FE0", VA = "0x29F3FE0")]
		public _003CExtractSelfStats_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6006078")]
		[Address(RVA = "0x29F4EF0", Offset = "0x29F4EF0", VA = "0x29F4EF0")]
		internal bool _003C_003Em__0(UGCPlayerStats x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000CA8")]
	private sealed class _003CExtractSelfTeamStats_003Ec__AnonStorey1
	{
		[Token(Token = "0x4006750")]
		[FieldOffset(Offset = "0x8")]
		internal UGCMatchStats stats;

		[Token(Token = "0x6006079")]
		[Address(RVA = "0x29F3FE8", Offset = "0x29F3FE8", VA = "0x29F3FE8")]
		public _003CExtractSelfTeamStats_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600607A")]
		[Address(RVA = "0x29F4F44", Offset = "0x29F4F44", VA = "0x29F4F44")]
		internal bool _003C_003Em__0(UGCTeamStats x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400674E")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<int> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600606A")]
	[Address(RVA = "0x29F333C", Offset = "0x29F333C", VA = "0x29F333C")]
	public static bool IsUGCGame(JOKABEAPNPP gameMode)
	{
		return default(bool);
	}

	[Token(Token = "0x600606B")]
	[Address(RVA = "0x29F33AC", Offset = "0x29F33AC", VA = "0x29F33AC")]
	public static int ExtractTeamCount(UGCMatchStats stats)
	{
		return default(int);
	}

	[Token(Token = "0x600606C")]
	[Address(RVA = "0x29F346C", Offset = "0x29F346C", VA = "0x29F346C")]
	public static int ExtractSelfTeammateCount(UGCMatchStats stats)
	{
		return default(int);
	}

	[Token(Token = "0x600606D")]
	[Address(RVA = "0x29F3700", Offset = "0x29F3700", VA = "0x29F3700")]
	public static int ExtractMaxTeammateCount(UGCMatchStats stats)
	{
		return default(int);
	}

	[Token(Token = "0x600606E")]
	[Address(RVA = "0x29F3874", Offset = "0x29F3874", VA = "0x29F3874")]
	public static int ExtractSelfRank(UGCMatchStats stats)
	{
		return default(int);
	}

	[Token(Token = "0x600606F")]
	[Address(RVA = "0x29F38EC", Offset = "0x29F38EC", VA = "0x29F38EC")]
	public static int ExtractSelfKillCount(UGCMatchStats stats)
	{
		return default(int);
	}

	[Token(Token = "0x6006070")]
	[Address(RVA = "0x29F3C10", Offset = "0x29F3C10", VA = "0x29F3C10")]
	public static UGCPlayerStats ExtractSelfStatsFromAllPlayers(UGCMatchStats stats)
	{
		return null;
	}

	[Token(Token = "0x6006071")]
	[Address(RVA = "0x29F3A80", Offset = "0x29F3A80", VA = "0x29F3A80")]
	public static UGCPlayerStats ExtractSelfStats(UGCMatchStats stats)
	{
		return null;
	}

	[Token(Token = "0x6006072")]
	[Address(RVA = "0x29F353C", Offset = "0x29F353C", VA = "0x29F353C")]
	public static UGCTeamStats ExtractSelfTeamStats(UGCMatchStats stats)
	{
		return null;
	}

	[Token(Token = "0x6006073")]
	[Address(RVA = "0x29F3FF0", Offset = "0x29F3FF0", VA = "0x29F3FF0")]
	public static bool IsTeammate(UGCMatchStats stats, ulong accountID, out bool foundUser)
	{
		return default(bool);
	}

	[Token(Token = "0x6006074")]
	[Address(RVA = "0x29F422C", Offset = "0x29F422C", VA = "0x29F422C")]
	public static string Print(UGCMatchStats stats)
	{
		return null;
	}

	[Token(Token = "0x6006075")]
	[Address(RVA = "0x29F47E8", Offset = "0x29F47E8", VA = "0x29F47E8")]
	public static void Print(UGCTeamStats teamStats, ref StringBuilder sb)
	{
	}

	[Token(Token = "0x6006076")]
	[Address(RVA = "0x29F4EE4", Offset = "0x29F4EE4", VA = "0x29F4EE4")]
	private static bool _003CExtractSelfKillCount_003Em__0(int x)
	{
		return default(bool);
	}
}
