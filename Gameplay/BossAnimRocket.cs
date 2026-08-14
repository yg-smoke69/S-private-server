using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AFE")]
public class BossAnimRocket : BossRocket
{
	[Token(Token = "0x4005F2C")]
	private const string m_AnimName = "Attack";

	[Token(Token = "0x4005F2D")]
	[FieldOffset(Offset = "0x60")]
	public float AnimTime;

	[Token(Token = "0x4005F2E")]
	[FieldOffset(Offset = "0x64")]
	public bool UseCodeMove;

	[Token(Token = "0x4005F2F")]
	[FieldOffset(Offset = "0x68")]
	public int AnimClipCount;

	[Token(Token = "0x4005F30")]
	[FieldOffset(Offset = "0x6C")]
	private Animator m_Animator;

	[Token(Token = "0x4005F31")]
	[FieldOffset(Offset = "0x70")]
	private float m_AnimBeginTime;

	[Token(Token = "0x4005F32")]
	[FieldOffset(Offset = "0x74")]
	private float m_CodeBeginMoveTime;

	[Token(Token = "0x600549E")]
	[Address(RVA = "0x2ED1050", Offset = "0x2ED1050", VA = "0x2ED1050")]
	public BossAnimRocket()
	{
	}

	[Token(Token = "0x600549F")]
	[Address(RVA = "0x2ED108C", Offset = "0x2ED108C", VA = "0x2ED108C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60054A0")]
	[Address(RVA = "0x2ED1118", Offset = "0x2ED1118", VA = "0x2ED1118", Slot = "4")]
	public override void Launch(Vector3 launchPos, Vector3 launchFoward, Vector3 targetPost, [Optional] Transform parent)
	{
	}

	[Token(Token = "0x60054A1")]
	[Address(RVA = "0x2ED14C0", Offset = "0x2ED14C0", VA = "0x2ED14C0", Slot = "5")]
	public override void Update()
	{
	}

	[Token(Token = "0x60054A2")]
	[Address(RVA = "0x2ED1570", Offset = "0x2ED1570", VA = "0x2ED1570")]
	private void CodeMove()
	{
	}
}
