using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C3A")]
public class UGCPrettySprite3DSize : MonoBehaviour
{
	[Token(Token = "0x40064D3")]
	[FieldOffset(Offset = "0xC")]
	private Transform m_trans;

	[Token(Token = "0x40064D4")]
	[FieldOffset(Offset = "0x10")]
	public float LogicScale;

	[Token(Token = "0x40064D5")]
	[FieldOffset(Offset = "0x14")]
	public float AdjustMinDistance;

	[Token(Token = "0x40064D6")]
	[FieldOffset(Offset = "0x18")]
	public float AdjustMaxDistance;

	[Token(Token = "0x40064D7")]
	[FieldOffset(Offset = "0x1C")]
	public Transform TrackObject;

	[Token(Token = "0x40064D8")]
	[FieldOffset(Offset = "0x20")]
	public string TrackEntityID;

	[Token(Token = "0x40064D9")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 OffsetPosition;

	[Token(Token = "0x40064DA")]
	[FieldOffset(Offset = "0x30")]
	private float Pixel2Scale;

	[Token(Token = "0x40064DB")]
	[FieldOffset(Offset = "0x34")]
	public float DistanceScalePerMeter;

	[Token(Token = "0x40064DC")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_sprite;

	[Token(Token = "0x40064DD")]
	[FieldOffset(Offset = "0x3C")]
	private UILabel m_label;

	[Token(Token = "0x40064DE")]
	[FieldOffset(Offset = "0x40")]
	public float m_9SpritePixelSize;

	[Token(Token = "0x40064DF")]
	[FieldOffset(Offset = "0x44")]
	public float m_max9SpriteSize;

	[Token(Token = "0x40064E0")]
	[FieldOffset(Offset = "0x48")]
	public float m_lockSpriteSize;

	[Token(Token = "0x40064E1")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_isAlwaysInScreen;

	[Token(Token = "0x40064E2")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_finalScale;

	[Token(Token = "0x40064E3")]
	[FieldOffset(Offset = "0x5C")]
	private float m_distanceToCamera;

	[Token(Token = "0x40064E4")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 m_curScreenPos;

	[Token(Token = "0x40064E5")]
	[FieldOffset(Offset = "0x6C")]
	private float m_finalPixelWidth;

	[Token(Token = "0x40064E6")]
	[FieldOffset(Offset = "0x70")]
	private float m_finalPixelHeight;

	[Token(Token = "0x40064E7")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_finalScreenPos;

	[Token(Token = "0x40064E8")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_debugViewportPos;

	[Token(Token = "0x40064E9")]
	[FieldOffset(Offset = "0x8C")]
	public float m_alwaysInScreenPadding;

	[Token(Token = "0x170007FB")]
	public bool Is9Sprite
	{
		[Token(Token = "0x6005D72")]
		[Address(RVA = "0x264A854", Offset = "0x264A854", VA = "0x264A854")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005D6E")]
	[Address(RVA = "0x26497B4", Offset = "0x26497B4", VA = "0x26497B4")]
	public UGCPrettySprite3DSize()
	{
	}

	[Token(Token = "0x6005D6F")]
	[Address(RVA = "0x2649920", Offset = "0x2649920", VA = "0x2649920")]
	private void Start()
	{
	}

	[Token(Token = "0x6005D70")]
	[Address(RVA = "0x26499FC", Offset = "0x26499FC", VA = "0x26499FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6005D71")]
	[Address(RVA = "0x264A84C", Offset = "0x264A84C", VA = "0x264A84C")]
	public void SetLabel(UILabel label)
	{
	}

	[Token(Token = "0x6005D73")]
	[Address(RVA = "0x264A23C", Offset = "0x264A23C", VA = "0x264A23C")]
	private void UpdateSize()
	{
	}

	[Token(Token = "0x6005D74")]
	[Address(RVA = "0x2649A28", Offset = "0x2649A28", VA = "0x2649A28")]
	private void UpdatePosition()
	{
	}

	[Token(Token = "0x6005D75")]
	[Address(RVA = "0x2649D10", Offset = "0x2649D10", VA = "0x2649D10")]
	private void UpdatePositionIfAlwaysInScreen()
	{
	}
}
