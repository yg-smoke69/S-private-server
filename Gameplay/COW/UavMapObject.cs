using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D2A")]
public class UavMapObject
{
	[Token(Token = "0x2002D2B")]
	private class UavPoint
	{
		[Token(Token = "0x40113FF")]
		[FieldOffset(Offset = "0x8")]
		public UISprite Sprite;

		[Token(Token = "0x4011400")]
		[FieldOffset(Offset = "0xC")]
		public TweenAlpha TweenAlpha;

		[Token(Token = "0x4011401")]
		[FieldOffset(Offset = "0x10")]
		public Transform SpriteTrans;

		[Token(Token = "0x6012E3D")]
		[Address(RVA = "0x219A78C", Offset = "0x219A78C", VA = "0x219A78C")]
		public UavPoint()
		{
		}
	}

	[Token(Token = "0x40113E1")]
	[FieldOffset(Offset = "0x8")]
	private LevelUAV m_Uav;

	[Token(Token = "0x40113E2")]
	[FieldOffset(Offset = "0xC")]
	private UIUAVMapObjectView m_UavObjectView;

	[Token(Token = "0x40113E3")]
	[FieldOffset(Offset = "0x10")]
	private float m_UavFadeStartTime;

	[Token(Token = "0x40113E4")]
	[FieldOffset(Offset = "0x14")]
	private float m_UavFadeEndTime;

	[Token(Token = "0x40113E5")]
	[FieldOffset(Offset = "0x18")]
	private float m_UavFadeTime;

	[Token(Token = "0x40113E6")]
	[FieldOffset(Offset = "0x1C")]
	private Color m_DefaultColor;

	[Token(Token = "0x40113E7")]
	[FieldOffset(Offset = "0x2C")]
	private List<UavPoint> m_UavPoints;

	[Token(Token = "0x40113E8")]
	[FieldOffset(Offset = "0x30")]
	private float m_Scale;

	[Token(Token = "0x40113E9")]
	[FieldOffset(Offset = "0x34")]
	private float m_RangeOnMap;

	[Token(Token = "0x40113EA")]
	[FieldOffset(Offset = "0x38")]
	private float m_RangeExtendedOnMap;

	[Token(Token = "0x40113EB")]
	[FieldOffset(Offset = "0x3C")]
	private float m_UAVRange;

	[Token(Token = "0x40113EC")]
	[FieldOffset(Offset = "0x40")]
	private float m_UAVRangeExtended;

	[Token(Token = "0x40113ED")]
	[FieldOffset(Offset = "0x44")]
	private float m_UAVPointTweenDurationExtension;

	[Token(Token = "0x40113EE")]
	[FieldOffset(Offset = "0x48")]
	private Transform m_MapContainer;

	[Token(Token = "0x40113EF")]
	[FieldOffset(Offset = "0x4C")]
	private UISprite m_UavPoint;

	[Token(Token = "0x40113F0")]
	[FieldOffset(Offset = "0x50")]
	private TweenAlpha m_PlayerTween;

	[Token(Token = "0x40113F1")]
	[FieldOffset(Offset = "0x54")]
	private TweenScale m_CircleTween;

	[Token(Token = "0x40113F2")]
	[FieldOffset(Offset = "0x58")]
	private UISprite m_Circle;

	[Token(Token = "0x40113F3")]
	[FieldOffset(Offset = "0x5C")]
	private UISprite m_CircleExtneded;

	[Token(Token = "0x40113F4")]
	[FieldOffset(Offset = "0x60")]
	private int m_LastUpdateFrame;

	[Token(Token = "0x40113F5")]
	[FieldOffset(Offset = "0x0")]
	private static bool m_IgnoreSubsequentLocalPlayerReveal;

	[Token(Token = "0x40113F6")]
	[FieldOffset(Offset = "0x64")]
	public BitArrayBoolean m_IsVisible;

	[Token(Token = "0x40113F7")]
	protected const uint ISVISIBLE_ALL = 1u;

	[Token(Token = "0x40113F8")]
	protected const uint ISVISIBLE_OWNER = 2u;

	[Token(Token = "0x40113F9")]
	protected const uint ISVISIBLE_TEAMMATE = 4u;

	[Token(Token = "0x40113FA")]
	protected const uint ISVISIBLE_REVEAL = 8u;

	[Token(Token = "0x40113FB")]
	[FieldOffset(Offset = "0x68")]
	private Color MyTeamUAVColor;

	[Token(Token = "0x40113FC")]
	[FieldOffset(Offset = "0x78")]
	private Color EnemyUAVColor;

	[Token(Token = "0x40113FD")]
	[FieldOffset(Offset = "0x88")]
	private Color GlobalEventUAVColor;

