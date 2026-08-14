using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F10")]
public class Track
{
	[Token(Token = "0x2001F11")]
	private sealed class _003CReturnBackPoint_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C36D")]
		[FieldOffset(Offset = "0x8")]
		internal Vector2 _point;

		[Token(Token = "0x600985D")]
		[Address(RVA = "0x232A8E4", Offset = "0x232A8E4", VA = "0x232A8E4")]
		public _003CReturnBackPoint_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600985E")]
		[Address(RVA = "0x232B12C", Offset = "0x232B12C", VA = "0x232B12C")]
		internal bool _003C_003Em__0(Vector2 point)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400C36A")]
	[FieldOffset(Offset = "0x8")]
	public List<Vector2> trackPoints;

	[Token(Token = "0x400C36B")]
	[FieldOffset(Offset = "0xC")]
	public int LimitNumber;

	[Token(Token = "0x400C36C")]
	[FieldOffset(Offset = "0x10")]
	public int usedPointsCount;

	[Token(Token = "0x6009855")]
	[Address(RVA = "0x232A2FC", Offset = "0x232A2FC", VA = "0x232A2FC")]
	public Track()
	{
	}

	[Token(Token = "0x6009856")]
	[Address(RVA = "0x232A390", Offset = "0x232A390", VA = "0x232A390")]
	public Track(Track track)
	{
	}

	[Token(Token = "0x6009857")]
	[Address(RVA = "0x232A614", Offset = "0x232A614", VA = "0x232A614")]
	public bool IsTrackFull()
	{
		return default(bool);
	}

	[Token(Token = "0x6009858")]
	[Address(RVA = "0x232A684", Offset = "0x232A684", VA = "0x232A684")]
	public void ReturnBackPoint(Vector2 _point)
	{
	}

	[Token(Token = "0x6009859")]
	[Address(RVA = "0x232A8EC", Offset = "0x232A8EC", VA = "0x232A8EC")]
	public void AddTrackPoint(Vector2 _point)
	{
	}

	[Token(Token = "0x600985A")]
	[Address(RVA = "0x232A9D4", Offset = "0x232A9D4", VA = "0x232A9D4")]
	public void Shuffle()
	{
	}

	[Token(Token = "0x600985B")]
	[Address(RVA = "0x232AC08", Offset = "0x232AC08", VA = "0x232AC08")]
	public bool PickRandomTrackPoint(out Vector2 res)
	{
		return default(bool);
	}

	[Token(Token = "0x600985C")]
	[Address(RVA = "0x232AD58", Offset = "0x232AD58", VA = "0x232AD58")]
	public bool PickSpecificTrackPoint(ref CoreNode node)
	{
		return default(bool);
	}
}
