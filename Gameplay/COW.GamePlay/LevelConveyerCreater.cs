using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000602")]
public class LevelConveyerCreater : BaseLevelObject
{
	[Token(Token = "0x4004541")]
	[FieldOffset(Offset = "0x74")]
	public float StartMoment;

	[Token(Token = "0x4004542")]
	[FieldOffset(Offset = "0x78")]
	public int MaxPlatformNum;

	[Token(Token = "0x4004543")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject PlatformPrefab;

	[Token(Token = "0x4004544")]
	[FieldOffset(Offset = "0x80")]
	public Transform PlatformRoot;

	[Token(Token = "0x4004545")]
	[FieldOffset(Offset = "0x84")]
	public GameObject EmptyPointPrefab;

	[Token(Token = "0x4004546")]
	[FieldOffset(Offset = "0x88")]
	public Transform PointRoot;

	[Token(Token = "0x4004547")]
	[FieldOffset(Offset = "0x8C")]
	public float TimeScalePara;

	[Token(Token = "0x4004548")]
	[FieldOffset(Offset = "0x90")]
	public List<GameObject> CacheList;

	[Token(Token = "0x4004549")]
	[FieldOffset(Offset = "0x94")]
	public List<LevelConveyerPlatform> PlatformList;

	[Token(Token = "0x400454A")]
	[FieldOffset(Offset = "0x98")]
	public List<GameObject> CachePointList;

	[Token(Token = "0x400454B")]
	[FieldOffset(Offset = "0x9C")]
	public bool IsDebug;

	[Token(Token = "0x400454C")]
	[FieldOffset(Offset = "0xA0")]
	public float DirectSpeed;

	[Token(Token = "0x400454D")]
	[FieldOffset(Offset = "0xA4")]
	public float EdgeAngle;

	[Token(Token = "0x400454E")]
	[FieldOffset(Offset = "0xA8")]
	public float EdgeOffset;

	[Token(Token = "0x400454F")]
	[FieldOffset(Offset = "0xAC")]
	public Transform StartPoint;

	[Token(Token = "0x4004550")]
	[FieldOffset(Offset = "0xB0")]
	public Transform EndPoint;

	[Token(Token = "0x4004551")]
	[FieldOffset(Offset = "0xB4")]
	public Transform[] RectPoints;

	[Token(Token = "0x4004552")]
	[FieldOffset(Offset = "0xB8")]
	public List<Transform> EdgePoints;

	[Token(Token = "0x4004553")]
	[FieldOffset(Offset = "0xBC")]
	public Transform[] CentrePoints;

	[Token(Token = "0x4004554")]
	[FieldOffset(Offset = "0xC0")]
	public float EdgeLength;

	[Token(Token = "0x4004555")]
	[FieldOffset(Offset = "0xC4")]
	public float EdgeMoveTime;

	[Token(Token = "0x4004556")]
	[FieldOffset(Offset = "0xC8")]
	public float EdgeSpeed;

	[Token(Token = "0x4004557")]
	[FieldOffset(Offset = "0xCC")]
	public float PerRoundTime;

	[Token(Token = "0x4004558")]
	[FieldOffset(Offset = "0xD0")]
	public float[] MoveTimeArray;

	[Token(Token = "0x60024F0")]
	[Address(RVA = "0x2393070", Offset = "0x2393070", VA = "0x2393070")]
	public LevelConveyerCreater()
	{
	}

	[Token(Token = "0x60024F1")]
	[Address(RVA = "0x239308C", Offset = "0x239308C", VA = "0x239308C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60024F2")]
	[Address(RVA = "0x2393130", Offset = "0x2393130", VA = "0x2393130")]
	private void Start()
	{
	}

	[Token(Token = "0x60024F3")]
	[Address(RVA = "0x23932DC", Offset = "0x23932DC", VA = "0x23932DC")]
	public void CreatePlatform()
	{
	}

	[Token(Token = "0x60024F4")]
	[Address(RVA = "0x2393CAC", Offset = "0x2393CAC", VA = "0x2393CAC")]
	private Transform HGKCCJKPFDF()
	{
		return null;
	}

	[Token(Token = "0x60024F5")]
	[Address(RVA = "0x2393E0C", Offset = "0x2393E0C", VA = "0x2393E0C")]
	public void OnDrawGizmos()
	{
	}
}
