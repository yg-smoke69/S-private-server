using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x2002D65")]
public static class MapStringUtils
{
	[Token(Token = "0x6012FBC")]
	[Address(RVA = "0x1537A7C", Offset = "0x1537A7C", VA = "0x1537A7C")]
	public static string GetDownloadUseMapName(uint mapId, uint gameMode)
	{
		return null;
	}

	[Token(Token = "0x6012FBD")]
	[Address(RVA = "0x153809C", Offset = "0x153809C", VA = "0x153809C")]
	public static string GetMapNameByMapId(uint mapId, uint matchMode = 0u)
	{
		return null;
	}

	[Token(Token = "0x6012FBE")]
	[Address(RVA = "0x15384A4", Offset = "0x15384A4", VA = "0x15384A4")]
	public static string GetModeNameByModeId(uint modeId)
	{
		return null;
	}

	[Token(Token = "0x6012FBF")]
	[Address(RVA = "0x15386C0", Offset = "0x15386C0", VA = "0x15386C0")]
	public static string GetModeNameByModeIdAndMatchMode(uint modeId, uint matchMode)
	{
		return null;
	}

	[Token(Token = "0x6012FC0")]
	[Address(RVA = "0x1538894", Offset = "0x1538894", VA = "0x1538894")]
	public static string GetModeSelectIconByModeID(uint modeID)
	{
		return null;
	}

	[Token(Token = "0x6012FC1")]
	[Address(RVA = "0x1538A0C", Offset = "0x1538A0C", VA = "0x1538A0C")]
	public static string GetGroupNameByGroupId(uint groupdMode)
	{
		return null;
	}

	[Token(Token = "0x6012FC2")]
	[Address(RVA = "0x1538E60", Offset = "0x1538E60", VA = "0x1538E60")]
	public static string GetUGCGroupNameByGroupId(uint groupMode)
	{
		return null;
	}

	[Token(Token = "0x6012FC3")]
	[Address(RVA = "0x15392B4", Offset = "0x15392B4", VA = "0x15392B4")]
	public static string GetUGCCustomTemplateTypeNameById(int id)
	{
		return null;
	}

	[Token(Token = "0x6012FC4")]
	[Address(RVA = "0x153942C", Offset = "0x153942C", VA = "0x153942C")]
	public static string GetMapSpriteByMapId(uint mapId)
	{
		return null;
	}

	[Token(Token = "0x6012FC5")]
	[Address(RVA = "0x15395A4", Offset = "0x15395A4", VA = "0x15395A4")]
	public static string GetMapModeSpriteByMapId(uint mapId)
	{
		return null;
	}

	[Token(Token = "0x6012FC6")]
	[Address(RVA = "0x1539708", Offset = "0x1539708", VA = "0x1539708")]
	public static string GetDifficultyString(EMapDifficulty eDiff)
	{
		return null;
	}

	[Token(Token = "0x6012FC7")]
	[Address(RVA = "0x153998C", Offset = "0x153998C", VA = "0x153998C")]
	public static string GetClimateString(uint visiblityStyle)
	{
		return null;
	}

	[Token(Token = "0x6012FC8")]
	[Address(RVA = "0x1539BCC", Offset = "0x1539BCC", VA = "0x1539BCC")]
	public static string GetClimateSpriteByClimateType(EGameClimateType climate)
	{
		return null;
	}

	[Token(Token = "0x6012FC9")]
	[Address(RVA = "0x1539CD4", Offset = "0x1539CD4", VA = "0x1539CD4")]
	public static string GetMapTagString(EMapTag tag)
	{
		return null;
	}

	[Token(Token = "0x6012FCA")]
	[Address(RVA = "0x1539DF4", Offset = "0x1539DF4", VA = "0x1539DF4")]
	public static string GetMapModeNameByMapConfigId(uint id)
	{
		return null;
	}

	[Token(Token = "0x6012FCB")]
	[Address(RVA = "0x1539F04", Offset = "0x1539F04", VA = "0x1539F04")]
	public static string GetGameModeName(uint matchMode, uint gameMode, [Optional] List<int> difficult)
	{
		return null;
	}

	[Token(Token = "0x6012FCC")]
	[Address(RVA = "0x153A804", Offset = "0x153A804", VA = "0x153A804")]
	public static string GetMapModeName(uint matchMode, uint gameMode, uint mapId, bool forceSpecifiedMapIds = false)
	{
		return null;
	}

	[Token(Token = "0x6012FCD")]
	[Address(RVA = "0x153A91C", Offset = "0x153A91C", VA = "0x153A91C")]
	public static string GetMapModeName(uint matchMode, uint gameMode, uint[] mapIds, bool forceSpecifiedMapIds = false)
	{
		return null;
	}

	[Token(Token = "0x6012FCE")]
	[Address(RVA = "0x153AE68", Offset = "0x153AE68", VA = "0x153AE68")]
	public static string GetGameModeText(JOKABEAPNPP gameMode, DGNDKMLMLPM matchMode, uint rank, bool isAlive, [Optional] UGCMatchStats ugcMatchStats, string customMapName = "", uint totalPlayerCnt = 1u, uint mapID = 0u)
	{
		return null;
	}

	[Token(Token = "0x6012FCF")]
	[Address(RVA = "0x153C0AC", Offset = "0x153C0AC", VA = "0x153C0AC")]
	public static string GetGroupModeIconSpriteName(uint groupmode)
	{
		return null;
	}

	[Token(Token = "0x6012FD0")]
	[Address(RVA = "0x153C1F0", Offset = "0x153C1F0", VA = "0x153C1F0")]
	public static string GenWorkshopShareCode(string code, bool add)
	{
		return null;
	}

	[Token(Token = "0x6012FD1")]
	[Address(RVA = "0x153C3E8", Offset = "0x153C3E8", VA = "0x153C3E8")]
	public static string GenWorkshopNumTxt(ulong num)
	{
		return null;
	}

	[Token(Token = "0x6012FD2")]
	[Address(RVA = "0x153C5FC", Offset = "0x153C5FC", VA = "0x153C5FC")]
	public static bool MapInString(string mapSeq, uint mapId)
	{
		return default(bool);
	}

	[Token(Token = "0x6012FD3")]
	[Address(RVA = "0x153C78C", Offset = "0x153C78C", VA = "0x153C78C")]
	public static bool IsUGCMode(uint mode)
	{
		return default(bool);
	}
}
