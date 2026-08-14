using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005B9")]
public class ClientHitFlyTrigger : MonoBehaviour
{
	[Token(Token = "0x4004397")]
	[FieldOffset(Offset = "0xC")]
	public float HitFlySpeedXZ;

	[Token(Token = "0x4004398")]
	[FieldOffset(Offset = "0x10")]
	public float HitFlySpeedY;

	[Token(Token = "0x4004399")]
	[FieldOffset(Offset = "0x14")]
	public float HitFlyTime;

	[Token(Token = "0x400439A")]
	[FieldOffset(Offset = "0x18")]
	private Transform m_CachedTransform;

	[Token(Token = "0x400439B")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 m_LastTickPos;

	[Token(Token = "0x400439C")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_CurTickMoveDir;

	[Token(Token = "0x60022BE")]
	[Address(RVA = "0x230E8F0", Offset = "0x230E8F0", VA = "0x230E8F0")]
	public ClientHitFlyTrigger()
	{
	}

	[Token(Token = "0x60022BF")]
	[Address(RVA = "0x230E918", Offset = "0x230E918", VA = "0x230E918")]
	private void Awake()
	{
	}

	[Token(Token = "0x60022C0")]
	[Address(RVA = "0x230E934", Offset = "0x230E934", VA = "0x230E934")]
	private void Start()
	{
	}

	[Token(Token = "0x60022C1")]
	[Address(RVA = "0x230E97C", Offset = "0x230E97C", VA = "0x230E97C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60022C2")]
	[Address(RVA = "0x230E9C4", Offset = "0x230E9C4", VA = "0x230E9C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60022C3")]
	[Address(RVA = "0x230EB20", Offset = "0x230EB20", VA = "0x230EB20")]
	private void OnTriggerEnter(Collider other)
	{
	}
}
