using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200226D")]
public class TeleportDoorHintInfo : MonoBehaviour
{
	[Token(Token = "0x400D737")]
	[FieldOffset(Offset = "0xC")]
	public uint UID;

	[Token(Token = "0x400D738")]
	[FieldOffset(Offset = "0x10")]
	public EFNHBHILCNJ DoorType;

	[Token(Token = "0x400D739")]
	[FieldOffset(Offset = "0x14")]
	public string MapGroup;

	[Token(Token = "0x400D73A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel GroupLabel;

	[Token(Token = "0x400D73B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GoArrow;

	[Token(Token = "0x600BC02")]
	[Address(RVA = "0x28A3884", Offset = "0x28A3884", VA = "0x28A3884")]
	public TeleportDoorHintInfo()
	{
	}

	[Token(Token = "0x600BC03")]
	[Address(RVA = "0x28A388C", Offset = "0x28A388C", VA = "0x28A388C")]
	public void InitData(uint uid, EFNHBHILCNJ doorType, string mapGroup)
	{
	}
}
