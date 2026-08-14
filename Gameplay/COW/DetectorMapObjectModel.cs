using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D25")]
public class DetectorMapObjectModel
{
	[Token(Token = "0x40113B3")]
	[FieldOffset(Offset = "0x8")]
	private LFHDEBBIOPO m_Detector;

	[Token(Token = "0x40113B4")]
	[FieldOffset(Offset = "0xC")]
	private Player m_LocalPlayer;

	[Token(Token = "0x40113B5")]
	[FieldOffset(Offset = "0x10")]
	private float m_Range;

	[Token(Token = "0x40113B6")]
	[FieldOffset(Offset = "0x14")]
	private float m_Interval;

	[Token(Token = "0x40113B7")]
	[FieldOffset(Offset = "0x18")]
	private float m_ShowPointTime;

	[Token(Token = "0x40113B8")]
	[FieldOffset(Offset = "0x1C")]
	private float m_FadeTime;

	[Token(Token = "0x40113B9")]
	[FieldOffset(Offset = "0x20")]
	private Player.DFKKGHCFGNM m_LastState;

	[Token(Token = "0x40113BA")]
	[FieldOffset(Offset = "0x24")]
	public bool ShowCircle;

	[Token(Token = "0x40113BB")]
	[FieldOffset(Offset = "0x28")]
	public List<Vector3> DetectedPoints;

	[Token(Token = "0x40113BC")]
	[FieldOffset(Offset = "0x2C")]
	public List<Vector3> DetectedCarPoints;

	[Token(Token = "0x40113BD")]
	[FieldOffset(Offset = "0x30")]
	public int LastDetectFrame;

	[Token(Token = "0x40113BE")]
	[FieldOffset(Offset = "0x34")]
	public float LastDetectTime;

	[Token(Token = "0x40113BF")]
	[FieldOffset(Offset = "0x38")]
	public float NextDetectTime;

	[Token(Token = "0x40113C0")]
	[FieldOffset(Offset = "0x3C")]
	public float FadeStartTime;

	[Token(Token = "0x40113C1")]
	[FieldOffset(Offset = "0x40")]
	public float FadeEndTime;

	[Token(Token = "0x40113C2")]
	[FieldOffset(Offset = "0x44")]
	private bool _003CStopped_003Ek__BackingField;

	[Token(Token = "0x40113C3")]
	[FieldOffset(Offset = "0x48")]
	private int m_RefCount;

	[Token(Token = "0x40113C4")]
	[FieldOffset(Offset = "0x0")]
	private static DetectorMapObjectModel Instance;

	[Token(Token = "0x1700135D")]
	public Vector3 DetectorPosition
	{
		[Token(Token = "0x6012E03")]
		[Address(RVA = "0x1C8D9D8", Offset = "0x1C8D9D8", VA = "0x1C8D9D8")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700135E")]
	public bool Stopped
	{
		[Token(Token = "0x6012E04")]
		[Address(RVA = "0x1C8BF8C", Offset = "0x1C8BF8C", VA = "0x1C8BF8C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6012E05")]
		[Address(RVA = "0x1C8F1E0", Offset = "0x1C8F1E0", VA = "0x1C8F1E0")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700135F")]
	public float Range
	{
		[Token(Token = "0x6012E06")]
		[Address(RVA = "0x1C8C948", Offset = "0x1C8C948", VA = "0x1C8C948")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001360")]
	public bool Inited
	{
		[Token(Token = "0x6012E09")]
		[Address(RVA = "0x1C8C6F0", Offset = "0x1C8C6F0", VA = "0x1C8C6F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6012E02")]
	[Address(RVA = "0x1C8F12C", Offset = "0x1C8F12C", VA = "0x1C8F12C")]
	private DetectorMapObjectModel()
	{
	}

	[Token(Token = "0x6012E07")]
	[Address(RVA = "0x1C8C5CC", Offset = "0x1C8C5CC", VA = "0x1C8C5CC")]
	public static DetectorMapObjectModel GetModel()
	{
		return null;
	}

	[Token(Token = "0x6012E08")]
	[Address(RVA = "0x1C8CE5C", Offset = "0x1C8CE5C", VA = "0x1C8CE5C")]
	public void Release()
	{
	}

	[Token(Token = "0x6012E0A")]
	[Address(RVA = "0x1C8C754", Offset = "0x1C8C754", VA = "0x1C8C754")]
	internal void Init(LFHDEBBIOPO d, float fadeTime)
	{
	}

	[Token(Token = "0x6012E0B")]
	[Address(RVA = "0x1C8D340", Offset = "0x1C8D340", VA = "0x1C8D340")]
	public void Update()
	{
	}

	[Token(Token = "0x6012E0C")]
	[Address(RVA = "0x1C8F61C", Offset = "0x1C8F61C", VA = "0x1C8F61C")]
	private void DetectionPlayers()
	{
	}

	[Token(Token = "0x6012E0D")]
	[Address(RVA = "0x1C8F1E8", Offset = "0x1C8F1E8", VA = "0x1C8F1E8")]
	private void DetectionCars()
	{
	}
}