	[Token(Token = "0x40113FE")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<uint, string> m_IconTypeMap;

	[Token(Token = "0x6012E29")]
	[Address(RVA = "0x1A38D30", Offset = "0x1A38D30", VA = "0x1A38D30")]
	public UavMapObject()
	{
	}

	[Token(Token = "0x6012E2A")]
	[Address(RVA = "0x1A39030", Offset = "0x1A39030", VA = "0x1A39030")]
	public void OnUIInit(Transform container, UIUAVMapObjectView uav, UISprite circle, UISprite circleExtneded, UISprite point, TweenAlpha tweenAlpha, TweenScale tweenScale, float scale)
	{
	}

	[Token(Token = "0x6012E2B")]
	[Address(RVA = "0x1A395AC", Offset = "0x1A395AC", VA = "0x1A395AC")]
	public void OnUIDestory()
	{
	}

	[Token(Token = "0x6012E2C")]
	[Address(RVA = "0x1A396D4", Offset = "0x1A396D4", VA = "0x1A396D4")]
	public void OnUavCreate(object[] data)
	{
	}

	[Token(Token = "0x6012E2D")]
	[Address(RVA = "0x1A3A670", Offset = "0x1A3A670", VA = "0x1A3A670")]
	private void UpdateUAVCircleRange()
	{
	}

	[Token(Token = "0x6012E2E")]
	[Address(RVA = "0x1A3A8F4", Offset = "0x1A3A8F4", VA = "0x1A3A8F4")]
	public void OnUavRecycle(object[] data)
	{
	}

	[Token(Token = "0x6012E2F")]
	[Address(RVA = "0x1A3AC8C", Offset = "0x1A3AC8C", VA = "0x1A3AC8C")]
	private void OnUavReveal(object[] data)
	{
	}

	[Token(Token = "0x6012E30")]
	[Address(RVA = "0x1A3BF40", Offset = "0x1A3BF40", VA = "0x1A3BF40")]
	private static void NotifyLocalPlayerRevealed(bool isPersonalUAV = false)
	{
	}

	[Token(Token = "0x6012E31")]
	[Address(RVA = "0x1A3C5FC", Offset = "0x1A3C5FC", VA = "0x1A3C5FC")]
	private static void UpdateLocalPlayerRevealed(LevelUAV m_Uav, bool rangeChecked, bool outRange)
	{
	}

	[Token(Token = "0x6012E32")]
	[Address(RVA = "0x1A3C860", Offset = "0x1A3C860", VA = "0x1A3C860")]
	private static Player GetLocalPlayer()
	{
		return null;
	}

	[Token(Token = "0x6012E33")]
	[Address(RVA = "0x1A3CA28", Offset = "0x1A3CA28", VA = "0x1A3CA28")]
	public void UpdateUAVPointScale(float map_scale_ratio = 1f)
	{
	}

	[Token(Token = "0x6012E34")]
	[Address(RVA = "0x1A3CCC8", Offset = "0x1A3CCC8", VA = "0x1A3CCC8")]
	public void UpdateUAVScale(float map_scale_ratio = 1f)
	{
	}

	[Token(Token = "0x6012E35")]
	[Address(RVA = "0x1A3CE84", Offset = "0x1A3CE84", VA = "0x1A3CE84")]
	public void UpdateUAVPosition()
	{
	}

	[Token(Token = "0x6012E36")]
	[Address(RVA = "0x1A3AA58", Offset = "0x1A3AA58", VA = "0x1A3AA58")]
	private void HideUavPoints()
	{
	}

	[Token(Token = "0x6012E37")]
	[Address(RVA = "0x1A3C4C4", Offset = "0x1A3C4C4", VA = "0x1A3C4C4")]
	private void ShowPlayerTween()
	{
	}

	[Token(Token = "0x6012E38")]
	[Address(RVA = "0x1A393E4", Offset = "0x1A393E4", VA = "0x1A393E4")]
	private void HidePlayerTween()
	{
	}

	[Token(Token = "0x6012E39")]
	[Address(RVA = "0x1A3C560", Offset = "0x1A3C560", VA = "0x1A3C560")]
	private void ShowCircleTween()
	{
	}

	[Token(Token = "0x6012E3A")]
	[Address(RVA = "0x1A394C8", Offset = "0x1A394C8", VA = "0x1A394C8")]
	private void HideCircleTween()
	{
	}

	[Token(Token = "0x6012E3B")]
	[Address(RVA = "0x1A3D8EC", Offset = "0x1A3D8EC", VA = "0x1A3D8EC")]
	public bool IsSelf(uint uavID)
	{
		return default(bool);
	}

	[Token(Token = "0x6012E3C")]
	[Address(RVA = "0x1A3D9FC", Offset = "0x1A3D9FC", VA = "0x1A3D9FC")]
	public bool IsRecycled()
	{
		return default(bool);
	}
}
