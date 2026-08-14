using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CAD")]
public class MaxRectsBinPack
{
	[Token(Token = "0x2003CAE")]
	public enum FreeRectChoiceHeuristic
	{
		[Token(Token = "0x4019C6E")]
		RectBestShortSideFit,
		[Token(Token = "0x4019C6F")]
		RectBestLongSideFit,
		[Token(Token = "0x4019C70")]
		RectBestAreaFit,
		[Token(Token = "0x4019C71")]
		RectBottomLeftRule,
		[Token(Token = "0x4019C72")]
		RectContactPointRule
	}

	[Token(Token = "0x4019C68")]
	[FieldOffset(Offset = "0x8")]
	public int binWidth;

	[Token(Token = "0x4019C69")]
	[FieldOffset(Offset = "0xC")]
	public int binHeight;

	[Token(Token = "0x4019C6A")]
	[FieldOffset(Offset = "0x10")]
	public bool allowRotations;

	[Token(Token = "0x4019C6B")]
	[FieldOffset(Offset = "0x14")]
	public List<Rect> usedRectangles;

	[Token(Token = "0x4019C6C")]
	[FieldOffset(Offset = "0x18")]
	public List<Rect> freeRectangles;

	[Token(Token = "0x6018445")]
	[Address(RVA = "0x224D08C", Offset = "0x224D08C", VA = "0x224D08C")]
	public MaxRectsBinPack(int width, int height, bool rotations)
	{
	}

	[Token(Token = "0x6018446")]
	[Address(RVA = "0x224D158", Offset = "0x224D158", VA = "0x224D158")]
	public void Init(int width, int height, bool rotations)
	{
	}

	[Token(Token = "0x6018447")]
	[Address(RVA = "0x224D2C8", Offset = "0x224D2C8", VA = "0x224D2C8")]
	public Rect Insert(int width, int height, FreeRectChoiceHeuristic method)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Rect);
	}

	[Token(Token = "0x6018448")]
	[Address(RVA = "0x225061C", Offset = "0x225061C", VA = "0x225061C")]
	public void Insert(List<Rect> rects, List<Rect> dst, FreeRectChoiceHeuristic method)
	{
	}

	[Token(Token = "0x6018449")]
	[Address(RVA = "0x2250A1C", Offset = "0x2250A1C", VA = "0x2250A1C")]
	private void PlaceRect(Rect node)
	{
	}

	[Token(Token = "0x601844A")]
	[Address(RVA = "0x2250904", Offset = "0x2250904", VA = "0x2250904")]
	private Rect ScoreRect(int width, int height, FreeRectChoiceHeuristic method, ref int score1, ref int score2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Rect);
	}

	[Token(Token = "0x601844B")]
	[Address(RVA = "0x2250BBC", Offset = "0x2250BBC", VA = "0x2250BBC")]
	public float Occupancy()
	{
		return default(float);
	}

	[Token(Token = "0x601844C")]
	[Address(RVA = "0x224DD80", Offset = "0x224DD80", VA = "0x224DD80")]
	private Rect FindPositionForNewNodeBottomLeft(int width, int height, ref int bestY, ref int bestX)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Rect);
	}

	[Token(Token = "0x601844D")]
	[Address(RVA = "0x224D5C0", Offset = "0x224D5C0", VA = "0x224D5C0")]
	private Rect FindPositionForNewNodeBestShortSideFit(int width, int height, ref int bestShortSideFit, ref int bestLongSideFit)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Rect);
	}

	[Token(Token = "0x601844E")]
	[Address(RVA = "0x224EBB4", Offset = "0x224EBB4", VA = "0x224EBB4")]
	private Rect FindPositionForNewNodeBestLongSideFit(int width, int height, ref int bestShortSideFit, ref int bestLongSideFit)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Rect);
	}

	[Token(Token = "0x601844F")]
	[Address(RVA = "0x224F374", Offset = "0x224F374", VA = "0x224F374")]
	private Rect FindPositionForNewNodeBestAreaFit(int width, int height, ref int bestAreaFit, ref int bestShortSideFit)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Rect);
	}

	[Token(Token = "0x6018450")]
	[Address(RVA = "0x2250D80", Offset = "0x2250D80", VA = "0x2250D80")]
	private int CommonIntervalLength(int i1start, int i1end, int i2start, int i2end)
	{
		return default(int);
	}

	[Token(Token = "0x6018451")]
	[Address(RVA = "0x2250E3C", Offset = "0x2250E3C", VA = "0x2250E3C")]
	private int ContactPointScoreNode(int x, int y, int width, int height)
	{
		return default(int);
	}

	[Token(Token = "0x6018452")]
	[Address(RVA = "0x224E4F4", Offset = "0x224E4F4", VA = "0x224E4F4")]
	private Rect FindPositionForNewNodeContactPoint(int width, int height, ref int bestContactScore)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Rect);
	}

	[Token(Token = "0x6018453")]
	[Address(RVA = "0x224FBFC", Offset = "0x224FBFC", VA = "0x224FBFC")]
	private bool SplitFreeNode(Rect freeNode, ref Rect usedNode)
	{
		return default(bool);
	}

	[Token(Token = "0x6018454")]
	[Address(RVA = "0x2250370", Offset = "0x2250370", VA = "0x2250370")]
	private void PruneFreeList()
	{
	}

	[Token(Token = "0x6018455")]
	[Address(RVA = "0x22514C4", Offset = "0x22514C4", VA = "0x22514C4")]
	private bool IsContainedIn(Rect a, Rect b)
	{
		return default(bool);
	}
}
