using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A59")]
public class GhostShadowEffectPlayer : MonoBehaviour
{
	[Token(Token = "0x4005BC2")]
	[FieldOffset(Offset = "0xC")]
	public float m_GhostTime;

	[Token(Token = "0x4005BC3")]
	[FieldOffset(Offset = "0x10")]
	public float m_GhostDelta;

	[Token(Token = "0x4005BC4")]
	[FieldOffset(Offset = "0x14")]
	public Shader ghostShader;

	[Token(Token = "0x4005BC5")]
	[FieldOffset(Offset = "0x18")]
	public Color ghostColor;

	[Token(Token = "0x4005BC6")]
	[FieldOffset(Offset = "0x28")]
	public float UseLerpDeltaDistance;

	[Token(Token = "0x4005BC7")]
	[FieldOffset(Offset = "0x2C")]
	public float StopLerpDeltaDistance;

	[Token(Token = "0x4005BC8")]
	[FieldOffset(Offset = "0x30")]
	private bool bUseRuntimeDate;

	[Token(Token = "0x4005BC9")]
	[FieldOffset(Offset = "0x34")]
	private float m_RuntimeGhostTime;

	[Token(Token = "0x4005BCA")]
	[FieldOffset(Offset = "0x38")]
	private float m_RuntIMEGhostDelta;

	[Token(Token = "0x4005BCB")]
	[FieldOffset(Offset = "0x3C")]
	private List<Renderer> RenderList;

	[Token(Token = "0x4005BCC")]
	[FieldOffset(Offset = "0x40")]
	private List<GhostShadowRoot> myGhostRootList;

	[Token(Token = "0x4005BCD")]
	[FieldOffset(Offset = "0x44")]
	private bool isPlaying;

	[Token(Token = "0x4005BCE")]
	[FieldOffset(Offset = "0x48")]
	private float lastTime;

	[Token(Token = "0x4005BCF")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 LastPostion;

	[Token(Token = "0x4005BD0")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 CurPlayPostion;

	[Token(Token = "0x4005BD1")]
	[FieldOffset(Offset = "0x64")]
	private bool bUsingLerpPostion;

	[Token(Token = "0x4005BD2")]
	[FieldOffset(Offset = "0x68")]
	private int m_SpawnedGhostNum;

	[Token(Token = "0x4005BD3")]
	[FieldOffset(Offset = "0x6C")]
	private int m_CurActivedGhostNum;

	[Token(Token = "0x4005BD4")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<GhostShadowRoot> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x17000634")]
	private float CurGhostTime
	{
		[Token(Token = "0x6005038")]
		[Address(RVA = "0x35027C8", Offset = "0x35027C8", VA = "0x35027C8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000635")]
	private float CurGhostDelta
	{
		[Token(Token = "0x6005039")]
		[Address(RVA = "0x35027E0", Offset = "0x35027E0", VA = "0x35027E0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6005037")]
	[Address(RVA = "0x350268C", Offset = "0x350268C", VA = "0x350268C")]
	public GhostShadowEffectPlayer()
	{
	}

	[Token(Token = "0x600503A")]
	[Address(RVA = "0x35027F8", Offset = "0x35027F8", VA = "0x35027F8")]
	public void InitRenderList()
	{
	}

	[Token(Token = "0x600503B")]
	[Address(RVA = "0x3502908", Offset = "0x3502908", VA = "0x3502908")]
	public void Clear()
	{
	}

	[Token(Token = "0x600503C")]
	[Address(RVA = "0x3502980", Offset = "0x3502980", VA = "0x3502980")]
	public void PlayEffect()
	{
	}

	[Token(Token = "0x600503D")]
	[Address(RVA = "0x35029F8", Offset = "0x35029F8", VA = "0x35029F8")]
	public void StopEffect()
	{
	}

	[Token(Token = "0x600503E")]
	[Address(RVA = "0x3502A04", Offset = "0x3502A04", VA = "0x3502A04")]
	public void PlayEffectByDate(float ghostTime, float ghostDelta)
	{
	}

	[Token(Token = "0x600503F")]
	[Address(RVA = "0x350298C", Offset = "0x350298C", VA = "0x350298C")]
	private void PlayInit()
	{
	}

	[Token(Token = "0x6005040")]
	[Address(RVA = "0x3502A18", Offset = "0x3502A18", VA = "0x3502A18")]
	private void Update()
	{
	}

	[Token(Token = "0x6005041")]
	[Address(RVA = "0x3504168", Offset = "0x3504168", VA = "0x3504168")]
	private void OnOneRootFinishEffect()
	{
	}

	[Token(Token = "0x6005042")]
	[Address(RVA = "0x350366C", Offset = "0x350366C", VA = "0x350366C")]
	private void SpawnGhost()
	{
	}

	[Token(Token = "0x6005043")]
	[Address(RVA = "0x3502DD8", Offset = "0x3502DD8", VA = "0x3502DD8")]
	private void ActiveLastGhost()
	{
	}

	[Token(Token = "0x6005044")]
	[Address(RVA = "0x350419C", Offset = "0x350419C", VA = "0x350419C")]
	public void DisActiveAllEffect()
	{
	}

	[Token(Token = "0x6005045")]
	[Address(RVA = "0x3504318", Offset = "0x3504318", VA = "0x3504318")]
	public static int Compare(GhostShadowRoot r1, GhostShadowRoot r2)
	{
		return default(int);
	}
}
