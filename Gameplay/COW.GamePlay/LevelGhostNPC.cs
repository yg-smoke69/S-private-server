using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200062A")]
public class LevelGhostNPC : MonoBehaviour
{
	[Token(Token = "0x4004632")]
	[FieldOffset(Offset = "0xC")]
	public bool rotateY;

	[Token(Token = "0x4004633")]
	[FieldOffset(Offset = "0x10")]
	public Transform RotatePart;

	[Token(Token = "0x6002620")]
	[Address(RVA = "0x2724868", Offset = "0x2724868", VA = "0x2724868")]
	public LevelGhostNPC()
	{
	}

	[Token(Token = "0x6002621")]
	[Address(RVA = "0x2724870", Offset = "0x2724870", VA = "0x2724870")]
	private void Start()
	{
	}

	[Token(Token = "0x6002622")]
	[Address(RVA = "0x27249B0", Offset = "0x27249B0", VA = "0x27249B0")]
	public void DebugRotate()
	{
	}

	[Token(Token = "0x6002623")]
	[Address(RVA = "0x2724AC8", Offset = "0x2724AC8", VA = "0x2724AC8")]
	public void QuickRotate(float DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002624")]
	[Address(RVA = "0x2724CB8", Offset = "0x2724CB8", VA = "0x2724CB8")]
	public void DoAnim()
	{
	}

	[Token(Token = "0x6002625")]
	[Address(RVA = "0x2724D0C", Offset = "0x2724D0C", VA = "0x2724D0C")]
	private void OnDestroy()
	{
	}
}
