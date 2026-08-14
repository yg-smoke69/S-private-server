using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D26")]
public class DetectorMapObject
{
	[Token(Token = "0x2002D27")]
	private class Point
	{
		[Token(Token = "0x40113D3")]
		[FieldOffset(Offset = "0x8")]
		public UISprite Sprite;

		[Token(Token = "0x40113D4")]
		[FieldOffset(Offset = "0xC")]
		public TweenAlpha TweenAlpha;

		[Token(Token = "0x40113D5")]
		[FieldOffset(Offset = "0x10")]
		public Transform SpriteTrans;

		[Token(Token = "0x6012E1A")]
		[Address(RVA = "0x1C8F124", Offset = "0x1C8F124", VA = "0x1C8F124")]
		public Point()
		{
		}
	}

	[Token(Token = "0x40113C5")]
	[FieldOffset(Offset = "0x8")]
	private DetectorMapObjectModel m_Model;

	[Token(Token = "0x40113C6")]
	[FieldOffset(Offset = "0xC")]
	private Transform m_MapContainer;

	[Token(Token = "0x40113C7")]
	[FieldOffset(Offset = "0x10")]
	private Transform m_Detector;

	[Token(Token = "0x40113C8")]
	[FieldOffset(Offset = "0x14")]
	private UISprite m_Point;

	[Token(Token = "0x40113C9")]
	[FieldOffset(Offset = "0x18")]
	private UISprite m_Circle;

	[Token(Token = "0x40113CA")]
	[FieldOffset(Offset = "0x1C")]
	private UISprite m_CarPoint;

	[Token(Token = "0x40113CB")]
	[FieldOffset(Offset = "0x20")]
	private TweenScale m_CircleTween;

	[Token(Token = "0x40113CC")]
	[FieldOffset(Offset = "0x24")]
	private List<Point> m_Points;

	[Token(Token = "0x40113CD")]
	[FieldOffset(Offset = "0x28")]
	private List<Point> m_CarPoints;

	[Token(Token = "0x40113CE")]
	[FieldOffset(Offset = "0x2C")]
	private float m_RangeOnMap;

	[Token(Token = "0x40113CF")]
	[FieldOffset(Offset = "0x30")]
	private int m_LastDetectFrame;

	[Token(Token = "0x40113D0")]
	[FieldOffset(Offset = "0x34")]
	public float m_FadeStartTime;

	[Token(Token = "0x40113D1")]
	[FieldOffset(Offset = "0x38")]
	public float m_FadeEndTime;

	[Token(Token = "0x40113D2")]
	[FieldOffset(Offset = "0x3C")]
	private float m_InitialPointRotAngle;

	[Token(Token = "0x17001361")]
	public bool Stopped
	{
		[Token(Token = "0x6012E0F")]
		[Address(RVA = "0x1C8BF14", Offset = "0x1C8BF14", VA = "0x1C8BF14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6012E0E")]
	[Address(RVA = "0x1C8BE60", Offset = "0x1C8BE60", VA = "0x1C8BE60")]
	public DetectorMapObject()
	{
	}

	[Token(Token = "0x6012E10")]
	[Address(RVA = "0x1C8BF94", Offset = "0x1C8BF94", VA = "0x1C8BF94")]
	internal void OnUIInit(Transform container, LFHDEBBIOPO d, Transform detector, UISprite circle, UISprite point, UISprite car, TweenScale tweenScale, float scale)
	{
	}

	[Token(Token = "0x6012E11")]
	[Address(RVA = "0x1C8C9A0", Offset = "0x1C8C9A0", VA = "0x1C8C9A0")]
	public void OnUIDestory()
	{
	}

	[Token(Token = "0x6012E12")]
	[Address(RVA = "0x1C8CF1C", Offset = "0x1C8CF1C", VA = "0x1C8CF1C")]
	public void Update(float rotAngles)
	{
	}

	[Token(Token = "0x6012E13")]
	[Address(RVA = "0x1C8EAF8", Offset = "0x1C8EAF8", VA = "0x1C8EAF8")]
	public void UpdateDetectorPointScale(float map_scale_ratio = 1f)
	{
	}

	[Token(Token = "0x6012E14")]
	[Address(RVA = "0x1C8E4DC", Offset = "0x1C8E4DC", VA = "0x1C8E4DC")]
	private void UpdateFading()
	{
	}

	[Token(Token = "0x6012E15")]
	[Address(RVA = "0x1C8E35C", Offset = "0x1C8E35C", VA = "0x1C8E35C")]
	private void ShowCircleTween()
	{
	}

	[Token(Token = "0x6012E16")]
	[Address(RVA = "0x1C8E3F8", Offset = "0x1C8E3F8", VA = "0x1C8E3F8")]
	private void HideCircleTween()
	{
	}

	[Token(Token = "0x6012E17")]
	[Address(RVA = "0x1C8DA5C", Offset = "0x1C8DA5C", VA = "0x1C8DA5C")]
	private void ShowPoints(List<Vector3> ps, float angle, UISprite sprite, List<Point> points)
	{
	}

	[Token(Token = "0x6012E18")]
	[Address(RVA = "0x1C8CAAC", Offset = "0x1C8CAAC", VA = "0x1C8CAAC")]
	private void DestroyPoints()
	{
	}

	[Token(Token = "0x6012E19")]
	[Address(RVA = "0x1C8ED50", Offset = "0x1C8ED50", VA = "0x1C8ED50")]
	private void HidePoints()
	{
	}
}
