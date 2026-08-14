using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003FFB")]
public class SmallNoRender : MonoBehaviour
{
	[Token(Token = "0x401AEBE")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<Renderer, float> mRenderAndSize;

	[Token(Token = "0x401AEBF")]
	[FieldOffset(Offset = "0x10")]
	private Camera mCamera;

	[Token(Token = "0x401AEC0")]
	[FieldOffset(Offset = "0x14")]
	private Vector3 mCameraPosition;

	[Token(Token = "0x401AEC1")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 mCameraPositionV2;

	[Token(Token = "0x401AEC2")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 mRendererPositionV2;

	[Token(Token = "0x401AEC3")]
	[FieldOffset(Offset = "0x30")]
	private float mFovAngleSqr;

	[Token(Token = "0x401AEC4")]
	[FieldOffset(Offset = "0x34")]
	private IEnumerator<KeyValuePair<Renderer, float>> mEnumerator;

	[Token(Token = "0x401AEC5")]
	[FieldOffset(Offset = "0x38")]
	private Renderer mRenderer;

	[Token(Token = "0x401AEC6")]
	[FieldOffset(Offset = "0x3C")]
	private float mTimer;

	[Token(Token = "0x401AEC7")]
	[FieldOffset(Offset = "0x40")]
	private int mRenderPerFrame;

	[Token(Token = "0x401AEC8")]
	[FieldOffset(Offset = "0x44")]
	private bool mRefreshable;

	[Token(Token = "0x401AEC9")]
	[FieldOffset(Offset = "0x0")]
	public static bool Refresh;

	[Token(Token = "0x401AECA")]
	[FieldOffset(Offset = "0x4")]
	public static float IgnoreSize;

	[Token(Token = "0x401AECB")]
	[FieldOffset(Offset = "0x8")]
	public static float SizeThresholdSqr;

	[Token(Token = "0x401AECC")]
	[FieldOffset(Offset = "0xC")]
	public static float RefreshTime;

	[Token(Token = "0x401AECD")]
	[FieldOffset(Offset = "0x10")]
	public static int RefreshFrames;

	[Token(Token = "0x601A10C")]
	[Address(RVA = "0x21D29C0", Offset = "0x21D29C0", VA = "0x21D29C0")]
	public SmallNoRender()
	{
	}

	[Token(Token = "0x601A10D")]
	[Address(RVA = "0x21D2A54", Offset = "0x21D2A54", VA = "0x21D2A54")]
	private void Awake()
	{
	}

	[Token(Token = "0x601A10E")]
	[Address(RVA = "0x21D2E9C", Offset = "0x21D2E9C", VA = "0x21D2E9C")]
	private void Start()
	{
	}

	[Token(Token = "0x601A10F")]
	[Address(RVA = "0x21D2F90", Offset = "0x21D2F90", VA = "0x21D2F90")]
	private void Update()
	{
	}

	[Token(Token = "0x601A110")]
	[Address(RVA = "0x21D2A58", Offset = "0x21D2A58", VA = "0x21D2A58")]
	private void GetRenderers()
	{
	}

	[Token(Token = "0x601A111")]
	[Address(RVA = "0x21D37F0", Offset = "0x21D37F0", VA = "0x21D37F0")]
	private bool ShouldRender(Renderer renderer, float sizeSqr)
	{
		return default(bool);
	}
}
