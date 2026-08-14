using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D45")]
public class PlayerPositionUI : MonoBehaviour
{
	[Token(Token = "0x4019FD9")]
	[FieldOffset(Offset = "0xC")]
	public Transform player;

	[Token(Token = "0x4019FDA")]
	[FieldOffset(Offset = "0x10")]
	public WorldMover worldMover;

	[Token(Token = "0x4019FDB")]
	[FieldOffset(Offset = "0x14")]
	public UILabel text;

	[Token(Token = "0x6018829")]
	[Address(RVA = "0x1E22A3C", Offset = "0x1E22A3C", VA = "0x1E22A3C")]
	public PlayerPositionUI()
	{
	}

	[Token(Token = "0x601882A")]
	[Address(RVA = "0x1E22A44", Offset = "0x1E22A44", VA = "0x1E22A44")]
	public void Start()
	{
	}

	[Token(Token = "0x601882B")]
	[Address(RVA = "0x1E22B4C", Offset = "0x1E22B4C", VA = "0x1E22B4C")]
	public void Update()
	{
	}
}
