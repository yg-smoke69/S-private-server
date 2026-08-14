using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using WorldStreamer;

[Token(Token = "0x2003D18")]
public class PlayerMover : MonoBehaviour
{
	[Token(Token = "0x4019EB4")]
	[FieldOffset(Offset = "0xC")]
	public Streamer[] streamers;

	[Token(Token = "0x4019EB5")]
	[FieldOffset(Offset = "0x10")]
	public Transform player;

	[Token(Token = "0x4019EB6")]
	[FieldOffset(Offset = "0x14")]
	public Transform safePosition;

	[Token(Token = "0x4019EB7")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent onDone;

	[Token(Token = "0x4019EB8")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject temporaryObject;

	[Token(Token = "0x4019EB9")]
	[FieldOffset(Offset = "0x20")]
	private float progress;

	[Token(Token = "0x4019EBA")]
	[FieldOffset(Offset = "0x24")]
	private bool waitForPlayer;

	[Token(Token = "0x4019EBB")]
	[FieldOffset(Offset = "0x25")]
	private bool playerMoved;

	[Token(Token = "0x6018763")]
	[Address(RVA = "0x1E21D88", Offset = "0x1E21D88", VA = "0x1E21D88")]
	public PlayerMover()
	{
	}

	[Token(Token = "0x6018764")]
	[Address(RVA = "0x1E21D90", Offset = "0x1E21D90", VA = "0x1E21D90")]
	private void Awake()
	{
	}

	[Token(Token = "0x6018765")]
	[Address(RVA = "0x1E220EC", Offset = "0x1E220EC", VA = "0x1E220EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6018766")]
	[Address(RVA = "0x1E2247C", Offset = "0x1E2247C", VA = "0x1E2247C")]
	public void Done()
	{
	}

	[Token(Token = "0x6018767")]
	[Address(RVA = "0x1E21E24", Offset = "0x1E21E24", VA = "0x1E21E24")]
	public void MovePlayer()
	{
	}
}
