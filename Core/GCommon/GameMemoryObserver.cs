using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F52")]
public class GameMemoryObserver : MonoBehaviour
{
	[Token(Token = "0x401AB0F")]
	[FieldOffset(Offset = "0x0")]
	public static GameMemoryObserver instance;

	[Token(Token = "0x401AB10")]
	[FieldOffset(Offset = "0xC")]
	private bool needLogMemory;

	[Token(Token = "0x401AB11")]
	[FieldOffset(Offset = "0x10")]
	public float logAvailMemoryInterval;

	[Token(Token = "0x401AB12")]
	[FieldOffset(Offset = "0x14")]
	public float logAvailMemoryTimer;

	[Token(Token = "0x401AB13")]
	[FieldOffset(Offset = "0x18")]
	private int currentMemory;

	[Token(Token = "0x401AB14")]
	[FieldOffset(Offset = "0x1C")]
	private int maxMemory;

	[Token(Token = "0x401AB15")]
	[FieldOffset(Offset = "0x20")]
	private int minMemory;

	[Token(Token = "0x6019C87")]
	[Address(RVA = "0x32B4C0C", Offset = "0x32B4C0C", VA = "0x32B4C0C")]
	public GameMemoryObserver()
	{
	}

	[Token(Token = "0x6019C88")]
	[Address(RVA = "0x32B4C14", Offset = "0x32B4C14", VA = "0x32B4C14")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019C89")]
	[Address(RVA = "0x32B4CA4", Offset = "0x32B4CA4", VA = "0x32B4CA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6019C8A")]
	[Address(RVA = "0x32B4CC0", Offset = "0x32B4CC0", VA = "0x32B4CC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6019C8B")]
	[Address(RVA = "0x32B4D30", Offset = "0x32B4D30", VA = "0x32B4D30")]
	private void LogAvailMemory()
	{
	}

	[Token(Token = "0x6019C8C")]
	[Address(RVA = "0x32B4D6C", Offset = "0x32B4D6C", VA = "0x32B4D6C")]
	public int GetMinAvailMemory()
	{
		return default(int);
	}

	[Token(Token = "0x6019C8D")]
	[Address(RVA = "0x32B4D74", Offset = "0x32B4D74", VA = "0x32B4D74")]
	public int GetMaxAvailMemory()
	{
		return default(int);
	}

	[Token(Token = "0x6019C8E")]
	[Address(RVA = "0x32B4D7C", Offset = "0x32B4D7C", VA = "0x32B4D7C")]
	public int GetCurrentAvailMemory()
	{
		return default(int);
	}

	[Token(Token = "0x6019C8F")]
	[Address(RVA = "0x32B4D84", Offset = "0x32B4D84", VA = "0x32B4D84")]
	public void StartLogMemory()
	{
	}

	[Token(Token = "0x6019C90")]
	[Address(RVA = "0x32B4DB0", Offset = "0x32B4DB0", VA = "0x32B4DB0")]
	public void StopLogMemory()
	{
	}
}
